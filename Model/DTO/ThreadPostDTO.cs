namespace Model;

public class ThreadPostDTO
{
    public Guid ThreadId { get; set; }
    public Guid UserId { get; set; }
    public String Content { get; set; } = String.Empty;
}