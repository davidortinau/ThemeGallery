using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeGallery.Styles;
using ThemeGallery.ViewModels.Messages;
using TinyMessenger;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemeGallery
{
    public partial class AppShell
    {
        public Command ChangeThemeCommand { get; set; }

        public AppShell()
        {
            ChangeThemeCommand = new Command<string>(OnThemeChange);

            BindingContext = this;

            InitializeComponent();
        }

        private void OnThemeChange(string theme)
        {
            App.Current.UserAppTheme = (theme == "dark") ? OSAppTheme.Dark : OSAppTheme.Light;
        }

        protected override void OnNavigating(ShellNavigatingEventArgs args)
        {
            base.OnNavigating(args);
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);
        }
    }
}