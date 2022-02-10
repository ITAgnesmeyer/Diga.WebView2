using System.Threading.Tasks;
// ReSharper disable IdentifierTypo

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

        public void alert(string message)
        {
            base.Exec(new object[] { message });
        }
        public  Task alertAsync(string message)
        {
             return base.ExecAsync(new object[] { message },nameof(alert));
        }
        public string atob(string encoded)
        {
            return Exec<string>(new object[] { encoded });
        }
        public async Task<string> atobAsync(string encoded)
        {
            return await ExecAsync<string>(new object[] { encoded },nameof(atob));
        }

        public void blur()
        {
            Exec(new object[] { });
        }
        public Task blurAsync()
        {
            return ExecAsync(new object[] { },nameof(blur));
        }

        public string btoa(string text)
        {
            return Exec<string>(new object[] { text });
        }

        public async Task<string> btoaAsync(string text)
        {
            return await ExecAsync<string>(new object[] { text },nameof(btoa));
        }

        public void close()
        {
            Exec(new object[] { });
        }

        public Task closeAsync()
        {
            return ExecAsync(new object[] { },nameof(close));
        }

        public bool closed => Get<bool>();
        public Task<bool> closedAsync => GetAsync<bool>(nameof(closed));

        public bool confirm(string message)
        {
            return Exec<bool>(new object[] { message });
        }

        public async Task<bool> confirmAsync(string message)
        {
            return await ExecAsync<bool>(new object[] { message },nameof(confirm));
        }

        public  DOMConsole console => GetTypedVar<DOMConsole>();

        public  Task<DOMConsole> consoleAsync => GetTypedVarAsync<DOMConsole>(nameof(console));

        public DOMDocument document => GetTypedVar<DOMDocument>();

        public Task< DOMDocument> documentAsync => GetTypedVarAsync<DOMDocument>(nameof(document));

        public void focus()
        {
            Exec(new object[] { });
        }

        public Task focusAsync()
        {
            return  ExecAsync(new object[] { },nameof(focus));
        }

        public  DOMElement frameElement => GetTypedVar<DOMElement>();

        public  Task< DOMElement> frameElementAsync => GetTypedVarAsync<DOMElement>(nameof(frameElement));

        public DOMObjectCollection frames => GetTypedVar<DOMObjectCollection>();

        public Task<DOMObjectCollection> framesAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(frames));

        public DOMHistory history => GetTypedVar<DOMHistory>();

        public Task<DOMHistory> historyAsync => GetTypedVarAsync<DOMHistory>(nameof(history));


        public int innerHeight => Get<int>();
        public Task<int> innerHeightAsync => GetAsync<int>(nameof(innerHeight));

        public int innerWidth => Get<int>();
        public Task<int> innerWidthAsync => GetAsync<int>(nameof(innerWidth));

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));


        public DOMStorage localStorage => GetTypedVar<DOMStorage>();

        public Task<DOMStorage> localStorageAsync => GetTypedVarAsync<DOMStorage>(nameof(localStorage));

        
        public void moveBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public Task moveByAsync(int x, int y)
        {
            return ExecAsync(new object[] { x, y },nameof(moveBy));
        }

        public void moveTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public Task moveToAsync(int x, int y)
        {
            return ExecAsync(new object[] { x, y },nameof(moveTo));
        }

        public string name
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> nameAsync
        {
            get => GetAsync<string>(nameof(name));
            set => _ = SetAsync(value);
        }

        public DOMWindow open(string url, string windowName = null, string specs = null, string replace = null)
        {
            DOMVar var = ExecGetVar( new object[] { url, windowName, specs, replace });

            return new DOMWindow(this._View2Control, var);
        }
        

        public async Task< DOMWindow> openAsync(string url, string windowName = null, string specs = null, string replace = null)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { url, windowName, specs, replace },nameof(open));

            return new DOMWindow(this._View2Control, var);
        }

        public  DOMWindow opener => GetTypedVar<DOMWindow>();
        public  Task<DOMWindow> openerAsync => GetTypedVarAsync<DOMWindow>(nameof(opener));

        public int outerHeight => Get<int>();
        public Task<int> outerHeightAsync => GetAsync<int>(nameof(outerHeight));

        public int outerWidth => Get<int>();
        public Task<int> outerWidthAsync => GetAsync<int>(nameof(outerWidth));

        public int pageXOffset => Get<int>();
        public Task<int> pageXOffsetAsync => GetAsync<int>(nameof(pageXOffset));

        public int pageYOffset => Get<int>();
        public Task<int> pageYOffsetAsync => GetAsync<int>(nameof(pageYOffset));

        public DOMWindow parent => GetTypedVar<DOMWindow>();
        public Task<DOMWindow> parentAsync => GetTypedVarAsync<DOMWindow>(nameof(parent));

        public void print()
        {
            Exec(new object[] { });
        }
        public Task printAsync()
        {
            return  ExecAsync(new object[] { },nameof(print));
        }

        public string prompt(string text, string defaultText = null)
        {
            return Exec<string>(new object[] { text, defaultText });
        }
        public async Task<string> promptAsync(string text, string defaultText = null)
        {
            return await ExecAsync<string>(new object[] { text, defaultText },nameof(prompt));
        }

        public void resizeBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }
        public Task resizeByAsync(int x, int y)
        {
            return ExecAsync(new object[] { x, y },nameof(resizeBy));
        }

        public void resizeTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }
        public Task resizeToAsync(int x, int y)
        {
            return ExecAsync(new object[] { x, y },nameof(resizeTo));
        }
        public DOMScreen screen=> GetTypedVar<DOMScreen>();
        public Task<DOMScreen> screenAsync=> GetTypedVarAsync<DOMScreen>(nameof(screen));

        public int screenLeft => Get<int>();
        public Task<int> screenLeftAsync => GetAsync<int>(nameof(screenLeft));
        public int screenTop => Get<int>();
        public Task<int> screenTopAsync => GetAsync<int>(nameof(screenTop));

        public int screenX => Get<int>();
        public Task<int> screenXAsync => GetAsync<int>(nameof(screenX));
        public int screenY => Get<int>();
        public Task<int> screenYAsync => GetAsync<int>(nameof(screenY));

        public void scrollBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }
        public Task scrollByAsync(int x, int y)
        {
            return ExecAsync(new object[] { x, y },nameof(scrollBy));
        }
        public void scrollTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public Task scrollToAsync(int x, int y)
        {
            return  ExecAsync(new object[] { x, y },nameof(scrollTo));
        }

        public int scrollX=> Get<int>();
        public Task<int> scrollXAsync => GetAsync<int>(nameof(scrollX));
        public int scrollY=> Get<int>();
        public Task<int> scrollYAsync => GetAsync<int>(nameof(scrollY));

        public DOMStorage sessionStorage => GetTypedVar<DOMStorage>();
        public Task<DOMStorage> sessionStorageAsync => GetTypedVarAsync<DOMStorage>(nameof(sessionStorage ));

        public DOMWindow self => GetTypedVar<DOMWindow>();

        public Task<DOMWindow> selfAsync => GetTypedVarAsync<DOMWindow>(nameof(self));

        public void stop()
        {
            Exec(new object[] { });
        }

        public Task stopAsync()
        {
           return ExecAsync(new object[] { },nameof(stop));
        }

        public DOMWindow top => GetTypedVar<DOMWindow>();
        public Task<DOMWindow> topAsync => GetTypedVarAsync<DOMWindow>(nameof(top));
    }
}