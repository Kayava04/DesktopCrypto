using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopCrypto.Views
{
    public partial class MainWindow : Window
    {
        private bool _isLightTheme = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region BASE METHODS

        private void MoveWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState.Minimized;
            if (_isLightTheme)
            {
                BorderBackground.Style = (Style)FindResource("BorderDarkStyle");
                MinimizeButton.Style = (Style)FindResource("MinimizeDarkStyle");
                CloseButton.Style = (Style)FindResource("CloseDarkStyle");
                CurrencyButton.Style = (Style)FindResource("TabDarkStyle");
                GraphicButton.Style = (Style)FindResource("TabDarkStyle");
                ConverterButton.Style = (Style)FindResource("TabDarkStyle");
                //Data4Button.Style = (Style)FindResource("TabDarkStyle");
                //Data5Button.Style = (Style)FindResource("TabDarkStyle");
            }

            else
            {
                BorderBackground.Style = (Style)FindResource("BorderLightStyle");
                MinimizeButton.Style = (Style)FindResource("MinimizeLightStyle");
                CloseButton.Style = (Style)FindResource("CloseLightStyle");
                CurrencyButton.Style = (Style)FindResource("TabLightStyle");
                GraphicButton.Style = (Style)FindResource("TabLightStyle");
                ConverterButton.Style = (Style)FindResource("TabLightStyle");
                //Data4Button.Style = (Style)FindResource("TabLightStyle");
                //Data5Button.Style = (Style)FindResource("TabLightStyle");
            }

            _isLightTheme = !_isLightTheme;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion
    }
}