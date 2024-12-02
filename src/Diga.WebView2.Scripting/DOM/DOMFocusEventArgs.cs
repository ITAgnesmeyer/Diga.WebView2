using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMFocusEventArgs : EventArgs
    {
        public DOMFocusEvent Event { get; }
        public DOMFocusEventArgs(DOMFocusEvent ev)
        {
            this.Event = ev;
        }
    }
}