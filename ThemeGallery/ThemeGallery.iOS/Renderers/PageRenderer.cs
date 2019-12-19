﻿using System;
using ThemeGallery.Domain;
using ThemeGallery.Styles;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(ThemeGallery.iOS.Renderers.PageRenderer))]
namespace ThemeGallery.iOS.Renderers
{
    public class PageRenderer : Xamarin.Forms.Platform.iOS.PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetAppTheme();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"\t\t\tERROR: {ex.Message}");
            }
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);
            Console.WriteLine($"TraitCollectionDidChange: {TraitCollection.UserInterfaceStyle} != {previousTraitCollection.UserInterfaceStyle}");

            if(this.TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
            {
                SetAppTheme();
            }

            
        }

        void SetAppTheme()
        {
            var useDeviceSettings = DependencyService.Get<AppModel>().UseDeviceThemeSettings;
            var useDarkMode = DependencyService.Get<AppModel>().UseDarkMode;

            if (!useDeviceSettings)
            {
                if (useDarkMode)
                {
                    if (App.AppTheme == "dark")
                        return;
                    //Add a Check for App Theme since this is called even when not changed really
                    App.Current.Resources = new DarkTheme();

                    App.AppTheme = "dark";
                }
                else
                {
                    if (App.AppTheme != "dark")
                        return;
                    App.Current.Resources = new LightTheme();
                    App.AppTheme = "light";
                }
            }
            else
            {
                if (this.TraitCollection.UserInterfaceStyle == UIUserInterfaceStyle.Dark)
                {
                    if (App.AppTheme == "dark")
                        return;
                    //Add a Check for App Theme since this is called even when not changed really
                    App.Current.Resources = new DarkTheme();

                    App.AppTheme = "dark";
                }
                else
                {
                    if (App.AppTheme != "dark")
                        return;
                    App.Current.Resources = new LightTheme();
                    App.AppTheme = "light";
                }
            }
        }
    }
}
