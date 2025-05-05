using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("api/[controller]/[action]")]
public class ReminderController : ControllerBase
{
    private readonly IReminderService reminderService;
    private readonly IMapper mapper;

    public ReminderController(IReminderService reminderService, IMapper mapper)
    {
        this.reminderService = reminderService;
        this.mapper = mapper;
    }

    [HttpGet()]
    public async Task<IActionResult> GetReminders()
    {
        var reminders = await reminderService.GetAll();
        return Ok(mapper.Map<List<ReminderAPIModel>>(reminders));
    }
    
    
}