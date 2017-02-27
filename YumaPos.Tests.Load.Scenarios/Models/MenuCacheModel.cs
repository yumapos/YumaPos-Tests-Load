using System;
using System.Collections.Generic;
using YumaPos.Shared.API.Enums;
using YumaPos.Shared.Core.MenuModels;

namespace YumaPos.Tests.Load.Scenarios.Models
{
    public class MenuCacheModel : IMenuCacheModel
    {
        public Dictionary<Guid, IMenuCategory> MenuCategories { get; set; }
        public Dictionary<Guid, IAvailability> Availabilities { get; set; }
        public Dictionary<Guid, IMenuItem> MenuItems { get; set; }
        public Dictionary<string, Dictionary<Guid, ILanguage>> Language { get; set; }
        public Dictionary<Guid, IModifierGroup> ModifierGroups { get; set; }
        public Dictionary<Guid, ICommonModifier> CommonModifiers { get; set; }
        public Dictionary<Guid, IRelatedModifier> RelatedModifiers { get; set; }
        public Dictionary<Guid, IEnumerable<Guid>> MenuItemImages { get; set; }
        public ICollection<IModifierGroup2MenuItem> ModifierGroup2MenuItems { get; set; }
        public ICollection<IMenuCategory2Availability> MenuCategory2Availabilities { get; set; }
        public ICollection<IMenuItem2Availability> MenuItem2Availabilities { get; set; } 
    }

    public class MenuCategory : IMenuCategory
    {
        public Guid CategoryId { get; set; }
        public Guid? ImageId { get; set; }
        public List<IMenuItem> MenuItems { get; set; }
        public List<ILanguage> Languages { get; set; }
        public List<IAvailability> Availabilities { get; set; }
    }

    public class Availability : IAvailability
    {
        public Guid AvailabilityId { get; set; }
        public DayWeek Days { get; set; }
        public int DaySecondsFrom { get; set; }
        public int DaySecondsTo { get; set; }
        public bool IsChecked { get; set; }
    }

    public class MenuItem : IMenuItem
    {
        public decimal Price { get; set; }
        public Guid? Image { get; set; }
        public int? DisplayOrder { get; set; }
        public List<ILanguage> Language { get; set; }
        public Guid MenuItemId { get; set; }
        public Guid CategoryId { get; set; }
        public List<IModifierGroup> ModifierGroups { get; set; }
        public List<IRelatedModifier> RelatedModifiers { get; set; }
        public List<IAvailability> Availabilities { get; set; }
        public List<Guid> Images { get; set; }
    }

    public class Language : ILanguage
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LanguageCode { get; set; }
    }

    public class ModifierGroup : IModifierGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ImageId { get; set; }
        public int? DisplayOrder { get; set; }
        public List<ICommonModifier> CommonModifiers { get; set; }
        public List<ILanguage> Languages { get; set; }
    }

    public class CommonModifier : ICommonModifier
    {
        public decimal Price { get; set; }
        public Guid? Image { get; set; }
        public int? DisplayOrder { get; set; }
        public List<ILanguage> Language { get; set; }
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public int? MaxNumberSelections { get; set; }
    }

    public class RelatedModifier : IRelatedModifier
    {
        public decimal Price { get; set; }
        public Guid? Image { get; set; }
        public int? DisplayOrder { get; set; }
        public List<ILanguage> Language { get; set; }
        public Guid Id { get; set; }
        public Guid MenuItemId { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsRequired { get; set; }
        public int MaxQuantity { get; set; }
        public int ViewNumber { get; set; }
        public bool NoChoice { get; set; }
        public int? GroupMaxQuantity { get; set; }
        public Guid GroupId { get; set; }
        public List<IRelatedModifier> Modifiers { get; set; }
    }

    public class ModifierGroup2MenuItem : IModifierGroup2MenuItem
    {
        public Guid ModifierGroupId { get; set; }
        public Guid MenuItemId { get; set; }
    }

    public class MenuCategory2Availability : IMenuCategory2Availability
    {
        public Guid MenuCategoryId { get; set; }
        public Guid AvailabilityId { get; set; }
    }

    public class MenuItem2Availability : IMenuItem2Availability
    {
        public Guid MenuItemId { get; set; }
        public Guid AvailabilityId { get; set; }
    }
}