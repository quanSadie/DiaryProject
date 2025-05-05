using IService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IDiaryService, DiaryService>();
        services.AddScoped<IMediaService, MediaService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IThreadPostService, ThreadPostService>();
        services.AddScoped<IThreadService, ThreadService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IReminderService, ReminderService>();
        return services;
    }

    public static IServiceCollection AddMapping(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        return services;
    }
}