using CCExchange.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace CCExchange.Views
{
    /// <summary>
    /// Логика взаимодействия для TopCurrencyView.xaml
    /// </summary>
    public partial class TopCurrencyView : UserControl
    {
        public TopCurrencyView()
        {
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is TopCurrencyVM ctx && DataContext!=null && CurrenciesDG.CurrentItem != null)
            ctx.ShowInfoDialogCommand.Execute(CurrenciesDG.CurrentItem);
        }
    }
}
