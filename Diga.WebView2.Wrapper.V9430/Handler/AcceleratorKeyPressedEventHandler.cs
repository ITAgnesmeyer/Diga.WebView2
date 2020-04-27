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

        public void Invoke(ICoreWebView2Host sender, ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            OnAcceleratorKeyPressed(new AcceleratorKeyPressedEventArgs(args));
        }
    }
}