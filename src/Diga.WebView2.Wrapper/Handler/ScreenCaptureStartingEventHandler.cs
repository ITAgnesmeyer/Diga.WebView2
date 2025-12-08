using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ScreenCaptureStartingEventHandler : ICoreWebView2ScreenCaptureStartingEventHandler
    {
        public event EventHandler<ScreenCaptureStartingEventArgs> ScreenCaptureStarting;

        private void OnScreenCaptureStarting(ScreenCaptureStartingEventArgs e)
        {
            this.ScreenCaptureStarting?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ScreenCaptureStartingEventArgs args)
        {
            try
            {
                OnScreenCaptureStarting(new ScreenCaptureStartingEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ScreenCaptureStartingEventHandler) + " Exception:" + ex.ToString());
            }

        }
    }
}