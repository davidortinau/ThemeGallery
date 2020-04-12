using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ThemeGallery.Styles;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ThemeGallery.UWP
{
    public sealed partial class MainPage
    {

        UISettings uiSettings;

        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new ThemeGallery.App());
   
            uiSettings = new UISettings();
            uiSettings.ColorValuesChanged += ColorValuesChanged;
        }

        private void ColorValuesChanged(UISettings sender, object args)
        {
            var backgroundColor = sender.GetColorValue(UIColorType.Background);
            var isDarkMode = backgroundColor == Colors.Black;
            if(isDarkMode)
            {
                Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                {
                    ThemeGallery.App.Current.Resources = new DarkTheme();
                });
                
            }
            else
            {
                Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                {
                    ThemeGallery.App.Current.Resources = new LightTheme();
                });
            }
        }
    }
}
