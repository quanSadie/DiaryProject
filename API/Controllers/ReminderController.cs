using APIModel;
using AutoMapper;
using IService;
using Microsoft.AspNetCore.Mvc;
using Model;

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
    public async Task<IActionResult> GetAllReminders()
    {
        var reminders = await reminderService.GetAll();
        return Ok(mapper.Map<List<ReminderAPIModel>>(reminders));
    }

    [HttpPost()]
    public async Task<IActionResult> AddReminder([FromBody] ReminderAPIModel reminder)
    {
        var dto = mapper.Map<ReminderDTO>(reminder);
        var result = await reminderService.AddReminder(dto);
        return result ? Ok(reminder) : BadRequest();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateReminder([FromBody] ReminderAPIModel reminder)
    {
        var dto = mapper.Map<ReminderDTO>(reminder);
        var result = await reminderService.UpdateReminder(dto);
        return result ? Ok(reminder) : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReminder(Guid id)
    {
        var result = await reminderService.DeleteReminder(id);
        return result ? Ok() : BadRequest();
    }
}
