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
            if (client == null) throw new FaultException(ErrorStrings.ClientNotFound);
            if (!client.IsActive) throw new FaultException(ErrorStrings.ClientNotActivated);
            // check available job to do
            var job = await jobService.GetNextJob();
            if (job != null && client.TasksCount < maxInstance)
            {
                var res = new List<TestTaskDto>();
                // check free terminals and employees
                // create new if need
                // reserve terminals and employees for this client
                Tuple<Terminal, Employee> tu = await jobService.ReserveEmployeeAndTerminal(job, client.ClientId);
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
                    TerminalToken = terminal.Token,
                    EmployeeLogin = employee.Login,
                    EmployeePassword = employee.Password,
                    Start = job.Start,
                    Duration = job.Duration,
                    MinInterval = job.MinInterval,
                    MaxInterval = job.MaxInterval,
                    Scenarios = job.Scenarios
                });
                await jobService.IncreaseTaskCount(job.JobId);
                await clientService.IncreaseTaskCount(client.ClientId);
                return res;
            }
            return null;
        }

        public async Task CancelMyTasks(Guid clientToken)
        {
            var clientService = Scope.Resolve<IClientService>();
            var jobService = Scope.Resolve<IJobService>();

            var client = await clientService.GetByToken(clientToken);
            if (client == null) throw new FaultException(ErrorStrings.ClientNotFound);
            if (!client.IsActive) throw new FaultException(ErrorStrings.ClientNotActivated);
            
            await jobService.CancelByClientId(client.ClientId);
        }

        public async Task Report(Guid clientToken, ReportDto report)
        {
            var clientService = Scope.Resolve<IClientService>();
            var client = await clientService.GetByToken(clientToken);
            if (client == null) throw new FaultException(ErrorStrings.ClientNotFound);
            if (!client.IsActive) throw new FaultException(ErrorStrings.ClientNotActivated);

            var reportService = Scope.Resolve<IReportService>();
            await reportService.Add(report);
        }

        public async Task Finish(Guid clientToken, int taskId)
        {
            var clientService = Scope.Resolve<IClientService>();
            var client = await clientService.GetByToken(clientToken);
            if (client == null) throw new FaultException(ErrorStrings.ClientNotFound);
            if (!client.IsActive) throw new FaultException(ErrorStrings.ClientNotActivated);

            var jobService = Scope.Resolve<IJobService>();
            await jobService.CancelByTaskId(taskId);
        }
    }
}
