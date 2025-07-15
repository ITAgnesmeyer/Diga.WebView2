using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameChildFrameCreatedEventHandler: ICoreWebView2FrameChildFrameCreatedEventHandler
    {
        public event EventHandler<FrameCreatedEventArgs> FrameChildFrameCreated;
        protected virtual void OnFrameChildFrameCreated(FrameCreatedEventArgs e)
        {
            FrameChildFrameCreated?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2Frame sender, ICoreWebView2FrameCreatedEventArgs args)
        {
            try
            {
                OnFrameChildFrameCreated(new FrameCreatedEventArgs((ICoreWebView2FrameCreatedEventArgs)args));
            }
            catch (Exception ex)
            {
                Debug.Print("FrameChildFrameCreatedEventHandler Exception:" + ex.ToString());
            }
        }
    }
}