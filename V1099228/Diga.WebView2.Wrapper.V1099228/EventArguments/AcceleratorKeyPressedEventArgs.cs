using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class AcceleratorKeyPressedEventArgs : ICoreWebView2AcceleratorKeyPressedEventArgs
    {
        private ICoreWebView2AcceleratorKeyPressedEventArgs _Args;
        private int _Handled;

        public AcceleratorKeyPressedEventArgs(ICoreWebView2AcceleratorKeyPressedEventArgs args)
        {
            this._Args = args;
        }


        private ICoreWebView2AcceleratorKeyPressedEventArgs ToInterface()
        {
            return _Args;
        }
        public KeyEventType KeyVentType
        {
            get => (KeyEventType)this.ToInterface().KeyEventKind;
        }




        public uint VirtualKey
        {
            get => this.ToInterface().VirtualKey;
        }



        public int KeyEventLParam => this.ToInterface().KeyEventLParam;



        public PhysicalKeyStatus PhysicalKeyStatus => new PhysicalKeyStatus(this.ToInterface().PhysicalKeyStatus);

        public bool Handled
        {
            get { return new CBOOL(_Handled); }
            set
            {
                _Handled = new CBOOL(value);
                this.ToInterface().Handled = _Handled;
            }
        }

        COREWEBVIEW2_KEY_EVENT_KIND ICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventKind => this._Args.KeyEventKind;
        COREWEBVIEW2_PHYSICAL_KEY_STATUS ICoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus => this._Args.PhysicalKeyStatus;

        int ICoreWebView2AcceleratorKeyPressedEventArgs.Handled
        {
            get => this._Args.Handled;
            set => this._Args.Handled = value;
        }

    }
}