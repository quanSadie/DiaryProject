using IService;
using Model;

namespace Service;

public class ReminderService : IReminderService
{
    public async Task<bool> AddReminder(ReminderDTO reminderDTO)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ReminderDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteReminder(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateReminder(ReminderDTO reminderDTO)
    {
        throw new NotImplementedException();
    }
}