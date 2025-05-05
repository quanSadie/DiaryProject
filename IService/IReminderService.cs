using Model;

namespace IService;

public interface IReminderService
{
    public Task<Boolean> AddReminder(ReminderDTO reminderDTO);
    public Task<List<ReminderDTO>> GetAll();
    public Task<Boolean> DeleteReminder(Guid id);
    public Task<Boolean> UpdateReminder(ReminderDTO reminderDTO);
}