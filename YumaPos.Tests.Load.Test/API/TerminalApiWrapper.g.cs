//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastucture.Dto;
using System.Diagnostics;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Client.API {
    public partial class TerminalApiWrapper
    {
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.MenuCacheResponseDto> GetTerminalCacheMenu()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.MenuCacheResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCashDrawerCheckItem(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.CashDrawerItemDto itemDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomer(YumaPos.Shared.API.Models.Ordering.CustomerDto customerDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomerAddress(YumaPos.Shared.API.Models.Ordering.CustomerAddressDto addressDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddOrdersToDriver(System.Guid driverId, System.Guid[] orderIds)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidResponseDto> AddTerminalToStore(YumaPos.Shared.API.Models.Ordering.TerminalDto terminalDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakeLoan(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.PickUpDto pickUpDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakePickUp(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.PickUpDto pickUpDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ClockOperation(YumaPos.Shared.API.Enums.UserActivityType operationType)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> EndShift(System.Decimal amount)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "EndShift",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.EndShift(amount);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto> GetActiveOrdersChangesDigest(System.DateTime timestamp)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto res = null;
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.CashDrawerInfoResponseDto> GetCashDrawerInfoTotal()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.CashDrawerInfoResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.CheckoutOptionListResponseDto> GetCheckoutOptionsByOrderType(YumaPos.Shared.API.Enums.OrderType orderType)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.CheckoutOptionListResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.CashDrawerItemResponseDto> GetCurrentCashierLastActivity()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.CashDrawerItemResponseDto res = null;
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.UserClockStateResponseDto> GetCurrentUserClockState()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.UserClockStateResponseDto res = null;
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DateTimeResponseDto> GetDateTimeActiveOrdersUpdated(System.DateTime clientDateTime)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.DateTimeResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDateTimeActiveOrdersUpdated",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDateTimeActiveOrdersUpdated(clientDateTime);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.DeliveryDetailsListResponseDto> GetDeliveryOrders(YumaPos.Shared.API.Models.Ordering.FilteredRequestDto filteredRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.DeliveryDetailsListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeliveryOrders",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDeliveryOrders(filteredRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DriverDetailsResponseDto> GetDriver(System.Guid driverId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.DriverDetailsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDriver",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDriver(driverId);
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersResponseResponseDto> GetFilteredCustomers(YumaPos.Shared.API.Models.Ordering.FilteredRequestDto model)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderListResponseDto> GetFilteredOrdersByIds(YumaPos.Shared.API.Models.Ordering.OrderFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.CashierShiftResponseDto> GetLastCashierShift()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.CashierShiftResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedActiveOrders(YumaPos.Shared.API.Models.Ordering.OrderFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.FilteredCashDrawerItemResponseDto> GetPagedCashDrawerItems(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.CashDrawerItemsFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.FilteredCashDrawerItemResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedClosedOrders(YumaPos.Shared.API.Models.Ordering.OrderFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.XReportResponseDto> GetReportById(System.Guid cashDrawerItemId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.XReportResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.LookupListResponseDto> GetSystemSettings(System.String[] listOfSystemSettings)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ImageResponseDto> GetTenantLogo()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ImageResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTenantLogo",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetTenantLogo();
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.XReportResponseDto> GetXReport()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.XReportResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsMenuNeedToUpdate(System.DateTime clientUtcDateTime)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.BoolResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsMenuNeedToUpdate",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.IsMenuNeedToUpdate(clientUtcDateTime);
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveCustomerAddress(System.Guid customerAddressId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> StartShift(System.Decimal initialAmount)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "StartShift",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.StartShift(initialAmount);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCustomer(YumaPos.Shared.API.Models.Ordering.CustomerDto customer)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderStatusMany(System.Guid[] orderIds, YumaPos.Shared.API.Enums.OrderStatus statusId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderStatusMany",
                Created = DateTime.UtcNow,
            };
			var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateOrderStatusMany(orderIds, statusId);
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