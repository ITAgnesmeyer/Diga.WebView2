using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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