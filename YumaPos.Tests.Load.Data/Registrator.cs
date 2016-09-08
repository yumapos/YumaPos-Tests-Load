using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Data.Interfaces;
using YumaPos.Tests.Load.Data.Repositories;

namespace YumaPos.Tests.Load.Data
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<EntityContainer, IEntityContainer>(Lifecycles.Singleton);
            Register<TaskRepository, ITaskRepository>(Lifecycles.Singleton);
            Register<ReportRepository, IReportRepository>(Lifecycles.Singleton);
        }
    }
}