using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ContextMenuRequestedEventArgs : ContextMenuRequestedEventArgsInterface
    {
        //private object _obj;

        public ContextMenuRequestedEventArgs(ICoreWebView2ContextMenuRequestedEventArgs args) : base(args)
        {
            //this._obj = args;
        }

        //public ContextMenuRequestedEventArgs(object obj):this((ICoreWebView2ContextMenuRequestedEventArgs)obj)
        //{

        //}

        public new ContextMenuItemCollection MenuItems => new ContextMenuItemCollection(base.MenuItems);
        public new ContextMenuTarget ContextMenuTarget => new ContextMenuTarget(base.ContextMenuTarget);

        public new bool Handled
        {
            get => (CBOOL)base.Handled;
            set => base.Handled = (CBOOL)value;
        }

        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }


    }
}