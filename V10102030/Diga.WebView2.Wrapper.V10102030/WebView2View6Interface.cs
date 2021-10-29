using Diga.WebView2.Interop;
using System.ComponentModel;

namespace Diga.WebView2.Wrapper
{   
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View6Interface : WebView2View5Interface, ICoreWebView2_6
    {
        private ICoreWebView2_6 _WebView;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View6Interface(ICoreWebView2_6 webView) : base(webView)
        {
            this._WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenTaskManagerWindow()
        {
            _WebView.OpenTaskManagerWindow();
        }
    }
}