using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMWindow : DOMObject
    {
     

        internal DOMWindow(WebView control) : base(control)
        {
            this._InstanceName = "window";
        }

        internal DOMWindow(WebView control, DOMVar domVar) : base(control,domVar)
        {
            
        }
        public  Task alert(string message)
        {
             return base.ExecAsync<object>(new object[] { message });
        }

        public async Task<string> atob(string encoded)
        {
            return await ExecAsync<string>(new object[] { encoded });
        }

        public Task blur()
        {
            return ExecAsync<object>(new object[] { });
        }

        public async Task<string> btoa(string text)
        {
            return await ExecAsync<string>(new object[] { text });
        }


        public Task close()
        {
            return ExecAsync<object>(new object[] { });
        }

        public Task<bool> closed => GetAsync<bool>();

        public async Task<bool> confirm(string message)
        {
            return await ExecAsync<bool>(new object[] { message });
        }

        public  Task<DOMConsole> console
        {
            get => GetTypedVarAsync<DOMConsole>();
        }
        
        public Task< DOMDocument> document
        {
            get=> GetTypedVarAsync<DOMDocument>();

            
        }
        public Task focus()
        {
            return  ExecAsync<object>(new object[] { });
        }

        public  Task< DOMElement> frameElement
        {
            get => GetTypedVarAsync<DOMElement>();
        }

        public Task<DOMObjectCollection> frames
        {
            get => GetTypedVarAsync<DOMObjectCollection>();
            
        }

        public Task<DOMHistory> history
        {
            get => GetTypedVarAsync<DOMHistory>();
            
        }



        public Task<int> innerHeight => GetAsync<int>();

        public Task<int> innerWidth => GetAsync<int>();

        public Task<int> length => GetAsync<int>();

        public Task<DOMStorage> localStorage => GetTypedVarAsync<DOMStorage>();

        

        public Task moveBy(int x, int y)
        {
            return ExecAsync<object>(new object[] { x, y });
        }

        public Task moveTo(int x, int y)
        {
            return ExecAsync<object>(new object[] { x, y });
        }

        public Task<string> name
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        

        public async Task< DOMWindow> open(string url, string windowName = null, string specs = null, string replace = null)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { url, windowName, specs, replace });

            return new DOMWindow(this._View2Control, var);
        }

        public  Task<DOMWindow> opener => GetTypedVarAsync<DOMWindow>();

        public Task<int> outerHeight => GetAsync<int>();

        public Task<int> outerWidth => GetAsync<int>();

        public Task<int> pageXOffset => GetAsync<int>();

        public Task<int> pageYOffset => GetAsync<int>();

        public Task<DOMWindow> parent => GetTypedVarAsync<DOMWindow>();

        public Task print()
        {
            return  ExecAsync<object>(new object[] { });
        }

        public async Task<string> prompt(string text, string defaultText = null)
        {
            return await ExecAsync<string>(new object[] { text, defaultText });
        }

        public Task resizeBy(int x, int y)
        {
            return ExecAsync<object>(new object[] { x, y });
        }

        public Task resizeTo(int x, int y)
        {
            return ExecAsync<object>(new object[] { x, y });
        }
        public Task<DOMScreen> screen=> GetTypedVarAsync<DOMScreen>();

        public Task<int> screenLeft => GetAsync<int>();
        public Task<int> screenTop => GetAsync<int>();

        public Task<int> screenX => GetAsync<int>();
        public Task<int> screenY => GetAsync<int>();

        public Task scrollBy(int x, int y)
        {
            return ExecAsync<object>(new object[] { x, y });
        }
        public Task scrollTo(int x, int y)
        {
            return  ExecAsync<object>(new object[] { x, y });
        }

        public Task<int> scrollX => GetAsync<int>();
        public Task<int> scrollY => GetAsync<int>();

        public Task<DOMStorage> sessionStorage => GetTypedVarAsync<DOMStorage>();

        public Task<DOMWindow> self => GetTypedVarAsync<DOMWindow>();

        
        public Task stop()
        {
           return ExecAsync<object>(new object[] { });
        }

        public Task<DOMWindow> top => GetTypedVarAsync<DOMWindow>();
    }
}