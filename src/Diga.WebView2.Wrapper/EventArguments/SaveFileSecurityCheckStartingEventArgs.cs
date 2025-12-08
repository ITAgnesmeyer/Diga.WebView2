using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class SaveFileSecurityCheckStartingEventArgs: SaveFileSecurityCheckStartingEventArgsInterface
    {
        public SaveFileSecurityCheckStartingEventArgs(ICoreWebView2SaveFileSecurityCheckStartingEventArgs args) : base(args)
        {
        }
        public new bool CancelSave
        {
            get => (CBOOL)base.CancelSave;
            set => base.CancelSave = (CBOOL)value;
        }
        public new bool SuppressDefaultPolicy
        {
            get => (CBOOL)base.SuppressDefaultPolicy;
            set => base.SuppressDefaultPolicy = (CBOOL)value;
        }
        public WebView2Deferral GetDeferralWrapper()
        {
            var deferral = base.GetDeferral();
            return new WebView2Deferral(deferral);
        }
    }
}