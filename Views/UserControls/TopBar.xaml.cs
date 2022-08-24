using System;
using System.Windows;
using System.Windows.Controls;

namespace CCExchange.Views.UserControls
{
    /// <summary>
    /// Логика взаимодействия для TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
            DataContext = this;
        }

        public object TitleContent
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(TopBar), new PropertyMetadata { DefaultValue = string.Empty });


        public bool CloseButton
        {
            get { return (bool)GetValue(CloseButtonProperty); }
            set { SetValue(CloseButtonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButton.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonProperty =
            DependencyProperty.Register("CloseButton", typeof(bool), typeof(TopBar), new PropertyMetadata { DefaultValue = true });



        public bool MaximizeButton
        {
            get { return (bool)GetValue(MaximazeButtonProperty); }
            set { SetValue(MaximazeButtonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaximazeButton.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximazeButtonProperty =
            DependencyProperty.Register("MaximazeButton", typeof(bool), typeof(TopBar), new PropertyMetadata { DefaultValue = false });


        public bool MinimizeButton
        {
            get { return (bool)GetValue(MinimizeButtonProperty); }
            set { SetValue(MinimizeButtonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinimizeButton.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimizeButtonProperty =
            DependencyProperty.Register("MinimizeButton", typeof(bool), typeof(TopBar), new PropertyMetadata { DefaultValue = false });



        public bool ThemeButton
        {
            get { return (bool)GetValue(ThemeButtonProperty); }
            set { SetValue(ThemeButtonProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThemeButton.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThemeButtonProperty =
            DependencyProperty.Register("ThemeButton", typeof(bool), typeof(TopBar), new PropertyMetadata { DefaultValue = false });

        public event EventHandler CloseButtonClicked;

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            if (CloseButtonClicked != null)
            {
                CloseButtonClicked(this, EventArgs.Empty);
            }
        }

        public event EventHandler MaximizeButtonClicked;

        private void MaximizeButtonClick(object sender, RoutedEventArgs e)
        {
            if (MaximizeButtonClicked != null)
            {
                MaximizeButtonClicked(this, EventArgs.Empty);
            }
        }

        public event EventHandler MinimizeButtonClicked;

        private void MinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            if (MinimizeButtonClicked != null)
            {
                MinimizeButtonClicked(this, EventArgs.Empty);
            }
        }

        public event EventHandler ThemeButtonClicked;

        private void ThemeButtonClick(object sender, RoutedEventArgs e)
        {
            if (ThemeButtonClicked != null)
            {
                ThemeButtonClicked(this, EventArgs.Empty);
            }
        }
    }
}
