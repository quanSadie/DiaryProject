namespace Repository;

public class Reminder : EntityBase
{
    public Guid UserId { get; set; }
    public String Message { get; set; }
    public DateTime RemindDate { get; set; }

    public User User { get; set; } = null!;
}