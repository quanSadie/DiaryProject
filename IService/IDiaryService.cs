using Model;

namespace IService;

public interface IDiaryService
{
    public Task AddDiary(DiaryEntryDTO diary);
    public Task<List<DiaryEntryDTO>> GetAll();
}