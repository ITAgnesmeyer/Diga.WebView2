using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2ContextMenuItem : WebView2ContextMenuItemInterface
    {
        public WebView2ContextMenuItem(ICoreWebView2ContextMenuItem menuItem) : base(menuItem)
        {

        }

    }
}