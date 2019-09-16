using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.MenuHelper;

namespace YumaPos.Tests.Load.Scenarios
{
    internal class VoidOldOrdersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly ITerminalApi _terminalApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public VoidOldOrdersScenario(IOrderServiceApi orderServiceApi, ITerminalApi terminalApi, IMenuAvailabilityHelper menuAvailabilityHelper)
        {
            _orderServiceApi = orderServiceApi;
            _terminalApi = terminalApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
        }
        public async Task StartAsync()
        {
            var response1 = await _terminalApi.GetPagedActiveOrders(new OrderFilterDto() {Statuses = new []{OrderStatus.New}, DateStart = DateTime.UtcNow.AddDays(-1), DateEnd = DateTime.UtcNow.AddMinutes(-15), Count = 1});
            IList<TerminalOrderDto> orders = response1.Value.Results;
            foreach (TerminalOrderDto orderDto in orders)
            {
                _orderServiceApi.ExecutionContext.OrderId = orderDto.OrderId;
                await _orderServiceApi.UpdateOrderStatusByOrderId(null, orderDto.OrderId, (int) OrderStatus.Void);
            }
        }
    }
}