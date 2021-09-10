using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FocusChangedEventHandler : ICoreWebView2FocusChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> FocusChanged;
#if V9488
        public void Invoke(ICoreWebView2Controller sender, object args)
        {
            OnFocusChanged(new WebView2EventArgs(sender,args));
        }

#else
        public void Invoke(ICoreWebView2Host sender, object args)
        {
            OnFocusChanged(new WebView2EventArgs(sender, args));
        }
#endif
        protected virtual void OnFocusChanged(WebView2EventArgs e)
        {
            FocusChanged?.Invoke(this, e);
        }

    }
}