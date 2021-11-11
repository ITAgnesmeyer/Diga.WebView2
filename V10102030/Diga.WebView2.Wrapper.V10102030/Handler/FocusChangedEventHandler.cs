using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class FocusChangedEventHandler : ICoreWebView2FocusChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> FocusChanged;
        public void Invoke(ICoreWebView2Controller sender, object args)
        {
            try
            {
                OnFocusChanged(new WebView2EventArgs(sender,args));
            }
            catch (Exception ex)
            {

                Debug.Print("FocusChangedEventHandler Exception:" + ex.ToString());
            }
            
        }


        protected virtual void OnFocusChanged(WebView2EventArgs e)
        {
            FocusChanged?.Invoke(this, e);
        }

    }
}