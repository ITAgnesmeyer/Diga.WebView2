using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CursorChangedEventArgs : EventArgs
    {
        public WebView2CompositionController CompositionController { get; }
        public object Args { get; }

        public CursorChangedEventArgs(WebView2CompositionController controller, object args)
        {
            this.CompositionController = controller;
            this.Args = args;
        }
    }
}