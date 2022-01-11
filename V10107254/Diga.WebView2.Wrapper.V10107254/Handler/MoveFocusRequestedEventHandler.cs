using Diga.WebView2.Interop;
using System;
using Diga.WebView2.Wrapper.EventArguments;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Handler
{
    public class MoveFocusRequestedEventHandler : ICoreWebView2MoveFocusRequestedEventHandler
    {
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2Controller sender, ICoreWebView2MoveFocusRequestedEventArgs args)
        {
            try
            {
                 OnMoveFocusRequested(new MoveFocusRequestedEventArgs(args));
            }
            catch (Exception ex)
            {

                Debug.Print("" + ex.ToString());
            }
           
        }


    }
}