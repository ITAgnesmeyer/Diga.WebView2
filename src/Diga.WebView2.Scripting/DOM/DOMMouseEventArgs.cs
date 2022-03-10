using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMMouseEventArgs : EventArgs
    {
        public DOMMouseEvent Event { get; }

        public DOMMouseEventArgs(DOMMouseEvent ev)
        {
            this.Event = ev;
        }
    }
}