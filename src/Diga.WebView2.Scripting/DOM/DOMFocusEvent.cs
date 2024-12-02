using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMFocusEvent : DOMUiEvent
    {
        public DOMFocusEvent(IWebViewControl control, DOMVar var) : base(control, var)
        {
            
        }

        public DOMElement relatedTarget => GetTypedVar<DOMElement>();

    }
}