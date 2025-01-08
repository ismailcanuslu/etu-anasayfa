using ETUAnaSayfa.Extensions;
using ETUAnaSayfa.Models.Shared;
using ETUAnaSayfa.Models.Shared.UnitTemplate;
using Microsoft.EntityFrameworkCore;

namespace ETUAnaSayfa.Repositories.Implementations;

public class UnitsTemplateRepository : IUnitsTemplateRepository
{
    private readonly AppDbContext _context;
    public UnitsTemplateRepository(AppDbContext context)
    {
        _context = context;
    }
    public UnitMainPage GetUnitPageInfosFromUri(string uri)
    {
        return _context.UnitMainPage.FirstOrDefault(x => x.Subpath == uri);
    }

    public IQueryable<UnitQuickAccess>? GetUnitQuickAccessFromMainPageId(int Id)
    {
        return _context.UnitQuickAccess
            .Where(x => x.UnitMainPage.Id == Id);
    }

    public IQueryable<UnitAnnouncements> GetUnitAnnouncementsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize)
    {
        return _context.UnitAnnouncements
            .Where(x => x.UnitMainPage.Id == Id)
            .Where(x => x.IsVisible)
            .OrderByDescending(e => e.IsPinned)
            .ThenByDescending(e => e.Date)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
    }

    public IQueryable<UnitPublications> GetUnitPublicationsFromMainPageIdWithPagination(int Id, int pageNumber, int pageSize)
    {
        return _context.UnitPublications
            .Where(x => x.UnitMainPage.Id == Id)
            .Where(x => x.IsVisible)
            .OrderByDescending(e => e.IsPinned)
            .ThenByDescending(e => e.Date)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
    }

    public IQueryable<UnitMenus> GetUnitMenusAndSubMenusFromMainPageId(int Id)
    {
        return _context.UnitMenus
            .Where(x => x.UnitMainPage.Id == Id)
            .Include(x => x.SubMenus);
    }

    public UnitMainPage GetUnitMainPageInfosFromSlugUri(string slugUri)
    {
        return _context.UnitMainPage.FirstOrDefault(x => x.Title.ToSlug() == slugUri);
    }
}