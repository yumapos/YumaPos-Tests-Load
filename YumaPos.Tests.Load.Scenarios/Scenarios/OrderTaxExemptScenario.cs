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

namespace YumaPos.Tests.Load.Scenarios
{
    internal class OrderTaxExemptScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public OrderTaxExemptScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper)
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

            var menuItems = _menuAvailabilityHelper.GetAvailableMenuItems();

            var menuItemsCount = menuItems.Count;

            var i = new Random().Next(menuItemsCount);
            var menuitem1 = menuItems.Skip(i).First();

            var orderitem1 = new RestaurantOrderItemDto()
            {
                OrderItemId = Guid.NewGuid(),
                MenuItemId = menuitem1.MenuItemId,
                OrderId = order.OrderId,
                CommonModifiers = new List<OrderItemCommonModifierDto>(),
                RelatedModifiers = new List<OrderItemRelatedModifierDto>(),
                Qty = 1,
                CalculatedPrice = menuitem1.Price
            };

            var response2 = await _orderServiceApi.AddOrderItem(orderitem1);
            var response3 = await _orderServiceApi.GetOrderItemsCosts(order.OrderId);

            Assert.AreEqual(1, response3.Value.Count);
            var cost = response3.Value.Sum(p => p.Value);

            var addTaxExemptResponse = await _orderServiceApi.UpdateTaxExempt(orderId,0,true);

            Assert.IsNull(addTaxExemptResponse.PostprocessingType);

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
                            TenderType = TenderType.Ca,
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