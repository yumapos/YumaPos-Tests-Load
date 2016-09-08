using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.Interfaces
{
    public interface ITestApi
    {
        Task<string> RegisterClient(string clientId);
        Task<TestTaskDto[]> GetTasks(string clientToken, int maxInstanceCount);
    }
}