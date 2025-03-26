namespace Repository;

public class Media : EntityBase
{
    public Guid DiaryId { get; set; }
    public String Url { get; set; }
    public Int32 MediaType { get; set; }
    
    public DiaryEntry DiaryEntry { get; set; } = null!;
}