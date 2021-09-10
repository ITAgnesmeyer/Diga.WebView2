using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NewWindowRequestedEventArgs : IWebView2NewWindowRequestedEventArgs
    {
        private IWebView2NewWindowRequestedEventArgs _Args;

        public NewWindowRequestedEventArgs(IWebView2NewWindowRequestedEventArgs args)
        {
            this._Args = args;
        }

        private IWebView2NewWindowRequestedEventArgs ToInterface()
        {
            return this._Args;
        }

        public string Uri => this.ToInterface().uri;

        public WebView2View NewWindow
        {
            get
            {
                return new WebView2View((IWebView2WebView5)this.ToInterface().NewWindow);
            }
            set
            {
                IWebView2WebView webView = value;
                this.ToInterface().NewWindow = webView;
            }
        }

        public bool Handled
        {
            get => new CBOOL(this.ToInterface().handled);
            set => this.ToInterface().handled = new CBOOL(value);
        }

        string IWebView2NewWindowRequestedEventArgs.uri => this._Args.uri;

       

        IWebView2WebView IWebView2NewWindowRequestedEventArgs.NewWindow
        {
            get => this._Args.NewWindow;
            set => this._Args.NewWindow = value;
        }

        int IWebView2NewWindowRequestedEventArgs.handled
        {
            get => this._Args.handled;
            set => this._Args.handled = value;
        }

        int IWebView2NewWindowRequestedEventArgs.IsUserInitiated => this._Args.IsUserInitiated;

        IWebView2Deferral IWebView2NewWindowRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}