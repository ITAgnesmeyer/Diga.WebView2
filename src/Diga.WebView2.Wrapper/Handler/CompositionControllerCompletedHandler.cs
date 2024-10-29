using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class
        CompositionControllerCompletedHandler :
            ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler
    {
        public event EventHandler<CompositionControllerCompletedEventArgs> Completed; 
        public void Invoke(int errorCode, ICoreWebView2CompositionController webView)
        {
            OnCompleted(new CompositionControllerCompletedEventArgs(errorCode, new WebView2CompositionController((ICoreWebView2CompositionController4)webView)));
        }

        protected virtual void OnCompleted(CompositionControllerCompletedEventArgs e)
        {
            Completed?.Invoke(this, e);
        }
    }
}