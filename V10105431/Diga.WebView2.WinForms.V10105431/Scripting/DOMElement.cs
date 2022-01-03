using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMElement : DOMObject
    {

        private string _InstanceName;
        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }
        internal DOMElement(WebView control, DOMVar domVar) : base(control)
        {
            this._InstanceName = domVar.Name;
        }

        public Task<string> GetAccessKey => GetAsync<string>("accessKey");
        public void SetAccessKey(string value) => Set(value, "accessKey");

        public void addEventListener(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            Exec(new object[]{eventName,scriptText, useCapture});
        }

        public void appendChild(DOMElement element)
        {
            Exec(new object[]{element});
        }

        public void blur() => Exec(new object[] { });

        public Task<int> childElementCount => GetAsync<int>();

        public Task<string> GetClassName => GetAsync<string>("className");
        public void SetClassName(string value) => Set(value, "className");

        public void click() => Exec(new object[] { });

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

        public DOMElement firstChild
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
        }

        public DOMElement firstElementChild
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
        }

        public void focus() => Exec(new object[] { });


        public Task<bool> hasAttribute(string value) => Exec<bool>(new object[] { value });

        public Task<bool> hasAttributes() => Exec<bool>(new object[] { });

        public Task<bool> hasChildNodes() => Exec<bool>(new object[] { });

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

        public DOMElement lastChild
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
        }

        public Task<bool> matches(string selectors) => Exec<bool>(new object[] { selectors });


        public Task<string> namespaceURI => GetAsync<string>();

        public DOMElement nextSibling
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
        }

        public DOMElement nextElementSibling
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
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

        public DOMElement offsetParent
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMElement(this._View2Control, domVar);
            }
        }

        public Task<string> GetOuterHTML => GetAsync<string>("outerHTML");
        public void SetOuterHTML(string value) => Set(value, "outerHTML");

        public Task<string> GetOuterText => GetAsync<string>("outerText");
        public void SetOuterText(string value) => Set(value, "outerText");

        public DOMDocument ownerDocument
        {
            get
            {
                DOMVar domVar = GetGetVar();
                return new DOMDocument(this._View2Control, domVar);
            }
        }

        public DOMElement parentNode
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public DOMElement parentElement
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public DOMElement previousSibling
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

        public DOMElement previousElementSibling
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMElement(this._View2Control, var);
            }
        }

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