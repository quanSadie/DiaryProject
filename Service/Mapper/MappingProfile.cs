using AutoMapper;
using Model;
using Repository;
using Thread = Repository.Thread;

namespace Service;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<DiaryEntry, DiaryEntryDTO>().ReverseMap();
        CreateMap<Media, MediaDTO>().ReverseMap();
        CreateMap<User, UserDTO>().ReverseMap();
        CreateMap<Reminder, ReminderDTO>().ReverseMap();
        CreateMap<Thread, ThreadDTO>().ReverseMap();
        CreateMap<Tag, TagDTO>().ReverseMap();
        CreateMap<ThreadPost, ThreadPostDTO>().ReverseMap();
    }
}