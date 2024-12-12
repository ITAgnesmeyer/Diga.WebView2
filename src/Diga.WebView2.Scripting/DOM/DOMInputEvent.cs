using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{

    public class DOMInputEvent : DOMUiEvent
    {
        public DOMInputEvent(IWebViewControl control, DOMVar var) : base(control, var)
        {
        }
        public string data => Get<string>();
        public Task<string> dataAsync => GetAsync<string>(nameof(this.data));

        public string dataTransfer => Get<string>();
        public Task<string> dataTransferAsync => GetAsync<string>(nameof(this.dataTransfer));
        public int inputType => Get<int>();
        public Task<int> inputTypeAsync => GetAsync<int>(nameof(this.inputType));
        public bool isComposing => Get<bool>();
        public Task<bool> isComposingAsync => GetAsync<bool>(nameof(this.isComposing));
        public DOMVar getTargetRanges()
        {
            return this.ExecGetVar(new object[] { });
        }
    }
}