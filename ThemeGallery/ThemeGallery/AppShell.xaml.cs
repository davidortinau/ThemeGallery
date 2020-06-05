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
            BindingContext = this;

            InitializeComponent();
        }
    }
}