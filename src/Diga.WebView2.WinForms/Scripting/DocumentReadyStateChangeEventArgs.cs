using System;
using Diga.WebView2.WinForms.Scripting.DOM;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DocumentReadyStateChangeEventArgs : EventArgs
    {
        public DOMDocument Document { get; }
        public string State { get; }

        public DocumentReadyStateChangeEventArgs(DOMDocument doc, string state)
        {
            this.Document = doc;
            this.State = state;
        }
    }
}