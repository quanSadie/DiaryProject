using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers;

[Route("api/[controller]/[action]")]
public class DiaryController : ControllerBase
{
    private readonly IDiaryService diaryService;

    public DiaryController(IDiaryService diaryService)
    {
        this.diaryService = diaryService;
    }

    [HttpGet()]
    public async Task<IActionResult> GetAllDiaries()
    {
        var diaryList = await diaryService.GetAll();
        if (diaryList == null)
        {
            return Ok(new List<DiaryEntryDTO>()); 
        }
        return Ok(diaryList);
    }
    
    [HttpPost()]
    public async Task<IActionResult> AddDiary(DiaryEntryDTO diary)
    {
        var result = await diaryService.AddDiary(diary);
        return result == true ? Ok(diary) : BadRequest();
    }
}