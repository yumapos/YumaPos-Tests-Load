using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Data.Interfaces;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TestClientDbContext _dbContext;

        public TaskRepository(IEntityContainer container)
        {
            _dbContext = container.Context;
        }

        public async Task AddRange(IEnumerable<TestTask> tasks)
        {
            _dbContext.Tasks.AddRange(tasks);
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<TestTask>> GetReadyTasks()
        {
            var utc = DateTime.UtcNow;
            return await _dbContext.Tasks.AsNoTracking().Where(p => p.IsStarting == false && p.Start < utc).ToListAsync().ConfigureAwait(false);
        }

        public async Task SetIsStarting(int taskId)
        {
            var task = await _dbContext.Tasks.FindAsync(taskId).ConfigureAwait(false);
            task.IsStarting = true;
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
