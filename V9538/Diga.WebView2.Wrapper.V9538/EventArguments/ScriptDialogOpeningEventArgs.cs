using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ScriptDialogOpeningEventArgs : ICoreWebView2ScriptDialogOpeningEventArgs
    {
        private ICoreWebView2ScriptDialogOpeningEventArgs _Args;

        public ScriptDialogOpeningEventArgs(ICoreWebView2ScriptDialogOpeningEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2ScriptDialogOpeningEventArgs ToInterface()
        {
            return this;
        }

        public string Uri => this.ToInterface().uri;
        public ScriptDialogKind Kind => (ScriptDialogKind)this.ToInterface().Kind;
        public string Message => this.ToInterface().Message;

        public void Accept()
        {
            this.ToInterface().Accept();
        }

        public string DefaultText => this.ToInterface().DefaultText;

        public string ResultText
        {
            get => this.ToInterface().ResultText;
            set => this.ToInterface().ResultText = value;

        }


        string ICoreWebView2ScriptDialogOpeningEventArgs.uri => this._Args.uri;
        COREWEBVIEW2_SCRIPT_DIALOG_KIND ICoreWebView2ScriptDialogOpeningEventArgs.Kind => this._Args.Kind;

        string ICoreWebView2ScriptDialogOpeningEventArgs.Message => this._Args.Message;

        void ICoreWebView2ScriptDialogOpeningEventArgs.Accept()
        {
            this._Args.Accept();
        }

        string ICoreWebView2ScriptDialogOpeningEventArgs.DefaultText => this._Args.DefaultText;

        string ICoreWebView2ScriptDialogOpeningEventArgs.ResultText
        {
            get => this._Args.ResultText;
            set => this._Args.ResultText = value;
        }

        ICoreWebView2Deferral ICoreWebView2ScriptDialogOpeningEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}