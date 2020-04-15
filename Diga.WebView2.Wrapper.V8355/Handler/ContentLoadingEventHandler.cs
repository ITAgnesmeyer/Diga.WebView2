using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class ContentLoadingEventHandler 
    {
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public void Invoke(IWebView2WebView5 webview)
        {
            
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }
    }
}