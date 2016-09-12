using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Data.Interfaces
{
    public interface ITaskRepository
    {
        Task AddRange(IEnumerable<TestTask> tasks);
        Task<IEnumerable<TestTask>> GetReadyTasks();
        Task SetIsStarting(int taskId);
    }
}