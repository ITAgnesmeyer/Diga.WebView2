using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Notification: WebView2NotificationInterface
    {
        public WebView2Notification(ICoreWebView2Notification notification):base(notification)
        {
            
        }
    }


}