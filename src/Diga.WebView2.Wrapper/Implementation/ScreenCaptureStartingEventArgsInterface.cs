using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    //ICoreWebView2ScreenCaptureStartingEventArgs
    public class ScreenCaptureStartingEventArgsInterface : EventArgs, IDisposable, ICoreWebView2ScreenCaptureStartingEventArgs
    { 
        private ComObjectHolder<ICoreWebView2ScreenCaptureStartingEventArgs> _Args;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        private bool disposedValue;

        public ICoreWebView2ScreenCaptureStartingEventArgs Args
        {
            get
            {
                if(this._Args==null)
                {
                    Debug.Print(nameof(ScreenCaptureStartingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                    throw new InvalidOperationException(nameof(ScreenCaptureStartingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args.Interface;
            }
            set { this._Args = new ComObjectHolder<ICoreWebView2ScreenCaptureStartingEventArgs>(value); }
        }

        public ScreenCaptureStartingEventArgsInterface(ICoreWebView2ScreenCaptureStartingEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }

        public int Cancel { get => Args.Cancel; set => Args.Cancel = value; }
        public int Handled { get => Args.Handled; set => Args.Handled = value; }

        public ICoreWebView2FrameInfo OriginalSourceFrameInfo => Args.OriginalSourceFrameInfo;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    Args = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~ScreenCaptureStartingEventArgsInterface()
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