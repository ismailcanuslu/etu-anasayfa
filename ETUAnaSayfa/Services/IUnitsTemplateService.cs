using ETUAnaSayfa.Models.Shared.UnitTemplate;

namespace ETUAnaSayfa.Services;

public interface IUnitsTemplateService
{
    public UnitMainPage GetUnitPageInfosFromUri(string uri);
    public IQueryable<UnitQuickAccess> GetUnitQuickAccessFromMainPageId(int Id);

    public IQueryable<UnitAnnouncements> GetUnitAnnouncementsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize);
    public IQueryable<UnitPublications> GetUnitPublicationsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize);

    public IQueryable<UnitMenus> GetUnitMenusAndSubMenusFromMainPageId(int Id);
    
    public UnitMainPage GetUnitMainPageInfosFromSlugUri(string slugUri);
}