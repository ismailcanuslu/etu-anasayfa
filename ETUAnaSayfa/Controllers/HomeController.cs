using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ETUAnaSayfa.Models;
using ETUAnaSayfa.Services;
using ETUAnaSayfa.ViewModels;

namespace ETUAnaSayfa.Controllers;

public class HomeController : Controller
{

    private readonly IHomeService _homeService;
    public HomeController(IHomeService homeService)
    {
        _homeService = homeService;
    }

    public IActionResult Index()
    {
        var events = _homeService.GetLast5Events();
        var news = _homeService.GetLast4News();
        var announcements = _homeService.GetPaginatedAnnouncements(1, 3);
        var videos = _homeService.GetLast5Videos();

        var model = new HomeViewModel()
        {
            Events = events,
            News = news,
            Announcements = announcements,
            CurrentPage = 1,
            Videos = videos
        };

        return View(model);
    }

    [HttpGet]
    public IActionResult GetPaginatedAnnouncements(int pageNumber = 1, int pageSize = 3)
    {
        var announcements = _homeService.GetPaginatedAnnouncements(pageNumber, pageSize);

        var viewModel = new HomeViewModel
        {
            Announcements = announcements
        };

        return PartialView("_AnnouncementsListPartial", viewModel);
    }

    [HttpGet]
    public IActionResult Contact()
    {
        var contactInformation = _homeService.GetContactData();
        
        return View("Contact", contactInformation);
    }

}