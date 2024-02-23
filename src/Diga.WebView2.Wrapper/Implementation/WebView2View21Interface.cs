using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View21Interface : WebView2View20Interface //, ICoreWebView2_21
    {
        private ComObjectHolder<ICoreWebView2_21> _Iface;
        private ICoreWebView2_21 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View21Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View21Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_21>(value);
        }
        public WebView2View21Interface(ICoreWebView2_21 iface) : base(iface)
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

        public void ExecuteScriptWithResult([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptWithResultCompletedHandler handler)
        {
            Iface.ExecuteScriptWithResult(javaScript, handler);
        }
    }
}