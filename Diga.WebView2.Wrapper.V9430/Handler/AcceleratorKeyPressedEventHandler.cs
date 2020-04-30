using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class AcceleratorKeyPressedEventHandler : ICoreWebView2AcceleratorKeyPressedEventHandler
    {
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }
#if V9488
        public void Invoke(ICoreWebView2Controller sender, ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            OnAcceleratorKeyPressed(new AcceleratorKeyPressedEventArgs(args));
        }
#else
        public void Invoke(ICoreWebView2Host sender, ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            OnAcceleratorKeyPressed(new AcceleratorKeyPressedEventArgs(args));
        }
#endif
       
    }
}