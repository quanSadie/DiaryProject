using Model;

namespace IService;

public interface IDiaryService
{
    public Task<Boolean> AddDiary(DiaryEntryDTO diary);
    public Task<List<DiaryEntryDTO>> GetAll();
}