using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameNameChangedEventHandler : ICoreWebView2FrameNameChangedEventHandler
    {
        public event EventHandler<FrameNameChangedEventArgs> FrameNameChanged;
        public void Invoke(ICoreWebView2Frame sender, object args)
        {
            try
            {
                string name = sender.name;
                Frame frame = new Frame(sender);
                FrameNameChangedEventArgs eventArgs = new FrameNameChangedEventArgs(frame, args);
                OnFrameNameChanged(eventArgs);
            }
            catch (Exception ex)
            {
                Debug.Print($"Exception {nameof(FrameNameChangedEventHandler)}.Invoke:{ex.Message}");
            }
            
        }

        protected virtual void OnFrameNameChanged(FrameNameChangedEventArgs e)
        {
            FrameNameChanged?.Invoke(this, e);
        }
    }
}