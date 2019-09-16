//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastucture.Dto;
using System.Diagnostics;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Client.API {
    public partial class OrderApiWrapper
    {
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDiscount(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.AddDiscountDto addDiscountDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDiscount",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddDiscount(addDiscountDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemListResponseDto> AddFreeOrderItems(YumaPos.Shared.API.Models.Ordering.FreeOrderItemToChooseDto[] items)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddFreeOrderItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddFreeOrderItems(items);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> AddGiftCardToOrder(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GiftCardOrderItemDto item)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderResponseDto> AddOrder(System.Guid orderId, YumaPos.Shared.API.Enums.OrderType orderType, System.Nullable<System.Guid> storeId)
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
                res = await _api.AddOrder(orderId, orderType, storeId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> AddOrderItem(YumaPos.Shared.API.Models.Ordering.RestaurantOrderItemDto item)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrderToDelivery(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.DeliveryDto deliveryDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderToDelivery",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrderToDelivery(deliveryDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrderToDineIn(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderToDineIn",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrderToDineIn(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrderToDriver(YumaPos.Shared.API.Models.Ordering.AddOrderToDriverDto addOrderToDriverDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderToDriver",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrderToDriver(addOrderToDriverDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrderToTakeOut(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.TakeOutDto takeOutDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderToTakeOut",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrderToTakeOut(takeOutDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TenderFeeListResponseDto> CalculateTendersFees(YumaPos.Shared.API.Models.Ordering.TenderFeeRequestDto requestInfo)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TenderFeeListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CalculateTendersFees",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CalculateTendersFees(requestInfo);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CancelPaymentTransaction(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.CancelPaymentDto data)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CancelPaymentTransaction",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CancelPaymentTransaction(data);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ChangeWantPayBy(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ChangeWantPayByDto wantPayBy)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "ChangeWantPayBy",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.ChangeWantPayBy(wantPayBy);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> CopyOrMoveOrderItemToSeat(YumaPos.Shared.API.Models.Ordering.MoveOrderItemToSeatRequestDto moveOrderItemToSeatRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CopyOrMoveOrderItemToSeat",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CopyOrMoveOrderItemToSeat(moveOrderItemToSeatRequestDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto> CreateOrUpdateOrder(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.TerminalCreateOrUpdateOrderRequestDto createOrUpdateOrderRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CreateOrUpdateOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CreateOrUpdateOrder(createOrUpdateOrderRequestDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalDiscountListResponseDto> GetAvailableDiscountsByOrderItemId(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetDiscountsByOrderItemRequestDto getDiscountsByOrderItemRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalDiscountListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAvailableDiscountsByOrderItemId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAvailableDiscountsByOrderItemId(getDiscountsByOrderItemRequestDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderPointsListResponseDto> GetAvailablePointsInfo()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.OrderPointsListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAvailablePointsInfo",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAvailablePointsInfo();
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemListResponseDto> GetIssuedItems(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalOrderItemListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetIssuedItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetIssuedItems(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto> GetOrderById(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto res = null;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderInfoResponseDto> GetOrderInfo(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderInfoResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderInfo",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderInfo(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
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
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderStatusChangeListResponseDto> GetOrderStatusHistory(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.OrderStatusChangeListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderStatusHistory",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetOrderStatusHistory(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderPointsResponseDto> GetPointsInfo(YumaPos.Shared.API.Models.Ordering.GetPointsInfoRequestDto getPointsInfoRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.OrderPointsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPointsInfo",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetPointsInfo(getPointsInfoRequestDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsOrderPaid(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsOrderPaid",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.IsOrderPaid(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> MoveOrderItemsToAnotherOrder(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.MoveOrderItemsToAnotherOrderDto moveOrderItemsToAnotherOrderDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "MoveOrderItemsToAnotherOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.MoveOrderItemsToAnotherOrder(moveOrderItemsToAnotherOrderDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> MoveOrderToStore(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.MoveOrderToStoreDto updateOrderStoreDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "MoveOrderToStore",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.MoveOrderToStore(updateOrderStoreDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> OverridePrice(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.OverridePriceDto overridePriceDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "OverridePrice",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.OverridePrice(overridePriceDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderItemResponseDto> RefillGiftCard(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GiftCardOrderItemDto item, System.Decimal amount)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveAllOrderItems()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveAllOrderItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveAllOrderItems();
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveProductFromOrder(YumaPos.Shared.API.Models.Ordering.RestaurantOrderItemDto orderItem)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto> RepeatOrder(System.Guid previousOrderId, System.Guid newOrderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RepeatOrder",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RepeatOrder(previousOrderId, newOrderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SaveFiscalData(System.Guid orderId, YumaPos.Shared.API.Models.Ordering.TransactionFiscalDataDto fiscalData)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SaveFiscalData",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SaveFiscalData(orderId, fiscalData);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SavePaymentTransaction(YumaPos.Shared.API.Models.Ordering.TransactionInfoDto data)
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
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> SetPreorderPrinted(System.Guid orderId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SetPreorderPrinted",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SetPreorderPrinted(orderId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SetPrintedOnKitchenPrinterStatus(System.Guid orderId, System.Guid[] orderItemsIds)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SetPrintedOnKitchenPrinterStatus",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SetPrintedOnKitchenPrinterStatus(orderId, orderItemsIds);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFromSameTableListResponseDto> SplitBySeat()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.OrderFromSameTableListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SplitBySeat",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SplitBySeat();
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TransactionInfoResponseDto> TryProcessPaymentTransaction(YumaPos.Shared.API.Models.Ordering.RequestTransactionDto requestTransaction)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCourseInItems(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.UpdateCourseDto updateCourseDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateCourseInItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateCourseInItems(updateCourseDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateDineInTable(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.DineInDto dineInDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateDineInTable",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateDineInTable(dineInDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateExpected(YumaPos.Shared.API.Models.Ordering.ExpectedTimeDto expectedTimeDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateExpected",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateExpected(expectedTimeDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateIssuedItems(System.Guid orderId, YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.IssuedOrderItemDto[] issuedItems)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateIssuedItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateIssuedItems(orderId, issuedItems);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrder(YumaPos.Shared.API.Models.Ordering.RestaurantOrderDto orderDto)
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
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItem(YumaPos.Shared.API.Models.Ordering.RestaurantOrderItemDto item)
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItemQuantity(YumaPos.Shared.API.Models.Ordering.RestaurantOrderItemDto item)
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
				throw;
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
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderStatusByOrderId(System.String reason, System.Guid orderId, Int32 statusId)
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
                res = await _api.UpdateOrderStatusByOrderId(reason, orderId, statusId);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdatePartySize(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.PartySizeDto partySizeDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdatePartySize",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdatePartySize(partySizeDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdatePrintedOnKitchenPrinterStatus(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.PrintedOnKitchenPrinterStatusDto printedOnKitchenPrinterStatusDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdatePrintedOnKitchenPrinterStatus",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdatePrintedOnKitchenPrinterStatus(printedOnKitchenPrinterStatusDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateTaxExempt(System.Guid orderId, Boolean isTaxExempt)
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
                res = await _api.UpdateTaxExempt(orderId, isTaxExempt);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
            }
            finally
            {
                stopwatch.Stop();
                reportItem.Duration = stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
        }
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.UsePointsResponseDto> UsePoints(YumaPos.Shared.API.Models.Ordering.UsePointsRequestDto usePointsRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.UsePointsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UsePoints",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UsePoints(usePointsRequestDto);
            }
            catch (Exception ex)
            {
                reportItem.ExceptionMessage = ex.ToString();
				throw;
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