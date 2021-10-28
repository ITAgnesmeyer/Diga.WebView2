using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NewWindowRequestedEventArgs : ICoreWebView2NewWindowRequestedEventArgs
    {
        private ICoreWebView2NewWindowRequestedEventArgs _Args;

        public NewWindowRequestedEventArgs(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2NewWindowRequestedEventArgs ToInterface()
        {
            return this._Args;
        }

        public string Uri => this.ToInterface().uri;

        public WebView2View NewWindow
        {
            get
            {
                return new WebView2View((ICoreWebView2_7)this.ToInterface().NewWindow);
            }
            set
            {
                
                this.ToInterface().NewWindow = value;
            }
        }

        public bool Handled
        {
            get => new CBOOL(this.ToInterface().Handled);
            set => this.ToInterface().Handled = new CBOOL(value);
        }

       
        string ICoreWebView2NewWindowRequestedEventArgs.uri => this._Args.uri;

        ICoreWebView2 ICoreWebView2NewWindowRequestedEventArgs.NewWindow
        {
            get => this._Args.NewWindow;
            set => this._Args.NewWindow = value;
        }

        int ICoreWebView2NewWindowRequestedEventArgs.Handled
        {
            get => this._Args.Handled;
            set => this._Args.Handled = value;
        }

        int ICoreWebView2NewWindowRequestedEventArgs.IsUserInitiated => this._Args.IsUserInitiated;

        ICoreWebView2Deferral ICoreWebView2NewWindowRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }

        public ICoreWebView2WindowFeatures WindowFeatures
        {
            get => this._Args.WindowFeatures;
        }
    }
}