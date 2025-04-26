using APIModel.Mapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APIModel;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddAPIModleMapper(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(MappingProfile));       
        return services;
    }
}