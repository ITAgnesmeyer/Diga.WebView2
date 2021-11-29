using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class DownloadStartingEventHandler : ICoreWebView2DownloadStartingEventHandler
    {
        public event EventHandler<DownloadStartingEventArgs> DownloadStarting;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2DownloadStartingEventArgs args)
        {
            try
            {
                 OnDownloadStarting(new DownloadStartingEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(DownloadStartingEventHandler) + " Exception:" + ex.ToString());

            }

           
        }

        protected virtual void OnDownloadStarting(DownloadStartingEventArgs e)
        {
            DownloadStarting?.Invoke(this, e);
        }
    }
}