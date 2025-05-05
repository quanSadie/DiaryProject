using IService;
using Model;

namespace Service;

public class ThreadService : IThreadService
{
    public async Task<bool> AddThread(ThreadDTO threadDTO)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ThreadDTO>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteThread(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateThread(ThreadDTO threadDTO)
    {
        throw new NotImplementedException();
    }
}