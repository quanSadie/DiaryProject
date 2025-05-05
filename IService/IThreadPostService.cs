using Model;

namespace IService;

public interface IThreadPostService
{
    public Task<Boolean> AddThreadPost(ThreadPostDTO threadPostDTO);
    public Task<List<ThreadPostDTO>> GetAll();
    public Task<Boolean> DeleteThreadPost();
    public Task<Boolean> UpdateThreadPost(ThreadPostDTO threadPostDTO);
}