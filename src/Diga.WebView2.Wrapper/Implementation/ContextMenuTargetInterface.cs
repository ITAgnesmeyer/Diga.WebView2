using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides information about the target of a context menu request in WebView2.
    /// </summary>
    public class ContextMenuTargetInterface : IDisposable
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextMenuTargetInterface"/> class.
        /// </summary>
        /// <param name="args">The context menu target arguments.</param>
        /// <exception cref="ArgumentNullException">Thrown when args is null.</exception>
        public ContextMenuTargetInterface(ICoreWebView2ContextMenuTarget args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Gets the kind of context menu target.
        /// </summary>
        public COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind => this.Args.Kind;

        /// <summary>
        /// Gets a value indicating whether the target is editable.
        /// </summary>
        public int IsEditable => this.Args.IsEditable;

        /// <summary>
        /// Gets a value indicating whether the context menu was requested for the main frame.
        /// </summary>
        public int IsRequestedForMainFrame => this.Args.IsRequestedForMainFrame;

        /// <summary>
        /// Gets the URI of the page where the context menu was requested.
        /// </summary>
        public string PageUri => this.Args.PageUri;

        /// <summary>
        /// Gets the URI of the frame where the context menu was requested.
        /// </summary>
        public string FrameUri => this.Args.FrameUri;

        /// <summary>
        /// Gets a value indicating whether the target has a link URI.
        /// </summary>
        public int HasLinkUri => this.Args.HasLinkUri;

        /// <summary>
        /// Gets the link URI if available.
        /// </summary>
        public string LinkUri => this.Args.LinkUri;

        /// <summary>
        /// Gets a value indicating whether the target has link text.
        /// </summary>
        public int HasLinkText => this.Args.HasLinkText;

        /// <summary>
        /// Gets the link text if available.
        /// </summary>
        public string LinkText => this.Args.LinkText;

        /// <summary>
        /// Gets a value indicating whether the target has a source URI.
        /// </summary>
        public int HasSourceUri => this.Args.HasSourceUri;

        /// <summary>
        /// Gets the source URI if available.
        /// </summary>
        public string SourceUri => this.Args.SourceUri;

        /// <summary>
        /// Gets a value indicating whether the target has a selection.
        /// </summary>
        public int HasSelection => this.Args.HasSelection;

        /// <summary>
        /// Gets the selected text if available.
        /// </summary>
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


        /// <summary>
        /// Releases the resources used by the <see cref="ContextMenuTargetInterface"/> instance.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}