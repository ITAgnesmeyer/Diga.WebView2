using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{


    /// <summary>
    /// Provides methods and properties to interact with a browser extension in WebView2.
    /// </summary>
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

        /// <summary>
        /// Gets the unique identifier of the browser extension.
        /// </summary>
        public string id => this.Iface.id;

        /// <summary>
        /// Gets the name of the browser extension.
        /// </summary>
        public string name => this.Iface.name;

        /// <summary>
        /// Removes the browser extension asynchronously.
        /// </summary>
        /// <param name="handler">A handler to be called when the remove operation is complete.</param>
        public void Remove([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserExtensionRemoveCompletedHandler handler)
        {
            this.Iface.Remove(handler);
        }

        /// <summary>
        /// Gets a value indicating whether the browser extension is enabled.
        /// </summary>
        public int IsEnabled => this.Iface.IsEnabled;

        /// <summary>
        /// Enables or disables the browser extension asynchronously.
        /// </summary>
        /// <param name="IsEnabled">Set to 1 to enable, 0 to disable.</param>
        /// <param name="handler">A handler to be called when the enable operation is complete.</param>
        public void Enable([In] int IsEnabled, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserExtensionEnableCompletedHandler handler)
        {
            this.Iface.Enable(IsEnabled, handler);
        }

        /// <summary>
        /// Returns the underlying COM interface for advanced scenarios.
        /// </summary>
        /// <returns>The <see cref="ICoreWebView2BrowserExtension"/> interface.</returns>
        public ICoreWebView2BrowserExtension ToInterface() => this.Iface;
    }
}