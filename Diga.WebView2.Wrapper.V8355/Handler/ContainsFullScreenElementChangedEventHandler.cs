using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper
{
    public class ContainsFullScreenElementChangedEventHandler : IWebView2ContainsFullScreenElementChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;
        public void Invoke(IWebView2WebView5 webview, object args)
        {
            OnContainsFullScreenElementChanged(new WebView2EventArgs(webview, args));
        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }
    }
}