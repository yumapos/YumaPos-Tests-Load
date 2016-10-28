using System;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using YumaPos.Common.Infrastructure.Enums;
using YumaPos.Tests.Load.Scenarios;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Tests.Load.Client.Data.Models;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class TestEngine : IDisposable
    {
        private bool _run = true;
        private TerminalContext _terminalContext;
        private ILifetimeScope _scope;
        private CancellationTokenSource _cancellationTokenSource;

        public TestEngine()
        {
            var rootScope = Bootstrapper.GetObjectInstance<ILifetimeScope>();
            _scope = rootScope.BeginLifetimeScope(NamedScopes.TaskScope);
        }

        public async void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _terminalContext = _scope.Resolve<TerminalContext>();
            _terminalContext.AuthServer         = TestTask.AuthorizationAddress;
            _terminalContext.TerminalServer     = TestTask.ServiceAddress;
            _terminalContext.TenantAlias        = TestTask.TenantAlias;
            _terminalContext.TerminalId         = TestTask.TerminalId;
            _terminalContext.TerminalToken      = TestTask.TerminalToken;
            _terminalContext.EmployeeLogin      = TestTask.EmployeeLogin;
            _terminalContext.EmployeePassword   = TestTask.EmployeePassword;
            _terminalContext.ClientIsRegistered = TestTask.ClientIsRegistered;

            ApiConfig config = (ApiConfig) _scope.Resolve<IAPIConfig>();
            config.TerminalId                   = TestTask.TerminalId.ToString();
            config.Token                        = TestTask.TerminalToken.ToString();
            config.Tenant                       = TestTask.TenantAlias;
            config.AuthorizationAddress         = TestTask.AuthorizationAddress;
            config.ServiceAddress               = TestTask.ServiceAddress;

            if (_terminalContext.ClientIsRegistered)
            {
                var regiterScenario = _scope.ResolveKeyed<RegisterTerminalScenario>(typeof(RegisterTerminalScenario).FullName);
                await regiterScenario.StartAsync();
            }
            var loginScenario = _scope.ResolveKeyed<EmployeeLoginScenario>(typeof(EmployeeLoginScenario).FullName);
            await loginScenario.StartAsync();
            var initScenario = _scope.ResolveKeyed<LoadFullMenuScenario>(typeof(LoadFullMenuScenario).FullName);
            await initScenario.StartAsync();

            foreach (string scenarioTypeName in TestTask.Scenarios)
            {
                IScenario scenario = _scope.ResolveKeyed<IScenario>(scenarioTypeName);
                await scenario.StartAsync();
                if (!_run) break;
            }
            OnFinished();
        }

        public void Stop()
        {
            _run = false;
            _cancellationTokenSource.Cancel();
        }

        public TestTask TestTask { get; set; }

        public Task ThreadTask { get; set; }

        public event EventHandler Finished;

        protected virtual void OnFinished()
        {
            var handler = Finished;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            Finished = null;
            _scope.Dispose();
            _scope = null;
        }

        public ReportDto GetReport()
        {
            return new ReportDto()
            {
                TaskId = TestTask.TaskId
            };
        }
    }


}