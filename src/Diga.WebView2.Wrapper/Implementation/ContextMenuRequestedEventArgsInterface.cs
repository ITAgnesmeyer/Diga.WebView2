using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class ContextMenuRequestedEventArgsInterface : EventArgs, ICoreWebView2ContextMenuRequestedEventArgs, IDisposable
    {
        private ComObjctHolder<ICoreWebView2ContextMenuRequestedEventArgs> _Args;
        private bool disposedValue;
        ///// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        /////             pattern for any type that is not sealed.
        /////             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        //private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuRequestedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(ContextMenuRequestedEventArgs) + "." + nameof(_Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuRequestedEventArgs) + "." + nameof(_Args) + " is null");

                }
                return _Args.Interface;
            }
        }

        public ContextMenuRequestedEventArgsInterface(object args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            _Args =new ComObjctHolder<ICoreWebView2ContextMenuRequestedEventArgs>( args);
        }

        public ICoreWebView2ContextMenuItemCollection MenuItems => Args.MenuItems;

        public ICoreWebView2ContextMenuTarget ContextMenuTarget => Args.ContextMenuTarget;

        public tagPOINT Location => Args.Location;

        public int SelectedCommandId { get => Args.SelectedCommandId; set => Args.SelectedCommandId = value; }
        public int Handled { get => Args.Handled; set => Args.Handled = value; }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return Args.GetDeferral();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //handle.Dispose();
                    //_Args = null;
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