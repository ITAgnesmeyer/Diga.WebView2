using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebMessageReceivedEventArgs : EventArgs, IWebView2WebMessageReceivedEventArgs
    {
        private IWebView2WebMessageReceivedEventArgs _Args;

        public WebMessageReceivedEventArgs(IWebView2WebMessageReceivedEventArgs args)
        {
            this._Args = args;
        }

        private IWebView2WebMessageReceivedEventArgs ToInterface()
        {
            return this;
        }

        public string Source => this.ToInterface().Source;
        public string WebMessageAsJson => this.ToInterface().webMessageAsJson;
        
        public string WebMessageAsString => this.ToInterface().webMessageAsString;
        string IWebView2WebMessageReceivedEventArgs.Source => this._Args.Source;

        string IWebView2WebMessageReceivedEventArgs.webMessageAsJson => this._Args.webMessageAsJson;

        string IWebView2WebMessageReceivedEventArgs.webMessageAsString => this._Args.webMessageAsString;
    }
}