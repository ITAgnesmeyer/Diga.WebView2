using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NewWindowRequestedEventArgs2Interface : NewWindowRequestedEventArgsInterface
    {
        private ComObjectHolder< ICoreWebView2NewWindowRequestedEventArgs2> _Args;
        private ICoreWebView2NewWindowRequestedEventArgs2 Args
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
            set => this._Args = new ComObjectHolder<ICoreWebView2NewWindowRequestedEventArgs2>(value);
        }
        public NewWindowRequestedEventArgs2Interface(ICoreWebView2NewWindowRequestedEventArgs2 args) : base(args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }
        public string name => this.Args.name;

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Args = null;
            }

            this._IsDisposed = true;
            base.Dispose(disposing);
        }
    }
}