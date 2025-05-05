using AutoMapper;
using Model;

namespace APIModel.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<DiaryEntryDTO, DiaryAPIModel>().ReverseMap();
        CreateMap<MediaDTO, MediaAPIModel>().ReverseMap();
        CreateMap<UserDTO, UserAPIModel>().ReverseMap();
        CreateMap<ThreadDTO, ThreadAPIModel>().ReverseMap();
        CreateMap<ThreadPostDTO, ThreadAPIModel>().ReverseMap();
        CreateMap<TagDTO, TagAPIModel>().ReverseMap();
        CreateMap<ReminderDTO, ReminderAPIModel>().ReverseMap();
        CreateMap<Mood, MoodAPI>().ReverseMap();
    }
}