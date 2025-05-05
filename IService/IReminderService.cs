using Model;

namespace IService;

public interface IReminderService
{
    public Task<Boolean> AddReminder(ReminderDTO reminderDTO);
    public Task<List<ReminderDTO>> GetAll();
    public Task<Boolean> DeleteReminder();
    public Task<Boolean> UpdateReminder(ReminderDTO reminderDTO);
}