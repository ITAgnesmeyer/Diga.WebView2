using Diga.WebView2.Interop;
using System;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgs2Interface : NewWindowRequestedEventArgsInterface, ICoreWebView2NewWindowRequestedEventArgs2
    {
        private ICoreWebView2NewWindowRequestedEventArgs2 _Args;
        private ICoreWebView2NewWindowRequestedEventArgs2 Args
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
        public NewWindowRequestedEventArgs2Interface(ICoreWebView2NewWindowRequestedEventArgs2 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            _Args = args;
        }
        public string name => Args.name;

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Args = null;
            }
            _IsDisposed = true;
            base.Dispose(disposing);
        }
    }
}