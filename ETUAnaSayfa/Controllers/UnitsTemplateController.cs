using ETUAnaSayfa.Extensions;
using ETUAnaSayfa.Services;
using ETUAnaSayfa.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ETUAnaSayfa.Controllers;

public class UnitsTemplateController : Controller
{
    private readonly IUnitsTemplateService _unitsTemplateService;
    public UnitsTemplateController(IUnitsTemplateService unitsTemplateService)
    {
        _unitsTemplateService = unitsTemplateService;
    }

    [HttpGet]
    public IActionResult UnitsTemplate(string uri)
    {
        if (string.IsNullOrEmpty(uri))
        {
            return NotFound();
        }

        var unitPage = _unitsTemplateService.GetUnitPageInfosFromUri(uri);
        if (unitPage == null)
        {
            return NotFound();
        }

        var unitQuickAccess = _unitsTemplateService.GetUnitQuickAccessFromMainPageId(unitPage.Id);
        var unitAccouncements = _unitsTemplateService.GetUnitAnnouncementsFromMainPageIdWithPagination(unitPage.Id, 1, 1);
        var unitPublications = _unitsTemplateService.GetUnitPublicationsFromMainPageIdWithPagination(unitPage.Id, 1, 1);
        var unitMenus = _unitsTemplateService.GetUnitMenusAndSubMenusFromMainPageId(unitPage.Id);

        var model = new UnitsTemplateViewModel
        {
            UnitMainPage = unitPage,
            UnitQuickAccess = unitQuickAccess,
            CurrentPage = 1,
            UnitAnnouncements = unitAccouncements,
            UnitPublications = unitPublications,
            UnitMenus = unitMenus,
        };
        return View(model);
    }

    //TO-DO Sayfalama yapısı HttpGET ile hazırlanmalıdır.

    [HttpGet]
    public IActionResult UnitsSubMenuTemplate(string mainPath, string menuPath, string subMenuPath)
    {
        
        var unitPage = _unitsTemplateService.GetUnitMainPageInfosFromSlugUri(mainPath);
        
        var menus = _unitsTemplateService.GetUnitMenusAndSubMenusFromMainPageId(unitPage.Id);
        
        var menu = menus.FirstOrDefault(m => m.Title.ToSlug() == menuPath);
        
        var subMenu = menu.SubMenus.FirstOrDefault(s => s.Title.ToSlug() == subMenuPath);
   
        var model = new UnitsSubMenuTemplateViewModel
        {
            UnitMainPage = unitPage,
            UnitMenu = menu,
            UnitSubMenu = subMenu
        };

        return View(model);
    }
}