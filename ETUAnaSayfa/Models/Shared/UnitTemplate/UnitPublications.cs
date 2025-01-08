namespace ETUAnaSayfa.Models.Shared.UnitTemplate;

public class UnitPublications
{
    public int Id { get; set; }
    
    public string Title { get; set; }

    public string? Text { get; set; }
    
    public string? Link { get; set; }
    
    public bool IsRedirect { get; set; }

    public bool IsVisible { get; set; }

    public bool IsPinned { get; set; }

    public DateTime Date { get; set; }
    
    public int UnitMainPageId { get; set; }
    public UnitMainPage UnitMainPage { get; set; }
}