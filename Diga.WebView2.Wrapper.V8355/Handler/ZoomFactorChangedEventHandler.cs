using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ZoomFactorChangedEventHandler:IWebView2ZoomFactorChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public void Invoke(IWebView2WebView sender, object args)
        {
            OnZoomFactorChanged(new WebView2EventArgs(sender, args));
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }
    }
}