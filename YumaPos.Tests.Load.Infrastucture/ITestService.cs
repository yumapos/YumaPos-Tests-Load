using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastructure.Dto;

namespace YumaPos.Tests.Load.Infrastructure
{
    [ServiceContract]
    public interface ITestService
    {

        [OperationContract]
        Task<Guid> Register(Guid clientId, string name);

        [OperationContract]
        Task<IEnumerable<TestTaskDto>> GetTasks(Guid clientToken, int maxInstance);

        [OperationContract]
        Task CancelMyTasks(Guid clientToken);

        [OperationContract]
        Task Report(ReportDto report);

        [OperationContract]
        Task Finish(Guid clientToken, int taskId);

    }
}