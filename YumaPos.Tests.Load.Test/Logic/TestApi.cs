using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class TestApi:ITestApi
    {

        public async Task<Guid> RegisterClient(Guid clientId, string name)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                return await client.RegisterAsync(clientId, name );
            }
        }

        public async Task<TestTaskDto[]> GetTasks(Guid clientToken, int maxInstanceCount)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                return await client.GetTasksAsync(clientToken, maxInstanceCount);
            }
        }
    }
}