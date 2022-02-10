using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class HistoryChangedEventHandler : ICoreWebView2HistoryChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public void Invoke(ICoreWebView2 webview, object args)
        {
            try
            {
                OnHistoryChanged(new WebView2EventArgs(webview, args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(HistoryChangedEventHandler) + " Exception:" + ex.ToString());

            }

        }

        protected virtual void OnHistoryChanged(WebView2EventArgs e)
        {
            HistoryChanged?.Invoke(this, e);
        }
    }
}