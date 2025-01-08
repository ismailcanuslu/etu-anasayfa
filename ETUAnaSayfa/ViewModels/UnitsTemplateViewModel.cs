using ETUAnaSayfa.Models.Shared.UnitTemplate;

namespace ETUAnaSayfa.ViewModels;

public class UnitsTemplateViewModel
{
    public UnitMainPage UnitMainPage { get; set; }
    public IQueryable<UnitQuickAccess> UnitQuickAccess { get; set; }
    public IQueryable<UnitAnnouncements> UnitAnnouncements { get; set; }
    public IQueryable<UnitPublications> UnitPublications { get; set; }
    public IQueryable<UnitMenus> UnitMenus { get; set; }
    
    public int CurrentPage { get; set; } = 1;
}