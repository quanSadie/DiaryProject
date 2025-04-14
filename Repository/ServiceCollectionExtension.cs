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
        return services;
    }
    
}