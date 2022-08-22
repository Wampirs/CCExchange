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
using System.Windows.Shapes;

namespace CCExchange.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void TopBar_CloseButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopBar_MinimizeButtonClicked(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TopBar_MaximizeButtonClicked(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                return;
            } 
            this.WindowState=WindowState.Maximized;
        }

        private void TopBar_ThemeButtonClicked(object sender, EventArgs e)
        {
            
        }
    }
}
