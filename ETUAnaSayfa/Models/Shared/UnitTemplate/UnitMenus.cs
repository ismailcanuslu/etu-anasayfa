namespace ETUAnaSayfa.Models.Shared.UnitTemplate;

public class UnitMenus
{
    public int Id { get; set; }
    public String IconPath { get; set; }
    public String Title { get; set; }
    public ICollection<UnitSubMenus> SubMenus { get; set; } = new List<UnitSubMenus>();

    public int UnitMainPageId { get; set; }
    public UnitMainPage UnitMainPage { get; set; }
}