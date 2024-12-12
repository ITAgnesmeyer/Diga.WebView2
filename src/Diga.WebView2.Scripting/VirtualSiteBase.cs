using Diga.WebView2.Interop;
using Diga.WebView2.Scripting.DOM;
using System;
using System.Collections.Concurrent;

namespace Diga.WebView2.Scripting
{
    public class ResourceVirtualSite : VirtualSiteBase
    {
        public ResourceVirtualSite(IWebViewControl webViewControl, string query) : base(webViewControl, "diga://resources/control.html", query)
        {
        }

    }
    public class VirtualSiteBase
    {
        private IWebViewControl _WebViewControl;
        private string _BaseUrl;
        private string _Query;
        private bool _IsLoaded;
        //hier muss eventuell eine ConcurrentList verwendet werden
        protected ConcurrentStack<DOMElement> _Elements = new ConcurrentStack<DOMElement>();
        //private object _Lock = new object();
        public VirtualSiteBase(IWebViewControl webViewControl, string baseUrl, string query)
        {
            this._WebViewControl = webViewControl;
            this._BaseUrl = baseUrl;
            this._Query = query;
            this._WebViewControl.DocumentLoading += WebViewControlOnDocumentLoading;


        }

        protected DOMDocument GetDOMDocument()
        {
            return new DOMDocument(this._WebViewControl);
        }
        protected DOMWindow GetDOMWindow()
        {
            return new DOMWindow(this._WebViewControl);
        }

        protected DOMConsole GetDOMConsole()
        {
            return new DOMConsole(this._WebViewControl);
        }


        private void WebViewControlOnDocumentUnload(object sender, EventArgs e)
        {
            this._WebViewControl.DocumentUnload -= WebViewControlOnDocumentUnload;
            this._IsLoaded = false;
            OnDocumentUnload();
            

        }

        private void OnDocumentUnload()
        {
            
            while(this._Elements.TryPop(out DOMElement element))
            {
                element.Dispose();
            }





        }

        private void WebViewControlOnDocumentLoading(object sender, EventArgs e)
        {
            ScriptContext.Run(OnDocumentLoading);
        }

        private void OnDocumentLoading()
        {
            DOMResultString result = GetDOMDocument().URL;
            Uri uri = new Uri(result.Result);
            string urlNoQuery = uri.GetLeftPart(UriPartial.Path);
            string query = uri.Query.Replace("?", "");
            if (this._BaseUrl == urlNoQuery && this._Query == query)
            {
                if (this._IsLoaded)
                    OnDocumentUnload();

                OnSiteLoaded();
                this._WebViewControl.DocumentUnload += WebViewControlOnDocumentUnload;
            }
        }



        private void OnSiteLoaded()
        {
           
                OnInitialize();
                this._IsLoaded = true;
            
        }
        protected virtual void OnInitialize()
        {

        }
    }
}
