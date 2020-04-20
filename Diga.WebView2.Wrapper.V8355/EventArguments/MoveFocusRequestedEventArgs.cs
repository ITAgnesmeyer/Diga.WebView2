using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class MoveFocusRequestedEventArgs : IWebView2MoveFocusRequestedEventArgs
    {
        private IWebView2MoveFocusRequestedEventArgs _Args;

        private IWebView2MoveFocusRequestedEventArgs ToInterface()
        {
            return this._Args;
        }
        public MoveFocusRequestedEventArgs(IWebView2MoveFocusRequestedEventArgs args)
        {
            this._Args = args;
        }
        WEBVIEW2_MOVE_FOCUS_REASON IWebView2MoveFocusRequestedEventArgs.reason
        {
            get => this._Args.reason;

        }

        int IWebView2MoveFocusRequestedEventArgs.handled
        {
            get => this._Args.handled;
            set => this._Args.handled = value;
        }

        public MoveFocusReason Reason => (MoveFocusReason) this.ToInterface().reason;

        public bool Handled
        {
            get
            {
                return new CBOOL(this.ToInterface().handled);
            }
            set
            {
                var b = new CBOOL(value);
                this.ToInterface().handled = b;
            }
        }
    }
}