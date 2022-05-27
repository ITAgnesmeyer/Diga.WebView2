using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuTarget : ContextMenuTargetInterface
    {
        public ContextMenuTarget(ICoreWebView2ContextMenuTarget args):base(args)
        {
            
        }

        public new bool IsEditable => (CBOOL)base.IsEditable;

        public new bool IsRequestedForMainFrame => (CBOOL)base.IsRequestedForMainFrame;
        public new bool HasLinkUri => (CBOOL)base.HasLinkUri;

        public new bool HasLinkText => (CBOOL)base.HasLinkText; 

        public new bool HasSourceUri => (CBOOL)base.HasSourceUri;

        public new bool HasSelection => (CBOOL)base.HasSelection;
    }
}