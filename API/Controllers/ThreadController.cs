using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class ThreadController : ControllerBase
{
    private readonly IThreadService threadService;
    private readonly IMapper mapper;

    public ThreadController(IThreadService threadService, IMapper mapper)
    {
        this.threadService = threadService;
        this.mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllThreads()
    {
        var threads = await threadService.GetAll();
        return Ok(mapper.Map<List<ThreadAPIModel>>(threads));
    }

    [HttpPost()]
    public async Task<IActionResult> AddThread([FromBody] ThreadAPIModel thread)
    {
        var dto = mapper.Map<ThreadDTO>(thread);
        var result = await threadService.AddThread(dto);
        return result ? Ok(thread) : BadRequest();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateThread([FromBody] ThreadAPIModel thread)
    {
        var dto = mapper.Map<ThreadDTO>(thread);
        var result = await threadService.UpdateThread(dto);
        return result ? Ok(thread) : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteThread(Guid id)
    {
        var result = await threadService.DeleteThread(id);
        return result ? Ok() : BadRequest();
    }
}