//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastructure.Dto;
using System.Diagnostics;
using System.Threading.Tasks;

namespace YumaPos.Tests.Load.Client.API {
    public partial class TerminalApiWrapper
    {
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddReservation(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReservationDto reservation)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddReservation",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.AddReservation(reservation);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> BeginJumioIdentityVerificationProcess(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.VerificationRequestDto verificationDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "BeginJumioIdentityVerificationProcess",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.BeginJumioIdentityVerificationProcess(verificationDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.EgaisIdCodeResponseDto> CheckEgaisIdCode(YumaPos.Shared.API.Models.Ordering.EgaisIdCodeDataDto code)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.EgaisIdCodeResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckEgaisIdCode",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CheckEgaisIdCode(code);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ClockOperation(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ClockOperationDto clockOperation)
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
                res = await _api.ClockOperation(clockOperation);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.BasicModeMenuItemResponseDto> CreateBasicModeMenuItem()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.BasicModeMenuItemResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CreateBasicModeMenuItem",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.CreateBasicModeMenuItem();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto> GetActiveOrdersChangesDigest(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ChangeDigestRequestDto changeDigestDto)
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
                res = await _api.GetActiveOrdersChangesDigest(changeDigestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalPromoCampaignListResponseDto> GetActualPromoCampaigns()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalPromoCampaignListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetActualPromoCampaigns",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetActualPromoCampaigns();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.SimpleCustomersListResponseDto> GetAllCustomers()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.SimpleCustomersListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllCustomers",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllCustomers();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalDeliveryZoneListResponseDto> GetAllDeliveryZones(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetAllDeliveryZonesRequestDto getAllDeliveryZonesRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalDeliveryZoneListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllDeliveryZones",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllDeliveryZones(getAllDeliveryZonesRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalDiscountListResponseDto> GetAllDiscounts(System.Guid storeId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.TerminalDiscountListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllDiscounts",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllDiscounts(storeId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalEmployeeListResponseDto> GetAllEmployees()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalEmployeeListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllEmployees",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllEmployees();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.LanguageListResponseDto> GetAllLanguages()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.LanguageListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllLanguages",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetAllLanguages();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreListResponseDto> GetAllStores()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreListResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.SimpleCustomersListResponseDto> GetChangedCustomers(YumaPos.Shared.API.Models.Ordering.SimpleCustomersRequestDto request)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.SimpleCustomersListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetChangedCustomers",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetChangedCustomers(request);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.ChangeReasonListResponseDto> GetChangeReasons(YumaPos.Shared.API.Enums.ChangeReasonSettings settings)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.ChangeReasonListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetChangeReasons",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetChangeReasons(settings);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalEmployeeResponseDto> GetCurrentEmployee()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalEmployeeResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreResponseDto> GetCurrentStore()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerResponseDto> GetCustomerByCardNo(System.String cardNo)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.CustomerResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomerByCardNo",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCustomerByCardNo(cardNo);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto> GetCustomersGroups()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomersGroups",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetCustomersGroups();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DateTimeResponseDto> GetDateTimeActiveOrdersUpdated(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetDateTimeActiveOrdersUpdatedDto getDateTimeActiveOrdersUpdatedDto)
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
                res = await _api.GetDateTimeActiveOrdersUpdated(getDateTimeActiveOrdersUpdatedDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.DeletedItemsByEmployeeReportResponseDto> GetDeletedItemsByEmployeeReport(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReportRequestDto reportRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.DeletedItemsByEmployeeReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeletedItemsByEmployeeReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDeletedItemsByEmployeeReport(reportRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.DeletedItemsReportResponseDto> GetDeletedItemsReport(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReportRequestDto reportRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.DeletedItemsReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeletedItemsReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDeletedItemsReport(reportRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderListResponseDto> GetDeliveryOrders(YumaPos.Shared.API.Models.Ordering.FilteredRequestDto filteredRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalOrderListResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DriverDetailsResponseDto> GetDriver(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetDriverDto getDriverDto)
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
                res = await _api.GetDriver(getDriverDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.DriveCostsReportResponseDto> GetDriverCostsReport()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.DriveCostsReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDriverCostsReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetDriverCostsReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.GetEventsResponseDto> GetEvents(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetEventsFilterDto eventsFilterDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.GetEventsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetEvents",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetEvents(eventsFilterDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalFloorPlanListResponseDto> GetFloorPlans(System.Guid storeId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalFloorPlanListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFloorPlans",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetFloorPlans(storeId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.DateTimeInfoResponseDto> GetLocalStoreDateTime()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.DateTimeInfoResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetLocalStoreDateTime",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetLocalStoreDateTime();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.MenuCacheListResponseDto> GetMenus(System.Guid[] storeIds)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.MenuCacheListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetMenus",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetMenus(storeIds);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.MenuCacheListResponseDto> GetMenus2(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.MenuRequestDto menuRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.MenuCacheListResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetMenus2",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetMenus2(menuRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.NullableDateTimeResponseDto> GetMenuUpdated()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.NullableDateTimeResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetMenuUpdated",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetMenuUpdated();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedActiveOrders(YumaPos.Shared.API.Models.Ordering.OrderFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.FilteredRestaurantOrdersResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedClosedOrders(YumaPos.Shared.API.Models.Ordering.OrderFilterDto filter)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.FilteredRestaurantOrdersResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.ReservationDetailsResponseDto> GetReservation(System.Guid reservationId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.ReservationDetailsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetReservation",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetReservation(reservationId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.ReservationsResponseDto> GetReservations(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.GetReservationsDto reservationsRequestDto)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.ReservationsResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetReservations",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetReservations(reservationsRequestDto);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.SalesByCategoryWithModifiersReportResponseDto> GetSalesByCategoryWithModifiersReport(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.SalesByCategoryWithModifiersReportRequestDto reportRequest)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.SalesByCategoryWithModifiersReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSalesByCategoryWithModifiersReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSalesByCategoryWithModifiersReport(reportRequest);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.SalesByEmployeeReportResponseDto> GetSalesByEmployeeReport()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.SalesByEmployeeReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSalesByEmployeeReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSalesByEmployeeReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.SalesByHoursReportResponseDto> GetSalesByHoursReport()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.SalesByHoursReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSalesByHoursReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSalesByHoursReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.SalesByMenuItemsReportResponseDto> GetSalesByMenuItemsReport(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReportRequestDto reportRequest)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.SalesByMenuItemsReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSalesByMenuItemsReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSalesByMenuItemsReport(reportRequest);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.SalesByEmployeeReportResponseDto> GetSalesByOrderCreatorReport()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.SalesByEmployeeReportResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSalesByOrderCreatorReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetSalesByOrderCreatorReport();
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreResponseDto> GetStoreByStoreId(System.Guid storeId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.TerminalStoreResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetStoreByStoreId",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.GetStoreByStoreId(storeId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.LookupListResponseDto> GetSystemSettings(System.String[] listOfSystemSettings, System.String code)
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
                res = await _api.GetSystemSettings(listOfSystemSettings, code);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.Models.ImageResponseDto> GetTenantLogo()
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.Models.ImageResponseDto res = null;
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> LogManualCustomerVerifications(YumaPos.Shared.API.Models.Ordering.CustomerManualVerificationsDto request)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "LogManualCustomerVerifications",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.LogManualCustomerVerifications(request);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveReservation(System.Guid reservationId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveReservation",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.RemoveReservation(reservationId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SavePaymentsenseData(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.PaymentsenseReportCollectionDto paymentsensReports)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SavePaymentsenseData",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SavePaymentsenseData(paymentsensReports);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SendReport(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReportForSendDto report)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SendReport",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SendReport(report);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.Terminal.API.ResponseDtos.EgaisIdCodeResponseDto> SetEgaisIdCodeShiftId(YumaPos.Shared.Terminal.Infrastructure.API.Models.Inventory.EgaisIdCodeDto code)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.Terminal.API.ResponseDtos.EgaisIdCodeResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SetEgaisIdCodeShiftId",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SetEgaisIdCodeShiftId(code);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SetStopMenuItem(System.Guid itemId, Boolean isStop, System.Nullable<System.Guid> storeId)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SetStopMenuItem",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.SetStopMenuItem(itemId, isStop, storeId);
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
    
        public async System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateReservation(YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering.ReservationDto reservation)
        {
            await Task.Delay((new Random().Next((int) MinInterval.TotalMilliseconds, (int) MaxInterval.TotalMilliseconds)));
            YumaPos.Shared.API.ResponseDtos.ResponseDto res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateReservation",
                Created = DateTime.UtcNow,
            };
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                res = await _api.UpdateReservation(reservation);
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