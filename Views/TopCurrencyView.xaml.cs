using CCExchange.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            (DataContext as TopCurrencyVM).ShowInfoDialogCommand.Execute(CurrenciesDG.CurrentItem);
        }
    }
}
