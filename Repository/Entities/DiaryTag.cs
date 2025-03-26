namespace Repository;

public class DiaryTag
{
    public Guid DiaryId { get; set; }
    public Guid TagId { get; set; }

    public DiaryEntry DiaryEntry { get; set; } = null!;
    public Tag Tag { get; set; } = null!;
}