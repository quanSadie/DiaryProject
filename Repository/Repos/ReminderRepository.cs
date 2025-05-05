namespace Repository;

public class ReminderRepository : BaseRepository<Reminder>, IReminderRepository
{
    public ReminderRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}