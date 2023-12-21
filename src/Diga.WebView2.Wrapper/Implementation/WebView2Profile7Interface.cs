using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Profile7Interface : WebView2Profile6Interface
    {
        private ComObjectHolder<ICoreWebView2Profile7> _Iface;
        private ICoreWebView2Profile7 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Profile7Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Profile7Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Profile7>(value);
        }
        public WebView2Profile7Interface(ICoreWebView2Profile7 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }

        public void AddBrowserExtension([In, MarshalAs(UnmanagedType.LPWStr)] string extensionFolderPath, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileAddBrowserExtensionCompletedHandler handler)
        {
            this.Iface.AddBrowserExtension(extensionFolderPath, handler);
        }

        public void GetBrowserExtensions([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler)
        {
            this.Iface.GetBrowserExtensions(handler);
        }
    }
}