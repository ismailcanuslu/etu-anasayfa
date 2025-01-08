using ETUAnaSayfa.Models.Shared.UnitTemplate;
using ETUAnaSayfa.Repositories;

namespace ETUAnaSayfa.Services.Implementations;

public class UnitsTemplateService : IUnitsTemplateService
{
    private readonly IUnitsTemplateRepository _unitsTemplateRepository;
    public UnitsTemplateService(IUnitsTemplateRepository unitsTemplateRepository)
    {
        _unitsTemplateRepository = unitsTemplateRepository;
    }
    public UnitMainPage GetUnitPageInfosFromUri(string uri)
    {
        return _unitsTemplateRepository.GetUnitPageInfosFromUri(uri);
    }

    public IQueryable<UnitQuickAccess> GetUnitQuickAccessFromMainPageId(int Id)
    {
        return _unitsTemplateRepository.GetUnitQuickAccessFromMainPageId(Id);
    }

    public IQueryable<UnitAnnouncements> GetUnitAnnouncementsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize)
    {
        return _unitsTemplateRepository.GetUnitAnnouncementsFromMainPageIdWithPagination(Id, pageNumber, pageSize);
    }

    public IQueryable<UnitPublications> GetUnitPublicationsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize)
    {
        return _unitsTemplateRepository.GetUnitPublicationsFromMainPageIdWithPagination(Id, pageNumber, pageSize);
    }

    public IQueryable<UnitMenus> GetUnitMenusAndSubMenusFromMainPageId(int Id)
    {
        return _unitsTemplateRepository.GetUnitMenusAndSubMenusFromMainPageId(Id);
    }

    public UnitMainPage GetUnitMainPageInfosFromSlugUri(string slugUri)
    {
        return _unitsTemplateRepository.GetUnitMainPageInfosFromSlugUri(slugUri);
    }
}