using IRepository;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly AppDbContext dbContext;
    
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<User> GetByUsername(string username)
    {
        return await this.dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
    }
}