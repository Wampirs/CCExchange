using CCExchange.ViewModels.Base;
using CCExchange.Views.Windows;

namespace CCExchange.Services
{
    public class DialogService : IDialogService
    {
        public bool? ShowDialog(ViewModel vm)
        {
            Dialog win = new Dialog();
            win.DataContext = vm;
            return win.ShowDialog();
        }
    }
}
