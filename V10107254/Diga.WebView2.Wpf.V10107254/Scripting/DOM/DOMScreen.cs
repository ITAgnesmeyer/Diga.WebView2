using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMScreen : DOMObject
    {
        public DOMScreen(WebView control) : base(control)
        {
            this._InstanceName = "screen";
        }
        public DOMScreen(WebView control, DOMVar domVar) : base(control,domVar)
        {
            
        }
        public Task<int> availHeight=>GetAsync<int>();
        public Task<int> availWidth=>GetAsync<int>();
        public Task<int> colorDepth=>GetAsync<int>();
        public Task<int> height=>GetAsync<int>();
        public Task<int> pixelDepth=>GetAsync<int>();
        public Task<int> width=>GetAsync<int>();


    }
}