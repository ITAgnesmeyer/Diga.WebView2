using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ContextMenuItemInterface : ICoreWebView2ContextMenuItem
    {
        private ICoreWebView2ContextMenuItem _MenuItem;

        private ICoreWebView2ContextMenuItem MenuItem
        {
            get
            {
                if (this._MenuItem == null)
                {
                    Debug.Print(nameof(WebView2ContextMenuItemInterface) + "=>" + nameof(this._MenuItem) + " is null");

                    throw new InvalidOperationException(nameof(WebView2ContextMenuItemInterface) + "=>" + nameof(this._MenuItem) + " is null");
                }
                return this._MenuItem;
            }
            set
            {
                this._MenuItem = value;
            }
        }
        public WebView2ContextMenuItemInterface(ICoreWebView2ContextMenuItem menuItem)
        {
            if(menuItem == null) throw new ArgumentNullException(nameof(menuItem));
            this._MenuItem = menuItem;
        }

        public string name => this.MenuItem.name;

        public string Label => this.MenuItem.Label;

        public int CommandId => this.MenuItem.CommandId;

        public string ShortcutKeyDescription => this.MenuItem.ShortcutKeyDescription;

        public IStream Icon => this.MenuItem.Icon;

        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind => this.MenuItem.Kind;

        public int IsEnabled { get => this.MenuItem.IsEnabled; set => this.MenuItem.IsEnabled = value; }
        public int IsChecked { get => this.MenuItem.IsChecked; set => this.MenuItem.IsChecked = value; }

        public ICoreWebView2ContextMenuItemCollection Children => this.MenuItem.Children;

        public void add_CustomItemSelected([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CustomItemSelectedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.MenuItem.add_CustomItemSelected(eventHandler, out token);
        }

        public void remove_CustomItemSelected([In] EventRegistrationToken token)
        {
            this.MenuItem.remove_CustomItemSelected(token);
        }
    }
}