using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameCreatedEventHandler : ICoreWebView2FrameCreatedEventHandler
    {
        public event EventHandler<FrameCreatedEventArgs> FrameCreated;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2FrameCreatedEventArgs args)
        {
            OnFrameCreated(new FrameCreatedEventArgs(args));
        }

        protected virtual void OnFrameCreated(FrameCreatedEventArgs e)
        {
            FrameCreated?.Invoke(this, e);
        }
    }
}