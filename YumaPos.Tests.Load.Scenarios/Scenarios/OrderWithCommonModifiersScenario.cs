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
    internal class OrderWithCommonModifiersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public OrderWithCommonModifiersScenario(IOrderServiceApi orderServiceApi, ITerminalApi terminalApi, IMenuAvailabilityHelper menuAvailabilityHelper)
        {
            _orderServiceApi = orderServiceApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            _orderServiceApi.ExecutionContext.OrderId = orderId;
            var response1 = await _orderServiceApi.AddOrder(orderId, OrderType.Quick);
            var order = response1.Value;

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
                OrderId = order.OrderId,
                CommonModifiers = commonModifiers.Select(a=>new OrderItemCommonModifierDto
                {
                    OrderItemId = orderItemId,
                    OrderId = orderId,
                    ModifierId = a.Id,
                    Qty = 1
                }).ToList(),
                RelatedModifiers = new List<OrderItemRelatedModifierDto>(),
                Qty = 1,
                CalculatedPrice = menuitem.Price + commonModifiers.Sum(a => a.Price)
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem);
            var response3 = await _orderServiceApi.GetOrderItemsCosts(order.OrderId);

            Assert.AreEqual(1, response3.Value.Count);

            var cost = response3.Value.Sum(p => p.Value);

            Assert.IsTrue(cost>0);

            var requestTransaction = new RequestTransactionDto
            {
                PaymentInfo = new TransactionInfoDto()
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
            var response4 = await _orderServiceApi.PaymentTransaction(requestTransaction);

            Assert.IsNull(response4.PostprocessingType);
        }
    }
}