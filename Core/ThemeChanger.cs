using System.Windows;
using DesktopCrypto.Models;

namespace DesktopCrypto.Core
{
    public static class ThemeChanger
    {
        private static bool _isLightTheme = true;

        public static void ChangeTheme(FrameworkElement context, ThemeElements element)
        {
            if (_isLightTheme)
            {
                element.BorderBackground.Style = (Style)context.FindResource("BorderDarkStyle");
                element.MinimizeButton.Style = (Style)context.FindResource("MinimizeDarkStyle");
                element.CloseButton.Style = (Style)context.FindResource("CloseDarkStyle");
                element.CurrencyButton.Style = 
                    element.GraphicButton.Style = 
                        element.ConverterButton.Style = (Style)context.FindResource("TabDarkStyle");
                            //element.Data4Button.Style = (Style)context.FindResource("TabDarkStyle");
                                //element.Data5Button.Style = (Style)context.FindResource("TabDarkStyle");
            }

            else
            {
                element.BorderBackground.Style = (Style)context.FindResource("BorderLightStyle");
                element.MinimizeButton.Style = (Style)context.FindResource("MinimizeLightStyle");
                element.CloseButton.Style = (Style)context.FindResource("CloseLightStyle");
                element.CurrencyButton.Style =
                    element.GraphicButton.Style =
                        element.ConverterButton.Style = (Style)context.FindResource("TabLightStyle");
                            //element.Data4Button.Style = (Style)context.FindResource("TabLightStyle");
                                //element.Data5Button.Style = (Style)context.FindResource("TabLightStyle");
            }

            _isLightTheme = !_isLightTheme;
        }
    }
}