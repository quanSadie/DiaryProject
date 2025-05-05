using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class ThreadPostController : ControllerBase
{
    private readonly IThreadPostService threadPostService;
    private readonly IMapper mapper;

    public ThreadPostController(IThreadPostService threadPostService, IMapper mapper)
    {
        this.threadPostService = threadPostService;
        this.mapper = mapper;
    }

    /*[HttpGet("{threadId}")]
    public async Task<IActionResult> GetPostsByThread(Guid threadId)
    {
        var posts = await threadPostService.GetPostsByThread(threadId);
        return Ok(mapper.Map<List<ThreadPostAPIModel>>(posts));
    }*/

    [HttpPost()]
    public async Task<IActionResult> AddThreadPost([FromBody] ThreadPostAPIModel post)
    {
        var dto = mapper.Map<ThreadPostDTO>(post);
        var result = await threadPostService.AddThreadPost(dto);
        return result ? Ok(post) : BadRequest();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateThreadPost([FromBody] ThreadPostAPIModel post)
    {
        var dto = mapper.Map<ThreadPostDTO>(post);
        var result = await threadPostService.UpdateThreadPost(dto);
        return result ? Ok(post) : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteThreadPost(Guid id)
    {
        var result = await threadPostService.DeleteThreadPost(id);
        return result ? Ok() : BadRequest();
    }
}
