using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using YumaPos.Tests.Load.Infrastucture;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Server
{
    public class TestService : IService
    {

        public string Register(string clientId)
        {
            // TODO: Register client and set it inactive, save ip
            return "new_client_token";
        }

        public TestTaskDto[] GetTasks(string clientToken, int maxInstance)
        {
            // TODO: check if client is active
            // check available job to do
            // check free terminals and employees
            // create new if need
            // reserve terminals and employees for this client
            // return array of task

            return new TestTaskDto[]
            {
                new TestTaskDto()
                {
                    TaskId = new Random().Next(),
                    ClientIsRegistered = false,
                    AuthorizationAddress = "http://localhost:39607",
                    ServiceAddress = "http://localhost:1999/Service.svc",
                    TenantAlias = "localhost",
                    TerminalId = "2003",
                    TerminalToken = "10000000-0000-0000-0000-000000000001",
                    EmployeeLogin = "admin",
                    EmployeePassword = "admin",
                    Start = DateTime.UtcNow,
                    Duration = TimeSpan.FromMinutes(1),
                    MinInterval = TimeSpan.FromSeconds(1),
                    MaxInterval = TimeSpan.FromMinutes(1),
                    Scenarios = new string[] {"YumaPos.Tests.Load.Scenarios.EmployeeLoginScenario"}
                }
            };
        }

        public void Report(int clientId, ReportDto report)
        {
            throw new NotImplementedException();
        }
    }
}
