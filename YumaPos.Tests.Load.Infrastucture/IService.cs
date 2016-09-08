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
    public interface IService
    {

        [OperationContract]
        string Register(string clientId);

        [OperationContract]
        TestTaskDto[] GetTasks(string clientToken, int maxInstance);

        [OperationContract]
        void Report(int clientId, ReportDto report);

    }
}