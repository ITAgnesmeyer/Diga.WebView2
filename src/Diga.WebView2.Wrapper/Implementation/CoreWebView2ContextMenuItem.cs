using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class CoreWebView2ContextMenuItemInterface : ICoreWebView2ContextMenuItem
    {
        private ICoreWebView2ContextMenuItem _ContextMenuItem;
        private ICoreWebView2ContextMenuItem ContextMenuItem
        {
            get
            {
                if (this._ContextMenuItem == null)
                {
                    Debug.Print(nameof(CoreWebView2ContextMenuItemInterface) + "." + nameof(this._ContextMenuItem) + " is null");
                    throw new InvalidOperationException(nameof(CoreWebView2ContextMenuItemInterface) + "." + nameof(this._ContextMenuItem) + " is null");

                }
                return this._ContextMenuItem;
            }
            set { this._ContextMenuItem = value; }
        }

        public CoreWebView2ContextMenuItemInterface(ICoreWebView2ContextMenuItem contextMenuItem)
        {
            if(contextMenuItem == null)
                throw new ArgumentNullException(nameof(contextMenuItem));
            this._ContextMenuItem = contextMenuItem;
        }

        public string name => this.ContextMenuItem.name;

        public string Label => this.ContextMenuItem.Label;

        public int CommandId => this.ContextMenuItem.CommandId;

        public string ShortcutKeyDescription => this.ContextMenuItem.ShortcutKeyDescription;

        public IStream Icon => this.ContextMenuItem.Icon;

        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind => this.ContextMenuItem.Kind;

        public int IsEnabled { get => this.ContextMenuItem.IsEnabled; set => this.ContextMenuItem.IsEnabled = value; }
        public int IsChecked { get => this.ContextMenuItem.IsChecked; set => this.ContextMenuItem.IsChecked = value; }

        public ICoreWebView2ContextMenuItemCollection Children => this.ContextMenuItem.Children;

        public void add_CustomItemSelected([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CustomItemSelectedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.ContextMenuItem.add_CustomItemSelected(eventHandler, out token);
        }

        public void remove_CustomItemSelected([In] EventRegistrationToken token)
        {
            this.ContextMenuItem.remove_CustomItemSelected(token);
        }
    }
}