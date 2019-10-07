using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using YumaPos.Common.Infrastructure.Enums;
using YumaPos.Tests.Load.Scenarios;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Tests.Load.Client.API;
using YumaPos.Tests.Load.Client.Data.Models;
using YumaPos.Tests.Load.Infrastructure.Dto;

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
            config.TerminalServiceAddress       = TestTask.ServiceAddress;
            config.OrderServiceAddress          = TestTask.ServiceAddress.ToLowerInvariant().Replace("/terminalservice.svc", "/orderservice.svc");

            var api = _scope.Resolve<TerminalApiWrapper>();
            api.MaxInterval = TestTask.MaxInterval;
            api.MinInterval = TestTask.MinInterval;


            while (true)
            {
                try
                {
                    if (_terminalContext.ClientIsRegistered)
                    {
                        var registerScenario = _scope.ResolveKeyed<RegisterTerminalScenario>(typeof(RegisterTerminalScenario).FullName);
                        await registerScenario.StartAsync();
                        _terminalContext.ClientIsRegistered = true;
                    }
                    var loginScenario = _scope.ResolveKeyed<EmployeeLoginScenario>(typeof(EmployeeLoginScenario).FullName);
                    await loginScenario.StartAsync();
                    var initScenario = _scope.ResolveKeyed<LoadFullMenuScenario>(typeof(LoadFullMenuScenario).FullName);
                    await initScenario.StartAsync();
                    break;
                }
                catch (Exception exception)
                {
                    api.ReportItems.Add(new ReportItem()
                    {
                        MethodName = "EmployeeLoginScenario",
                        Created = DateTime.UtcNow,
                        ExceptionMessage = exception.ToString()
                    });
                    await Task.Delay(10000);
                }
            }
            var endTime = TestTask.Start + TestTask.Duration;

            while (endTime > DateTime.UtcNow)
            {
                foreach (string scenarioTypeName in TestTask.Scenarios)
                {
                    IScenario scenario = _scope.ResolveKeyed<IScenario>(scenarioTypeName);
                    try
                    {
                        await scenario.StartAsync();
                    }
                    catch (Exception exception)
                    {
                        api.ReportItems.Add(new ReportItem()
                        {
                            MethodName = scenarioTypeName,
                            Created = DateTime.UtcNow,
                            ExceptionMessage = exception.ToString()
                        });

                    }
                    OnReported();
                    if (!_run) break;
                }
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
        public event EventHandler Reported;

        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnReported()
        {
            Reported?.Invoke(this, EventArgs.Empty);
        }


        public void Dispose()
        {
            Finished = null;
            _scope.Dispose();
            _scope = null;
        }

        public ReportDto GetReport()
        {
            var api = _scope.Resolve<TerminalApiWrapper>();
            List<ReportItem> reportItems = api.ReportItems.ToList();
            api.ReportItems.Clear();
            return new ReportDto()
            {
                TaskId = TestTask.TaskId,
                ReportItems = reportItems
            };
        }
    }


}