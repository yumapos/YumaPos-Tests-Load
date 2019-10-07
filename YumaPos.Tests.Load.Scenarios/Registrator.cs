using YumaPos.Client.WCF;
using YumaPos.Common.Infrastructure.IoC.Registration;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.API;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Tests.Load.Scenarios.MenuHelper;

namespace YumaPos.Tests.Load.Scenarios
{
    public class Registrator : ModuleRegistrator
    {
        protected override void Init()
        {
            Register<AuthorizationApi, IAuthorizationApi>(Lifecycles.PerScope);

            Register<ApiConfig, IAPIConfig>(Lifecycles.PerScope);
            Register<TerminalContext>(Lifecycles.PerScope);

            Register<EmployeeLoginScenario>             (typeof(EmployeeLoginScenario).FullName,             Lifecycles.PerScope).As<IScenario>().As<EmployeeLoginScenario>();
            Register<RegisterTerminalScenario>          (typeof(RegisterTerminalScenario).FullName,          Lifecycles.PerScope).As<IScenario>().As<RegisterTerminalScenario>();
            Register<LoadFullMenuScenario>              (typeof(LoadFullMenuScenario).FullName,              Lifecycles.PerScope).As<IScenario>().As<LoadFullMenuScenario>();
            //Register<SimpleOrderScenario>               (typeof(SimpleOrderScenario).FullName,               Lifecycles.PerScope).As<IScenario>().As<SimpleOrderScenario>();
            //Register<SplittingOrderScenario>            (typeof(SplittingOrderScenario).FullName,            Lifecycles.PerScope).As<IScenario>().As<SplittingOrderScenario>();
            //Register<PayAndRefundOrderScenario>         (typeof(PayAndRefundOrderScenario).FullName,         Lifecycles.PerScope).As<IScenario>().As<PayAndRefundOrderScenario>();
            //Register<UpdateModifiersScenario>           (typeof(UpdateModifiersScenario).FullName,           Lifecycles.PerScope).As<IScenario>().As<UpdateModifiersScenario>();
            //Register<OrderDiscountScenario>             (typeof(OrderDiscountScenario).FullName,             Lifecycles.PerScope).As<IScenario>().As<OrderDiscountScenario>();
            //Register<OrderTaxExemptScenario>            (typeof(OrderTaxExemptScenario).FullName,            Lifecycles.PerScope).As<IScenario>().As<OrderTaxExemptScenario>();
            //Register<UpdateOrderCustomerScenario>       (typeof(UpdateOrderCustomerScenario).FullName,       Lifecycles.PerScope).As<IScenario>().As<UpdateOrderCustomerScenario>();
            //Register<OrderWithRelatedModifiersScenario> (typeof(OrderWithRelatedModifiersScenario).FullName, Lifecycles.PerScope).As<IScenario>().As<OrderWithRelatedModifiersScenario>();
            //Register<OrderWithCommonModifiersScenario>  (typeof(OrderWithCommonModifiersScenario).FullName,  Lifecycles.PerScope).As<IScenario>().As<OrderWithCommonModifiersScenario>();
            //Register<VoidOldOrdersScenario>             (typeof(VoidOldOrdersScenario).FullName,             Lifecycles.PerScope).As<IScenario>().As<VoidOldOrdersScenario>();
            
            Register<MenuAvailabilityHelper, IMenuAvailabilityHelper>(Lifecycles.PerScope);
        }
    }
}