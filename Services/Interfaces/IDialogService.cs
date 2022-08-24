using CCExchange.ViewModels.Base;

namespace CCExchange.Services
{
    public interface IDialogService
    {
        bool? ShowDialog(ViewModel vm);
    }
}