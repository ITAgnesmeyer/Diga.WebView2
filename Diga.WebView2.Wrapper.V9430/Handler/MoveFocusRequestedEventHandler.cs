using Diga.WebView2.Interop;
using System;

namespace Diga.WebView2.Wrapper
{
    public class MoveFocusRequestedEventHandler : ICoreWebView2MoveFocusRequestedEventHandler
    {
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
      
        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2Host sender, ICoreWebView2MoveFocusRequestedEventArgs args)
        {
            OnMoveFocusRequested(new MoveFocusRequestedEventArgs(args));
        }
    }
}