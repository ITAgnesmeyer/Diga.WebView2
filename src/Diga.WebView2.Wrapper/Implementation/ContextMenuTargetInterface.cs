using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ContextMenuTargetInterface :IDisposable//, ICoreWebView2ContextMenuTarget
    {
        private ComObjectHolder<ICoreWebView2ContextMenuTarget> _Args;
        
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuTarget Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(ContextMenuTargetInterface) + "." + nameof(_Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuTargetInterface) + "." + nameof(_Args) + " is null");

                }
                return this._Args.Interface;
            }
            set => this._Args = new ComObjectHolder<ICoreWebView2ContextMenuTarget>(value);
        }

        public ContextMenuTargetInterface(ICoreWebView2ContextMenuTarget args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }

        public COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind => this.Args.Kind;

        public int IsEditable => this.Args.IsEditable;

        public int IsRequestedForMainFrame => this.Args.IsRequestedForMainFrame;

        public string PageUri => this.Args.PageUri;

        public string FrameUri => this.Args.FrameUri;

        public int HasLinkUri => this.Args.HasLinkUri;

        public string LinkUri => this.Args.LinkUri;

        public int HasLinkText => this.Args.HasLinkText;

        public string LinkText => this.Args.LinkText;

        public int HasSourceUri => this.Args.HasSourceUri;

        public string SourceUri => this.Args.SourceUri;

        public int HasSelection => this.Args.HasSelection;

        public string SelectionText => this.Args.SelectionText;

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