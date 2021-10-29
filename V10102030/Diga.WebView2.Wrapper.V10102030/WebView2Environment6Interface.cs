using Diga.WebView2.Interop;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment6Interface:WebView2Environment5Interface,ICoreWebView2Environment6
    {
        private readonly ICoreWebView2Environment6 _Environment6;
        public WebView2Environment6Interface(ICoreWebView2Environment6 environment):base(environment)
        {
            this._Environment6 = environment;
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PrintSettings CreatePrintSettings()
        {
            return _Environment6.CreatePrintSettings();
        }
    }
}