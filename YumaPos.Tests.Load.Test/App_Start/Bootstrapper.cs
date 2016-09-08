using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Core;
using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Common.Tools.IoC;

namespace YumaPos.Tests.Load.Client
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

            Container = Builder.Build();
            // in the future - one named scope per window/client, several command controllers with different sets of commands
            MainScope = Container; //.BeginLifetimeScope(NamedScopes.MainScope);
            Start();
        }

        private static void RegisterTypes()
        {
            //AutoFacHelper.Register<YumaPos.Common.Tools.Registrator>(Builder);
            AutoFacHelper.Register<Registrator>(Builder);
            AutoFacHelper.Register<YumaPos.Tests.Load.Data.Registrator>(Builder);
            AutoFacHelper.Register<YumaPos.Tests.Load.Scenarios.Registrator>(Builder);

        }

        private static void Start()
        {
            //ErrorHandler = MainScope.Resolve<IErrorHandlingService>();
            //foreach (var initializationWarning in InitializationWarnings)
            {
                //ErrorHandler.ReportWarning(initializationWarning);
            }
            //MainController.Run(MainScope.Resolve<IResolver>());

            //var bLoader = GetObjectInstance<ICommandsLayerLoader>();
            //bLoader.Run().FireAndForget(ErrorHandler.ReportErrorAndExit);

            //PluginController.Run(MainScope.Resolve<IResolver>());

            // for debug purposes only, to run synchnously
            // AsyncHelpers.RunSync(() => GetObjectInstance<IBusinessLogicLoader>().Run());
            //GetObjectInstance<IPresentationLoader>().Run();
            //GetObjectInstance<IViewModelsLoader>().Run();
        }
    }
}

