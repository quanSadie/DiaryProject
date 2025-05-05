using Repository;

namespace IRepository;

public interface IUserRepository : IBaseRepository<User>
{
    public Task<User> GetByUsername(string username);
}