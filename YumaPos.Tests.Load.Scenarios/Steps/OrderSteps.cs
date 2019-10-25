using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;

namespace YumaPos.Tests.Load.Scenarios.Steps
{
    public static class OrderSteps
    {
        public static async Task<RestaurantOrderDto> CreateOrder(IOrderServiceApi orderServiceApi, Guid orderId, Guid storeId)
        {
            orderServiceApi.ExecutionContext.OrderId = orderId;
            var response1 = await orderServiceApi.AddOrder(orderId, OrderType.Quick, storeId);
            if (response1.PostprocessingType == CommandPostprocessingType.ReopenShiftRequired)
            {

            }
            Assert.AreEqual(null, response1.PostprocessingType);
            var order = response1.Value;
            return order;
        }

        public static async Task Pay(IOrderServiceApi orderServiceApi, Guid orderId, decimal amount)
        {
            orderServiceApi.ExecutionContext.OrderId = orderId;
            var requestTransaction = new RequestTransactionDto
            {
                PaymentInfo = new TransactionInfoDto()
                {
                    OrderId = orderId,
                },
                Transaction = new PaymentTransactionParamsDto
                {
                    TransType = PaymentTransactionType.Payment,
                    Tenders = new List<TenderParamsDto>
                    {
                        new TenderParamsDto
                        {
                            Amount = amount,
                            TipAmount = 0,
                            TenderType = TenderType.Ca,
                        }
                    }
                }
            };
            var response4 = await orderServiceApi.TryProcessPaymentTransaction(requestTransaction);
            Assert.AreEqual(null, response4.PostprocessingType);
            await Task.Delay(100);
            var response5 = await orderServiceApi.SavePaymentTransaction(requestTransaction.PaymentInfo);
            Assert.AreEqual(null, response5.PostprocessingType);
        }

        public static async Task PayAndClose(IOrderServiceApi orderServiceApi, Guid orderId, decimal amount)
        {
            await Pay(orderServiceApi, orderId, amount);
            await Task.Delay(100);
            var response6 = await orderServiceApi.UpdateOrderStatusByOrderId("", orderId, (int)OrderStatus.Closed);
            Assert.AreEqual(null, response6.PostprocessingType);
        }
    }
}