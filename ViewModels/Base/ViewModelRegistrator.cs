using Microsoft.Extensions.DependencyInjection;

namespace CCExchange.ViewModels.Base
{
    public static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddTransient<MainWindowVM>()
            ;
    }
}
