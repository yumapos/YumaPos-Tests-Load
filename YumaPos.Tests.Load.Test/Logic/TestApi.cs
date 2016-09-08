using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class TestApi:ITestApi
    {

        public async Task<string> RegisterClient(string clientId)
        {
            using (var client = new TestServiceReference.ServiceClient())
            {
                return await client.RegisterAsync(clientId);
            }
        }

        public async Task<TestTaskDto[]> GetTasks(string clientToken, int maxInstanceCount)
        {
            using (var client = new TestServiceReference.ServiceClient())
            {
                return await client.GetTasksAsync(clientToken, maxInstanceCount);
            }
        }
    }
}