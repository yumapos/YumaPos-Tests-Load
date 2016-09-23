using System;
using System.Threading.Tasks;
using YumaPos.Shared.API;
using YumaPos.Shared.Infrastructure;
using YumaPos.Tests.Load.Scenarios.Interfaces;

namespace YumaPos.Tests.Load.Scenarios
{
    public class SimpleOrderScenario : IScenario
    {
        private TerminalContext _context;
        private ITerminalApi _terminalApi;

        public SimpleOrderScenario(TerminalContext context, ITerminalApi terminalApi)
        {
            _context = context;
            _terminalApi = terminalApi;
        }
        public Task StartAsync()
        {
            throw new NotImplementedException();
        }

    }
}