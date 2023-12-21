using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;



namespace Diga.WebView2.Wrapper
{
    public class BrowserExtensionList: BrowserExtensionListInterface
    {
        public BrowserExtensionList(ICoreWebView2BrowserExtensionList args):base(args)
        {
            
        }

        public new BrowserExtension GetValueAtIndex(uint index)
        {
            return new BrowserExtension(base.GetValueAtIndex(index));
        }
    }
}