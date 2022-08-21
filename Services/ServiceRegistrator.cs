using Microsoft.Extensions.DependencyInjection;

namespace CCExchange.Services
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IApiService, ApiService>()
            .AddTransient<IThemeService, ThemeService>()
            ;
    }
}
