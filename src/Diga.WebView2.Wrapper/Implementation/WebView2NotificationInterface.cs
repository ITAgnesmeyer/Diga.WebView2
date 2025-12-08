using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2NotificationInterface : IDisposable 
    {
        private ComObjectHolder<ICoreWebView2Notification> _Iface;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Notification Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2NotificationInterface) + "=>" + nameof(Iface) + " is null");
                    throw new InvalidOperationException(nameof(WebView2NotificationInterface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2Notification>(value);
        }
        public WebView2NotificationInterface(ICoreWebView2Notification iface) 
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        public void add_CloseRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NotificationCloseRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Iface.add_CloseRequested(eventHandler, out token);
        }

        public void remove_CloseRequested([In] EventRegistrationToken token)
        {
            Iface.remove_CloseRequested(token);
        }

        public void ReportShown()
        {
            Iface.ReportShown();
        }

        public void ReportClicked()
        {
            Iface.ReportClicked();
        }

        public void ReportClosed()
        {
            Iface.ReportClosed();
        }

        public string Body => Iface.Body;

        public COREWEBVIEW2_TEXT_DIRECTION_KIND Direction => Iface.Direction;

        public string Language => Iface.Language;

        public string Tag => Iface.Tag;

        public string IconUri => Iface.IconUri;

        public string title => Iface.title;

        public string BadgeUri => Iface.BadgeUri;

        public string BodyImageUri => Iface.BodyImageUri;

        public int ShouldRenotify => Iface.ShouldRenotify;

        public int RequiresInteraction => Iface.RequiresInteraction;

        public int IsSilent => Iface.IsSilent;

        public double Timestamp => Iface.Timestamp;

        public void GetVibrationPattern(out uint Count, [Out] IntPtr vibrationPattern)
        {
            Iface.GetVibrationPattern(out Count, vibrationPattern);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    Iface = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2NotificationInterface()
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