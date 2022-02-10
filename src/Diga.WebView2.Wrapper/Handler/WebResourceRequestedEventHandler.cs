using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebResourceRequestedEventHandler : ICoreWebView2WebResourceRequestedEventHandler
    {
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2WebResourceRequestedEventArgs args)
        {
            try
            {
                OnWebResourceRequested(new WebResourceRequestedEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(WebResourceRequestedEventHandler) + " Exception:" + ex.ToString());

            }



        }
    }
}