using AutoMapper;
using Model;
using Repository;

namespace Service;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<DiaryEntry, DiaryEntryDTO>().ReverseMap();
    }
}