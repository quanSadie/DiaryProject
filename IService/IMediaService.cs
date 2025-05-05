using Model;

namespace IService;

public interface IMediaService
{
    public Task<Boolean> AddMedia(MediaDTO media);
    public Task<List<MediaDTO>> GetAll();
    public Task<Boolean> DeleteMedia();
    public Task<Boolean> UpdateMedia(MediaDTO mediaDTO);
}