using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{




    public class MoveFocusRequestedEventArgs : MoveFocusRequestedEventArgsInterface
    {
        //private ICoreWebView2MoveFocusRequestedEventArgs _Args;

        //private ICoreWebView2MoveFocusRequestedEventArgs ToInterface()
        //{
        //    return this._Args;
        //}
        public MoveFocusRequestedEventArgs(ICoreWebView2MoveFocusRequestedEventArgs args):base(args)
        {
            //this._Args = args;
        }
      

        public MoveFocusReason Reason => (MoveFocusReason)base.reason;

      

        public new bool Handled
        {
            get
            {
                return new CBOOL(base.Handled);
            }
            set
            {
                var b = new CBOOL(value);
                base.Handled = b;
            }
        }

        //COREWEBVIEW2_MOVE_FOCUS_REASON ICoreWebView2MoveFocusRequestedEventArgs.reason => this._Args.reason;

        //int ICoreWebView2MoveFocusRequestedEventArgs.Handled
        //{
        //    get => this._Args.Handled;
        //    set => this._Args.Handled = value;
        //}

    }
}