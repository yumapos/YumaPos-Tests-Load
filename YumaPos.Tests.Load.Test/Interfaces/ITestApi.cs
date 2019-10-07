using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastructure.Dto;

namespace YumaPos.Tests.Load.Client.Interfaces
{
    public interface ITestApi
    {
        Task<Guid> RegisterClient(Guid clientId, string name);
        Task<TestTaskDto[]> GetTasks(Guid clientToken, int maxInstanceCount);
        Task CancelMyTasks(Guid clientToken);
        Task Report(Guid clientToken, ReportDto report);
        Task Finish(Guid clientToken, int taskId);
    }
}