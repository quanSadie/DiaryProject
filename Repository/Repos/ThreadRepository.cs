namespace Repository;

public class ThreadRepository : BaseRepository<Thread>, IThreadRepository
{
    public ThreadRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}