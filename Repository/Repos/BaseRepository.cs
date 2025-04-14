using IRepository;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repos;

public class BaseRepository<T> : IBaseRepository<T>  where T : EntityBase
{
    private readonly AppDbContext dbContext;

    public BaseRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
        
    public async Task SaveAsync(T entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        entity.ModifiedAt = DateTime.UtcNow;
        await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        dbContext.Set<T>().Remove(entity);
        return await dbContext.SaveChangesAsync() > 0;
    }

    public async Task UpdateAsync(T entity)
    {
        entity.ModifiedAt = DateTime.UtcNow;
        dbContext.Set<T>().Update(entity);
        await dbContext.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return dbContext.Set<T>().ToList();
    }

    public async Task<T?> GetSingle(Guid guid)
    {
        return await dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == guid);
    }
}