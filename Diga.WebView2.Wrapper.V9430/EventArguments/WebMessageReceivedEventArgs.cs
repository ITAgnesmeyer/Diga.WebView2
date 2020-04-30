using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebMessageReceivedEventArgs : EventArgs, ICoreWebView2WebMessageReceivedEventArgs
    {
        private ICoreWebView2WebMessageReceivedEventArgs _Args;

        public WebMessageReceivedEventArgs(ICoreWebView2WebMessageReceivedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebMessageReceivedEventArgs ToInterface()
        {
            return this;
        }

        public string Source => this.ToInterface().Source;
        public string WebMessageAsJson => this.ToInterface().webMessageAsJson;

        public string WebMessageAsString
        {
            get
            {
                string value = this.ToInterface().TryGetWebMessageAsString();
                if (string.IsNullOrEmpty(value)) return "";
                return value;
            }
        }

        string ICoreWebView2WebMessageReceivedEventArgs.Source => this._Args.Source;

        string ICoreWebView2WebMessageReceivedEventArgs.webMessageAsJson => this._Args.webMessageAsJson;

        string ICoreWebView2WebMessageReceivedEventArgs.TryGetWebMessageAsString()
        {
            return this._Args.TryGetWebMessageAsString();
        }
    }
}