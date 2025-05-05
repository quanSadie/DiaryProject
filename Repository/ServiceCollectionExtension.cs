using IRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Repository;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<IDiaryRepository, DiaryRepository>();
        services.AddScoped<IMediaRepository, MediaRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IReminderRepository, ReminderRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<IThreadRepository, ThreadRepository>();
        return services;
    }
    
}