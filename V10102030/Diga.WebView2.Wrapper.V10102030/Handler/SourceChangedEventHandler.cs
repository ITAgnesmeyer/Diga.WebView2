using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class SourceChangedEventHandler : ICoreWebView2SourceChangedEventHandler
    {
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public void Invoke(ICoreWebView2 webview, ICoreWebView2SourceChangedEventArgs args)
        {
            try
            {
                OnSourceChanged(new SourceChangedEventArgs(args.IsNewDocument == 0));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(SourceChangedEventHandler) + " Exception:" + ex.ToString());

            }
            
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }
    }
}