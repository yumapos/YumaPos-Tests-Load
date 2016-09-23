using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.Interfaces
{
    public interface ITestApi
    {
        Task<Guid> RegisterClient(Guid clientId, string name);
        Task<TestTaskDto[]> GetTasks(Guid clientToken, int maxInstanceCount);
        Task CancelMyTasks(Guid clientToken);
    }
}