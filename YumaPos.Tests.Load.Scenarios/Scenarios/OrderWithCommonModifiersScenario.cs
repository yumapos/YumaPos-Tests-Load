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
    internal class OrderWithCommonModifiersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;
        private readonly TerminalContext _context;

        public OrderWithCommonModifiersScenario(IOrderServiceApi orderServiceApi, ITerminalApi terminalApi, IMenuAvailabilityHelper menuAvailabilityHelper, TerminalContext context)
        {
            _orderServiceApi = orderServiceApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
            _context = context;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            var order = await OrderSteps.CreateOrder(_orderServiceApi, orderId, _context.StoreId);


            var menuItems = _menuAvailabilityHelper.GetAvailableMenuItems()
                .Where(
                    a => a.ModifierGroups.Any(b=>b.CommonModifiers.Any())
                );
            var menuItemsCount = menuItems.Count();

            Assert.IsTrue(menuItemsCount > 0, "Menuitems with common modifiers not found");

            var i = new Random().Next(menuItemsCount);

            var menuitem = menuItems.Skip(i).First();
            var commonModifiers = menuitem.ModifierGroups.First(a => a.CommonModifiers.Any()).CommonModifiers;

            var orderItemId = Guid.NewGuid();

            var orderitem = new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                MenuItemId = menuitem.MenuItemId,
                MenuItemVersionIds = new VersionIdsDto()
                {
                    ItemVersionId = menuitem.MenuItemVersionId,
                    PriceListItemVersionId = menuitem.PriceListItemVersionId,
                },
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a=>new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    CommonModifierVersionIds = new VersionIdsDto()
                    {
                        ItemVersionId = a.VersionId,
                        PriceListItemVersionId = a.PriceListItemVersionId,
                    },
                    Quantity = 1
                }).ToList(),
                RelatedModifiers = new List<OrderItemRelatedModifierDto>(),
                Quantity = 1,
                CalculatedPrice = menuitem.Price + commonModifiers.Sum(a => a.Price)
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem);
            var response3 = await _orderServiceApi.GetOrderInfo(order.OrderId);

            Assert.AreEqual(1, response3.Value.OrderItemsCosts.Count);

            var cost = response3.Value.OrderItemsCosts.Sum(p => p.Value);

            Assert.IsTrue(cost>0);

            await OrderSteps.PayAndClose(_orderServiceApi, order.OrderId, cost);

        }
    }
}