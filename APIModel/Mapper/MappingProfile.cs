using AutoMapper;
using Model;

namespace APIModel.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<DiaryEntryDTO, DiaryAPIModel>().ReverseMap();
    }
}