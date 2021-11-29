using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class SourceChangedEventArgs : EventArgs
    {
        public SourceChangedEventArgs(bool isNewDocument)
        {
            this.IsNewDocument = isNewDocument;
        }

        public bool IsNewDocument{get;}

    }
}