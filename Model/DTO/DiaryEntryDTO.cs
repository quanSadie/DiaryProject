namespace Model;

public class DiaryEntryDTO
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Mood { get; set; }
    public string? Location { get; set; }
}