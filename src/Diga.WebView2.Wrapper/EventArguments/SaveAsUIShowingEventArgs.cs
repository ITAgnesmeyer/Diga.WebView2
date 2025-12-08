using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class SaveAsUIShowingEventArgs : SaveAsUIShowingEventArgsInterface
    {
        public SaveAsUIShowingEventArgs(ICoreWebView2SaveAsUIShowingEventArgs args) : base(args)
        {
        }

        public new bool AllowReplace
        {
            get => (CBOOL)base.AllowReplace;
            set => base.AllowReplace = (CBOOL)value;
        }

        public new bool Cancel
        {
            get => (CBOOL)base.Cancel;
            set => base.Cancel = (CBOOL)value;
        }

        public new bool SuppressDefaultDialog
        {
            get => (CBOOL)base.SuppressDefaultDialog;
            set => base.SuppressDefaultDialog = (CBOOL)value;
        }

        public WebView2Deferral GetDeferralWrapper()
        {
            var deferral = base.GetDeferral();
            return new WebView2Deferral(deferral);
        }
    }
}