using ETUAnaSayfa.Repositories;
using ETUAnaSayfa.Repositories.Implementations;
using ETUAnaSayfa.Services;
using ETUAnaSayfa.Services.Implementations;

namespace ETUAnaSayfa.Extensions;

public static class DependecyInjection
{
    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        //services.AddScoped<SymposiumRepository>();
        services.AddScoped<IHomeRepository, HomeRepository>();
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        //services.AddScoped<SymposiumService>();
        services.AddScoped<IHomeService, HomeService>();
        return services;
    }
    
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddRepositories();
        services.AddServices();
        return services;
    }
}