using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Server.Data.Interfaces;

namespace YumaPos.Tests.Load.Server.Data
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<EntityContainer, IEntityContainer>(Lifecycles.PerScope);

        }
    }
}