namespace Repository;

public class MediaRepository: BaseRepository<Media>, IMediaRepository
{
    public MediaRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}