using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMInputEventArgs : EventArgs
    {
        public DOMInputEvent Event { get; }
        public DOMInputEventArgs(DOMInputEvent ev)
        {
            this.Event = ev;
        }
    }
}