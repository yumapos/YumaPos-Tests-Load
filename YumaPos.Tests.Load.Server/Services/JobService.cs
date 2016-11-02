using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class JobService : IJobService
    {
        private readonly LoadTestDbContext _db;
        private readonly IPosfDatService _posfdatService;

        public JobService(IEntityContainer container, IPosfDatService posfdatService)
        {
            _posfdatService = posfdatService;
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
                    // TODO: create new store
                    throw new NotImplementedException();
                }
            }

            // get free terminal and employee
            var terminal = await _db.Terminals.Include(p=>p.Tenant).FirstOrDefaultAsync(t => t.StoreId == store.StoreId && t.ClientId == null);
            if (terminal == null)
            {
                terminal = await _posfdatService.CreateNewTerminal(tenant.TenantId, store.StoreId, job.Server.DataConnectionString);
            }
            var employee = await _db.Employees.FirstOrDefaultAsync(e => e.StoreId == store.StoreId && e.ClientId == null);
            if (employee == null)
            {
                employee = await _posfdatService.CreateNewEmployee(tenant.TenantId, store.StoreId, job.Server.DataConnectionString);
            }
            terminal.ClientId = clientId;
            employee.ClientId = clientId;
            await _db.SaveChangesAsync();
            return new Tuple<Terminal, Employee>(terminal, employee);

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