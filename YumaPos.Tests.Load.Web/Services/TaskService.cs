using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Web.Interfaces;

namespace YumaPos.Tests.Load.Web.Services
{
    public class TaskService: ITaskService
    {
        private LoadTestDbContext _db;

        public TaskService(IEntityContainer container)
        {
            _db = container.Context;
        }
        public async Task<TestTask> CreateTask(Job job, Terminal terminal, Employee employee, Server.Data.DataObjects.Client client)
        {
            var t = new TestTask()
            {
                ClientId = client.ClientId,
                EmployeeId = employee.EmployeeId,
                JobId = job.JobId,
                StoreId = terminal.StoreId,
                TenantId = terminal.TenantId,
                TerminalId = terminal.TerminalId
            };
            _db.TestTasks.Add(t);
            await _db.SaveChangesAsync();
            return t;
        }

        public Task<List<TestTask>> GetTasksByClientId(Guid clientId)
        {
            return _db.TestTasks.Where(p => p.ClientId == clientId).ToListAsync();
        }
    }
}