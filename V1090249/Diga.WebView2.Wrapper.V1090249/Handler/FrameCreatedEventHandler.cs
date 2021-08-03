using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameCreatedEventHandler : ICoreWebView2FrameCreatedEventHandler
    {
        public event EventHandler<FrameCreatedEventArgs> FrameCreated;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2FrameCreatedEventArgs args)
        {
            try
            {
                string name = args.Frame.name;
                Debug.Print(name);

                OnFrameCreated(new FrameCreatedEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print($"Exception {nameof(FrameCreatedEventHandler)}.Invoke:{ex.Message}");

            }
            
        }

        protected virtual void OnFrameCreated(FrameCreatedEventArgs e)
        {
            FrameCreated?.Invoke(this, e);
        }
    }
}