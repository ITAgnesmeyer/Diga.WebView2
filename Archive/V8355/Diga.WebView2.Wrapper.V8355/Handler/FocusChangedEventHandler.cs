using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FocusChangedEventHandler : IWebView2FocusChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> FocusChanged;
        public void Invoke(IWebView2WebView sender, object args)
        {
            OnFocusChanged(new WebView2EventArgs(sender, args));
        }

        protected virtual void OnFocusChanged(WebView2EventArgs e)
        {
            FocusChanged?.Invoke(this, e);
        }
    }
}