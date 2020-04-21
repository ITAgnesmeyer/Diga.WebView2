using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class ScriptDialogOpeningEventArgs : IWebView2ScriptDialogOpeningEventArgs
    {
        private IWebView2ScriptDialogOpeningEventArgs _Args;

        public ScriptDialogOpeningEventArgs(IWebView2ScriptDialogOpeningEventArgs args)
        {
            this._Args = args;
        }

        private IWebView2ScriptDialogOpeningEventArgs ToInterface()
        {
            return this;
        }

        public string Uri => this.ToInterface().uri;
        public ScriptDialogKind Kind => (ScriptDialogKind) this.ToInterface().Kind;
        public string Message => this.ToInterface().Message;

        public void Accept()
        {
            this.ToInterface().Accept();
        }

        public string DefaultText => this.ToInterface().DefaultText;

        public string ResultText
        {
            get=> this.ToInterface().ResultText;
            set=>this.ToInterface().ResultText = value;

        }

        public Deferral GetDeferral()
        {
            return new Deferral(this.ToInterface().GetDeferral());
        }
        string IWebView2ScriptDialogOpeningEventArgs.uri =>this._Args.uri;

        WEBVIEW2_SCRIPT_DIALOG_KIND IWebView2ScriptDialogOpeningEventArgs.Kind => this._Args.Kind;

        string IWebView2ScriptDialogOpeningEventArgs.Message => this._Args.Message;

        void IWebView2ScriptDialogOpeningEventArgs.Accept()
        {
            this._Args.Accept();
        }

        string IWebView2ScriptDialogOpeningEventArgs.DefaultText => this._Args.DefaultText;

        string IWebView2ScriptDialogOpeningEventArgs.ResultText
        {
            get => this._Args.ResultText; 
            set => this._Args.ResultText = value;
        }

        IWebView2Deferral IWebView2ScriptDialogOpeningEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}