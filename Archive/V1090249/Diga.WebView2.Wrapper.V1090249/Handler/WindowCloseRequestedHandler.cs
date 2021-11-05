using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WindowCloseRequestedHandler : ICoreWebView2WindowCloseRequestedEventHandler
    {
        public event EventHandler<WebView2EventArgs> WindowCloseRequested;

        public void Invoke(ICoreWebView2 sender, object args)
        {
            OnWindowCloseRequested(new WebView2EventArgs(sender, args));
        }

        protected virtual void OnWindowCloseRequested(WebView2EventArgs e)
        {
            WindowCloseRequested?.Invoke(this, e);
        }
    }
}