using YumaPos.Client.WCF;
using YumaPos.Common.Infrastructure.Common.Serialization;
using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Common.Tools.JsonSerialization;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Tests.Load.Client.API;
using YumaPos.Tests.Load.Client.Interfaces;
using YumaPos.Tests.Load.Client.Logic;
using YumaPos.Tests.Load.Web.Services;

namespace YumaPos.Tests.Load.Client
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<App, App>(Lifecycles.Singleton);
            Register<Config, IConfig>(Lifecycles.Singleton);
            Register<TestApi, ITestApi>(Lifecycles.Singleton);
            Register<SerializationService, ISerializationService>(Lifecycles.Singleton);
            Register<CheckServerConnectionService, ICheckServerConnectionService>(Lifecycles.Singleton);
            Register<TerminalApiWrapper, ITerminalApi>(Lifecycles.PerScope).As<TerminalApiWrapper>();
            Register<OrderApiWrapper, IOrderServiceApi>(Lifecycles.PerScope).As<OrderApiWrapper>();

        }
    }
}