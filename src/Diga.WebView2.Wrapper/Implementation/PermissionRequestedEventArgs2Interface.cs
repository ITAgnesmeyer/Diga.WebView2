using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class PermissionRequestedEventArgs2Interface : PermissionRequestedEventArgsInterface, ICoreWebView2PermissionRequestedEventArgs2
    {
        private ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs2> _Args;
        private ICoreWebView2PermissionRequestedEventArgs2 Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(PermissionRequestedEventArgs2Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(PermissionRequestedEventArgs2Interface) + " Args is null");
                }

                return this._Args.Interface;
            }
            set
            {
                this._Args = new ComObjectHolder<ICoreWebView2PermissionRequestedEventArgs2>(value);
            }
        }
        public PermissionRequestedEventArgs2Interface(ICoreWebView2PermissionRequestedEventArgs2 args):base(args)
        {
            this.Args = args;
        }
        public int Handled { get => this.Args.Handled; set => this.Args.Handled = value; }
        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    
                    
                    this._Args = null;
                }

                this.disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }
}