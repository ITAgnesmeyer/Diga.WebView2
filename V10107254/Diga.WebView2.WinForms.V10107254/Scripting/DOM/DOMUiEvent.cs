using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMUiEvent : DOMEvent
    {
        public DOMUiEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public Task<int> detail => GetAsync<int>();

        public Task<DOMWindow> view => GetTypedVarAsync<DOMWindow>();


    }
}