using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings5Interface:WebView2Settings4Interface,ICoreWebView2Settings5
    {
        private readonly ICoreWebView2Settings5 _Settings;
        public WebView2Settings5Interface(ICoreWebView2Settings5 settings):base(settings)
        {
            this._Settings = settings;
        }

        public int IsPinchZoomEnabled { get => _Settings.IsPinchZoomEnabled; set => _Settings.IsPinchZoomEnabled = value; }
    }
}