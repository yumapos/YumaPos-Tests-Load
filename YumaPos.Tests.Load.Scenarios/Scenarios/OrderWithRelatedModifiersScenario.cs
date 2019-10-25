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
    internal class OrderWithRelatedModifiersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;
        private readonly TerminalContext _context;

        public OrderWithRelatedModifiersScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper, TerminalContext context)
        {
            _orderServiceApi = orderServiceApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
            _context = context;
        }
        public async Task StartAsync()
        {

            var menuItems = _menuAvailabilityHelper.GetAvailableMenuItems().Where(a => a.RelatedModifiers.Count > 1);
            var menuItemsCount = menuItems.Count();

            Assert.IsTrue(menuItemsCount > 0, "Menuitems with related modifiers not found");

            var orderId = Guid.NewGuid();
            var order = await OrderSteps.CreateOrder(_orderServiceApi, orderId, _context.StoreId);

            var i = new Random().Next(menuItemsCount);

            var menuitem = menuItems.Skip(i).First();
            var relatedModifiers = menuitem.RelatedModifiers.Take(menuitem.RelatedModifiers.Count / 2);

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
                CommonModifiers = new List<OrderItemCommonModifierDto>(),
                RelatedModifiers = relatedModifiers.Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 1,
                    RelatedModifierId = a.Id,
                    RelatedModifierVersionIds = new VersionIdsDto()
                    {
                        ItemVersionId = a.VersionId,
                        PriceListItemVersionId = a.PriceListItemVersionId,
                    },
                }).ToList(),
                Quantity = 1,
                CalculatedPrice = menuitem.Price + relatedModifiers.Sum(a => a.Price)
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem);
            Assert.IsNull(response2.PostprocessingType, response2.PostprocessingType.ToString());
            var response3 = await _orderServiceApi.GetOrderInfo(order.OrderId);

            Assert.AreEqual(1, response3.Value.OrderItemsCosts.Count);

            var cost = response3.Value.OrderItemsCosts.Sum(p => p.Value);

            Assert.IsTrue(cost > 0);

            await OrderSteps.PayAndClose(_orderServiceApi, order.OrderId, cost);

        }
    }
}