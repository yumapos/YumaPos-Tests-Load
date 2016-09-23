using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Infrastucture
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
        void Report(int clientId, ReportDto report);

    }
}