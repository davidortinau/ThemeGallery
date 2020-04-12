using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Resources.ProductSans-Regular.ttf", Alias = "Product")]
[assembly: ExportFont("Resources.RobotoMono-Regular.ttf", Alias = "Roboto")]
namespace ThemeGallery.Styles
{
    public partial class DefaultTheme : ResourceDictionary
    {
        public DefaultTheme()
        {
            InitializeComponent();
        }
    }
}