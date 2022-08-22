using CCExchange.Views.Windows;

namespace CCExchange.Services
{
    public class DialogService : IDialogService
    {
        public bool? ShowDialog(object vm)
        {
            Dialog win = new Dialog();
            win.DataContext = vm;
            return win.ShowDialog();
        }
    }
}
