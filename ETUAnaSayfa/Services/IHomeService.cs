using ETUAnaSayfa.Models.Home;

namespace ETUAnaSayfa.Services;

public interface IHomeService
{
    IQueryable<Events> GetLast5Events();
    IQueryable<Events> GetPaginatedEvents(int pageNumber, int pageSize);
    
    IQueryable<News> GetLast4News();
    
    IQueryable<News> GetPaginatedNews(int pageNumber, int pageSize);
    
    IQueryable<Announcements> GetPaginatedAnnouncements(int pageNumber, int pageSize);
    
    IQueryable<Videos> GetLast5Videos();

    IQueryable<Contact> GetContactData();
}