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
                ConverterButton = ConverterButton,
                ThemeChanging = ThemeChanging,
                SearchButton = SearchButton
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
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        private void ThemeChanging_Click(object sender, RoutedEventArgs e)
        {
            ThemeChanger.ChangeTheme(this, _elements);
        }

        private void CryptoTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Submit_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void GetDataAsync()
        {
            var cryptocurrencyDataFetcher = new CryptocurrencyDataFetcher();
            var cryptocurrencyDataList = await cryptocurrencyDataFetcher.GetCryptocurrencyListAsync();

            //if (cryptocurrencyDataList != null)
            //{

            //}
            //else
            //{

            //}
        }
    }
}