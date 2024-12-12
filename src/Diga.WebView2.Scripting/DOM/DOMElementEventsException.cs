using System;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMElementEventsException : Exception
    {
        public DOMElementEventsException(string message) : base(message)
        {
        }
        public DOMElementEventsException(string message,Exception exception):base(message, exception)
        {
            
        }
    }

}