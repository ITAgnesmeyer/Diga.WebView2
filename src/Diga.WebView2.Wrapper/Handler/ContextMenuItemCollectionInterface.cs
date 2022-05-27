using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuItemCollectionInterface : ICoreWebView2ContextMenuItemCollection,IDisposable
    {
        private ICoreWebView2ContextMenuItemCollection _Args;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuItemCollection Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(ContextMenuItemCollectionInterface) + "." + nameof(this._Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuItemCollectionInterface) + "." + nameof(this._Args) + " is null");

                }
                return this._Args;
            }
        }

        public ContextMenuItemCollectionInterface(ICoreWebView2ContextMenuItemCollection args)
        {
            if(args == null) throw new ArgumentNullException(nameof(args));
            this._Args = args;
        }
        public uint Count => this.Args.Count;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ContextMenuItem GetValueAtIndex([In] uint index)
        {
            return this.Args.GetValueAtIndex(index);
        }

        public void RemoveValueAtIndex(uint index)
        {
            this.Args.RemoveValueAtIndex(index);
        }

        public void InsertValueAtIndex(uint index, ICoreWebView2ContextMenuItem value)
        {
            this.Args.InsertValueAtIndex(index,value);
        }

        //public  void InsertValueAtIndex(uint index, WebView2ContextMenuItem value)
        //{
        //    this.Args.InsertValueAtIndex(index, value.ToInterface());
        //}

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    //this._Args = null;
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