using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class DOMContentLoadedEventArgs : ICoreWebView2DOMContentLoadedEventArgs
    {
        private ICoreWebView2DOMContentLoadedEventArgs _Args;

        public DOMContentLoadedEventArgs(ICoreWebView2DOMContentLoadedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2DOMContentLoadedEventArgs ToInterface()
        {
            return this._Args;
        }

        public ulong NavigationId => this.ToInterface().NavigationId;
    }
}