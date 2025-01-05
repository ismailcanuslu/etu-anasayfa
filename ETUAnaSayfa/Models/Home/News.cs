namespace ETUAnaSayfa.Models.Home;

public class News
{
    public int Id { get; set; }
    public String Title { get; set; }
    public String Text { get; set; }
    
    public String CoverImgPath { get; set; }
    public DateTime Date { get; set; }
    
    public bool IsPinned { get; set; }
    public bool IsVisible { get; set; }
    
    public List<NewsImages> Images { get; set; } = new List<NewsImages>();
}