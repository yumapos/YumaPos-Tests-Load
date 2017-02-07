using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.Common.Infrastructure.BusinessLogic.Tendering;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models;
using YumaPos.Shared.API.ResponseDtos;
using YumaPos.Shared.Infrastructure;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.MenuHelper;

namespace YumaPos.Tests.Load.Scenarios
{
    internal class OrderWithRelatedModifiersScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public OrderWithRelatedModifiersScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper)
        {
            _orderServiceApi = orderServiceApi;
            _menuAvailabilityHelper = menuAvailabilityHelper;
        }
        public async Task StartAsync()
        {

            var menuItems = _menuAvailabilityHelper.GetAvailableMenuItems().Where(a => a.RelatedModifiers.Count > 1);
            var menuItemsCount = menuItems.Count();

            Assert.IsTrue(menuItemsCount > 0, "Menuitems with related modifiers not found");

            var orderId = Guid.NewGuid();
            _orderServiceApi.ExecutionContext.OrderId = orderId;
            var response1 = await _orderServiceApi.AddOrder(orderId, OrderType.Quick);
            var order = response1.Value;


            var i = new Random().Next(menuItemsCount);

            var menuitem = menuItems.Skip(i).First();
            var relatedModifiers = menuitem.RelatedModifiers.Take(menuitem.RelatedModifiers.Count / 2);

            var orderItemId = Guid.NewGuid();

            var orderitem = new RestaurantOrderItemDto()
            {
                OrderItemId = orderItemId,
                MenuItemId = menuitem.MenuItemId,
                OrderId = order.OrderId,
                CommonModifiers = new List<OrderItemCommonModifierDto>(),
                RelatedModifiers = relatedModifiers.Select(a => new OrderItemRelatedModifierDto
                {
                    OrderId = orderId,
                    OrderItemId = orderItemId,
                    Quantity = 1,
                    RelatedModifierId = a.Id
                }).ToList(),
                Qty = 1,
                CalculatedPrice = menuitem.Price + relatedModifiers.Sum(a => a.Price)
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem);
            Assert.IsNull(response2.PostprocessingType, response2.PostprocessingType.ToString());
            var response3 = await _orderServiceApi.GetOrderItemsCosts(order.OrderId);

            Assert.AreEqual(1, response3.Value.Count);

            var cost = response3.Value.Sum(p => p.Value);

            Assert.IsTrue(cost > 0);

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