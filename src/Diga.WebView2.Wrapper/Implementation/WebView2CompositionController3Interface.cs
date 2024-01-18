
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2CompositionController3Interface : WebView2CompositionController2Interface
    {
        private ComObjectHolder<ICoreWebView2CompositionController3> _Iface;
        private ICoreWebView2CompositionController3 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2CompositionController3Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2CompositionController3Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2CompositionController3>(value);
        }
        public WebView2CompositionController3Interface(ICoreWebView2CompositionController3 iface) : base(iface)
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

        

        public uint DragEnter([In, MarshalAs(UnmanagedType.Interface)] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point)
        {
            return Iface.DragEnter(dataObject, keyState, point);
        }

        public void DragLeave()
        {
            Iface.DragLeave();
        }

        public uint DragOver([In] uint keyState, [In] tagPOINT point)
        {
            return Iface.DragOver(keyState, point);
        }

        public uint Drop([In, MarshalAs(UnmanagedType.Interface)] IDataObject dataObject, [In] uint keyState, [In] tagPOINT point)
        {
            return Iface.Drop(dataObject, keyState, point);
        }
    }
}