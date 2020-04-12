using System;
using ThemeGallery.Views;
using TinyMessenger;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemeGallery
{
    public partial class App : Application
    {

        public static string AppTheme { get; set; } = "light";

        public App()
        {
            Device.SetFlags(new string[] { 
                "IndicatorView_Experimental",
                "SwipeView_Experimental",
                "CarouselView_Experimental",
                "Shell_UWP_Experimental",
                "AppTheme_Experimental"
            });

            InitializeComponent();

            DependencyService.Register<TinyMessengerHub>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
