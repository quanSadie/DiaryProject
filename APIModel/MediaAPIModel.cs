namespace APIModel;

public class MediaAPIModel
{
    public Guid DiaryId { get; set; }
    public MediaTypeAPIModel MediaType { get; set; }
    public string Url { get; set; }
}