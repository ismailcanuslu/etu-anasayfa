namespace ETUAnaSayfa.Models.Home;

public class Announcements
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public bool IsVisible { get; set; }

    public bool IsPinned { get; set; }

    public DateTime Date { get; set; }
}