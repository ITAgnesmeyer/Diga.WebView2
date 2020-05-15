using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class AcceleratorKeyPressedEventHandler : IWebView2AcceleratorKeyPressedEventHandler
    {
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;
        public void Invoke(IWebView2WebView webview, IWebView2AcceleratorKeyPressedEventArgs args)
        {
            OnAcceleratorKeyPressed(new AcceleratorKeyPressedEventArgs(args));
        }

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }
    }
}