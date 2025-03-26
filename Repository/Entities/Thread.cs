namespace Repository;

public class Thread : EntityBase
{
    public String Title { get; set; }
    public String Description { get; set; }

    public List<ThreadPost> Posts { get; set; } = new();
}