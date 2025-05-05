namespace Model;

public class ReminderDTO
{
    public Guid UserId { get; set; }
    public String Message { get; set; }
    public DateTime RemindDate { get; set; }
}