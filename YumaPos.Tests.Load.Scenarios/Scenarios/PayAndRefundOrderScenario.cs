using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.Common.Infrastructure.BusinessLogic.Tendering;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.MenuHelper;
using YumaPos.Tests.Load.Scenarios.Steps;

namespace YumaPos.Tests.Load.Scenarios
{
    internal class PayAndRefundOrderScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;
        private readonly TerminalContext _context;

        public PayAndRefundOrderScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper, TerminalContext context)
        {
            _orderServiceApi = orderServiceApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
            _context = context;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            var order = await OrderSteps.CreateOrder(_orderServiceApi, orderId, _context.StoreId);


            var menuItems = _menuAvailabilityHelper.GetAvailableMenuItems();

            var menuItemsCount = menuItems.Count;

            var i = new Random().Next(menuItemsCount);
            var menuitem1 = menuItems.Skip(i).First();

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

            Assert.AreEqual(1, response3.Value.OrderItemsCosts.Count);

            var cost = response3.Value.OrderItemsCosts.Sum(p => p.Value);

            Assert.IsTrue(cost>0);

            await OrderSteps.PayAndClose(_orderServiceApi, order.OrderId, cost);
        }
    }
}