using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMTouchList : DOMObject
    {
        public DOMTouchList(IWebViewControl control, DOMVar var) : base(control, var)
        {
        }
        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(this.length));
        public DOMTouch item(int index)
        {
            return Exec<DOMTouch>(new object[] { index });
        }
        public Task<DOMTouch> itemAsync(int index)
        {
            return ExecAsync<DOMTouch>(new object[] { index }, nameof(item));
        }
    }
}