using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class DownloadStartingEventArgsInterface //: ICoreWebView2DownloadStartingEventArgs
    {
        private ComObjectHolder< ICoreWebView2DownloadStartingEventArgs> _Args;

        private ICoreWebView2DownloadStartingEventArgs Args
        {
            get => this._Args.Interface;
            set => this._Args = new ComObjectHolder<ICoreWebView2DownloadStartingEventArgs>(value);
        }
        public DownloadStartingEventArgsInterface(ICoreWebView2DownloadStartingEventArgs args)
        {
            this.Args = args;
        }
        public ICoreWebView2DownloadOperation DownloadOperation => this.Args.DownloadOperation;

        public int Cancel
        {
            get => this.Args.Cancel;
            set => this.Args.Cancel = value;
        }

        public string ResultFilePath
        {
            get => this.Args.ResultFilePath;
            set => this.Args.ResultFilePath = value;
        }

        public int Handled
        {
            get => this.Args.Handled;
            set => this.Args.Handled = value;
        }

        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }
    }
}