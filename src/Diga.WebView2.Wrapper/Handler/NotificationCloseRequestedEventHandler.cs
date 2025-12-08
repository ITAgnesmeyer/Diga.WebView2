using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NotificationCloseRequestedEventHandler : ICoreWebView2NotificationCloseRequestedEventHandler
    {
        public event EventHandler<NotificationCloseRequestedEventArgs> NotificationCloseRequested;
        protected virtual void OnNotificationCloseRequested(NotificationCloseRequestedEventArgs e)
        {
            NotificationCloseRequested?.Invoke(this, e);
        }

        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2Notification sender, [In, MarshalAs(UnmanagedType.IUnknown)] object args)
        {
            try
            {
                OnNotificationCloseRequested(new NotificationCloseRequestedEventArgs(new WebView2Notification(sender), args));
            }
            catch (Exception ex)
            {

                Debug.Print(ex.ToString());
            }
        }
    }

}