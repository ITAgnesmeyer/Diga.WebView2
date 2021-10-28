using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class CompositionControllerCompletedEventArgs : EventArgs
    {
        public WebView2CompositionController CompositionController { get; }
        public int ErrorCode { get; }

        public CompositionControllerCompletedEventArgs(int errCode, WebView2CompositionController controller)
        {
            this.CompositionController = controller;
            this.ErrorCode = errCode;
        }
    }
}