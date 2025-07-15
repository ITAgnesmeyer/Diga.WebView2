using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the DownloadStarting event in WebView2.
    /// </summary>
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
        /// <summary>
        /// Gets the download operation associated with the event.
        /// </summary>
        public ICoreWebView2DownloadOperation DownloadOperation => this.Args.DownloadOperation;

        /// <summary>
        /// Gets or sets a value indicating whether the download should be canceled.
        /// </summary>
        public int Cancel
        {
            get => this.Args.Cancel;
            set => this.Args.Cancel = value;
        }

        /// <summary>
        /// Gets or sets the file path where the download result will be saved.
        /// </summary>
        public string ResultFilePath
        {
            get => this.Args.ResultFilePath;
            set => this.Args.ResultFilePath = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the event is handled.
        /// </summary>
        public int Handled
        {
            get => this.Args.Handled;
            set => this.Args.Handled = value;
        }

        /// <summary>
        /// Gets a deferral object to defer the download starting decision.
        /// </summary>
        /// <returns>An <see cref="ICoreWebView2Deferral"/> object.</returns>
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }
    }
}