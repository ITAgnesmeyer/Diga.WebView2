using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Settings6Interface : WebView2Settings5Interface, ICoreWebView2Settings6
    {
        private ICoreWebView2Settings6 _Settings;
        private ICoreWebView2Settings6 Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Settings5Interface) + "." + nameof(Settings) + " is null");

                }
                return _Settings;
            }
            set
            {
                _Settings = value;
            }
        }

        public WebView2Settings6Interface(ICoreWebView2Settings6 settings) : base(settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            _Settings = settings;
        }

        public int IsSwipeNavigationEnabled { get => Settings.IsSwipeNavigationEnabled; set => Settings.IsSwipeNavigationEnabled = value; }
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