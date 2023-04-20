using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{


    public class NewWindowRequestedEventArgs : NewWindowRequestedEventArgs2Interface
    {
        

        public NewWindowRequestedEventArgs(ICoreWebView2NewWindowRequestedEventArgs2 args):base(args)
        {
           
        }

        public new WebView2View NewWindow
        {
            get
            {
                return new WebView2View((ICoreWebView2_17)base.NewWindow);
            }
            set
            {
                
                base.NewWindow = value.GetInterface();
            }
        }

        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }

    }
}