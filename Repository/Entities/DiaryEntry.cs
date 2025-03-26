namespace Repository;

public class DiaryEntry : EntityBase
{
    public Guid UserId { get; set; }
    public String Title { get; set; }
    public String Content { get; set; }
    public Int32 Mood { get; set; }
    public String? Location { get; set; }

    public User User { get; set; } = null!;
    public List<DiaryTag> DiaryTags { get; set; } = new ();
    public List<Media> MediaFiles { get; set; } = new();
}