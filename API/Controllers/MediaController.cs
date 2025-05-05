using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class MediaController : ControllerBase
{
    private readonly IMediaService mediaService;
    private readonly IMapper mapper;

    public MediaController(IMediaService mediaService, IMapper mapper)
    {
        this.mediaService = mediaService;
        this.mapper = mapper;
    }
    
    [HttpGet()]
    public async Task<IActionResult> GetAllMedias()
    {
        var mediaList = await mediaService.GetAll();
        return Ok(mapper.Map<List<MediaAPIModel>>(mediaList));
    }
    
    [HttpPost()]
    public async Task<IActionResult> AddMedia(MediaAPIModel media)
    {
        var mediaDTO = mapper.Map<MediaDTO>(media);
        var result = await mediaService.AddMedia(mediaDTO);
        return result == true ? Ok(media) : BadRequest();
    }
}