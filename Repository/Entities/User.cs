namespace Repository;

public class User : EntityBase
{
    public String Name { get; set; } = String.Empty;
    public String Username { get; set; } = String.Empty;
    public String Password { get; set; } = String.Empty;
    
    public List<DiaryEntry> Diaries { get; set; } = new();
    public List<Reminder> Reminders { get; set; } = new();
    public List<ThreadPost> ThreadPosts { get; set; } = new();
}