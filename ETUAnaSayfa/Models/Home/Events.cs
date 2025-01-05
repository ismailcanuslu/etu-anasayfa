
namespace ETUAnaSayfa.Models.Home;

public class Events
{
    public int Id { get; set; }
    public String Title { get; set; }
    
    public String ImgPath { get; set; }
    public DateTime Date { get; set; }
    public String Location { get; set; }
    public bool IsPinned { get; set; }
    public bool IsVisible { get; set; }
}