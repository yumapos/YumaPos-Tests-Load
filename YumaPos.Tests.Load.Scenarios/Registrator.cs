using YumaPos.Client.WCF;
using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.API;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Shared.Infrastructure;

namespace YumaPos.Tests.Load.Scenarios
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<ApiConfig, IAPIConfig>(Lifecycles.Singleton);
            Register<AuthorizationApi, IAuthorizationApi>(Lifecycles.Singleton);
            Register<TerminalApi, ITerminalApi>(Lifecycles.Singleton);

            Register<TerminalContext>(Lifecycles.PerScope);

            Register<EmployeeLoginScenario>(typeof(EmployeeLoginScenario).FullName, Lifecycles.PerScope).As<IScenario>().As<EmployeeLoginScenario>();
            Register<RegisterTerminalScenario>(typeof(RegisterTerminalScenario).FullName, Lifecycles.PerScope).As<IScenario>().As<RegisterTerminalScenario>();
            Register<LoadFullMenuScenario>(typeof(LoadFullMenuScenario).FullName, Lifecycles.PerScope).As<IScenario>().As<LoadFullMenuScenario>();
            Register<SimpleOrderScenario>(typeof(SimpleOrderScenario).FullName, Lifecycles.PerScope).As<IScenario>().As<SimpleOrderScenario>();
        }
    }
}