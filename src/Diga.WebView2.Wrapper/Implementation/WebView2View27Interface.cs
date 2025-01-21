using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View27Interface : WebView2View26Interface, ICoreWebView2_27
    {
        private ComObjectHolder<ICoreWebView2_27> _Iface;
        private ICoreWebView2_27 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View27Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View27Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_27>(value);

        }

        public WebView2View27Interface(ICoreWebView2_27 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        public void add_ScreenCaptureStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScreenCaptureStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_ScreenCaptureStarting(eventHandler, out token);
        }

        public void remove_ScreenCaptureStarting([In] EventRegistrationToken token)
        {
            Iface.remove_ScreenCaptureStarting(token);
        }
    }
}
       