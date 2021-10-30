using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings6Interface:WebView2Settings5Interface,ICoreWebView2Settings6
    {
        private  ICoreWebView2Settings6 _Settings;
        public WebView2Settings6Interface(ICoreWebView2Settings6 settings):base(settings)
        {
            this._Settings = settings;
        }

        public int IsSwipeNavigationEnabled { get => _Settings.IsSwipeNavigationEnabled; set => _Settings.IsSwipeNavigationEnabled = value; }

          protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Settings = null;
            }
                

            base.Dispose(disposing);
        }
    }
}