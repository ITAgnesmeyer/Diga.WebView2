﻿using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{


    public class WebResourceResponse : WebResourceResponseInterface
    {
        //public WebResourceResponse()
        //{
        //    this._Interface = this.ToInterface();
        //}
        public WebResourceResponse(ICoreWebView2WebResourceResponse iface):base(iface)
        {
        }




        public new Stream Content
        {
            get
            {
                if (base.Content == null) return null;
                return new ComStream(base.Content);
            }
        }

        public new int StatusCode => base.StatusCode;

        public new string ReasonPhrase
        {
            get => base.ReasonPhrase;
            set => base.ReasonPhrase = value;
        }





        public new HttpResponseHeaders Headers
        {
            get
            {
                if (base.Headers == null) return null;
                return new HttpResponseHeaders(base.Headers);
            }
        }


        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponse()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

    }
}