using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class DOMContentLoadedEventHandler : ICoreWebView2DOMContentLoadedEventHandler
    {
        public event EventHandler<DOMContentLoadedEventArgs> DOMContentLoaded;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2DOMContentLoadedEventArgs args)
        {
            OnDomContentLoaded(new DOMContentLoadedEventArgs(args));
        }

        protected virtual void OnDomContentLoaded(DOMContentLoadedEventArgs e)
        {
            DOMContentLoaded?.Invoke(this, e);
        }
    }
}