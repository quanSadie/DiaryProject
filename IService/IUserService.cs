using Model;

namespace IService;

public interface IUserService
{
    public Task<Boolean> AddUser(UserDTO user);
    public Task<List<UserDTO>> GetAll();
    public Task<UserDTO> GetByUsername(string username);
    public Task<Boolean> DeleteUser(string username);
    public Task<Boolean> UpdateUser(UserDTO user);
}