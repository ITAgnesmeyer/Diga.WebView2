using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgsInterface : ICoreWebView2NewWindowRequestedEventArgs, IDisposable
    {
        private ICoreWebView2NewWindowRequestedEventArgs _Args;
        private bool _IsDisposed;

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