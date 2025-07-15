using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    /// <summary>
    /// Provides data for the ContextMenuRequested event in WebView2.
    /// </summary>
    public class ContextMenuRequestedEventArgsInterface : EventArgs, IDisposable
    {
        private ComObjectHolder<ICoreWebView2ContextMenuRequestedEventArgs> _Args;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextMenuRequestedEventArgsInterface"/> class.
        /// </summary>
        /// <param name="args">The native event args implementation.</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="args"/> is null.</exception>
        public ContextMenuRequestedEventArgsInterface(object args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            _Args =new ComObjectHolder<ICoreWebView2ContextMenuRequestedEventArgs>( args);
        }

        /// <summary>
        /// Gets the collection of context menu items.
        /// </summary>
        public ICoreWebView2ContextMenuItemCollection MenuItems => Args.MenuItems;

        /// <summary>
        /// Gets the context menu target information.
        /// </summary>
        public ICoreWebView2ContextMenuTarget ContextMenuTarget => Args.ContextMenuTarget;

        /// <summary>
        /// Gets the location where the context menu was requested.
        /// </summary>
        public tagPOINT Location => Args.Location;

        /// <summary>
        /// Gets or sets the selected command ID.
        /// </summary>
        public int SelectedCommandId { get => Args.SelectedCommandId; set => Args.SelectedCommandId = value; }

        /// <summary>
        /// Gets or sets a value indicating whether the context menu request is handled.
        /// </summary>
        public int Handled { get => Args.Handled; set => Args.Handled = value; }

        /// <summary>
        /// Gets a deferral object to defer the context menu handling decision.
        /// </summary>
        /// <returns>An <see cref="ICoreWebView2Deferral"/> object.</returns>
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


        /// <summary>
        /// Releases the resources used by the <see cref="ContextMenuRequestedEventArgsInterface"/>.
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}