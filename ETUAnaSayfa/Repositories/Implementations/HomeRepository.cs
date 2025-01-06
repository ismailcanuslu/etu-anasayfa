
using ETUAnaSayfa.Models.Home;
using ETUAnaSayfa.Models.Shared;
using ETUAnaSayfa.Services;

namespace ETUAnaSayfa.Repositories.Implementations;

public class HomeRepository : IHomeRepository
{
    private readonly AppDbContext _context;
    public HomeRepository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<Events> GetLast5Events()
    {
        return _context.Events
            .Where(e => e.IsVisible) 
            .OrderByDescending(e => e.IsPinned) 
            .ThenByDescending(e => e.Date)
            .Take(5);
    }

    
    public IQueryable<Events> GetPaginatedEvents(int pageNumber, int pageSize)
    {
        return _context.Events
            .Where(e => e.IsVisible) 
            .OrderByDescending(e => e.IsPinned) 
            .ThenByDescending(e => e.Date) 
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize); 
    }

    public IQueryable<News> GetLast4News()
    {
        return _context.News
            .Where(e => e.IsVisible)
            .OrderByDescending(e => e.IsPinned)
            .ThenByDescending(e => e.Date)
            .Take(4)
            .Select(e => new News
            {
                Id = e.Id,
                Title = e.Title,
                CoverImgPath = e.CoverImgPath,
                Date = e.Date,
                IsPinned = e.IsPinned,
                IsVisible = e.IsVisible
            });;
    }

    public IQueryable<News> GetPaginatedNews(int pageNumber, int pageSize)
    {
        return _context.News
            .Where(e => e.IsVisible)
            .OrderByDescending(e => e.IsPinned)
            .ThenByDescending(e => e.Date)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
    }
    

    public IQueryable<Announcements> GetPaginatedAnnouncements(int pageNumber, int pageSize)
    {
        return _context.Announcements
            .Where(e => e.IsVisible)
            .OrderByDescending(e => e.IsPinned)
            .ThenByDescending(e => e.Date)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);
    }

    public IQueryable<Videos> GetLast5Videos()
    {
        return _context.Videos.
            OrderByDescending(e => e.ReleaseDate)
            .Take(5);
    }

    public IQueryable<Contact> GetContactData()
    {
        return _context.Contacts
            .Where(x => x.Id == 1);
    }
}