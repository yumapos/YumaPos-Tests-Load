using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YumaPos.Common.Infrastructure.BusinessLogic.Tendering;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;
using YumaPos.Tests.Load.Scenarios.Interfaces;

namespace YumaPos.Tests.Load.Scenarios
{
    public class SimpleOrderScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private TerminalContext _context;

        public SimpleOrderScenario(IOrderServiceApi orderServiceApi, TerminalContext context)
        {
            _orderServiceApi = orderServiceApi;
            _context = context;
        }
        public async Task StartAsync()
        {
            var orderId = Guid.NewGuid();
            _orderServiceApi.ExecutionContext.OrderId = orderId;
            var response1 = await _orderServiceApi.AddOrder(orderId, OrderType.Quick);
            var order = response1.Value;
            decimal cost = 0;
            int menuItemsCount = _context.FullMenu.MenuItems.Count;
            while (cost == 0)
            {
                var i = new Random().Next(menuItemsCount);
                var menuitem1 = _context.FullMenu.MenuItems.Skip(i).First().Value;
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
                cost = response3.Value.Sum(p => p.Value);
            }
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
        }

    }
}