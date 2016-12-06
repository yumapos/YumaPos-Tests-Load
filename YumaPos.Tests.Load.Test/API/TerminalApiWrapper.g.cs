//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastucture.Dto;
using System.Diagnostics;


namespace YumaPos.Tests.Load.Client.API {
    public partial class TerminalApiWrapper : YumaPos.Shared.Infrastructure.ITerminalApi
    {
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCashDrawerCheckItem(YumaPos.Shared.API.Models.CashDrawerItemDto itemDto)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCashDrawerCheckItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddCashDrawerCheckItem(itemDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomer(YumaPos.Shared.API.Models.CustomerDto customerDto)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCustomer",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddCustomer(customerDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomerAddress(YumaPos.Shared.API.Models.CustomerAddressDto addressDto)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCustomerAddress",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddCustomerAddress(addressDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDeliveryOrder(YumaPos.Shared.API.Models.Ordering.DeliveryDto deliveryDto)
        {
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrdersToDriver(System.Guid driverId, System.Guid[] orderIds)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrdersToDriver",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddOrdersToDriver(driverId, orderIds);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddRelatedModifierToOrderItem(System.Guid orderId, YumaPos.Shared.API.Models.OrderItemRelatedModifierDto relatedModifier)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddRelatedModifierToOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddRelatedModifierToOrderItem(orderId, relatedModifier);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidResponseDto> AddTerminalToStore(YumaPos.Shared.API.Models.TerminalDto terminalDto)
        {
            YumaPos.Shared.API.ResponseDtos.GuidResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddTerminalToStore",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddTerminalToStore(terminalDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakeLoan(YumaPos.Shared.API.Models.PickUpDto pickUpDto)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CashDrawerMakeLoan",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CashDrawerMakeLoan(pickUpDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakePickUp(YumaPos.Shared.API.Models.PickUpDto pickUpDto)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CashDrawerMakePickUp",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CashDrawerMakePickUp(pickUpDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ClockOperation(YumaPos.Shared.API.Enums.UserActivityType operationType)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "ClockOperation",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.ClockOperation(operationType);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto> GetActiveOrdersChangesDigest(System.DateTime timestamp)
        {
            YumaPos.Shared.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetActiveOrdersChangesDigest",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetActiveOrdersChangesDigest(timestamp);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DiscountListResponseDto> GetAllDiscounts()
        {
            YumaPos.Shared.API.ResponseDtos.DiscountListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllDiscounts",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllDiscounts();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GiftCardTypeListResponseDto> GetAllGiftCardTypes()
        {
            YumaPos.Shared.API.ResponseDtos.GiftCardTypeListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllGiftCardTypes",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllGiftCardTypes();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreListResponseDto> GetAllStores()
        {
            YumaPos.Shared.API.ResponseDtos.StoreListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllStores",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllStores();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerInfoResponseDto> GetCashDrawerInfoTotal()
        {
            YumaPos.Shared.API.ResponseDtos.CashDrawerInfoResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCashDrawerInfoTotal",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCashDrawerInfoTotal();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CheckoutOptionListResponseDto> GetCheckoutOptionsByOrderType(YumaPos.Shared.API.Enums.OrderType orderType)
        {
            YumaPos.Shared.API.ResponseDtos.CheckoutOptionListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCheckoutOptionsByOrderType",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCheckoutOptionsByOrderType(orderType);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerItemResponseDto> GetCurrentCashierLastActivity()
        {
            YumaPos.Shared.API.ResponseDtos.CashDrawerItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentCashierLastActivity",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCurrentCashierLastActivity();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto> GetCurrentEmployee()
        {
            YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentEmployee",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCurrentEmployee();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreResponseDto> GetCurrentStore()
        {
            YumaPos.Shared.API.ResponseDtos.StoreResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentStore",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCurrentStore();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.UserClockStateResponseDto> GetCurrentUserClockState()
        {
            YumaPos.Shared.API.ResponseDtos.UserClockStateResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentUserClockState",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCurrentUserClockState();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerAddressListResponseDto> GetCustomerAddresses(System.Guid customerId)
        {
            YumaPos.Shared.API.ResponseDtos.CustomerAddressListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomerAddresses",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCustomerAddresses(customerId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DeliveryDetailsListResponseDto> GetDeliveryOrders()
        {
            YumaPos.Shared.API.ResponseDtos.DeliveryDetailsListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeliveryOrders",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDeliveryOrders();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DriverDetailsListResponseDto> GetDriversDetails()
        {
            YumaPos.Shared.API.ResponseDtos.DriverDetailsListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDriversDetails",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDriversDetails();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersResponseResponseDto> GetFilteredCustomers(YumaPos.Shared.API.Models.FilteredRequestDto model)
        {
            YumaPos.Shared.API.ResponseDtos.FilteredCustomersResponseResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredCustomers",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetFilteredCustomers(model);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderListResponseDto> GetFilteredOrdersByIds(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            YumaPos.Shared.API.ResponseDtos.TerminalOrderListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredOrdersByIds",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetFilteredOrdersByIds(filter);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashierShiftResponseDto> GetLastCashierShift()
        {
            YumaPos.Shared.API.ResponseDtos.CashierShiftResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetLastCashierShift",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetLastCashierShift();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedActiveOrders(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedActiveOrders",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetPagedActiveOrders(filter);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCashDrawerItemResponseDto> GetPagedCashDrawerItems(YumaPos.Shared.API.Models.CashDrawerItemsFilterDto filter)
        {
            YumaPos.Shared.API.ResponseDtos.FilteredCashDrawerItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedCashDrawerItems",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetPagedCashDrawerItems(filter);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedClosedOrders(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedClosedOrders",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetPagedClosedOrders(filter);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetReportById(System.Guid cashDrawerItemId)
        {
            YumaPos.Shared.API.ResponseDtos.XReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetReportById",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetReportById(cashDrawerItemId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetShiftReport()
        {
            YumaPos.Shared.API.ResponseDtos.XReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetShiftReport",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetShiftReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.LookupListResponseDto> GetSystemSettings(System.String[] listOfSystemSettings)
        {
            YumaPos.Shared.API.ResponseDtos.LookupListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSystemSettings",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSystemSettings(listOfSystemSettings);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalResponseDto> GetTerminal(System.Guid terminalId)
        {
            YumaPos.Shared.API.ResponseDtos.TerminalResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminal",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetTerminal(terminalId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> GetTerminals()
        {
            YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminals",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetTerminals();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> GetTerminalsByStoreId(System.Guid storeId)
        {
            YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminalsByStoreId",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetTerminalsByStoreId(storeId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetXReport()
        {
            YumaPos.Shared.API.ResponseDtos.XReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetXReport",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetXReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsActiveOrdersUpdated(System.DateTime clientDateTime)
        {
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsActiveOrdersUpdated",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.IsActiveOrdersUpdated(clientDateTime);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsMenuUpdated(System.DateTime clientUtcDateTime)
        {
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsMenuUpdated",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.IsMenuUpdated(clientUtcDateTime);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> Logout()
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "Logout",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.Logout();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveCustomerAddress(System.Guid customerAddressId)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveCustomerAddress",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveCustomerAddress(customerAddressId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveRelatedModifierFromOrderItem(YumaPos.Shared.API.Models.OrderItemRelatedModifierDto relatedModifier)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveRelatedModifierFromOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveRelatedModifierFromOrderItem(relatedModifier);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SavePaymentTransaction(YumaPos.Shared.API.Models.InputTransactionInfoDto data)
        {
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> TryProcessPaymentTransaction(YumaPos.Shared.API.Models.RequestTransactionDto requestTransaction)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCommonModifierQuantityForOrderItem(YumaPos.Shared.API.Models.OrderItemCommonModifierDto modifier)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateCommonModifierQuantityForOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateCommonModifierQuantityForOrderItem(modifier);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCustomer(YumaPos.Shared.API.Models.CustomerDto customer)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateCustomer",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateCustomer(customer);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateDriverDetails(YumaPos.Shared.API.Models.Ordering.DriverDetailsDto driverDetails)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateDriverDetails",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateDriverDetails(driverDetails);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItemQuantity(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderStatusByOrderId(System.Guid orderId, Int32 statusId)
        {
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateRelatedModifierQuantityForOrderItem(System.Guid orderId, YumaPos.Shared.API.Models.OrderItemRelatedModifierDto modifier)
        {
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateRelatedModifierQuantityForOrderItem",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateRelatedModifierQuantityForOrderItem(orderId, modifier);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.MenuCacheResponseDto> GetTerminalCacheMenu()
        {
            YumaPos.Shared.API.ResponseDtos.MenuCacheResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminalCacheMenu",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetTerminalCacheMenu();
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