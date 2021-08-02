using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameNameChangedEventHandler : ICoreWebView2FrameNameChangedEventHandler
    {
        public event EventHandler<FrameNameChangedEventArgs> FrameNameChanged;
        public void Invoke(ICoreWebView2Frame sender, object args)
        {
            OnFrameNameChanged(new FrameNameChangedEventArgs(new Frame(sender), args));
        }

        protected virtual void OnFrameNameChanged(FrameNameChangedEventArgs e)
        {
            FrameNameChanged?.Invoke(this, e);
        }
    }
}