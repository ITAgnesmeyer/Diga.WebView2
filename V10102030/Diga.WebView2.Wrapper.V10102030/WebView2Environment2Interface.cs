using Diga.WebView2.Interop;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment2Interface:WebView2EnvironmentInterface,ICoreWebView2Environment2
    {
        private  ICoreWebView2Environment2 _Environment2;
        public WebView2Environment2Interface(ICoreWebView2Environment2 environment):base(environment)
        {
            this._Environment2 = environment;
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceRequest CreateWebResourceRequest([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In, MarshalAs(UnmanagedType.LPWStr)] string Method, [In, MarshalAs(UnmanagedType.Interface)] IStream postData, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return _Environment2.CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Environment2 = null;
            }
            base.Dispose(disposing);
        }
    }
}