using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMKeyboardEventArgs : EventArgs
    {
        public DOMKeyboardEvent Event { get; }

        public DOMKeyboardEventArgs(DOMKeyboardEvent ev)
        {
            this.Event = ev;
        }
    }
}