namespace ETUAnaSayfa.Models.Shared.UnitTemplate;

public class UnitQuickAccess
{
    public int Id { get; set; }
    public String Title { get; set; }
    public String ActionURI { get; set; }
    public int MainPageId { get; set; }
    public UnitMainPage UnitMainPage { get; set; }
}