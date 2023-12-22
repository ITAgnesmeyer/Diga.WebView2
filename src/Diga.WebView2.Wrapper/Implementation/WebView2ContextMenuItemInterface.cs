using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2ContextMenuItemInterface : IDisposable//, ICoreWebView2ContextMenuItem
    {
        private ComObjectHolder<ICoreWebView2ContextMenuItem> _Iface;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public WebView2ContextMenuItemInterface(ICoreWebView2ContextMenuItem iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private ICoreWebView2ContextMenuItem Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2ContextMenuItemInterface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2ContextMenuItemInterface) + "=>" + nameof(Iface) + " is null");
                }

                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2ContextMenuItem>(value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _Iface = null;
                }

                _IsDesposed = true;
            }
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string name => this.Iface.name;

        public string Label => this.Iface.Label;

        public int CommandId => this.Iface.CommandId;

        public string ShortcutKeyDescription => this.Iface.ShortcutKeyDescription;

        public IStream Icon => this.Iface.Icon;

        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind => this.Iface.Kind;

        public int IsEnabled { get => this.Iface.IsEnabled; set => this.Iface.IsEnabled = value; }
        public int IsChecked { get => this.Iface.IsChecked; set => this.Iface.IsChecked = value; }

        public ICoreWebView2ContextMenuItemCollection Children => this.Iface.Children;

        public void add_CustomItemSelected([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CustomItemSelectedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Iface.add_CustomItemSelected(eventHandler, out token);
        }

        public void remove_CustomItemSelected([In] EventRegistrationToken token)
        {
            this.Iface.remove_CustomItemSelected(token);
        }
    }



    //internal abstract  class WebView2ContextMenuItemInterface : ICoreWebView2ContextMenuItem,IDisposable
    //{

    //    private bool disposedValue;
    //    ///// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
    //    /////             pattern for any type that is not sealed.
    //    /////             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
    //    //private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
    //    protected  abstract  ICoreWebView2ContextMenuItem ContextMenuItem{get;}

    //    //public WebView2ContextMenuItemInterface(ICoreWebView2ContextMenuItem contextMenuItem)
    //    //{
    //    //    if(contextMenuItem == null)
    //    //        throw new ArgumentNullException(nameof(contextMenuItem));
    //    //    this._ContextMenuItem = new ComObjctHolder<ICoreWebView2ContextMenuItem>( contextMenuItem);
    //    //}

    //    public string name => this.ContextMenuItem.name;

    //    public string Label => this.ContextMenuItem.Label;

    //    public int CommandId => this.ContextMenuItem.CommandId;

    //    public string ShortcutKeyDescription => this.ContextMenuItem.ShortcutKeyDescription;

    //    public IStream Icon => this.ContextMenuItem.Icon;

    //    public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind => this.ContextMenuItem.Kind;

    //    public int IsEnabled { get => this.ContextMenuItem.IsEnabled; set => this.ContextMenuItem.IsEnabled = value; }
    //    public int IsChecked { get => this.ContextMenuItem.IsChecked; set => this.ContextMenuItem.IsChecked = value; }

    //    public ICoreWebView2ContextMenuItemCollection Children => this.ContextMenuItem.Children;

    //    public void add_CustomItemSelected([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CustomItemSelectedEventHandler eventHandler, out EventRegistrationToken token)
    //    {
    //        this.ContextMenuItem.add_CustomItemSelected(eventHandler, out token);
    //    }

    //    public void remove_CustomItemSelected([In] EventRegistrationToken token)
    //    {
    //        this.ContextMenuItem.remove_CustomItemSelected(token);
    //    }

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposedValue)
    //        {
    //            if (disposing)
    //            {
    //                //this.handle.Dispose();
    //                //_ContextMenuItem = null;
    //            }


    //            disposedValue = true;
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(disposing: true);
    //        GC.SuppressFinalize(this);
    //    }
    //}
}