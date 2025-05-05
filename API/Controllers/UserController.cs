using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly IUserService userService;
    private readonly IMapper mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        this.userService = userService;
        this.mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllUsers()
    {
        var userList = await userService.GetAll();
        return Ok(mapper.Map<List<UserAPIModel>>(userList));
    }

    [HttpPost()]
    public async Task<IActionResult> AddUser([FromBody] UserAPIModel user)
    {
        var userDTO = mapper.Map<UserDTO>(user);
        var result = await userService.AddUser(userDTO);
        return result == true ? Ok(user) : BadRequest();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateUser([FromBody] UserAPIModel user)
    {
        var userDTO = mapper.Map<UserDTO>(user);
        var result = await userService.UpdateUser(userDTO);
        return result == true ? Ok(user) : BadRequest();
    }

    [HttpDelete()]
    public async Task<IActionResult> DeleteUser([FromBody] string username)
    {
        var result = await userService.DeleteUser(username);
        return result == true ? Ok() : BadRequest();
    }
}