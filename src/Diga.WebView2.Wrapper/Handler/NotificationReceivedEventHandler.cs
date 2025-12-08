using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NotificationReceivedEventHandler : ICoreWebView2NotificationReceivedEventHandler
    { 
        public event EventHandler<NotificationReceivedEventArgs> NotificationReceived;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2NotificationReceivedEventArgs args)
        {
            try
            {
                OnNotificationReceived(new NotificationReceivedEventArgs(args));
            }
            catch (Exception ex)
            {

                Debug.Print(ex.ToString());
            }
            
        }
        protected virtual void OnNotificationReceived(NotificationReceivedEventArgs e)
        {
            NotificationReceived?.Invoke(this, e);
        }
    }
}