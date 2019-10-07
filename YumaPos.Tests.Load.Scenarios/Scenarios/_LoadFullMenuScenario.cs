using System.Linq;
using System.Threading.Tasks;
using YumaPos.Shared.Core.Cache;
using YumaPos.Shared.Core.MenuModels;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Shared.Terminal.Infrastructure.API.Models.Ordering;
using YumaPos.Tests.Load.Scenarios.Interfaces;
using YumaPos.Tests.Load.Scenarios.Models;

namespace YumaPos.Tests.Load.Scenarios
{
    public class LoadFullMenuScenario : IScenario {
        private TerminalContext _context;
        private ITerminalApi _terminalApi;

        public LoadFullMenuScenario(TerminalContext context,  ITerminalApi terminalApi)
        {
            _context = context;
            _terminalApi = terminalApi;
        }
        public async Task StartAsync()
        {
            _context.FullMenu = (await _terminalApi.GetMenus2(new MenuRequestDto())).Value.First();
            IMenuCacheModel menuCache = CacheTree.Map<MenuCacheModel, Availability, CommonModifier, Language, MenuCategory, MenuItem, ModifierGroup, RelatedModifier, MenuCategory2Availability, MenuItem2Availability, ModifierGroup2MenuItem>(_context.FullMenu);
            _context.TreeMenu = CacheTree.CreateTree(menuCache, "en");
        }

    }
}