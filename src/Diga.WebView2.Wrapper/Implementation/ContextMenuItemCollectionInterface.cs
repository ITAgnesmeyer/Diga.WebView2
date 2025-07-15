using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides methods to interact with a collection of context menu items in WebView2.
    /// </summary>
    public class ContextMenuItemCollectionInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2ContextMenuItemCollection> _Args;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2ContextMenuItemCollection Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(ContextMenuItemCollectionInterface) + "." + nameof(_Args) + " is null");
                    throw new InvalidOperationException(nameof(ContextMenuItemCollectionInterface) + "." + nameof(_Args) + " is null");

                }
                return _Args.Interface;
            }
        }

        public ContextMenuItemCollectionInterface(ICoreWebView2ContextMenuItemCollection args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            _Args = new ComObjectHolder<ICoreWebView2ContextMenuItemCollection>(args);
        }
        /// <summary>
        /// Gets the number of context menu items in the collection.
        /// </summary>
        public uint Count => Args.Count;

        /// <summary>
        /// Gets the context menu item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to retrieve.</param>
        /// <returns>The <see cref="ICoreWebView2ContextMenuItem"/> at the specified index.</returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ContextMenuItem GetValueAtIndex([In] uint index)
        {
            return Args.GetValueAtIndex(index);
        }

        /// <summary>
        /// Removes the context menu item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        public void RemoveValueAtIndex(uint index)
        {
            Args.RemoveValueAtIndex(index);
        }

        /// <summary>
        /// Inserts a context menu item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which to insert the item.</param>
        /// <param name="value">The <see cref="ICoreWebView2ContextMenuItem"/> to insert.</param>
        public void InsertValueAtIndex(uint index, ICoreWebView2ContextMenuItem value)
        {
            Args.InsertValueAtIndex(index, value);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle.Dispose();
                    //this._Args = null;
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