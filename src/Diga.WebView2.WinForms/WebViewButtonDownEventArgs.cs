using System;
using System.Drawing;

namespace Diga.WebView2.WinForms
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