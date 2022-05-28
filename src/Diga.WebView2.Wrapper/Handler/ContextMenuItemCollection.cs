using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuItemCollection : ContextMenuItemCollectionInterface
    {
        
        public ContextMenuItemCollection(ICoreWebView2ContextMenuItemCollection args):base(args)
        {
            
        }

        public new WebView2ContextMenuItem GetValueAtIndex(uint index) => new WebView2ContextMenuItem( base.GetValueAtIndex(index));

        public void InsertValueAtIndex(uint index, WebView2ContextMenuItem item)
        {
            ICoreWebView2ContextMenuItem i = item.ToInterface();
            base.InsertValueAtIndex(index,i);
        }
            


    }
}