using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class DocumentStateChangedEventArgs : IWebView2DocumentStateChangedEventArgs
    {
        private IWebView2DocumentStateChangedEventArgs _Args;

        public DocumentStateChangedEventArgs(IWebView2DocumentStateChangedEventArgs args)
        {
            this._Args = args;
        }

        public bool IsNewDocument => new CBOOL(this._Args.IsNewDocument);
        public bool IsErrorPage => new CBOOL(this._Args.IsErrorPage);
        int IWebView2DocumentStateChangedEventArgs.IsNewDocument => this._Args.IsNewDocument;

        int IWebView2DocumentStateChangedEventArgs.IsErrorPage => this._Args.IsErrorPage;
    }
}