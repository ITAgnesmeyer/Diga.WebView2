using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{

    public class AcceleratorKeyPressedEventHandler : ICoreWebView2AcceleratorKeyPressedEventHandler
    {
        public event EventHandler<AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed;

        protected virtual void OnAcceleratorKeyPressed(AcceleratorKeyPressedEventArgs e)
        {
            AcceleratorKeyPressed?.Invoke(this, e);
        }
        public void Invoke(ICoreWebView2Controller sender, ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            try
            {
                OnAcceleratorKeyPressed(new AcceleratorKeyPressedEventArgs((ICoreWebView2AcceleratorKeyPressedEventArgs2)args));
            }
            catch (Exception ex)
            {

                Debug.Print("AcceleratorKeyPressedEventHandler Exception:" + ex.ToString());
            }


        }

       
    }
}