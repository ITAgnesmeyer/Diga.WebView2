using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NewWindowRequestedEventArgs2Interface:NewWindowRequestedEventArgsInterface,ICoreWebView2NewWindowRequestedEventArgs2
    {
        private ICoreWebView2NewWindowRequestedEventArgs2 _Args;
        public NewWindowRequestedEventArgs2Interface(ICoreWebView2NewWindowRequestedEventArgs2 args):base(args)
        {
            this._Args = args;
        }
        public string name => _Args.name;
    }

    public class NewWindowRequestedEventArgsInterface:ICoreWebView2NewWindowRequestedEventArgs
    {
        private ICoreWebView2NewWindowRequestedEventArgs _Args;
        public NewWindowRequestedEventArgsInterface(ICoreWebView2NewWindowRequestedEventArgs args)
        {
            this._Args = args;
        }
        public string uri => _Args.uri;

        public ICoreWebView2 NewWindow { get => _Args.NewWindow; set => _Args.NewWindow = value; }
        public int Handled { get => _Args.Handled; set => _Args.Handled = value; }

        public int IsUserInitiated => _Args.IsUserInitiated;

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2Deferral GetDeferral()
        {
            return _Args.GetDeferral();
        }

        public ICoreWebView2WindowFeatures WindowFeatures => _Args.WindowFeatures;
    }


    public class NewWindowRequestedEventArgs : NewWindowRequestedEventArgs2Interface
    {
        private ICoreWebView2NewWindowRequestedEventArgs _Args;

        public NewWindowRequestedEventArgs(ICoreWebView2NewWindowRequestedEventArgs2 args):base(args)
        {
            this._Args = args;
        }

        private ICoreWebView2NewWindowRequestedEventArgs ToInterface()
        {
            return this._Args;
        }

       

        public new WebView2View NewWindow
        {
            get
            {
                return new WebView2View((ICoreWebView2_7)base.NewWindow);
            }
            set
            {
                
                base.NewWindow = value;
            }
        }

       
    }
}