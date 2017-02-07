//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastucture.Dto;
using System.Diagnostics;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Client.API {
    public partial class OrderApiWrapper : YumaPos.Shared.Infrastructure.IOrderServiceApi
    {
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDeliveryOrder(YumaPos.Shared.API.Models.Ordering.DeliveryDto deliveryDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDeliveryOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddDeliveryOrder(deliveryDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDiscountToSplitting(System.Guid orderId, Int32 splittingNumber, System.Nullable<System.Guid> discountId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDiscountToSplitting",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddDiscountToSplitting(orderId, splittingNumber, discountId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> AddGiftCardToOrder(YumaPos.Shared.API.Models.GiftCardOrderItemDto item)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddGiftCardToOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddGiftCardToOrder(item);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderResponseDto> AddOrder(System.Guid orderId, YumaPos.Shared.API.Enums.OrderType orderType)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.RestaurantOrderResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrder(orderId, orderType);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> AddOrderItem(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrderItem(item);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DecimalResponseDto> CheckGiftCardBalance(System.String cardNumber)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.DecimalResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckGiftCardBalance",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CheckGiftCardBalance(cardNumber);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DeliveryDetailsResponseDto> GetDeliveryInfo(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.DeliveryDetailsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeliveryInfo",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDeliveryInfo(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderResponseDto> GetOrderById(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderById",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderById(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderItemListResponseDto> GetOrderItemsByOrderId(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.RestaurantOrderItemListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderItemsByOrderId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderItemsByOrderId(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidDecimalDictonaryResponseDto> GetOrderItemsCosts(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.GuidDecimalDictonaryResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderItemsCosts",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderItemsCosts(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptListResponseDto> GetOrderReceiptsByOrderId(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderReceiptsByOrderId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderReceiptsByOrderId(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> MobilePayment(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "MobilePayment",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.MobilePayment(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> OverrideLogin(System.String password, Int32 feature)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "OverrideLogin",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.OverrideLogin(password, feature);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> PaymentTransaction(YumaPos.Shared.API.Models.RequestTransactionDto requestTransaction)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "PaymentTransaction",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.PaymentTransaction(requestTransaction);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> RefillGiftCard(YumaPos.Shared.API.Models.GiftCardOrderItemDto item, System.Decimal amount)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RefillGiftCard",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RefillGiftCard(item, amount);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveOrderFromDelivery(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveOrderFromDelivery",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveOrderFromDelivery(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveProductFromOrder(YumaPos.Shared.API.Models.RestaurantOrderItemDto orderItem)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveProductFromOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveProductFromOrder(orderItem);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SavePaymentTransaction(YumaPos.Shared.API.Models.TransactionInfoDto data)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SavePaymentTransaction",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SavePaymentTransaction(data);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SendReceipt(System.Guid orderId, System.String email)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SendReceipt",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SendReceipt(orderId, email);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TransactionInfoResponseDto> TryProcessPaymentTransaction(YumaPos.Shared.API.Models.RequestTransactionDto requestTransaction)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TransactionInfoResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "TryProcessPaymentTransaction",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.TryProcessPaymentTransaction(requestTransaction);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrder(YumaPos.Shared.API.Models.RestaurantOrderDto orderDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrder(orderDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderCustomer(System.Guid orderId, System.Guid customerId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderCustomer",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderCustomer(orderId, customerId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItem(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderItem(item);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItemQuantity(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderItemQuantity",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderItemQuantity(item);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderNotes(System.Guid orderId, System.String notes)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderNotes",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderNotes(orderId, notes);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderStatusByOrderId(System.Guid orderId, Int32 statusId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderStatusByOrderId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderStatusByOrderId(orderId, statusId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> UpdateSplittingsForOrderId(System.Guid orderId, YumaPos.Shared.API.Enums.SplittingType splittingType, System.String[] parameters)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateSplittingsForOrderId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateSplittingsForOrderId(orderId, splittingType, parameters);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateTaxExempt(System.Guid orderId, Int32 splittingNumber, Boolean isTaxExempt)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateTaxExempt",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateTaxExempt(orderId, splittingNumber, isTaxExempt);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
    }
}