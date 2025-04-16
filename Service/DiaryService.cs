using AutoMapper;
using IRepository;
using IService;
using Model;
using Repository;

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

    public async Task AddDiary(DiaryEntryDTO diaryEntryDTO)
    {
        var diaryEntity = mapper.Map<DiaryEntry>(diaryEntryDTO);
        await diaryRepository.SaveAsync(diaryEntity);
    }

    public async Task<List<DiaryEntryDTO>> GetAll()
    {
        var list = await diaryRepository.GetAllAsync();
        return mapper.Map<List<DiaryEntryDTO>>(list);
    }
}