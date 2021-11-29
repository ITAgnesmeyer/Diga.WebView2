using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NavigationStartingEventArgs : NavigationStartingEventArgsInterface
    {

        public NavigationStartingEventArgs(ICoreWebView2NavigationStartingEventArgs args) : base(args)
        {
        }

        new public bool IsUserInitiated => (CBOOL)base.IsUserInitiated;


        new public bool IsRedirected => (CBOOL)base.IsRedirected;


        new public bool Cancel
        {
            get => (CBOOL)base.Cancel;
            set => base.Cancel = (CBOOL)value;
        }

    }
}