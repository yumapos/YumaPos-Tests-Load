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
    internal class UpdateModifiersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;
        private readonly TerminalContext _context;

        public UpdateModifiersScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper, TerminalContext context)
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
                    a => a.RelatedModifiers.Count > 1 &&
                    a.ModifierGroups.Any(b=>b.CommonModifiers.Any())
                );
            var menuItemsCount = menuItems.Count();

            Assert.IsTrue(menuItemsCount > 0);

            var i = new Random().Next(menuItemsCount);

            var menuitem = menuItems.Skip(i).First();
            var relatedModifiers = menuitem.RelatedModifiers.Take(menuitem.RelatedModifiers.Count / 2);
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
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
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
                RelatedModifiers = relatedModifiers.Select(a=>new OrderItemRelatedModifierDto
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
                CalculatedPrice = menuitem.Price + relatedModifiers.Sum(a=>a.Price) + commonModifiers.Sum(a=>a.Price)
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem);
            var response3 = await _orderServiceApi.GetOrderInfo(order.OrderId);

            Assert.AreEqual(1, response3.Value.OrderItemsCosts.Count);

            var cost = response3.Value.OrderItemsCosts.Sum(p => p.Value);

            Assert.IsTrue(cost>0);

            var commonModifier = commonModifiers.First();
            var relatedModifier = relatedModifiers.First();

            #region Remove modifiers


            var response4 = await _orderServiceApi.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Where(a=>a.Id!=commonModifier.Id).Select(a => new OrderItemCommonModifierDto
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
                RelatedModifiers = relatedModifiers.Where(a=>a.Id!=relatedModifier.Id).Select(a => new OrderItemRelatedModifierDto
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
            });

            #endregion

            var costs = await _orderServiceApi.GetOrderInfo(order.OrderId);
            var newCost = costs.Value.OrderItemsCosts.Sum(a => a.Value);
            Assert.IsTrue(newCost <= cost);
            cost = newCost;

            #region Add modifiers

            var response5 = await _orderServiceApi.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
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
            });

            #endregion

            costs = await _orderServiceApi.GetOrderInfo(order.OrderId);
            newCost = costs.Value.OrderItemsCosts.Sum(a => a.Value);
            Assert.IsTrue(newCost >= cost);
            cost = newCost;

            #region Update quantity

            var response6 = await _orderServiceApi.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    CommonModifierVersionIds = new VersionIdsDto()
                    {
                        ItemVersionId = a.VersionId,
                        PriceListItemVersionId = a.PriceListItemVersionId,
                    },
                    Quantity = 5
                }).ToList(),
                RelatedModifiers = relatedModifiers.Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 5,
                    RelatedModifierId = a.Id,
                    RelatedModifierVersionIds = new VersionIdsDto()
                    {
                        ItemVersionId = a.VersionId,
                        PriceListItemVersionId = a.PriceListItemVersionId,
                    },
                }).ToList(),
                Quantity = 1,
            });

            #endregion

            costs = await _orderServiceApi.GetOrderInfo(order.OrderId);
            newCost = costs.Value.OrderItemsCosts.Sum(a => a.Value);
            Assert.IsTrue(newCost >= cost);
            cost = newCost;
            await OrderSteps.PayAndClose(_orderServiceApi, order.OrderId, cost);
        }
    }
}