namespace Model;

public class DiaryEntryDTO
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Mood { get; set; }
    public string? Location { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<string>? Tags { get; set; }
    public List<MediaDTO>? MediaFiles { get; set; }
}