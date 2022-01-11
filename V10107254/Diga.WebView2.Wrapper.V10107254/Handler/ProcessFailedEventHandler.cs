using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ProcessFailedEventHandler : ICoreWebView2ProcessFailedEventHandler
    {
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;


        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2ProcessFailedEventArgs args)
        {
            try
            {
                OnProcessFailed(new ProcessFailedEventArgs((ICoreWebView2ProcessFailedEventArgs2)args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ProcessFailedEventHandler) + " Exception:" + ex.ToString());

            }

        }
    }
}