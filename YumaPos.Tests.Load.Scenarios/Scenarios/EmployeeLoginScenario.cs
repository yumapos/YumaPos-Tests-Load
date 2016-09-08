using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Shared.API;
using YumaPos.Shared.Infrastructure;

namespace YumaPos.Tests.Load.Scenarios
{
    public class EmployeeLoginScenario : IScenario
    {
        private readonly TerminalContext _context;
        private readonly IAuthorizationApi _authorizationApi;
        private readonly ITerminalApi _terminalApi;

        public EmployeeLoginScenario(TerminalContext context, IAuthorizationApi authorizationApi, ITerminalApi terminalApi)
        {
            _context = context;
            _authorizationApi = authorizationApi;
            _terminalApi = terminalApi;
        }

        public async Task StartAsync()
        {
            await WhenILoginToTerminal();
            await ThenIAmAuthennticated();
        }

        #region Steps

        public async Task WhenILoginToTerminal()
        {
            try
            {
                _context.EmployeeToken = await _authorizationApi.Login(_context.EmployeeLogin, _context.EmployeePassword);
                _terminalApi.SetUserToken(_context.EmployeeToken);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                _context.EmployeeToken = "invalid password";
            }
            Debug.WriteLine("token: {0}", _context.EmployeeToken);
        }

        public async Task ThenIAmAuthennticated()
        {
            var empl = await _terminalApi.GetCurrentEmployee();
            Assert.AreEqual("admin", empl.Value.Login);
            Assert.AreEqual(1496, empl.Value.Id);
        }

        #endregion Steps

    }
}
