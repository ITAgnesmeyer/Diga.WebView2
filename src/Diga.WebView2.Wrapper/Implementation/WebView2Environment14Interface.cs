using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment14Interface : WebView2Environment13Interface, ICoreWebView2Environment14
    {
        private ComObjectHolder<ICoreWebView2Environment14> _Iface;
        private ICoreWebView2Environment14 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2Environment14Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2Environment14Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Environment14>(value);
        }
        public WebView2Environment14Interface(ICoreWebView2Environment14 iface) : base(iface)
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

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2FileSystemHandle CreateWebFileSystemFileHandle([In, MarshalAs(UnmanagedType.LPWStr)] string Path, [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission)
        {
            return Iface.CreateWebFileSystemFileHandle(Path, Permission);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2FileSystemHandle CreateWebFileSystemDirectoryHandle([In, MarshalAs(UnmanagedType.LPWStr)] string Path, [In] COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission)
        {
            return Iface.CreateWebFileSystemDirectoryHandle(Path, Permission);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ObjectCollection CreateObjectCollection([In] uint length, [In, MarshalAs(UnmanagedType.IUnknown)] ref object items)
        {
            return Iface.CreateObjectCollection(length, ref items);
        }
    }
}