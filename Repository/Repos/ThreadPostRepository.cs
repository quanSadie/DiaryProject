namespace Repository;

public class ThreadPostRepository : BaseRepository<ThreadPost>, IThreadPostRepository
{
    public ThreadPostRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}