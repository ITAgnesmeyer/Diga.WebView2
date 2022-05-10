using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuRequestedEventArgs :EventArgs , ICoreWebView2ContextMenuRequestedEventArgs
    {
        private ICoreWebView2ContextMenuRequestedEventArgs _Args;

        private ICoreWebView2ContextMenuRequestedEventArgs Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ContextMenuRequestedEventArgs) + "." + nameof(this._Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuRequestedEventArgs) + "." + nameof(this._Args) + " is null");

                }
                return this._Args;
            }
        }

        public ContextMenuRequestedEventArgs(ICoreWebView2ContextMenuRequestedEventArgs args)
        {
            if(args == null) throw new ArgumentNullException(nameof(args));
            this._Args = args;
        }

        public ICoreWebView2ContextMenuItemCollection MenuItems => this.Args.MenuItems;

        public ICoreWebView2ContextMenuTarget ContextMenuTarget => this.Args.ContextMenuTarget;

        public tagPOINT Location => this.Args.Location;

        public int SelectedCommandId { get => this.Args.SelectedCommandId; set => this.Args.SelectedCommandId = value; }
        public int Handled { get => this.Args.Handled; set => this.Args.Handled = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return this.Args.GetDeferral();
        }
    }
}