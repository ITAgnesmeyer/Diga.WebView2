using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMElement : DOMObject
    {

      
        internal DOMElement(WebView control, DOMVar domVar) : base(control)
        {
            this._Var = domVar;
            this._InstanceName = domVar.Name;
        }

        public  Task<string> accessKey
        {
            get => GetAsync<string>("accessKey");
            set => _ = SetAsync<string>(value);
        }

        
        public Task addEventListener(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            return Exec<object>(new object[]{eventName,scriptText, useCapture});
        }

        public Task appendChild(DOMElement element)
        {
            return Exec<object>(new object[]{element});
        }

        public Task blur() => Exec<object>(new object[] { });

        public Task<int> childElementCount => GetAsync<int>();

        public Task<string> className
        {
            get=> GetAsync<string>();
            set => _ = SetAsync(value);

        }

        public Task click() => Exec<object>(new object[] { });

        public Task<int> clientHeight => GetAsync<int>();
        public Task<int> clientLeft => GetAsync<int>();

        public Task<int> clientTop => GetAsync<int>();

        public Task<int> clientWidth => GetAsync<int>();

        public DOMElement cloneNode(bool deep)
        {
            DOMVar domVar = ExecGetVar(new object[] { deep });
            return new DOMElement(this._View2Control, domVar);
        }

        public DOMElement closes(string selector)
        {
            DOMVar domVar = ExecGetVar(new object[] {selector});
            return new DOMElement(this._View2Control, domVar);
        }

        public Task<bool> contains(DOMElement element)
        {
            return Exec<bool>(new object[] { element });
        }

        public Task<string> GetContentEditable => GetAsync<string>("contentEditable");
        public void SetContentEditable(string value) => Set(value, "contentEditable");

        public Task<string> GetDir => GetAsync<string>("dir");
        public void SetDir(string value) => Set(value, "dir");

        public void exitFullscreen() => Exec(new object[] { });

        public Task< DOMElement> firstChild
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<DOMElement> firstElementChild
        {
            get => GetTypedVar<DOMElement>();
        }

        public void focus() => Exec(new object[] { });


        public Task<bool> hasAttribute(string value) => Exec<bool>(new object[] { value });

        public Task<bool> hasAttributes() => Exec<bool>(new object[] { });

        public Task<bool> hasChildNodes() => Exec<bool>(new object[] { });

        public Task<string> id
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }
        public Task<string> GetId => GetAsync<string>("id");
        public void SetId(string value) => Set(value, "id");

        public Task<string> GetInnerHTML => GetAsync<string>("innerHTML");
        public void SetInnerHTML(string value) => Set(value, "innerHTML");

        public Task<string> GetInnerText => GetAsync<string>("innerText");
        public void SetInnerText(string value) => Set(value, "innerText");

        public void insertAdjacentElement(string position, DOMElement element)
        {
            Exec(new object[]{position,element});
        }

        public void insertAdjacentHTML(string position, string html)
        {
            Exec(new object[]{position,html});
        }

        public void insertAdjacentText(string position, string text)
        {
            Exec(new object[]{position, text});
        }

        public void insertBefore(DOMElement newNode, DOMElement existingNode)
        {
            Exec(new object[] { newNode, existingNode });
        }

        public Task<bool> isContentEditable => GetAsync<bool>();

        public Task<bool> isDefaultNamespace(string nameSpace) => Exec<bool>(new object[] { nameSpace });

        public Task<bool> isEqualNode(DOMElement element) => Exec<bool>(new object[] { element });

        public Task<bool> isSameNode(DOMElement element) => Exec<bool>(new object[] { element});

        public Task<bool> isSupported(string feature, string version) => Exec<bool>(new object[] { feature, version });

        public Task<string> GetLang => GetAsync<string>("lang");
        public void SetLang(string value) => Set(value, "lang");

        public Task< DOMElement> lastChild
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<bool> matches(string selectors) => Exec<bool>(new object[] { selectors });


        public Task<string> namespaceURI => GetAsync<string>();

        public Task< DOMElement> nextSibling
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<DOMElement> nextElementSibling
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<string> nodeName => GetAsync<string>();

        public Task<int> nodeType => GetAsync<int>();

        public Task<string> GetNodeValue => GetAsync<string>("nodeValue");
        public void SetNodeValue(string value) => Set(value, "nodeValue");

        public void normalize() => Exec(new object[] { });

        public Task<int> offsetHeight => GetAsync<int>();
        public Task<int> offsetWidth => GetAsync<int>();
        public Task<int> offsetLeft => GetAsync<int>();
        public Task<int> offsetTop => GetAsync<int>();

        public Task<DOMElement > offsetParent
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<string> GetOuterHTML => GetAsync<string>("outerHTML");
        public void SetOuterHTML(string value) => Set(value, "outerHTML");

        public Task<string> GetOuterText => GetAsync<string>("outerText");
        public void SetOuterText(string value) => Set(value, "outerText");

        public Task<DOMDocument> ownerDocument
        {
            get=> GetTypedVar<DOMDocument>();


        }

        public Task<DOMElement> parentNode
        {
            get=> GetTypedVar<DOMElement>();
            
        }

        public Task< DOMElement> parentElement
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<DOMElement> previousSibling
        {
            get => GetTypedVar<DOMElement>();
        }

        public Task<DOMElement> previousElementSibling
        {
            get => GetTypedVar<DOMElement>();        }

        public DOMElement querySelector(string cssSelector)
        {
            DOMVar var = ExecGetVar(new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }


        public void remove() => Exec(new object[] { });

        public void removeAttribute(string name) => Exec(new object[] { name });

        public void removeAttributeNode(DOMAttribute attr) => Exec(new object[] { attr });

        public void removeChild(DOMElement elem) => Exec(new object[] { elem});

        public void replaceChild(DOMElement newNode, DOMElement oldNode) =>
            Exec(new object[] { newNode, oldNode });

        public void requestFullscreen() => Exec(new object[] { });

        public Task<int> scrollHeight => GetAsync<int>();
        public void scrollIntoView() => Exec(new object[] { });
        public Task<int> scrollLeft => GetAsync<int>();

        public Task<int> scrollTop => GetAsync<int>();

        public void setAttribute(string attributename, string attributevalue) =>
            Exec(new object[] { attributename, attributevalue });


        public void setAttributeNode(DOMVar attr) => Exec(new object[] { attr.Name });

       
    }


}