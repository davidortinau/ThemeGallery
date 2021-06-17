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
                "RadioButton_Experimental",
                "Shell_UWP_Experimental"
            });

            InitializeComponent();

            DependencyService.Register<TinyMessengerHub>();

            MainPage = new AppShell();

            //var tp = new TabbedPage();
            //tp.Children.Add(new RadioButtonsPage());
            //tp.Children.Add(new CheckBoxesPage());
            //tp.Children.Add(new ButtonsPage());
            //tp.Children.Add(new EntriesPage());


            //MainPage = tp;

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
