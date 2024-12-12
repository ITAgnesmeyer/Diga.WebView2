using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{

    public class DOMTouchEvent : DOMUiEvent
    {

        public DOMTouchEvent(IWebViewControl control, DOMVar var) : base(control, var)
        {

        }
        public bool altKey => Get<bool>();
        public Task<bool> altKeyAsync => GetAsync<bool>(nameof(this.altKey));
        public DOMTouchList changedTouches => GetTypedVar<DOMTouchList>();
        public Task<DOMTouchList> changedTouchesAsync => GetTypedVarAsync<DOMTouchList>(nameof(this.changedTouches));
        public bool ctrlKey => Get<bool>();
        public Task<bool> ctrlKeyAsync => GetAsync<bool>(nameof(this.ctrlKey));
        public bool metaKey => Get<bool>();
        public Task<bool> metaKeyAsync => GetAsync<bool>(nameof(this.metaKey));
        public bool shiftKey => Get<bool>();
        public Task<bool> shiftKeyAsync => GetAsync<bool>(nameof(this.shiftKey));

        public DOMTouchList targetTouches => GetTypedVar<DOMTouchList>();
        public Task<DOMTouchList> targetTouchesAsync => GetTypedVarAsync<DOMTouchList>(nameof(this.targetTouches));
        public DOMTouchList touches => GetTypedVar<DOMTouchList>();
        public Task<DOMTouchList> touchesAsync => GetTypedVarAsync<DOMTouchList>(nameof(this.touches));
    }
}