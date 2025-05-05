using AutoMapper;
using IService;
using Model;
using Repository;
using Utility;

namespace Service;

public class MediaService : IMediaService
{
    private readonly IMediaRepository mediaRepository;
    private readonly IMapper mapper;

    public MediaService(IMediaRepository mediaRepository, IMapper mapper)
    {
        this.mediaRepository = mediaRepository;
        this.mapper = mapper;
    }

    public async Task<Boolean> AddMedia(MediaDTO media)
    {
        try
        {
            LoggerManager.Debug("Saving media...");

            var mediaEntity = mapper.Map<Media>(media);
            await mediaRepository.SaveAsync(mediaEntity);
            return true;
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return false;
        }
    }

    public async Task<List<MediaDTO>> GetAll()
    {
        try
        {
            var list = await mediaRepository.GetAllAsync();
            return mapper.Map<List<MediaDTO>>(list);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred while retrieving Medias", ex);
            return null;
        }
    }

    public async Task<bool> DeleteMedia()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateMedia(MediaDTO mediaDTO)
    {
        throw new NotImplementedException();
    }
}