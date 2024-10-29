using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View25Interface : WebView2View24Interface //, ICoreWebView2_25
    {
        private ComObjectHolder<ICoreWebView2_25> _Iface;
        private ICoreWebView2_25 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View25Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View25Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_25>(value);
        }
        public WebView2View25Interface(ICoreWebView2_25 iface) : base(iface)
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

        public void add_SaveAsUIShowing([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SaveAsUIShowingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_SaveAsUIShowing(eventHandler, out token);
        }

        public void remove_SaveAsUIShowing([In] EventRegistrationToken token)
        {
            Iface.remove_SaveAsUIShowing(token);
        }

        public void ShowSaveAsUI([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ShowSaveAsUICompletedHandler handler)
        {
            Iface.ShowSaveAsUI(handler);
        }
    }
}
       