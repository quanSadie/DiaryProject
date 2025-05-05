using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class DiaryController : ControllerBase
{
    private readonly IDiaryService diaryService;
    private readonly IMapper mapper;

    public DiaryController(IDiaryService diaryService, IMapper mapper)
    {
        this.diaryService = diaryService;
        this.mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllDiaries()
    {
        var diaryList = await diaryService.GetAll();
        return Ok(mapper.Map<List<DiaryAPIModel>>(diaryList));
    }
    
    [HttpPost()]
    public async Task<IActionResult> AddDiary(DiaryAPIModel diary)
    {
        var diaryDTO = mapper.Map<DiaryEntryDTO>(diary);
        var result = await diaryService.AddDiary(diaryDTO);
        return result == true ? Ok(diary) : BadRequest();
    }
}