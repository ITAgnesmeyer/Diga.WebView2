using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgsInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs> _Args;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2NewWindowRequestedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(this.Args) + " is null");

                    throw new InvalidOperationException(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }
                return this._Args.Interface;
            }
            set { this._Args = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs>(value); }
        }
        public NewWindowRequestedEventArgsInterface(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        public string uri => this.Args.uri;

        public ICoreWebView2 NewWindow { get => this.Args.NewWindow; set => this.Args.NewWindow = value; }
        public int Handled { get => this.Args.Handled; set => this.Args.Handled = value; }

        public int IsUserInitiated => this.Args.IsUserInitiated;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }

        public ICoreWebView2WindowFeatures WindowFeatures => this.Args.WindowFeatures;

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