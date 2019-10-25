using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Client.Backoffice;
using YumaPos.Client.WCF;
using YumaPos.Common.Tools.JsonSerialization;
using YumaPos.Shared.API;
using YumaPos.Shared.BackOffice.Infrastructure;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Tests.Load.Scenarios;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Interfaces;

namespace YumaPos.Tests.Load.Web.Services
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
                    if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant);
                    // TODO: create new tenant
                    throw new NotImplementedException();
                }
            }

            // Get free store for this tenant
            var stores = await _db.Stores.AsNoTracking().Where(s => s.TenantId == tenant.TenantId && s.JobId == job.JobId).ToListAsync();
            var storeIds = stores.Select(s => s.StoreId).ToArray();
            if (!stores.Any())
            {
                if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant);
                // TODO: create new store
                throw new NotImplementedException();
            }

            // get free terminal and employee
            var terminal = await _db.Terminals.Include(p=>p.Tenant).FirstOrDefaultAsync(t => storeIds.Contains( t.StoreId) && t.ClientId == null);
            if (terminal == null)
            {
                if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant);
                terminal = await posDataService.CreateNewTerminal(tenant.TenantId, storeIds.Random() );
            }
            var employee = await _db.Employees.FirstOrDefaultAsync(e => storeIds.Contains(e.StoreId.Value) && e.ClientId == null);
            if (employee == null)
            {
                if (posDataService == null) posDataService = CreatePosfDatService(job.Server, tenant);
                employee = await posDataService.CreateNewEmployee(tenant.TenantId, storeIds.Random());
            }
            terminal.ClientId = clientId;
            employee.ClientId = clientId;
            await _db.SaveChangesAsync();
            _db.Entry(terminal).State = EntityState.Detached;
            _db.Entry(employee).State = EntityState.Detached;
            terminal.Tenant = tenant;
            return new Tuple<Terminal, Employee>(terminal, employee);

        }

        private IPosDataService CreatePosfDatService(Server.Data.DataObjects.Server server, Tenant tenant)
        {
            IAPIConfig apiConfig = new ApiConfig()
            {
                Tenant = tenant.TenantAlias,
                TerminalId = Guid.NewGuid().ToString(),
                AuthorizationAddress = server.AuthorizationAddress,
                BackOfficeAddress = server.BackofficeAddress,
                OrderServiceAddress = server.ServiceAddress.ToLowerInvariant().Replace("/terminalservice.svc", "/orderservice.svc"),
                TerminalServiceAddress = server.ServiceAddress,
                ApiVersion = "6.0.0"
            };
            IBackOfficeApi b = new BackOfficeApi(apiConfig);
            IAuthorizationApi a = new AuthorizationApi(apiConfig);
            ITerminalApi t = new TerminalApi(apiConfig, new SerializationService(), new CheckServerConnectionService());
            var posfDatService = new PosDataService(_container, b, a, t, tenant.Login, tenant.Password);
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
            (await _db.Employees.Where(p => p.ClientId == clientId).ToListAsync()).ForEach(p => p.ClientId = null);
            (await _db.Terminals.Where(p => p.ClientId == clientId).ToListAsync()).ForEach(p => p.ClientId = null);
            _db.TestTasks.RemoveRange(tasks);
            await _db.SaveChangesAsync();
            foreach (var job in (await _db.Jobs.ToListAsync()))
            {
                job.TasksCount = ( await _db.TestTasks.CountAsync(p => p.JobId == job.JobId));
            }
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

        public void Init()
        {
            _db.Database.ExecuteSqlCommand("UPDATE Employees SET ClientId = null ");
            _db.Database.ExecuteSqlCommand("UPDATE Terminals SET ClientId = null ");
            _db.Database.ExecuteSqlCommand("UPDATE Clients SET TasksCount = 0 ");
            _db.Database.ExecuteSqlCommand("UPDATE Jobs SET TasksCount = 0 ");
            _db.Database.ExecuteSqlCommand("TRUNCATE TABLE TestTasks ");
        }
    }

}