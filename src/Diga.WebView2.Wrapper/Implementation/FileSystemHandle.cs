using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class FileSystemHandle:IDisposable//, ICoreWebView2FileSystemHandle
    {
        private ComObjectHolder<ICoreWebView2FileSystemHandle> _Iface;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2FileSystemHandle Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(FileSystemHandle) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(FileSystemHandle) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2FileSystemHandle>(value);

        }

        public FileSystemHandle(ICoreWebView2FileSystemHandle iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }
        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                this.handle.Dispose();
                _Iface = null;
                _IsDisposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_KIND Kind => Iface.Kind;

        public string Path => Iface.Path;

        public COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION Permission => Iface.Permission;
    }
}