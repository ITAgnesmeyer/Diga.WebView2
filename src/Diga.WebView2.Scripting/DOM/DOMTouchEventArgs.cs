using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMTouchEventArgs : EventArgs
    {
        public DOMTouchEvent Event { get; }
        public DOMTouchEventArgs(DOMTouchEvent ev)
        {
            this.Event = ev;
        }
    }
}