using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Client.WCF;
using YumaPos.Shared.API;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Shared.Infrastructure;
using YumaPos.Tests.Load.Scenarios;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class JobService : IJobService
    {
        private readonly IEntityContainer _container;
        private readonly LoadTestDbContext _db;

        public JobService(IEntityContainer container)
        {
            _container = container;
            _db = container.Context;
        }

        public Task<Job> GetNextJob()
        {
            return _db.Jobs.Include(p=>p.Server).AsNoTracking()
                .Where(p => DbFunctions.AddMilliseconds(p.Start, DbFunctions.DiffMilliseconds(TimeSpan.Zero, p.Duration)) >= DateTime.UtcNow)
                .OrderBy(p => p.Start).ThenBy(p => p.TasksCount).FirstOrDefaultAsync(p => p.TasksCount < p.MaxTasksCount);
        }

        public async Task<Tuple<Terminal, Employee>> ReserveEmployeeAndTerminal(Job job, Guid clientId)
        {
            IPosDataService posDataService = null;
            // Get free tenant for this job
            var tenant = await _db.Tenants.AsNoTracking().FirstOrDefaultAsync(t => t.JobId == job.JobId);
            if (tenant == null)
            {
                tenant = await _db.Tenants.FirstOrDefaultAsync(t => t.ServerId == job.ServerId && t.JobId == null);
                if (tenant != null)
                {
                    tenant.JobId = job.JobId;
                    await _db.SaveChangesAsync();
                }
                else
                {
                    if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant.TenantAlias);
                    // TODO: create new tenant
                    throw new NotImplementedException();
                }
            }

            // Get free store for this tenant
            var store = await _db.Stores.AsNoTracking().FirstOrDefaultAsync(s => s.TenantId == tenant.TenantId && s.JobId == job.JobId);
            if (store == null)
            {
                store = await _db.Stores.FirstOrDefaultAsync(s => s.TenantId == tenant.TenantId && s.JobId == null);
                if (store != null)
                {
                    store.JobId = job.JobId;
                    await _db.SaveChangesAsync();
                }
                else
                {
                    if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant.TenantAlias);
                    // TODO: create new store
                    throw new NotImplementedException();
                }
            }

            // get free terminal and employee
            var terminal = await _db.Terminals.Include(p=>p.Tenant).FirstOrDefaultAsync(t => t.StoreId == store.StoreId && t.ClientId == null);
            if (terminal == null)
            {
                if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant.TenantAlias);
                terminal = await posDataService.CreateNewTerminal(tenant.TenantId, store.StoreId);
            }
            var employee = await _db.Employees.FirstOrDefaultAsync(e => e.StoreId == store.StoreId && e.ClientId == null);
            if (employee == null)
            {
                if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant.TenantAlias);
                employee = await posDataService.CreateNewEmployee(tenant.TenantId, store.StoreId);
            }
            terminal.ClientId = clientId;
            employee.ClientId = clientId;
            await _db.SaveChangesAsync();
            _db.Entry(terminal).State = EntityState.Detached;
            _db.Entry(employee).State = EntityState.Detached;
            terminal.Tenant = tenant;
            return new Tuple<Terminal, Employee>(terminal, employee);

        }

        private IPosDataService CreatePosfDatService(Data.DataObjects.Server server, string tenantAlias)
        {
            IAPIConfig apiConfig = new ApiConfig()
            {
                Tenant = tenantAlias,
                TerminalId = Guid.NewGuid().ToString(),
                AuthorizationAddress = server.AuthorizationAddress,
                BackOfficeAddress = server.BackofficeAddress,
                ServiceAddress = server.ServiceAddress
            };
            IBackOfficeApi b = new BackOfficeApi(apiConfig);
            IAuthorizationApi a = new AuthorizationApi(apiConfig);
            ITerminalApi t = new TerminalApi(apiConfig, new SerializationService());
            var posfDatService = new PosDataService(_container, b, a, t, server.Login, server.Password);
            return posfDatService;
        }

        public async Task IncreaseTaskCount(int jobId)
        {
            (await _db.Jobs.FindAsync(jobId)).TasksCount++;
            await _db.SaveChangesAsync();
        }

        public async Task CancelByClientId(Guid clientId)
        {
            var tasks = await _db.TestTasks.Where(p => p.ClientId == clientId).ToListAsync();
            foreach (TestTask task in tasks)
            {
                (await _db.Jobs.FindAsync(task.JobId)).TasksCount--;
            }
            (await _db.Employees.Where(p => p.ClientId == clientId).ToListAsync()).ForEach(p => p.ClientId = null);
            (await _db.Terminals.Where(p => p.ClientId == clientId).ToListAsync()).ForEach(p => p.ClientId = null);
            _db.TestTasks.RemoveRange(tasks);
            await _db.SaveChangesAsync();
        }

        public async Task CancelByTaskId(int taskId)
        {
            var task = await _db.TestTasks.FindAsync(taskId);
            (await _db.Jobs.FindAsync(task.JobId)).TasksCount--;
            (await _db.Employees.FindAsync(task.EmployeeId)).ClientId = null;
            (await _db.Terminals.FindAsync(task.TerminalId)).ClientId = null;
            _db.TestTasks.Remove(task);
            await _db.SaveChangesAsync();
        }
    }
}