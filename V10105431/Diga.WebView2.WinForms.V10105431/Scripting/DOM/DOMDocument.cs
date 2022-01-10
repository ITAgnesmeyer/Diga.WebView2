using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMDocument : DOMObject
    {
        
        internal DOMDocument(WebView control):base(control)
        {
            this._InstanceName = "document";
        }
        internal DOMDocument(WebView control, DOMVar domVar) : base(control, domVar)
        {

        }

        public Task< DOMElement> activeElement
        {
            get=> GetTypedVar<DOMElement>();
                
        }

        public Task addEventListener(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName,this);
            return Exec<object>(new object[]{eventName,scriptText, useCapture});
        }

        public async Task<DOMElement> adoptNode(DOMElement node)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node});
            return new DOMElement(this._View2Control, var);
        }


        public Task<DOMObjectCollection> anchors
        {
            get => GetTypedVar<DOMObjectCollection>();
           
        }

        public Task< DOMElement> body
        {
            get=> GetTypedVar<DOMElement>();
            set => _ = SetAsync(value);
        }


        public Task<string> baseURI => GetAsync<string>();
        public Task close() => Exec<object>(new object[] { });

        public Task<string> cookie
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> characterSet => GetAsync<string>();

        public async Task< DOMAttribute> createAttribute(string attributeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] {attributeName});
            return new DOMAttribute(this._View2Control, var);
        }

        public async Task< DOMElement> createComment(string comment)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { comment });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMElement> createDocumentFragment()
        {
            DOMVar var = await ExecGetVarAsync( new object[] { });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMElement> createElement(string nodeName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { nodeName });
            return new DOMElement(this._View2Control, var);
        }

        public async  Task<DOMVar> createEvent(string typeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { typeName });
            return var;
        }

        public async Task< DOMElement> createTextNode(string text)
        {
            DOMVar var = await  ExecGetVarAsync( new object[] { text });
            return new DOMElement(this._View2Control, var);
        }


        public Task<DOMWindow> defaultView
        {
            get => GetTypedVar<DOMWindow>();

        }

        public Task<DOMElement> documentElement
        {
            get => GetTypedVar<DOMElement>();
        }

        public Task<string> designMode
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> documentURI
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }


        public Task<string> domain => GetAsync<string>();

        public Task< DOMObjectCollection> embeds
        {
            get => GetTypedVar<DOMObjectCollection>();
        }


        public Task<bool> execCommand(string command, bool showUI, string value)
        {
            return Exec<bool>(new object[] { command, showUI, value });
        }

        public Task<DOMObjectCollection> forms
        {
            get=> GetTypedVar<DOMObjectCollection>();
           
        }


        public Task<DOMElement> fullscreenElement
        {
            get=> GetTypedVar<DOMElement>();
            
        }



        public Task<bool> fullscreenEnabled() => Exec<bool>(new object[] { });

        public async  Task< DOMElement> getElementById(string id)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { id });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMObjectCollection> getElementsByClassName(string className)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { className });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public async  Task< DOMObjectCollection> getElementsByName(string name)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { name });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public async Task< DOMObjectCollection> getElementsByTagName(string tagName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { tagName });
            return new DOMObjectCollection(this._View2Control, var);
        }

        public Task<bool> hasFocus() => Exec<bool>(new object[] { });

        public Task<DOMElement> head
        {
            get => GetTypedVar<DOMElement>();
        }

        public Task<DOMObjectCollection> images
        {
            get => GetTypedVar<DOMObjectCollection>();

        }

        public async Task< DOMElement> importNode(DOMElement node, bool deep)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node, deep });
            return new DOMElement(this._View2Control, var);
        }

        public Task<string> inputEncoding => GetAsync<string>();

        public Task<string> lastModified => GetAsync<string>();

        public Task<DOMObjectCollection> links
        {
            get => GetTypedVar<DOMObjectCollection>();
        }

        public Task normalize() => Exec<object>(new object[] { });

        public Task open() => Exec<object>(new object[] { });

        public async Task< DOMElement> querySelector(string cssSelector)
        {
            DOMVar var = await  ExecGetVarAsync( new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMObjectCollection> querySelectorAll(string cssSelector)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { cssSelector });
            return new DOMObjectCollection(this._View2Control, var);
        }
        public Task<string> readyState => GetAsync<string>();

        public Task<string> referrer => GetAsync<string>();

        public async Task< DOMElement> renameNode(DOMElement node, string namespaceUri, string nodeName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node, namespaceUri, nodeName });
            return new DOMElement(this._View2Control, var);
        }

        public Task<bool> strictErrorChecking
        {
            get => GetAsync<bool>();
            set=> _ = SetAsync(value);
        }


        public Task<CSSStyleSheetList> styleSheets => GetTypedVar<CSSStyleSheetList>();

        public Task<string> title
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        
        public Task<string> URL => GetAsync<string>();

        public Task write(params object[] parameters) => Exec<object>(parameters);

        public Task writeln(params object[] parameters) => Exec<object>(parameters);

    }
}