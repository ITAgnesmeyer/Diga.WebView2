using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMTouch : DOMObject
    {
        public DOMTouch(IWebViewControl control, DOMVar var) : base(control, var)
        {
        }
        public long identifier => Get<long>();
        
        public Task<long> identifierAsync => GetAsync<long>(nameof(this.identifier));
        public double clientX => Get<double>();
        public Task<double> clientXAsync => GetAsync<double>(nameof(this.clientX));
        public double clientY => Get<double>();
        public Task<double> clientYAsync => GetAsync<double>(nameof(this.clientY));
        public float force => Get<float>();
        public Task<float> forceAsync => GetAsync<float>(nameof(this.force));
        public double pageX => Get<double>();
        public Task<double> pageXAsync => GetAsync<double>(nameof(this.pageX));
        public int pageY => Get<int>();
        public Task<double> pageYAsync => GetAsync<double>(nameof(this.pageY));

        public decimal radiusX => Get<decimal>();
        public Task<decimal> radiusXAsync => GetAsync<decimal>(nameof(this.radiusX));
        public decimal radiusY => Get<decimal>();
        public Task<decimal> radiusYAsync => GetAsync<decimal>(nameof(this.radiusY));
        public decimal rotationAngle => Get<decimal>();

        public Task<decimal> rotationAngleAsync => GetAsync<decimal>(nameof(this.rotationAngle));

        public decimal screenX => Get<decimal>();
        public Task<decimal> screenXAsync => GetAsync<decimal>(nameof(this.screenX));
        public decimal screenY => Get<decimal>();
        public Task<decimal> screenYAsync => GetAsync<decimal>(nameof(this.screenY));
        public DOMElement target => GetTypedVar<DOMElement>();
        public Task<DOMElement> targetAsync => GetTypedVarAsync<DOMElement>(nameof(this.target));


    }
}