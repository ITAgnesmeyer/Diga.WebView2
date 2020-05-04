using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ContentLoadingEventArgs : EventArgs
    {
        public ContentLoadingEventArgs(bool isErrorPage, ulong navigationId)
        {
            this.IsErrorPage = isErrorPage;
            this.NavigationId = navigationId;
        }

        public bool IsErrorPage{get;}
        public ulong NavigationId{get;}

    }
}