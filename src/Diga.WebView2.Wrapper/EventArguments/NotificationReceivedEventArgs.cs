using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NotificationReceivedEventArgs: NotificationReceivedEventArgsInterface
    {
        public NotificationReceivedEventArgs(ICoreWebView2NotificationReceivedEventArgs iface) : base(iface)
        {
            
        }

        public new WebView2Notification Notification => new WebView2Notification(base.Notification);

        public new WebView2Deferral GetDeferral()
        {
            var def = base.GetDeferral();
            return new WebView2Deferral(def);
        }

    }

}