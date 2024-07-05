using DesktopCrypto.Core;
using DesktopCrypto.Models;
using System.Windows;
using System.Windows.Input;

namespace DesktopCrypto.Views
{
    public partial class MainWindow : Window
    {
        private ThemeElements _elements;

        public MainWindow()
        {
            InitializeComponent();

            _elements = new ThemeElements()
            {
                BorderBackground = BorderBackground,
                MinimizeButton = MinimizeButton,
                CloseButton = CloseButton,
                CurrencyButton = CurrencyButton,
                GraphicButton = GraphicButton,
                ConverterButton = ConverterButton
                // Data4Button = Data4Button,
                // Data5Button = Data5Button
            };
        }

        #region BASE METHODS

        private void MoveWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

            //ThemeChanger.ChangeTheme(this, _elements);
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        private async void GetDataAsync()
        {

        }
    }
}