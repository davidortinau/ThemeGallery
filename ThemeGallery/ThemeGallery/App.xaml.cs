using System;
using ThemeGallery.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Resources.ProductSans-Regular.ttf", Alias = "Product")]
[assembly: ExportFont("Resources.RobotoMono-Regular.ttf", Alias = "Roboto")]
namespace ThemeGallery
{
    public partial class App : Application
    {

        public static string AppTheme { get; set; }

        public App()
        {
            Device.SetFlags(new string[] { 
                "IndicatorView_Experimental",
                "SwipeView_Experimental",
                "CarouselView_Experimental",
                "Shell_UWP_Experimental"
            });

            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new ControlReference();
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
