using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThemeGallery.Views
{
    public partial class RadioButtonsPage : ContentPage
    {
        public RadioButtonsPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CheckBoxesPage(), true);
        }
    }
}
