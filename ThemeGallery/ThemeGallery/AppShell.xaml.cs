using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeGallery.Styles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThemeGallery
{
    public partial class AppShell
    {
        public Command ChangeThemeCommand { get; set; }

        public AppShell()
        {
            BindingContext = this;

            ChangeThemeCommand = new Command<string>(OnChangeTheme);

            InitializeComponent();
        }

        private void OnChangeTheme(string theme)
        {
            if (theme == "dark")
            {
                App.Current.Resources = new DarkTheme();
                App.AppTheme = theme;
            }
            else
            {
                App.Current.Resources = new LightTheme();
                App.AppTheme = theme;
            }

            Shell.Current.FlyoutIsPresented = false;
        }
    }
}