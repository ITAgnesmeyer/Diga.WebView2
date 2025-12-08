using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ScreenCaptureStartingEventArgs: ScreenCaptureStartingEventArgsInterface
    {
        public ScreenCaptureStartingEventArgs(ICoreWebView2ScreenCaptureStartingEventArgs args) : base(args)
        {
        }
        public new bool Cancel
        {
            get => (CBOOL)base.Cancel;
            set => base.Cancel = (CBOOL)value;
        }
        public new bool Handled
        {
            get => (CBOOL)base.Handled;
            set => base.Handled = (CBOOL)value;
        }
        public WebView2Deferral GetDeferralWrapper()
        {
            var deferral = base.GetDeferral();
            return new WebView2Deferral(deferral);
        }
    }
}