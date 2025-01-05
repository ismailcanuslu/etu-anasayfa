
using ETUAnaSayfa.Models.Home;
using ETUAnaSayfa.Repositories;

namespace ETUAnaSayfa.Services.Implementations;

public class HomeService : IHomeService
{
    private readonly IHomeRepository _homeRepository;
    
    public HomeService(IHomeRepository homeRepository)
    {
        _homeRepository = homeRepository;
    }

    public IQueryable<Events> GetLast5Events()
    {
        return _homeRepository.GetLast5Events();
    }

    public IQueryable<Events> GetPaginatedEvents(int pageNumber, int pageSize)
    {
        return _homeRepository.GetPaginatedEvents(pageNumber, pageSize);
    }

    public IQueryable<News> GetLast4News()
    {
        return _homeRepository.GetLast4News();
    }

    public IQueryable<News> GetPaginatedNews(int pageNumber, int pageSize)
    {
        return _homeRepository.GetPaginatedNews(pageNumber, pageSize);
    }
    
    public IQueryable<Announcements> GetPaginatedAnnouncements(int pageNumber, int pageSize)
    {
        return _homeRepository.GetPaginatedAnnouncements(pageNumber, pageSize);
    }

    public IQueryable<Videos> GetLast5Videos()
    {
        return _homeRepository.GetLast5Videos();
    }
}