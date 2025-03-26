namespace Repository;

public class Tag : EntityBase
{
    public Guid UserId { get; set; }
    public String TagName { get; set; }

    public List<DiaryTag> DiaryTags { get; set; } = new();
}