using Microsoft.Extensions.DependencyInjection;

namespace CCExchange.ViewModels.Base
{
    public class ViewModelLocator
    {
        MainWindowVM mainWindowVM;
        public MainWindowVM MainWindowVM => mainWindowVM ??= App.Services.GetRequiredService<MainWindowVM>();



    }
}
