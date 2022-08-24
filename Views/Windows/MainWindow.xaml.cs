using CCExchange.Commands;
using System;
using System.Windows;
using System.Windows.Input;

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
            this.WindowState = WindowState.Maximized;
        }

        private void TopBar_ThemeButtonClicked(object sender, EventArgs e)
        {
            new ChangeThemeCommand().Execute(null);
        }
    }
}
