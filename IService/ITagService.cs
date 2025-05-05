using Model;

namespace IService;

public interface ITagService
{
    public Task<Boolean> AddTag(TagDTO tagDTO);
    public Task<List<TagDTO>> GetAll();
    public Task<Boolean> DeleteTag();
    public Task<Boolean> UpdateTag(TagDTO tagDTO);
}