﻿using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgsInterface : ICoreWebView2NewWindowRequestedEventArgs, IDisposable
    {
        private ICoreWebView2NewWindowRequestedEventArgs _Args;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2NewWindowRequestedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NewWindowRequestedEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }
                return _Args;
            }
            set { _Args = value; }
        }
        public NewWindowRequestedEventArgsInterface(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            _Args = args;
        }
        public string uri => Args.uri;

        public ICoreWebView2 NewWindow { get => Args.NewWindow; set => Args.NewWindow = value; }
        public int Handled { get => Args.Handled; set => Args.Handled = value; }

        public int IsUserInitiated => Args.IsUserInitiated;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        public ICoreWebView2WindowFeatures WindowFeatures => _Args.WindowFeatures;

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    _Args = null;
                }

                _IsDisposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}