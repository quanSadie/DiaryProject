using AutoMapper;
using IRepository;
using IService;
using Model;
using Repository;
using Utility;

namespace Service;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IMapper mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
    }
    
    public async Task<Boolean> AddUser(UserDTO userDTO)
    {
        try
        {
            var userEntity = mapper.Map<User>(userDTO);
            await userRepository.SaveAsync(userEntity);
            return true;
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return false;
        }
    }

    public async Task<Boolean> DeleteUser(string username)
    {
        try
        {
            var userEntity = await userRepository.GetByUsername(username);
            return await userRepository.DeleteAsync(userEntity);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return false;
        }
    }

    public async Task<UserDTO> GetByUsername(string username)
    {
        try
        {
            var userEntity = await userRepository.GetByUsername(username);
            return mapper.Map<UserDTO>(userEntity);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return null;
        }
    }

    public async Task<Boolean> UpdateUser(UserDTO userDTO)
    {
        try
        {
            var userEntity = await userRepository.GetByUsername(userDTO.Username);
            userEntity = mapper.Map<UserDTO, User>(userDTO, userEntity);
            return await userRepository.UpdateAsync(userEntity);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return false;
        }
    }
    
    public async Task<List<UserDTO>> GetAll()
    {
        try
        {
            var list = await userRepository.GetAllAsync();
            return mapper.Map<List<UserDTO>>(list);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred while retrieving Users", ex);
            return null;
        }
    }
}