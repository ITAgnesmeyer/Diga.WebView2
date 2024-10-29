using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{





    public class WebMessageReceivedEventArgs : WebMessageReceivedEventArgs2Intefrace  //EventArgs, ICoreWebView2WebMessageReceivedEventArgs,IDisposable
    {
        
        public WebMessageReceivedEventArgs(ICoreWebView2WebMessageReceivedEventArgs2 args):base(args)
        {
            
        }


        public new string Source => base.Source;
        public string WebMessageAsJson => base.webMessageAsJson;

        public string WebMessageAsString
        {
            get
            {
                string value = null;
                try
                {
                    value = base.TryGetWebMessageAsString();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    
                }
                    
                if (string.IsNullOrEmpty(value)) return "";
                return value;
            }
        }


        
        ~WebMessageReceivedEventArgs()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }
    }
}