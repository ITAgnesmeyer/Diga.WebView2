using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings3Interface : WebView2Settings2Interface, ICoreWebView2Settings3
    {
        private ICoreWebView2Settings3 _Settings;
        private ICoreWebView2Settings3 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings3Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings3Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }
        public WebView2Settings3Interface(ICoreWebView2Settings3 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
            _Settings = settings;
        }

        public int AreBrowserAcceleratorKeysEnabled { get => Settings.AreBrowserAcceleratorKeysEnabled; set => Settings.AreBrowserAcceleratorKeysEnabled = value; }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Settings = null;
                _IsDisposed = true;
            }


            base.Dispose(disposing);
        }
    }
}