using IRepository;
using Repository;

namespace Service;

public class DiaryService
{
    private readonly IDiaryRepository _diaryRepository;

    public DiaryService(IDiaryRepository diaryRepository)
    {
        _diaryRepository = diaryRepository;
    }

    public async Task Add(DiaryEntry diaryEntry)
    {
        await _diaryRepository.SaveAsync(diaryEntry);    
    }
}