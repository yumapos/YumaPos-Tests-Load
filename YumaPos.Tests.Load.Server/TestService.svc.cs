using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;
using Autofac;
using YumaPos.Tests.Load.Infrastucture;
using YumaPos.Tests.Load.Infrastucture.Dto;
using YumaPos.Tests.Load.Server.Data.DataObjects;
using YumaPos.Tests.Load.Server.Interfaces;

namespace YumaPos.Tests.Load.Server
{
    public class TestService : ITestService
    {
        public ILifetimeScope Scope { get; private set; }

        public TestService(ILifetimeScope scope)
        {
            Scope = scope;
        }

        public async Task<Guid> Register(Guid clientId, string name)
        {
            return await Scope.Resolve<IClientService>().RegisterClient(clientId, HttpContext.Current.Request.UserHostAddress, name);
        }

        public async Task<IEnumerable<TestTaskDto>> GetTasks(Guid clientToken, int maxInstance)
        {
            var clientService = Scope.Resolve<IClientService>();
            var jobService = Scope.Resolve<IJobService>();
            var taskService = Scope.Resolve<ITaskService>();

            var client = await clientService.GetByToken(clientToken);
            if (!client.IsActive) throw new FaultException("client is not activated");
            // check available job to do
            var job = await jobService.GetNextJob();
            if (job != null && client.TasksCount < maxInstance)
            {
                var res = new List<TestTaskDto>();
                // check free terminals and employees
                // create new if need
                // reserve terminals and employees for this client
                Tuple<Terminal, Employee> tu = await jobService.ReserveEmployeeAndTerminal(job);
                var terminal = tu.Item1;
                var employee = tu.Item2;
                TestTask tt = await taskService.CreateTask(job, terminal, employee, client);
                
                // return array of task
                res.Add(new TestTaskDto()
                {
                    TaskId = tt.TestId,
                    TerminalIsRegistered = false,
                    AuthorizationAddress = job.Server.AuthorizationAddress,
                    ServiceAddress = job.Server.ServiceAddress,
                    TenantAlias = terminal.Tenant.TenantAlias,
                    TerminalId = terminal.TerminalId,
                    TerminalToken = terminal.TerminalId,
                    EmployeeLogin = employee.Login,
                    EmployeePassword = employee.Password,
                    Start = job.Start,
                    Duration = job.Duration,
                    MinInterval = job.MinInterval,
                    MaxInterval = job.MaxInterval,
                    Scenarios = job.Scenarios
                });
                return res;
            }
            return null;
        }

        public void Report(int clientId, ReportDto report)
        {
            throw new NotImplementedException();
        }
    }
}
