using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebMessageReceivedEventArgs : EventArgs, ICoreWebView2WebMessageReceivedEventArgs,IDisposable
    {
        private ICoreWebView2WebMessageReceivedEventArgs _Args;
        private bool disposedValue;

        public WebMessageReceivedEventArgs(ICoreWebView2WebMessageReceivedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebMessageReceivedEventArgs ToInterface()
        {
            return _Args;
        }

        public string Source => this.ToInterface().Source;
        public string WebMessageAsJson => this.ToInterface().webMessageAsJson;

        public string WebMessageAsString
        {
            get
            {
                string value = null;
                try
                {
                    value = this.ToInterface().TryGetWebMessageAsString();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    
                }
                    
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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }

                this._Args = null;
            
                disposedValue = true;
            }
        }

        
        ~WebMessageReceivedEventArgs()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        public void Dispose()
        {
           
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}