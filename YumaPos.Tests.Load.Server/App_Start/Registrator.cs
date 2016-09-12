using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Server.Interfaces;
using YumaPos.Tests.Load.Server.Services;

namespace YumaPos.Tests.Load.Server
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<ClientService, IClientService>(Lifecycles.PerScope);
            Register<JobService, IJobService>(Lifecycles.PerScope);
            Register<TaskService, ITaskService>(Lifecycles.PerScope);
        }
    }
}