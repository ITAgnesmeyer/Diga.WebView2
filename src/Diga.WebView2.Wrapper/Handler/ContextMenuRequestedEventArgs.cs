using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuRequestedEventArgs :ContextMenuRequestedEventArgsInterface
    {
        //private object _obj;

        public ContextMenuRequestedEventArgs(ICoreWebView2ContextMenuRequestedEventArgs args):base(args)
        {
            //this._obj = args;
        }

        public ContextMenuRequestedEventArgs(object obj):this((ICoreWebView2ContextMenuRequestedEventArgs)obj)
        {
            
        }

        public new ContextMenuItemCollection MenuItems => new ContextMenuItemCollection(base.MenuItems);
        public new ContextMenuTarget ContextMenuTarget => new ContextMenuTarget(base.ContextMenuTarget);

        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }

      
    }
}