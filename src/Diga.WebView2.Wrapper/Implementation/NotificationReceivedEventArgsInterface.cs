using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{

    //ICoreWebView2NotificationReceivedEventArgs
    public class NotificationReceivedEventArgsInterface : EventArgs, IDisposable
    {

        private ComObjectHolder<ICoreWebView2NotificationReceivedEventArgs> _Iface;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2NotificationReceivedEventArgs Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(NotificationReceivedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                    throw new InvalidOperationException(nameof(NotificationReceivedEventArgsInterface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2NotificationReceivedEventArgs>(value);

        }

        public NotificationReceivedEventArgsInterface(ICoreWebView2NotificationReceivedEventArgs iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        public string SenderOrigin => Iface.SenderOrigin;

        public ICoreWebView2Notification Notification => Iface.Notification;

        public int Handled { get => Iface.Handled; set => Iface.Handled = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Iface.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    handle.Dispose();
                    Iface = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~NotificationReceivedEventArgsInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

}