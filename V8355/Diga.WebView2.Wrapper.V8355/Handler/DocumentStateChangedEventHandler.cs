using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class DocumentStateChangedEventHandler : IWebView2DocumentStateChangedEventHandler
    {
        public event EventHandler<DocumentStateChangedEventArgs> DocumentStateChanged;
        public void Invoke(IWebView2WebView webview, IWebView2DocumentStateChangedEventArgs args)
        {
            OnDocumentStateChanged(new DocumentStateChangedEventArgs(args));
        }

        protected virtual void OnDocumentStateChanged(DocumentStateChangedEventArgs e)
        {
            DocumentStateChanged?.Invoke(this, e);
        }
    }
}