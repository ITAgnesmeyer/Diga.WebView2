using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ContextMenuTargetInterface : ICoreWebView2ContextMenuTarget, IDisposable
    {
        private ComObjctHolder<ICoreWebView2ContextMenuTarget> _Args;
        
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuTarget Args
        {
            get
            {
                //if (_Args == null)
                //{
                //    Debug.Print(nameof(ContextMenuTargetInterface) + "." + nameof(_Args) + " is null");
                //    throw new InvalidOperationException(nameof(ContextMenuTargetInterface) + "." + nameof(_Args) + " is null");

                //}
                return  _Args.Interface;
            }
        }

        public ContextMenuTargetInterface(ICoreWebView2ContextMenuTarget args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));


            _Args = new ComObjctHolder<ICoreWebView2ContextMenuTarget>(args);
        }

        public COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind => Args.Kind;

        public int IsEditable => Args.IsEditable;

        public int IsRequestedForMainFrame => Args.IsRequestedForMainFrame;

        public string PageUri => Args.PageUri;

        public string FrameUri => Args.FrameUri;

        public int HasLinkUri => Args.HasLinkUri;

        public string LinkUri => Args.LinkUri;

        public int HasLinkText => Args.HasLinkText;

        public string LinkText => Args.LinkText;

        public int HasSourceUri => Args.HasSourceUri;

        public string SourceUri => Args.SourceUri;

        public int HasSelection => Args.HasSelection;

        public string SelectionText => Args.SelectionText;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Args = null;
                }


                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}