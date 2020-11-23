using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NewBrowserVersionAvailableEventHandler : ICoreWebView2NewBrowserVersionAvailableEventHandler
    {
        public event EventHandler<WebView2EventArgs> NewBrowserVersionAvailable;
        public void Invoke(ICoreWebView2Environment webviewEnvironment, object args)
        {
            WebView2EventArgs evArgs = new WebView2EventArgs(webviewEnvironment, args);
            OnNewBrowserVersionAvailable(evArgs);
        }

        protected virtual void OnNewBrowserVersionAvailable(WebView2EventArgs args)
        {
            NewBrowserVersionAvailable?.Invoke(this, args);
        }
    }
}