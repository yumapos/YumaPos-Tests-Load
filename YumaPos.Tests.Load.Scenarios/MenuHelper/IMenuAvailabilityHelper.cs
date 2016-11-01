using System.Collections.Generic;
using YumaPos.Shared.Core.MenuModels;

namespace YumaPos.Tests.Load.Scenarios.MenuHelper
{
    internal interface IMenuAvailabilityHelper
    {
        IReadOnlyCollection<IMenuItem> GetAvailableMenuItems();
    }
}