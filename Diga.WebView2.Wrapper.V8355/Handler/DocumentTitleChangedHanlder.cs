using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class DocumentTitleChangedHanlder : IWebView2DocumentTitleChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> DocumentTitleChanged;
        public void Invoke(IWebView2WebView3 webview, object args)
        {
            OnDocumentTitleChanged(new WebView2EventArgs(webview, args));
        }

        protected virtual void OnDocumentTitleChanged(WebView2EventArgs e)
        {
            DocumentTitleChanged?.Invoke(this, e);
        }
    }
}