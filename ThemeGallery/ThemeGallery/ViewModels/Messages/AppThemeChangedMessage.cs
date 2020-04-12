using System;
using System.Collections.Generic;
using System.Text;
using TinyMessenger;

namespace ThemeGallery.ViewModels.Messages
{
    public class AppThemeChangedMessage : ITinyMessage
    {
        public AppThemeChangedMessage()
        {
        }

        public object Sender { get; private set; }
    }
}
