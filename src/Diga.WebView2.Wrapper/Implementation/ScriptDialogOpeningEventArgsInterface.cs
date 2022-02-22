using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ScriptDialogOpeningEventArgsInterface : ICoreWebView2ScriptDialogOpeningEventArgs, IDisposable
    {
        private ICoreWebView2ScriptDialogOpeningEventArgs _Args;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ScriptDialogOpeningEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ScriptDialogOpeningEventArgsInterface) + "=>" + nameof(this.Args) + " is null");

                    throw new InvalidOperationException(nameof(ScriptDialogOpeningEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args;
            }
            set { this._Args = value; }
        }

        public ScriptDialogOpeningEventArgsInterface(ICoreWebView2ScriptDialogOpeningEventArgs args)
        {
            if(args == null)
                throw new ArgumentNullException(nameof(args));
            this._Args= args;
        }
        public string uri => this.Args.uri;

        public COREWEBVIEW2_SCRIPT_DIALOG_KIND Kind => this.Args.Kind;

        public string Message => this.Args.Message;

        public void Accept()
        {
            this.Args.Accept();
        }

        public string DefaultText => this.Args.DefaultText;

        public string ResultText { get => this.Args.ResultText; set => this.Args.ResultText = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDisposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Args = null;
                }

                this._IsDisposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}