using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FrameDestroyedEventHandler : ICoreWebView2FrameDestroyedEventHandler
    {
        public event EventHandler<FrameDestroyedEventArgs> FrameDestroyed;
        public void Invoke(ICoreWebView2Frame sender, object args)
        {
            try
            {
                CBOOL isDestryed = sender.IsDestroyed();
                
                
                if (isDestryed == true)
                {
                    FrameDestroyedEventArgs eventArgs = new FrameDestroyedEventArgs(null, args);
                    OnFrameDestroyed(eventArgs);

                }
                else
                {
                    string name = sender.name;
                    Frame frame = new Frame(sender);
                    FrameDestroyedEventArgs eventArgs = new FrameDestroyedEventArgs(frame, args);
                    OnFrameDestroyed(eventArgs);
                    
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"Exception {nameof(FrameDestroyedEventHandler)}.Invoke:{ex.Message}");
            }
           
        }

        protected virtual void OnFrameDestroyed(FrameDestroyedEventArgs e)
        {
            FrameDestroyed?.Invoke(this, e);
        }
    }
}