using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ThemeGallery
{
    public partial class App : Application
    {

        public static string AppTheme { get; set; }

        public App()
        {
            InitializeComponent();

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
