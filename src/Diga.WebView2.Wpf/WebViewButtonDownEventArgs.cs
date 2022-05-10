using System;
using System.Windows;

namespace Diga.WebView2.Wpf
{
    public class WebViewButtonDownEventArgs : EventArgs
    {
        public Point Location { get;  }

        public WebViewButtonDownEventArgs(Point location)
        {
            this.Location = location;
        }
    }
}