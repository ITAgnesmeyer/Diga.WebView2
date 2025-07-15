using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the BrowserProcessExited event in WebView2.
    /// </summary>
    public class BrowserProcessExitedEventArgsInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2BrowserProcessExitedEventArgs> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public BrowserProcessExitedEventArgsInterface(ICoreWebView2BrowserProcessExitedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2BrowserProcessExitedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(BrowserProcessExitedEventArgsInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(BrowserProcessExitedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2BrowserProcessExitedEventArgs>(value);
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
        /// Gets the kind of exit for the browser process.
        /// </summary>
        public COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind => Iface.BrowserProcessExitKind;

        /// <summary>
        /// Gets the process ID of the exited browser process.
        /// </summary>
        public uint BrowserProcessId => Iface.BrowserProcessId;
    }
}