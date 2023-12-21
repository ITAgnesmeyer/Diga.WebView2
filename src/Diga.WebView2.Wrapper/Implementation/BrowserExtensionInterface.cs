using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{


    public class BrowserExtensionInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2BrowserExtension> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public BrowserExtensionInterface(ICoreWebView2BrowserExtension iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2BrowserExtension Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(BrowserExtensionInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(BrowserExtensionInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2BrowserExtension>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Iface = null;
                }

                _IsDesposed = true;
            }
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string id => this.Iface.id;

        public string name => this.Iface.name;

        public void Remove([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserExtensionRemoveCompletedHandler handler)
        {
            this.Iface.Remove(handler);
        }

        public int IsEnabled => this.Iface.IsEnabled;

        public void Enable([In] int IsEnabled, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserExtensionEnableCompletedHandler handler)
        {
            this.Iface.Enable(IsEnabled, handler);
        }

        public ICoreWebView2BrowserExtension ToInterface() => this.Iface;
    }
}