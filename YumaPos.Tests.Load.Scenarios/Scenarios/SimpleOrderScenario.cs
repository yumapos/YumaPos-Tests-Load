using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Common.Infrastructure.BusinessLogic.Tendering;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.Steps;

namespace YumaPos.Tests.Load.Scenarios
{
    public class SimpleOrderScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private TerminalContext _context;

        public SimpleOrderScenario(IOrderServiceApi orderServiceApi, TerminalContext context)
        {
            _orderServiceApi = orderServiceApi;
            _context = context;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            var order = await OrderSteps.CreateOrder(_orderServiceApi, orderId, _context.StoreId);
            decimal cost = 0;
            int menuItemsCount = _context.FullMenu.MenuItems.Count;
            while (cost == 0)
            {
                var i = new Random().Next(menuItemsCount);
                var menuitem1 = _context.FullMenu.MenuItems.Skip(i).First().Value;
                var orderitem1 = new RestaurantOrderItemDto()
                {
                    OrderItemId = Guid.NewGuid(),
                    MenuItemId = menuitem1.MenuItemId,
                    MenuItemVersionIds = new VersionIdsDto()
                    {
                        ItemVersionId = menuitem1.MenuItemVersionId,
                        PriceListItemVersionId = menuitem1.PriceListItemVersionId,
                    },
                    OrderId = order.OrderId,
                    CommonModifiers = new List<OrderItemCommonModifierDto>(),
                    RelatedModifiers = new List<OrderItemRelatedModifierDto>(),
                    Quantity = 1,
                    CalculatedPrice = menuitem1.Price
                };
                var response2 = await _orderServiceApi.AddOrderItem(orderitem1);
                var response3 = await _orderServiceApi.GetOrderInfo(order.OrderId);
                cost = response3.Value.OrderItemsCosts.Sum(p => p.Value);
            }
            var reciept = (await _orderServiceApi.GetOrderReceiptsByOrderId(order.OrderId)).Value.Single();

            await OrderSteps.PayAndClose(_orderServiceApi, order.OrderId, reciept.TotalAmount);
        }


    }
}