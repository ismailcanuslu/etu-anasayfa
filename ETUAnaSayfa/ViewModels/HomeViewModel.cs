using ETUAnaSayfa.Models.Home;

namespace ETUAnaSayfa.ViewModels;

public class HomeViewModel
{
    public IQueryable<Events> Events { get; set; }
    public IQueryable<News> News { get; set; }
    
    public IQueryable<Announcements> Announcements { get; set; }
    
    public IQueryable<Videos> Videos { get; set; }
    
    public int CurrentPage { get; set; } = 1;
}