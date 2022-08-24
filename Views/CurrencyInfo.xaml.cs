using CCExchange.Models;
using CCExchange.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace CCExchange.Views
{
    /// <summary>
    /// Логика взаимодействия для CurrencyInfo.xaml
    /// </summary>
    public partial class CurrencyInfo : UserControl
    {
        public CurrencyInfo()
        {
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(DataContext is CurrencyInfoVM ctx && DataContext!= null && MarketsDG.CurrentItem != null)
            ctx.ShowInfoDialogCommand.Execute((MarketsDG.CurrentItem as Market).ExchangeId);
        }
    }
}
