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
    internal class SplittingOrderScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly IMenuAvailabilityHelper _menuAvailabilityHelper;

        public SplittingOrderScenario(IOrderServiceApi orderServiceApi, IMenuAvailabilityHelper menuAvailabilityHelper)
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

            Assert.IsTrue(cost>0);

            var isNeedUpdate = await _orderServiceApi.UpdateSplittingsForOrderId(orderId, SplittingType.SplitEvently, new[] {2.ToString()});

            Assert.IsTrue(isNeedUpdate.Value);

            //Deserialization exception for GetOrderReceiptsByOrderId
            //var receipts = await _api.GetOrderReceiptsByOrderId(orderId);
            //Assert.AreEqual(2,receipts.Value.Count());

            var requestTransaction1 = new RequestTransactionDto
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
                            Amount = (cost/2).ToString("F"),
                            TipAmount = 0.ToString("F"),
                            TenderType = TenderType.Ca,
                        }
                    }
                }
            };
            await Task.Delay(100);
            var response4 = await _orderServiceApi.PaymentTransaction(requestTransaction1);

            Assert.IsNull(response4.PostprocessingType);

            var requestTransaction2 = new RequestTransactionDto
            {
                PaymentInfo = new TransactionInfoDto()
                {
                    OrderId = order.OrderId,
                    SplittingNumber = 1
                },
                Transaction = new PaymentTransactionParamsDto
                {
                    TransType = PaymentTransactionType.Payment,
                    Tenders = new List<TenderParamsDto>
                    {
                        new TenderParamsDto
                        {
                            Amount = ((cost/2)+1).ToString("F"),
                            TipAmount = 1.ToString("F"),
                            TenderType = TenderType.Ca,
                        }
                    }
                }
            };
            await Task.Delay(100);
            var response5 = await _orderServiceApi.PaymentTransaction(requestTransaction2);

            Assert.IsNull(response5.PostprocessingType);
        }
    }
}