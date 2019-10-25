using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.API;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;

namespace YumaPos.Tests.Load.Scenarios
{
    public class EmployeeLoginScenario : IScenario
    {
        private readonly IOrderServiceApi _orderServiceApi;
        private readonly TerminalContext _context;
        private readonly IAuthorizationApi _authorizationApi;
        private readonly ITerminalApi _terminalApi;

        public EmployeeLoginScenario(IOrderServiceApi orderServiceApi, TerminalContext context, IAuthorizationApi authorizationApi, ITerminalApi terminalApi)
        {
            _orderServiceApi = orderServiceApi;
            _context = context;
            _authorizationApi = authorizationApi;
            _terminalApi = terminalApi;
        }

        public async Task StartAsync()
        {
            await LoginToTerminal();
            await ShiftStart();
            await ThenIAmAuthennticated();
        }

        #region Steps

        public async Task LoginToTerminal()
        {
            try
            {
                _context.EmployeeToken = await _authorizationApi.Login(_context.EmployeeLogin, _context.EmployeePassword);
                _terminalApi.SetUserToken(_context.EmployeeToken);
                _orderServiceApi.SetUserToken(_context.EmployeeToken);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                _context.EmployeeToken = "invalid password";
            }
            Debug.WriteLine("token: {0}", _context.EmployeeToken);
        }

        private async Task ShiftStart()
        {
            var lastActivity = await _terminalApi.GetCurrentCashierLastActivity();
            Assert.AreEqual(null, lastActivity.PostprocessingType);
            if (lastActivity.Value.Activity == CashDrawerActivity.ShiftStart)
            {
                var cashDrawerInfo = await _terminalApi.GetCashDrawerInfoTotal();
                Assert.AreEqual(null, cashDrawerInfo.PostprocessingType);

                var response3 = await _terminalApi.AddCashDrawerCheckItem(new CashDrawerItemDto()
                {
                    Id = Guid.NewGuid(),
                    Activity = CashDrawerActivity.CashierOut,
                    Amount = cashDrawerInfo.Value.CalculatedBalance,
                });
                Assert.AreEqual(null, response3.PostprocessingType);
                lastActivity.Value.Activity = CashDrawerActivity.CashierOut;
            }
            if (lastActivity.Value.Activity == CashDrawerActivity.CashierOut)
            {
                var cashDrawerInfo = await _terminalApi.GetCashDrawerInfoTotal();
                Assert.AreEqual(null, cashDrawerInfo.PostprocessingType);
                var response4 = await _terminalApi.EndShift(cashDrawerInfo.Value.CalculatedBalance);
                Assert.AreEqual(null, response4.PostprocessingType);
                lastActivity.Value.Activity = CashDrawerActivity.CashierOut;
            }
            if (lastActivity.Value.Activity == CashDrawerActivity.ShiftEnd)
            {
                var response5 = await _terminalApi.StartShift(0);
                Assert.AreEqual(null, response5.PostprocessingType);
                lastActivity.Value.Activity = CashDrawerActivity.ShiftStart;
            }
            if (lastActivity.Value.Activity == CashDrawerActivity.ShiftStart)
            {
                var response6 = await _terminalApi.AddCashDrawerCheckItem(new CashDrawerItemDto
                {
                    Activity = CashDrawerActivity.CashierIn,
                    Amount = 0,
                });
                Assert.AreEqual(null, response6.PostprocessingType);
            }
            lastActivity = await _terminalApi.GetCurrentCashierLastActivity();
            Assert.AreEqual(null, lastActivity.PostprocessingType);
            Assert.AreEqual(CashDrawerActivity.CashierIn, lastActivity.Value.Activity);
        }

        public async Task ThenIAmAuthennticated()
        {
            var empl = await _terminalApi.GetCurrentEmployee();
            //Assert.AreEqual("admin", empl.Value.Login);
            //Assert.AreEqual(1496, empl.Value.Id);
        }

        #endregion Steps

    }
}
