using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class FrameCreatedEventArgs : ICoreWebView2FrameCreatedEventArgs
    {
        private ICoreWebView2FrameCreatedEventArgs _Args;
        public FrameCreatedEventArgs(ICoreWebView2FrameCreatedEventArgs args)
        {
            this._Args = args;
        }
        public Frame Frame => new Frame(((ICoreWebView2FrameCreatedEventArgs)this).Frame);

        ICoreWebView2Frame ICoreWebView2FrameCreatedEventArgs.Frame => this._Args.Frame;
    }
}