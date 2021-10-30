using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings3Interface : WebView2Settings2Interface, ICoreWebView2Settings3
    {
        private  ICoreWebView2Settings3 _Settings;
        public WebView2Settings3Interface(ICoreWebView2Settings3 settings) : base(settings)
        {
            this._Settings = settings;
        }

        public int AreBrowserAcceleratorKeysEnabled { get => _Settings.AreBrowserAcceleratorKeysEnabled; set => _Settings.AreBrowserAcceleratorKeysEnabled = value; }
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