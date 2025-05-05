namespace Repository;

public class TagRepository : BaseRepository<Tag>, ITagRepository
{
    public TagRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}