using System;
using System.Diagnostics;
using System.Threading.Tasks;
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
            await _terminalApi.StartShift(0);
            await _terminalApi.AddCashDrawerCheckItem(new CashDrawerItemDto
            {
                Activity = CashDrawerActivity.CashierIn,
                Amount = 0,
            });
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
