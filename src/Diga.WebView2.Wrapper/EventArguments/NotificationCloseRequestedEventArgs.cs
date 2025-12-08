using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NotificationCloseRequestedEventArgs : EventArgs
    {
        public WebView2Notification Notification { get; }
        public object Args { get; }
        public NotificationCloseRequestedEventArgs(WebView2Notification notification, object args)
        {
            Notification = notification ?? throw new ArgumentNullException(nameof(notification));
            Args = args;
        }
    }

}