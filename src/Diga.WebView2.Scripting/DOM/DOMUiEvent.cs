using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMUiEvent : DOMEvent
    {
        public DOMUiEvent(IWebViewControl control,DOMVar var):base(control,var)
        {
            
        }

        public int detail => Get<int>();
        public Task<int> detailAsync => GetAsync<int>(nameof(this.detail));

        public DOMWindow view => GetTypedVar<DOMWindow>();
        public Task<DOMWindow> viewAsync => GetTypedVarAsync<DOMWindow>(nameof(this.view));


    }
}