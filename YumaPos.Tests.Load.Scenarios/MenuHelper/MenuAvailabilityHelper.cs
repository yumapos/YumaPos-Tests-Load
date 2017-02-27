using System;
using System.Collections.Generic;
using System.Linq;
using YumaPos.Shared.API.Models.Ordering;
using YumaPos.Shared.Core.MenuModels;
using YumaPos.Shared.Core.Utils.Availability;

namespace YumaPos.Tests.Load.Scenarios.MenuHelper
{
    internal sealed class MenuAvailabilityHelper : IMenuAvailabilityHelper
    {
        private readonly TerminalContext _context;

        public MenuAvailabilityHelper(TerminalContext context)
        {
            _context = context;
        }

        public IReadOnlyCollection<IMenuItem> GetAvailableMenuItems()
        {
            var menuItems = _context.TreeMenu.MenuItems.Select(a => a.Value);

            return menuItems.Where(menuItem =>
                menuItem.Availabilities.Any() &&
                CheckingAvailability.Check(menuItem.Availabilities.Select(Map), DateTime.Now) &&
                menuItem.Price > 0
                ).ToList();
        }

        private static AvailabilityDto Map(IAvailability availability)
        {
            return new AvailabilityDto
            {
                AvailabilityId = availability.AvailabilityId,
                Days = availability.Days,
                IsChecked = availability.IsChecked,
                TimeFrom = availability.DaySecondsFrom,
                TimeTo = availability.DaySecondsTo
            };
        }
    }
}