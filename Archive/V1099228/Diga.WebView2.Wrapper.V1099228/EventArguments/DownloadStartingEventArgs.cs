using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class DownloadStartingEventArgs : ICoreWebView2DownloadStartingEventArgs
    {
        private ICoreWebView2DownloadStartingEventArgs _Args;

        public DownloadStartingEventArgs(ICoreWebView2DownloadStartingEventArgs args)
        {
            this._Args = args;
        }
        public ICoreWebView2DownloadOperation DownloadOperation => this._Args.DownloadOperation;

        public int Cancel
        {
            get => this._Args.Cancel;
            set => this._Args.Cancel = value;
        }

        public string ResultFilePath
        {
            get => this._Args.ResultFilePath;
            set => this._Args.ResultFilePath = value;
        }

        public int Handled
        {
            get => this._Args.Handled;
            set => this._Args.Handled = value;
        }

        public ICoreWebView2Deferral GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}