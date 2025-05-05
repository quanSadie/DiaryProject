using AutoMapper;
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

    public async Task<bool> DeleteDiary(Guid id)
    {
        try
        {
            var diaryEntity = await diaryRepository.GetSingle(id);
            return await diaryRepository.DeleteAsync(diaryEntity);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred while removing Diary", ex);
            return false;
        }
    }

    public async Task<bool> UpdateDiary(DiaryEntryDTO diaryDTO)
    {
        try
        {
            var diaryEntity = await diaryRepository.GetSingle(diaryDTO.Id);
            diaryEntity = mapper.Map<DiaryEntry>(diaryDTO);
            return await diaryRepository.UpdateAsync(diaryEntity);
        }
        catch (Exception ex)
        {
            LoggerManager.Error("An error has occurred while updating Diary", ex);
            return false;
        }
    }
}