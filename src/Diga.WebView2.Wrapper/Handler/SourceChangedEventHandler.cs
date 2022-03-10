using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class SourceChangedEventHandler : ICoreWebView2SourceChangedEventHandler
    {
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public void Invoke(ICoreWebView2 webview, ICoreWebView2SourceChangedEventArgs args)
        {
            try
            {
                int isNew = args.IsNewDocument;
                CBOOL b = isNew;
                string url = webview.Source;
                OnSourceChanged(new SourceChangedEventArgs(b));
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