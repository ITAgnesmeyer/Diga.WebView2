using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMLocation : DOMObject
    {
        public DOMLocation(WebView control):base(control)
        {
            this._InstanceName = "location";
        }
        public DOMLocation(WebView control, DOMVar domVar) : base(control,domVar)
        {
            
        }

        public Task<string> hash{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> host{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> hostname{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> href{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> origin => GetAsync<string>();
        public Task<string> pathname{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> port{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> protocol{get=>GetAsync<string>();set=>_=SetAsync(value);}
        public Task<string> search{get=>GetAsync<string>();set=>_=SetAsync(value);}

    }
}