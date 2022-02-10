using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ProcessFailedEventArgsInterface : EventArgs, ICoreWebView2ProcessFailedEventArgs, IDisposable
    {
        private ICoreWebView2ProcessFailedEventArgs _Args;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        
        private ICoreWebView2ProcessFailedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ProcessFailedEventArgsInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(ProcessFailedEventArgsInterface) + " Args is null");
                }

                return this._Args;
            }
            set
            {
                this._Args = value;
            }
        }

        public ProcessFailedEventArgsInterface(ICoreWebView2ProcessFailedEventArgs args)
        {
            this.Args = args;

        }
        public COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind => this.Args.ProcessFailedKind;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Args = null;
                }

                this.disposedValue = true;
            }
        }

       

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}