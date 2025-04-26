using AutoMapper;
using IRepository;
using IService;
using Model;
using Repository;
using Utility;

namespace Service;

public class DiaryService : IDiaryService
{
    
    private readonly IDiaryRepository diaryRepository;
    private readonly IMapper mapper;

    public DiaryService(IDiaryRepository diaryRepository, IMapper mapper)
    {
        this.diaryRepository = diaryRepository;
        this.mapper = mapper;
    }

    public async Task Add(DiaryEntry diaryEntry)
    {
        await diaryRepository.SaveAsync(diaryEntry);    
    }

    public async Task<Boolean> AddDiary(DiaryEntryDTO diaryEntryDTO)
    {
        try
        {
            var diaryEntity = mapper.Map<DiaryEntry>(diaryEntryDTO);
            await diaryRepository.SaveAsync(diaryEntity);
            return true;
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred", ex);
            return false;
        }
    }

    public async Task<List<DiaryEntryDTO>> GetAll()
    {
        try
        {
            var list = await diaryRepository.GetAllAsync();
            return mapper.Map<List<DiaryEntryDTO>>(list);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred while retrieving Diaries", ex);
            return null;
        }
    }
}