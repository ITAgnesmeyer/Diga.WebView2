using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class PermissionRequestedEventArgs : PermissionRequestedEventArgsInterface
    {
        

        public PermissionRequestedEventArgs(ICoreWebView2PermissionRequestedEventArgs args):base(args)
        {
            
        }

       
        public string Uri => base.uri;

        public new PermissionState State
        {
            get => (PermissionState)base.State;

            set => base.State = (COREWEBVIEW2_PERMISSION_STATE)value;
        }

        public PermissionType PermissionType => (PermissionType)base.PermissionKind;


        public new WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(base.GetDeferral());
        }

        
      
        
    }
}