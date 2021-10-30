using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings2Interface : WebView2SettingsInterface, ICoreWebView2Settings2
    {
        private  ICoreWebView2Settings2 _Settings;
        public WebView2Settings2Interface(ICoreWebView2Settings2 settings) : base(settings)
        {
            this._Settings = settings;
        }

        public string UserAgent { get => _Settings.UserAgent; set => _Settings.UserAgent = value; }

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