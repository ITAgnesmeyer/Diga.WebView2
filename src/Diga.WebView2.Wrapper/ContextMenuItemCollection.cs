using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class ContextMenuItemCollection : ContextMenuItemCollectionInterface
    {

        public ContextMenuItemCollection(ICoreWebView2ContextMenuItemCollection args) : base(args)
        {

        }

        public new WebView2ContextMenuItem GetValueAtIndex(uint index) => new WebView2ContextMenuItem(base.GetValueAtIndex(index));

        public void InsertValueAtIndex(uint index, WebView2ContextMenuItem item)
        {
            ICoreWebView2ContextMenuItem i = item.ToInterface();
            InsertValueAtIndex(index, i);
        }



    }
}