using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Infrastructure;
using YumaPos.Tests.Load.Server;
using YumaPos.Tests.Load.Web.Interfaces;
using YumaPos.Tests.Load.Web.Services;

namespace YumaPos.Tests.Load.Web
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<ClientService, IClientService>(Lifecycles.PerScope);
            Register<JobService, IJobService>(Lifecycles.PerScope);
            Register<TaskService, ITaskService>(Lifecycles.PerScope);
            Register<ReportService, IReportService>(Lifecycles.PerScope);
            Register<TenantService, ITenantService>(Lifecycles.PerScope);
        }
    }
}