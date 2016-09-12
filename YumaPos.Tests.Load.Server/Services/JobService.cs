using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Server.Data;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Data.Interfaces;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server.Services
{
    public class JobService: IJobService
    {
        private LoadTestDbContext _db;

        public JobService(IEntityContainer container)
        {
            _db = container.Context;
        }

        public Task<Job> GetNextJob()
        {
            return _db.Jobs.OrderBy(p => p.Start).ThenBy(p => p.TasksCount).FirstOrDefaultAsync(p => p.TasksCount < p.MaxTasksCount);
        }

        public Task<Tuple<Terminal, Employee>> ReserveEmployeeAndTerminal(Job job)
        {
            // Get free tenant for this job
            // Get free store for thos tenant
            // get free terminal and employee
            throw new NotImplementedException();
        }
    }
}