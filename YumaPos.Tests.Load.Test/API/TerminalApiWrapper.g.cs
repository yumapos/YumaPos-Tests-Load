//This file generated Automaticaly
using System;
using YumaPos.Tests.Load.Infrastucture.Dto;


namespace YumaPos.Tests.Load.Client.API {
    public partial class TerminalApiWrapper : YumaPos.Shared.Infrastructure.ITerminalApi
    {
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrder(YumaPos.Shared.API.Models.RestaurantOrderDto orderDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateOrder(orderDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderCustomer(System.Guid orderId, System.Guid customerId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderCustomer",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateOrderCustomer(orderId, customerId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderItemQuantity(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderItemQuantity",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateOrderItemQuantity(item);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderNote(System.Guid orderId, System.String note)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderNote",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateOrderNote(orderId, note);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateOrderStatusByOrderId(System.Guid orderId, Int32 statusId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateOrderStatusByOrderId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateOrderStatusByOrderId(orderId, statusId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateProfile(YumaPos.Shared.API.Models.EmployeeDto model)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateProfile",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateProfile(model);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdatePushToken(YumaPos.Shared.API.Enums.PushType pushType, System.String pushToken)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdatePushToken",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdatePushToken(pushType, pushToken);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateRelatedModifierQuantityForOrderItem(System.Guid orderId, YumaPos.Shared.API.Models.OrderItemRelatedModifierDto modifier)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateRelatedModifierQuantityForOrderItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateRelatedModifierQuantityForOrderItem(orderId, modifier);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> UpdateSplittingsForOrderId(System.Guid orderId, YumaPos.Shared.API.Enums.SplittingType splittingType, System.String[] parameters)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateSplittingsForOrderId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateSplittingsForOrderId(orderId, splittingType, parameters);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateTaxExempt(System.Guid orderId, Int32 splittingNumber, Boolean isTaxExempt)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateTaxExempt",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateTaxExempt(orderId, splittingNumber, isTaxExempt);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateTerminal(YumaPos.Shared.API.Models.TerminalDto terminal)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateTerminal",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateTerminal(terminal);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.MenuCacheResponseDto> GetTerminalCacheMenu()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.MenuCacheResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminalCacheMenu",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetTerminalCacheMenu();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCashDrawerCheckItem(YumaPos.Shared.API.Models.CashDrawerItemDto itemDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCashDrawerCheckItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddCashDrawerCheckItem(itemDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomer(YumaPos.Shared.API.Models.CustomerDto customerDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCustomer",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddCustomer(customerDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddCustomerAddress(YumaPos.Shared.API.Models.CustomerAddressDto addressDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCustomerAddress",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddCustomerAddress(addressDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.IntResponseDto> AddCustomersGroup(YumaPos.Shared.API.Models.CustomerGroupDto customerGroup)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.IntResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddCustomersGroup",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddCustomersGroup(customerGroup);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDeliveryOrder(YumaPos.Shared.API.Models.Ordering.DeliveryDto deliveryDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDeliveryOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddDeliveryOrder(deliveryDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDiscountToOrder(System.Guid orderId, System.Guid discountId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDiscountToOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddDiscountToOrder(orderId, discountId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddDiscountToSplitting(System.Guid orderId, Int32 splittingNumber, System.Nullable<System.Guid> discountId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddDiscountToSplitting",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddDiscountToSplitting(orderId, splittingNumber, discountId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> AddGiftCardToOrder(YumaPos.Shared.API.Models.GiftCardOrderItemDto item)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddGiftCardToOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddGiftCardToOrder(item);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderResponseDto> AddOrder(System.Guid orderId, YumaPos.Shared.API.Enums.OrderType orderType)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddOrder(orderId, orderType);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> AddOrderItem(YumaPos.Shared.API.Models.RestaurantOrderItemDto item)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddOrderItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddOrderItem(item);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> AddRelatedModifierToOrderItem(System.Guid orderId, YumaPos.Shared.API.Models.OrderItemRelatedModifierDto relatedModifier)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddRelatedModifierToOrderItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddRelatedModifierToOrderItem(orderId, relatedModifier);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidResponseDto> AddTerminalToStore(YumaPos.Shared.API.Models.TerminalDto terminalDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "AddTerminalToStore",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.AddTerminalToStore(terminalDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakeLoan(YumaPos.Shared.API.Models.PickUpDto pickUpDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CashDrawerMakeLoan",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CashDrawerMakeLoan(pickUpDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CashDrawerMakePickUp(YumaPos.Shared.API.Models.PickUpDto pickUpDto)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CashDrawerMakePickUp",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CashDrawerMakePickUp(pickUpDto);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ChangePassword(YumaPos.Shared.API.Models.ChangePasswordDto model)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "ChangePassword",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.ChangePassword(model);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> CheckEmployeePin(Int32 pin)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckEmployeePin",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CheckEmployeePin(pin);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DecimalResponseDto> CheckGiftCardBalance(System.String cardNumber)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DecimalResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckGiftCardBalance",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CheckGiftCardBalance(cardNumber);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CheckIn(System.String cardNo)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckIn",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CheckIn(cardNo);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> CheckOut(System.String cardNo)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "CheckOut",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.CheckOut(cardNo);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> ClockOperation(YumaPos.Shared.API.Enums.UserActivityType operationType)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "ClockOperation",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.ClockOperation(operationType);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> GetActiveOrders()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetActiveOrders",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetActiveOrders();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto> GetActiveOrdersChangesDigest(System.DateTime timestamp)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ActiveOrdersChangesDigestResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetActiveOrdersChangesDigest",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetActiveOrdersChangesDigest(timestamp);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetActiveOrdersRange(YumaPos.Shared.API.Models.ActiveOrdersFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetActiveOrdersRange",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetActiveOrdersRange(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto> GetAllCustomersGroups()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllCustomersGroups",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetAllCustomersGroups();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DiscountListResponseDto> GetAllDiscounts()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DiscountListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllDiscounts",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetAllDiscounts();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GiftCardTypeListResponseDto> GetAllGiftCardTypes()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GiftCardTypeListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllGiftCardTypes",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetAllGiftCardTypes();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreListResponseDto> GetAllStores()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetAllStores",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetAllStores();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerInfoResponseDto> GetCashDrawerInfoTotal()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerInfoResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCashDrawerInfoTotal",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCashDrawerInfoTotal();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerItemListResponseDto> GetCashDrawerItems(YumaPos.Shared.API.Models.CashDrawerItemsFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerItemListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCashDrawerItems",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCashDrawerItems(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CheckoutOptionListResponseDto> GetCheckoutOptionsByOrderType(YumaPos.Shared.API.Enums.OrderType orderType)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CheckoutOptionListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCheckoutOptionsByOrderType",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCheckoutOptionsByOrderType(orderType);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerItemResponseDto> GetCurrentCashierLastActivity()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashDrawerItemResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentCashierLastActivity",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCurrentCashierLastActivity();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto> GetCurrentEmployee()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentEmployee",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCurrentEmployee();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreResponseDto> GetCurrentStore()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.StoreResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentStore",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCurrentStore();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.UserClockStateResponseDto> GetCurrentUserClockState()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.UserClockStateResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCurrentUserClockState",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCurrentUserClockState();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerResponseDto> GetCustomer(System.Guid customerId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomer",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCustomer(customerId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerAddressListResponseDto> GetCustomerAddresses(System.Guid customerId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerAddressListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomerAddresses",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCustomerAddresses(customerId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> GetCustomersByGroup(Int32 groupId, Int32 pageNum, Int32 pageSize)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomersByGroup",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCustomersByGroup(groupId, pageNum, pageSize);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> GetCustomersFiltered(YumaPos.Shared.API.Models.CustomerFilterDto filters)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetCustomersFiltered",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetCustomersFiltered(filters);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<System.Byte[]> GetDefaultImage(YumaPos.Shared.API.Enums.ImageSizeType imageSizeType)
        {
            System.Threading.Tasks.Task<System.Byte[]> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDefaultImage",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetDefaultImage(imageSizeType);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DelvieryDetailsResponseDto> GetDeliveryInfo(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.DelvieryDetailsResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetDeliveryInfo",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetDeliveryInfo(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersResponseResponseDto> GetFilteredCustomers(YumaPos.Shared.API.Models.FilteredRequestDto model)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersResponseResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredCustomers",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetFilteredCustomers(model);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersOrdersResponseResponseDto> GetFilteredCustomersOrders(YumaPos.Shared.API.Models.FilteredRequestDto model)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCustomersOrdersResponseResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredCustomersOrders",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetFilteredCustomersOrders(model);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomersSummaryResponseDto> GetFilteredCustomersSummary(YumaPos.Shared.API.Models.FilteredRequestFilterDto[] model)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomersSummaryResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredCustomersSummary",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetFilteredCustomersSummary(model);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> GetFilteredOrdersByIds(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetFilteredOrdersByIds",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetFilteredOrdersByIds(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto> GetGroupsWithCustomerAmount()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerGroupListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetGroupsWithCustomerAmount",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetGroupsWithCustomerAmount();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashierShiftResponseDto> GetLastCashierShift()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CashierShiftResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetLastCashierShift",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetLastCashierShift();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderResponseDto> GetOrderById(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalOrderResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderById",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderById(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodListResponseDto> GetOrderFoodItemsByOrderId(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderFoodItemsByOrderId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderFoodItemsByOrderId(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderItemListResponseDto> GetOrderItemsByOrderId(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderItemListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderItemsByOrderId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderItemsByOrderId(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidDecimalDictonaryResponseDto> GetOrderItemsCosts(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.GuidDecimalDictonaryResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderItemsCosts",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderItemsCosts(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderMakerResponseDto> GetOrderMaker(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderMakerResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderMaker",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderMaker(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptListResponseDto> GetOrderReceiptsByOrderId(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderReceiptsByOrderId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderReceiptsByOrderId(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> GetOrdersByIds(System.Guid[] ids)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrdersByIds",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrdersByIds(ids);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderStatusListResponseDto> GetOrderStatuses()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderStatusListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderStatuses",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderStatuses();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderTypeListResponseDto> GetOrderTypes()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderTypeListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetOrderTypes",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetOrderTypes();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedActiveOrders(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedActiveOrders",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetPagedActiveOrders(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCashDrawerItemResponseDto> GetPagedCashDrawerItems(YumaPos.Shared.API.Models.CashDrawerItemsFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredCashDrawerItemResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedCashDrawerItems",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetPagedCashDrawerItems(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> GetPagedClosedOrders(YumaPos.Shared.API.Models.OrderFilterDto filter)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.FilteredRestaurantOrdersResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetPagedClosedOrders",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetPagedClosedOrders(filter);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto> GetProfile()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.EmployeeResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetProfile",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetProfile();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptResponseDto> GetReceiptByTransactionId(System.Guid transactionId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.RestaurantOrderReceiptResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetReceiptByTransactionId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetReceiptByTransactionId(transactionId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetReportById(System.Guid cashDrawerItemId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetReportById",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetReportById(cashDrawerItemId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetShiftReport()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetShiftReport",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetShiftReport();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.LookupListResponseDto> GetSystemSettings(System.String[] listOfSystemSettings)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.LookupListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetSystemSettings",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetSystemSettings(listOfSystemSettings);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalResponseDto> GetTerminal(System.Guid terminalId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminal",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetTerminal(terminalId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> GetTerminals()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminals",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetTerminals();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> GetTerminalsByStoreId(System.Guid storeId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.TerminalListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetTerminalsByStoreId",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetTerminalsByStoreId(storeId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> GetWebCustomers(Int32 pageNum, Int32 pageSize)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.CustomerListResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetWebCustomers",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetWebCustomers(pageNum, pageSize);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> GetXReport()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.XReportResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "GetXReport",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.GetXReport();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsActiveOrdersUpdated(System.DateTime clientDateTime)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsActiveOrdersUpdated",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.IsActiveOrdersUpdated(clientDateTime);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> IsMenuUpdated(System.DateTime clientUtcDateTime)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.BoolResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "IsMenuUpdated",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.IsMenuUpdated(clientUtcDateTime);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> Logout()
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "Logout",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.Logout();
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> MarkActiveOrdersAsRead(System.Guid[] ids)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "MarkActiveOrdersAsRead",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.MarkActiveOrdersAsRead(ids);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> OverrideLogin(System.String password, Int32 feature)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "OverrideLogin",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.OverrideLogin(password, feature);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> PaymentTransaction(YumaPos.Shared.API.Models.RequestTransactionDto requestTransaction)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "PaymentTransaction",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.PaymentTransaction(requestTransaction);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> RefillGiftCard(YumaPos.Shared.API.Models.GiftCardOrderItemDto item, System.Decimal amount)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.OrderFoodResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RefillGiftCard",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RefillGiftCard(item, amount);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveAllDiscountsFromOrder(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveAllDiscountsFromOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RemoveAllDiscountsFromOrder(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveCustomerAddress(System.Guid customerAddressId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveCustomerAddress",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RemoveCustomerAddress(customerAddressId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveOrderFromDelivery(System.Guid orderId)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveOrderFromDelivery",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RemoveOrderFromDelivery(orderId);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveProductFromOrder(YumaPos.Shared.API.Models.RestaurantOrderItemDto orderItem)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveProductFromOrder",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RemoveProductFromOrder(orderItem);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> RemoveRelatedModifierFromOrderItem(YumaPos.Shared.API.Models.OrderItemRelatedModifierDto relatedModifier)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "RemoveRelatedModifierFromOrderItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.RemoveRelatedModifierFromOrderItem(relatedModifier);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SavePaymentTransaction(YumaPos.Shared.API.Models.InputTransactionInfoDto data)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SavePaymentTransaction",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.SavePaymentTransaction(data);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> SendReceipt(System.Guid orderId, System.String email)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "SendReceipt",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.SendReceipt(orderId, email);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> TryProcessPaymentTransaction(YumaPos.Shared.API.Models.RequestTransactionDto requestTransaction)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "TryProcessPaymentTransaction",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.TryProcessPaymentTransaction(requestTransaction);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCommonModifierQuantityForOrderItem(YumaPos.Shared.API.Models.OrderItemCommonModifierDto modifier)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateCommonModifierQuantityForOrderItem",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateCommonModifierQuantityForOrderItem(modifier);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
        public System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> UpdateCustomer(YumaPos.Shared.API.Models.CustomerDto customer)
        {
            System.Threading.Tasks.Task<YumaPos.Shared.API.ResponseDtos.ResponseDto> res = null;
            var reportItem = new ReportItem()
            {
                MethodName = "UpdateCustomer",
                Created = DateTime.UtcNow,
            };
            _stopwatch.Start();
            try
            {
                res = _api.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    ex = ((AggregateException) ex).Flatten();
                }
                reportItem.ExceptionMessage = ex.Message;
            }
            finally
            {
                _stopwatch.Stop();
                reportItem.Duration = _stopwatch.Elapsed;
                _reportItems.Add(reportItem);
            }
            return res;
            
        }
    
    }
}