using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMDocument : DOMObject
    {
        private string _InstanceName = "document";
        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }
        internal DOMDocument(WebView control):base(control)
        {
            
        }
        internal DOMDocument(WebView control, DOMVar domVar) : base(control)
        {
            this._InstanceName = domVar.Name;
        }

        public DOMElement activeElement
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public void addEventListener(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            Exec(new object[]{eventName,scriptText, useCapture});
        }

        public DOMElement adoptNode(DOMElement node)
        {
            DOMVar var = ExecGetVar(new object[] { node});
            return new DOMElement(this._View2Control, var);
        }


        public DOMObjectCollection anchors
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);
            }
        }

        public DOMElement GetBody
        {
            get
            {
                DOMVar var = GetGetVar("body");
                return new DOMElement(this._View2Control, var);
            }
        }

        public void SetBody(DOMElement element)
        {
            Set(element, "body");
        }

        public Task<string> baseURI => GetAsync<string>();
        public void close() => Exec(new object[] { });

        public Task<string> GetCookie => GetAsync<string>("cookie");

        public void SetCookie(string cookie)
        {
            Set(cookie,"cookie");
        }

        public Task<string> characterSet => GetAsync<string>();

        public DOMAttribute createAttribute(string attributeName)
        {
            DOMVar var = ExecGetVar(new object[] {attributeName});
            return new DOMAttribute(this._View2Control, var);
        }

        public DOMElement createComment(string comment)
        {
            DOMVar var = ExecGetVar(new object[] { comment });
            return new DOMElement(this._View2Control, var);
        }

        public DOMElement createDocumentFragment()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMElement(this._View2Control, var);
        }

        public DOMElement createElement(string nodeName)
        {
            DOMVar var = ExecGetVar(new object[] { nodeName });
            return new DOMElement(this._View2Control, var);
        }

        public DOMVar createEvent(string typeName)
        {
            DOMVar var = ExecGetVar(new object[] { typeName });
            return var;
        }

        public DOMElement createTextNode(string text)
        {
            DOMVar var = ExecGetVar(new object[] { text });
            return new DOMElement(this._View2Control, var);
        }


        public DOMWindow defaultView
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMWindow(this._View2Control, var);
            }
        }

        public DOMElement documentElement
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }
        public Task<string> GetDesignMode => GetAsync<string>("designMode");

        public void SetDesignMode(string value) => Set( value , "designMode");

        public Task<string> GetDocumentURI => GetAsync<string>("documentURI");

        public void SetDocumentURI(string value) => Set(value , "documentURI");

        public Task<string> domain => GetAsync<string>();

        public DOMObjectCollection embeds
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);
            }
        }


        public Task<bool> execCommand(string command, bool showUI, string value)
        {
            return Exec<bool>(new object[] { command, showUI, value });
        }

        public DOMObjectCollection forms
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);
            }
        }


        public DOMElement fullscreenElement
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }



        public Task<bool> fullscreenEnabled() => Exec<bool>(new object[] { });

        public DOMElement getElementById(string id)
        {
            DOMVar var = ExecGetVar(new object[] { id });
            return new DOMElement(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByClassName(string className)
        {
            DOMVar var = ExecGetVar(new object[] { className });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByName(string name)
        {
            DOMVar var = ExecGetVar(new object[] { name });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByTagName(string tagName)
        {
            DOMVar var = ExecGetVar(new object[] { tagName });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public Task<bool> hasFocus() => Exec<bool>(new object[] { });

        public DOMElement head
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public DOMObjectCollection images
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);

            }
        }

        public DOMElement importNode(DOMElement node, bool deep)
        {
            DOMVar var = ExecGetVar(new object[] { node, deep });
            return new DOMElement(this._View2Control, var);
        }

        public Task<string> inputEncoding => GetAsync<string>();

        public Task<string> lastModified => GetAsync<string>();

        public DOMObjectCollection links
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMObjectCollection(this._View2Control, var);
            }
        }

        public void normalize() => Exec(new object[] { });

        public void open() => Exec(new object[] { });

        public DOMElement querySelector(string cssSelector)
        {
            DOMVar var = ExecGetVar(new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }

        public DOMObjectCollection querySelectorAll(string cssSelector)
        {
            DOMVar var = ExecGetVar(new object[] { cssSelector });
            return new DOMObjectCollection(this._View2Control, var);
        }
        public Task<string> readyState => GetAsync<string>();

        public Task<string> referrer => GetAsync<string>();

        public DOMElement renameNode(DOMElement node, string namespaceUri, string nodeName)
        {
            DOMVar var = ExecGetVar(new object[] { node, namespaceUri, nodeName });
            return new DOMElement(this._View2Control, var);
        }

        public Task<bool> GetStrictErrorChecking => GetAsync<bool>("strictErrorChecking");
        public void SetStrictErrorChecking(bool value) => Set(value , "strictErrorChecking");

        public Task<string> GetTitle => GetAsync<string>("title");
        public void SetTitle(string value) => Set(value, "title");

        public Task<string> URL => GetAsync<string>();

        public void write(params object[] parameters) => Exec(parameters);

        public void writeln(params object[] parameters) => Exec(parameters);

    }
}