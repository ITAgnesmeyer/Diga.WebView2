using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class SourceChangedEventHandler : ICoreWebView2SourceChangedEventHandler
    {
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public void Invoke(ICoreWebView2 webview, ICoreWebView2SourceChangedEventArgs args)
        {
            OnSourceChanged(new SourceChangedEventArgs(args.IsNewDocument==0));
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }
    }
}