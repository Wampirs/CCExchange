using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CCExchange.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        SolidColorBrush ownerBackground;
        public Dialog()
        {
            InitializeComponent();
            Closing += DialogWindow_Closing;
        }

        private void DialogWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Background = ownerBackground;
            Owner.Opacity = 1;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            var actWin = App.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Owner = actWin;
            ownerBackground = (SolidColorBrush)Owner.Background;
            Owner.Background = new SolidColorBrush(Colors.Gray);
            Owner.Opacity = 0.5;
        }

        public void Close(bool res)
        {
            this.DialogResult = res;
            base.Close();
        }

        private void TopBar_CloseButtonClicked(object sender, EventArgs e)
        {
            this.Close(false);
        }

        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
