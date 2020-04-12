using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using ThemeGallery.ViewModels.Messages;
using TinyMessenger;
using Xamarin.Forms;

namespace ThemeGallery.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        private TinyMessengerHub _hub;

        public string SelectedTheme
        {
            get
            {
                return (App.AppTheme == "light") 
                    ? "Light Theme"
                    : "Dark Theme";
            }
        }

        public AppViewModel()
        {
            _hub = DependencyService.Resolve<TinyMessengerHub>();
            _hub.Subscribe<AppThemeChangedMessage>(OnThemeChanged);
        }

        private void OnThemeChanged(AppThemeChangedMessage obj)
        {
            this.OnPropertyChanged(nameof(SelectedTheme));
        }
    }
}
