using Microsoft.Extensions.DependencyInjection;

namespace CCExchange.ViewModels.Base
{
    public class ViewModelLocator
    {
        #region MainWindowVM
        MainWindowVM mainWindowVM;
        public MainWindowVM MainWindowVM => mainWindowVM ??= App.Services.GetRequiredService<MainWindowVM>();
        #endregion

    }
}
