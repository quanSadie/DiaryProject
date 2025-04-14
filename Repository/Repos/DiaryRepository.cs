using IRepository;

namespace Repository;

public class DiaryRepository : BaseRepository<DiaryEntry>, IDiaryRepository
{
    public DiaryRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}