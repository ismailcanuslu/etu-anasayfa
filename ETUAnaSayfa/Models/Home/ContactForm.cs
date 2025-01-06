namespace ETUAnaSayfa.Models.Home;

public class ContactForm
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }
    public IEnumerable<String> Choices { get; set; }
    public String Message { get; set; }
    public bool IsRead { get; set; }
}