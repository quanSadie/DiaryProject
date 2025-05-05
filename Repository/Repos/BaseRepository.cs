using Microsoft.EntityFrameworkCore;

namespace Repository;

public class BaseRepository<T> : IBaseRepository<T>  where T : EntityBase
{
    private readonly AppDbContext dbContext;

    public BaseRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
        
    public async Task SaveAsync(T entity)
    {
        entity.Id = Guid.NewGuid();
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

    public async Task<bool> UpdateAsync(T entity)
    {
        entity.ModifiedAt = DateTime.UtcNow;
        dbContext.Set<T>().Update(entity);
        return await dbContext.SaveChangesAsync() > 0;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await dbContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetSingle(Guid guid)
    {
        return await dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == guid);
    }
}