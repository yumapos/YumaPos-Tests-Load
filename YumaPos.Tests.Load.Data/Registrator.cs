using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Client.Data.Interfaces;
using YumaPos.Tests.Load.Client.Data.Repositories;

namespace YumaPos.Tests.Load.Client.Data
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<EntityContainer, IEntityContainer>(Lifecycles.Singleton);
            Register<TaskRepository, ITaskRepository>(Lifecycles.Singleton);
            Register<ReportRepository, IReportRepository>(Lifecycles.Singleton);
            Register<ConfigRepository, IConfigRepository>(Lifecycles.Singleton);
        }
    }
}