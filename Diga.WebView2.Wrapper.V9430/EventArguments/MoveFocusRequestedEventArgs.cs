using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class MoveFocusRequestedEventArgs : ICoreWebView2MoveFocusRequestedEventArgs
    {
        private ICoreWebView2MoveFocusRequestedEventArgs _Args;

        private ICoreWebView2MoveFocusRequestedEventArgs ToInterface()
        {
            return this._Args;
        }
        public MoveFocusRequestedEventArgs(ICoreWebView2MoveFocusRequestedEventArgs args)
        {
            this._Args = args;
        }
      

        public MoveFocusReason Reason => (MoveFocusReason)this.ToInterface().reason;

        public bool Handled
        {
            get
            {
                return new CBOOL(this.ToInterface().Handled);
            }
            set
            {
                var b = new CBOOL(value);
                this.ToInterface().Handled = b;
            }
        }
        CORE_WEBVIEW2_MOVE_FOCUS_REASON ICoreWebView2MoveFocusRequestedEventArgs.reason => this._Args.reason;

        int ICoreWebView2MoveFocusRequestedEventArgs.Handled
        {
            get => this._Args.Handled;
            set => this._Args.Handled = value;
        }
    }
}