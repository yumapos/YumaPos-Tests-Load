using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.Common.Infrastructure.BusinessLogic.Tendering;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models;
using YumaPos.Shared.Infrastructure;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.MenuHelper;

namespace YumaPos.Tests.Load.Scenarios
{
    internal class UpdateModifiersScenario : IScenario
    {
        private readonly ITerminalApi _api;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public UpdateModifiersScenario(ITerminalApi terminalApi, IMenuAvailabilityHelper menuAvailabilityHelper)
        {
            _api = terminalApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            _api.ExecutionContext.OrderId = orderId;
            var response1 = await _api.AddOrder(orderId, OrderType.Quick);
            var order = response1.Value;

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
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    Qty = 1
                }),
                RelatedModifiers = relatedModifiers.Select(a=>new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 1,
                    RelatedModifierId = a.Id
                }),
                Qty = 1,
                CalculatedPrice = menuitem.Price + relatedModifiers.Sum(a=>a.Price) + commonModifiers.Sum(a=>a.Price)
            };

            var response2 = await _api.AddOrderItem(orderitem);
            var response3 = await _api.GetOrderItemsCosts(order.OrderId);

            Assert.AreEqual(1, response3.Value.Count);

            var cost = response3.Value.Sum(p => p.Value);

            Assert.IsTrue(cost>0);

            var commonModifier = commonModifiers.First();
            var relatedModifier = relatedModifiers.First();

            #region Remove modifiers


            var response4 = await _api.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Where(a=>a.Id!=commonModifier.Id).Select(a => new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    Qty = 1
                }),
                RelatedModifiers = relatedModifiers.Where(a=>a.Id!=relatedModifier.Id).Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 1,
                    RelatedModifierId = a.Id
                }),
                Qty = 1,
            });

            #endregion

            var costs = await _api.GetOrderItemsCosts(order.OrderId);
            var newCost = costs.Value.Sum(a => a.Value);
            Assert.IsTrue(newCost <= cost);
            cost = newCost;

            #region Add modifiers

            var response5 = await _api.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    Qty = 1
                }),
                RelatedModifiers = relatedModifiers.Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 1,
                    RelatedModifierId = a.Id
                }),
                Qty = 1,
            });

            #endregion

            costs = await _api.GetOrderItemsCosts(order.OrderId);
            newCost = costs.Value.Sum(a => a.Value);
            Assert.IsTrue(newCost >= cost);
            cost = newCost;

            #region Update quantity

            var response6 = await _api.UpdateOrderItem(new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a => new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    Qty = 5
                }),
                RelatedModifiers = relatedModifiers.Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 5,
                    RelatedModifierId = a.Id
                }),
                Qty = 1,
            });

            #endregion

            costs = await _api.GetOrderItemsCosts(order.OrderId);
            newCost = costs.Value.Sum(a => a.Value);
            Assert.IsTrue(newCost >= cost);
            cost = newCost;

            var requestTransaction = new RequestTransactionDto
            {
                PaymentInfo = new InputTransactionInfoDto
                {
                    OrderId = order.OrderId,
                    SplittingNumber = 0
                },
                Transaction = new PaymentTransactionParamsDto
                {
                    TransType = PaymentTransactionType.Payment,
                    Tenders = new List<TenderParamsDto>
                    {
                        new TenderParamsDto
                        {
                            Amount = cost.ToString("F"),
                            TipAmount = 0.ToString("F"),
                            TenderType = TenderType.Ca
                        }
                    }
                }
            };
            await Task.Delay(100);
            var response10 = await _api.PaymentTransaction(requestTransaction);

            Assert.IsNull(response10.PostprocessingType);
        }
    }
}