using Diga.WebView2.Interop;
using System;

namespace Diga.WebView2.Wrapper
{
    public class MoveFocusRequestedEventHandler : IWebView2MoveFocusRequestedEventHandler
    {
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public void Invoke(IWebView2WebView webview, IWebView2MoveFocusRequestedEventArgs args)
        {
            OnMoveFocusRequested(new MoveFocusRequestedEventArgs(args));
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }
    }
}