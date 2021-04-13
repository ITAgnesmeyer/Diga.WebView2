using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Handler;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceResponseView : ICoreWebView2WebResourceResponseView
    {
        private ICoreWebView2WebResourceResponseView _Interface;
      
        public WebResourceResponseView()
        {
            this._Interface = this.ToInterface();
        }

        public WebResourceResponseView(ICoreWebView2WebResourceResponseView iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2WebResourceResponseView ToInterface()
        {
            return this;
        }

        public int StatusCode => this.ToInterface().StatusCode;
        public string ReasonPhrase => this.ToInterface().ReasonPhrase;

        public void GetContent(WebResourceResponseViewGetContentCompletedHandler handler)
        {
            this.ToInterface().GetContent(handler);
        }

        public HttpResponseHeaders Headers => new HttpResponseHeaders( this.ToInterface().Headers);

        ICoreWebView2HttpResponseHeaders ICoreWebView2WebResourceResponseView.Headers => this._Interface.Headers;

        int ICoreWebView2WebResourceResponseView.StatusCode => this._Interface.StatusCode;

        string ICoreWebView2WebResourceResponseView.ReasonPhrase => this._Interface.ReasonPhrase;

        void ICoreWebView2WebResourceResponseView.GetContent(ICoreWebView2WebResourceResponseViewGetContentCompletedHandler handler)
        {
            this._Interface.GetContent(handler);
        }
    }
}