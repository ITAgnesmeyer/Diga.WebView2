﻿using System;

namespace Diga.WebView2.WinForms.Scripting.DOM
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