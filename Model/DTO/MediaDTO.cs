namespace Model;

public class MediaDTO
{
    public Guid Id { get; set; }
    public Guid DiaryId { get; set; }
    public MediaType MediaType { get; set; }
    public string Url { get; set; }
}