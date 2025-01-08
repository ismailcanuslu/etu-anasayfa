namespace ETUAnaSayfa.Models.Shared.UnitTemplate;

public class UnitSubMenus
{
    public int Id { get; set; }
    public String Title { get; set; }
    public String? Text { get; set; }
    
    public String? Url { get; set; }
    
    public bool IsRedirect { get; set; }
    public String? Link { get; set; }
    public int UnitMenusId { get; set; }
    public UnitMenus UnitMenus { get; set; }
}