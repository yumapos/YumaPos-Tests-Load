using System;
using System.Diagnostics;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Infrastructure.Dto;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class TestApi:ITestApi
    {
        public async Task<Guid> RegisterClient(Guid clientId, string name)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                return await client.RegisterAsync(clientId, name);
            }
        }

        public async Task<TestTaskDto[]> GetTasks(Guid clientToken, int maxInstanceCount)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                return client.GetTasks(clientToken, maxInstanceCount);
            }
        }
        public async Task CancelMyTasks(Guid clientToken)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                await client.CancelMyTasksAsync(clientToken);
            }
        }
        public async Task Report(Guid clientToken, ReportDto report)
        {
            report.ClientToken = clientToken;
            using (var client = new TestServiceReference.TestServiceClient())
            {
                client.Report(report);
            }
        }
        public async Task Finish(Guid clientToken, int taskId)
        {
            using (var client = new TestServiceReference.TestServiceClient())
            {
                await client.FinishAsync(clientToken, taskId);
            }
        }
    }
}