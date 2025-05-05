using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class TagController : ControllerBase
{
    private readonly ITagService tagService;
    private readonly IMapper mapper;

    public TagController(ITagService tagService, IMapper mapper)
    {
        this.tagService = tagService;
        this.mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllTags()
    {
        var tags = await tagService.GetAll();
        return Ok(mapper.Map<List<TagAPIModel>>(tags));
    }

    [HttpPost()]
    public async Task<IActionResult> AddTag([FromBody] TagAPIModel tag)
    {
        var dto = mapper.Map<TagDTO>(tag);
        var result = await tagService.AddTag(dto);
        return result ? Ok(tag) : BadRequest();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateTag([FromBody] TagAPIModel tag)
    {
        var dto = mapper.Map<TagDTO>(tag);
        var result = await tagService.UpdateTag(dto);
        return result ? Ok(tag) : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTag(Guid id)
    {
        var result = await tagService.DeleteTag(id);
        return result ? Ok() : BadRequest();
    }
}
