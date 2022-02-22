using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class PermissionRequestedEventArgsInterface : EventArgs, ICoreWebView2PermissionRequestedEventArgs
    {
        private ICoreWebView2PermissionRequestedEventArgs _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2PermissionRequestedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(PermissionRequestedEventArgsInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(PermissionRequestedEventArgsInterface) + " Args is null");
                }

                return this._Args;
            }
            set
            {
                this._Args = value;
            }
        }
        public PermissionRequestedEventArgsInterface(ICoreWebView2PermissionRequestedEventArgs args)
        {
            this.Args = args;
        }

        public string uri => this.Args.uri;

        public COREWEBVIEW2_PERMISSION_KIND PermissionKind => this.Args.PermissionKind;

        public int IsUserInitiated => this.Args.IsUserInitiated;

        public COREWEBVIEW2_PERMISSION_STATE State { get => this.Args.State; set => this.Args.State = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }

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