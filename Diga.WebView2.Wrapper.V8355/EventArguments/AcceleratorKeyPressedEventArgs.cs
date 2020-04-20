using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class AcceleratorKeyPressedEventArgs : IWebView2AcceleratorKeyPressedEventArgs
    {
        private IWebView2AcceleratorKeyPressedEventArgs _Args;

        public AcceleratorKeyPressedEventArgs(IWebView2AcceleratorKeyPressedEventArgs args)
        {
            this._Args = args;
        }
        WEBVIEW2_KEY_EVENT_TYPE IWebView2AcceleratorKeyPressedEventArgs.KeyEventType
        {
            get => this._Args.KeyEventType;

        }

        private IWebView2AcceleratorKeyPressedEventArgs ToInterface()
        {
            return this;
        }
        public KeyEventType KeyVentType
        {
            get => (KeyEventType) this.ToInterface().KeyEventType;
        }

        uint IWebView2AcceleratorKeyPressedEventArgs.VirtualKey
        {
            get => this._Args.VirtualKey;

        }

        public uint VirtualKey
        {
            get => this.ToInterface().VirtualKey;
        }

        int IWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam
        {
            get => this._Args.KeyEventLParam;

        }

        public int KeyEventLParam => this.ToInterface().KeyEventLParam;
        WEBVIEW2_PHYSICAL_KEY_STATUS IWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus
        {
            get => this._Args.PhysicalKeyStatus;

        }


        public PhysicalKeyStatus PhysicalKeyStatus => new PhysicalKeyStatus(this.ToInterface().PhysicalKeyStatus);

        void IWebView2AcceleratorKeyPressedEventArgs.Handle(int handled)
        {
            this._Args.Handle(handled);
        }
    }
}