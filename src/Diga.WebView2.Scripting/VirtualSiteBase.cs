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
        private Guid TransactionId = Guid.Empty;
        public VirtualSiteBase(IWebViewControl webViewControl, string baseUrl, string query)
        {
            this._WebViewControl = webViewControl;
            this._BaseUrl = baseUrl;
            this._Query = query;
            this._WebViewControl.DocumentLoading += WebViewControlOnDocumentLoading;


        }
        private DOMDocument _Document;
        protected DOMDocument GetDOMDocument()
        {
            if (_Document == null)
                _Document = new DOMDocument(this._WebViewControl);

            return _Document;
        }
        private DOMWindow _Window;
        protected DOMWindow GetDOMWindow()
        {
            if(_Window == null)
                _Window = new DOMWindow(this._WebViewControl);
            return _Window;
        }
        private DOMConsole _Console;
        protected DOMConsole GetDOMConsole()
        {
            if(_Console == null)
                _Console= new DOMConsole(this._WebViewControl);
            return _Console;
        }


        private void WebViewControlOnDocumentUnload(object sender, EventArgs e)
        {
            this._WebViewControl.DocumentUnload -= WebViewControlOnDocumentUnload;
            this._IsLoaded = false;
            OnDocumentUnload();
            

        }

        private void OnDocumentUnload()
        {
            
            //while(this._Elements.TryPop(out DOMElement element))
            //{
            //    element.Dispose();
            //}
            //_Console?.Dispose();
            //_Document?.Dispose();
            //_Window?.Dispose();
            DOMGC.CommitTransaction(TransactionId);



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
                TransactionId = DOMGC.BeginTransaction();
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
