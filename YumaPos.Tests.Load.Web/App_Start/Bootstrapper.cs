using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.Wcf;
using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Common.Tools.IoC;
using YumaPos.Tests.Load.Infrastructure;
using YumaPos.Tests.Load.Server;

namespace YumaPos.Tests.Load.Web
{
    public static class Bootstrapper
    {

        private static readonly List<Exception> InitializationWarnings = new List<Exception>();

        private static ContainerBuilder Builder { get; set; }

        private static IContainer Container { get; set; }

        private static ILifetimeScope MainScope { get; set; }

        public static T GetObjectInstance<T>()
        {
            T ret;
            MainScope.TryResolve(out ret);
            return ret;
        }

        public static void Init(IList<RegistrationInfo> registration = null)
        {
            Builder = new ContainerBuilder();
            RegisterTypes();
            if (registration != null)
            {
                AutoFacHelper.Register(Builder, registration);
            }
            Builder.RegisterControllers(typeof(MvcApplication).Assembly);
            Container = Builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));

            // in the future - one named scope per window/client, several command controllers with different sets of commands
            MainScope = Container; //.BeginLifetimeScope(NamedScopes.MainScope);
            AutofacHostFactory.Container = Container;

        }

        private static void RegisterTypes()
        {
            Builder.RegisterType<TestService>().As<ITestService>().AsSelf();

            AutoFacHelper.Register<Registrator>(Builder);
            AutoFacHelper.Register<Server.Data.Registrator>(Builder);
        }
    }
}

