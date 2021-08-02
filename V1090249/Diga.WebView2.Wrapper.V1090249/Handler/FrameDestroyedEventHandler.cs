using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameDestroyedEventHandler : ICoreWebView2FrameDestroyedEventHandler
    {
        public event EventHandler<FrameDestroyedEventArgs> FrameDestroyed;
        public void Invoke(ICoreWebView2Frame sender, object args)
        {
            OnFrameDestroyed(new FrameDestroyedEventArgs(new Frame(sender), args));
        }

        protected virtual void OnFrameDestroyed(FrameDestroyedEventArgs e)
        {
            FrameDestroyed?.Invoke(this, e);
        }
    }
}