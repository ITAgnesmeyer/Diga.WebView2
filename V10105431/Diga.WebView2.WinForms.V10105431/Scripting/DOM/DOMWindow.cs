﻿using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMWindow : DOMObject
    {
     

        internal DOMWindow(WebView control) : base(control)
        {
            this._InstanceName = "window";
        }

        internal DOMWindow(WebView control, DOMVar domVar) : base(control)
        {
            this._Var = domVar;
            this._InstanceName = domVar.Name;
        }
        public async Task alert(string message)
        {
             await base.Exec<string>(new object[] { message });
        }

        public async Task<string> atob(string encoded)
        {
            return await Exec<string>(new object[] { encoded });
        }

        public void blur()
        {
            Exec(new object[] { });
        }

        public async Task<string> btoa(string text)
        {
            return await Exec<string>(new object[] { text });
        }


        public void close()
        {
            Exec(new object[] { });
        }

        public Task<bool> closed => GetAsync<bool>();

        public async Task<bool> confirm(string message)
        {
            return await Exec<bool>(new object[] { message });
        }

        public DOMConsole console
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMConsole(this._View2Control, var);
            }
        }

        public DOMDocument document
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMDocument(this._View2Control, var);
            }
        }
        public void focus()
        {
            Exec(new object[] { });
        }

        public DOMElement frameElement
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public DOMObjectCollection frames
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);
            }
        }

        public DOMHistory history
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMHistory(this._View2Control, var);
            }
        }



        public Task<int> innerHeight => GetAsync<int>();

        public Task<int> innerWidth => GetAsync<int>();

        public Task<int> length => GetAsync<int>();

        public void moveBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public void moveTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public async Task<string> GetName()
        {
            return await GetAsync<string>("name");
        }

        public void SetName(string name)
        {
            Set(name, "name");
        }

        public DOMWindow open(string url, string windowName = null, string specs = null, string replace = null)
        {
            DOMVar var = ExecGetVar(new object[] { url, windowName, specs, replace });

            return new DOMWindow(this._View2Control, var);
        }

        public Task<int> outerHeight => GetAsync<int>();

        public Task<int> outerWidth => GetAsync<int>();

        public Task<int> pageXOffset => GetAsync<int>();

        public Task<int> pageYOffset => GetAsync<int>();

        public void print()
        {
            Exec(new object[] { });
        }

        public async Task<string> prompt(string text, string defaultText = null)
        {
            return await Exec<string>(new object[] { text, defaultText });
        }

        public void resizeBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public void resizeTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public Task<int> screenLeft => GetAsync<int>();
        public Task<int> screenTop => GetAsync<int>();

        public Task<int> screenX => GetAsync<int>();
        public Task<int> screenY => GetAsync<int>();

        public void scrollBy(int x, int y)
        {
            Exec(new object[] { x, y });
        }
        public void scrollTo(int x, int y)
        {
            Exec(new object[] { x, y });
        }

        public Task<int> scrollX => GetAsync<int>();
        public Task<int> scrollY => GetAsync<int>();

        public void stop()
        {
            Exec(new object[] { });
        }

    }
}