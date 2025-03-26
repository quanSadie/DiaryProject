namespace Repository;

public class ThreadPost : EntityBase
{
    public Guid ThreadId { get; set; }
    public Guid UserId { get; set; }
    public String Content { get; set; } = String.Empty;

    public Thread Thread { get; set; } = null!;
    public User User { get; set; } = null!;
}