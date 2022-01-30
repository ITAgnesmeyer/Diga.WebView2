using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMUiEvent : DOMEvent
    {
        public DOMUiEvent(WebView control,DOMVar var):base(control,var)
        {
            
        }

        public int detail => Get<int>();
        public Task<int> detailAsync => GetAsync<int>(nameof(detail));

        public DOMWindow view => GetTypedVar<DOMWindow>();
        public Task<DOMWindow> viewAsync => GetTypedVarAsync<DOMWindow>(nameof(view));


    }
}