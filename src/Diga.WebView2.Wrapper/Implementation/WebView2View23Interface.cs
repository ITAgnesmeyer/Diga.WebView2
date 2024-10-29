using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class WebView2View23Interface :WebView2View22Interface //, ICoreWebView2_23
    {
        private ComObjectHolder<ICoreWebView2_23> _Iface;
        private ICoreWebView2_23 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View23Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View23Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_23>(value);
        }
        public WebView2View23Interface(ICoreWebView2_23 iface) : base(iface)
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

        public void PostWebMessageAsJsonWithAdditionalObjects([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ObjectCollectionView additionalObjects)
        {
            Iface.PostWebMessageAsJsonWithAdditionalObjects(webMessageAsJson, additionalObjects);
        }
    }
}