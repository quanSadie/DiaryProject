using Model;

namespace IService;

public interface IThreadService
{
    public Task<Boolean> AddThread(ThreadDTO threadDTO);
    public Task<List<ThreadDTO>> GetAll();
    public Task<Boolean> DeleteThread(Guid id);
    public Task<Boolean> UpdateThread(ThreadDTO threadDTO);
}