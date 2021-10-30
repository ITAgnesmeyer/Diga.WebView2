using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings4Interface : WebView2Settings3Interface, ICoreWebView2Settings4
    {
        private  ICoreWebView2Settings4 _Settings;
        public WebView2Settings4Interface(ICoreWebView2Settings4 settings) : base(settings)
        {
            this._Settings = settings;
        }

        public int IsPasswordAutosaveEnabled { get => _Settings.IsPasswordAutosaveEnabled; set => _Settings.IsPasswordAutosaveEnabled = value; }
        public int IsGeneralAutofillEnabled { get => _Settings.IsGeneralAutofillEnabled; set => _Settings.IsGeneralAutofillEnabled = value; }

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