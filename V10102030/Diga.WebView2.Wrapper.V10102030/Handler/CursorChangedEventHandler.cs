using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class CursorChangedEventHandler : ICoreWebView2CursorChangedEventHandler
    {
        public event EventHandler<CursorChangedEventArgs> CursorChanged;
        public void Invoke(ICoreWebView2CompositionController sender, object args)
        {
            OnCursorChanged(new CursorChangedEventArgs(
                new WebView2CompositionController((ICoreWebView2CompositionController2) sender), args));
        }

        protected virtual void OnCursorChanged(CursorChangedEventArgs e)
        {
            CursorChanged?.Invoke(this, e);
        }
    }
}