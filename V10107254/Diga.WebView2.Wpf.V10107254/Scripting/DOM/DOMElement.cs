using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMElement : DOMObject
    {

      
        internal DOMElement(WebView control, DOMVar domVar) : base(control,domVar)
        {

        }

        public  Task<string> accessKey
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> accessKeyLabel => GetAsync<string>();
        
        public Task addEventListener(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName,this);
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

        public async Task<DOMElement> cloneNode(bool deep)
        {
            DOMVar domVar = await ExecGetVarAsync(new object[] { deep });
            return new DOMElement(this._View2Control, domVar);
        }

        public async Task<DOMElement> closes(string selector)
        {
            DOMVar domVar = await ExecGetVarAsync( new object[] {selector});
            return new DOMElement(this._View2Control, domVar);
        }

        public Task<bool> contains(DOMElement element)
        {
            return Exec<bool>(new object[] { element });
        }

        public Task<string> contentEditable
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> dir
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> enterKeyHint
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }
        public Task exitFullscreen() => Exec<object>(new object[] { });

        public Task< DOMElement> firstChild
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<DOMElement> firstElementChild
        {
            get => GetTypedVar<DOMElement>();
        }

        public Task focus() => Exec<object>(new object[] { });


        public Task<bool> hasAttribute(string value) => Exec<bool>(new object[] { value });

        public Task<bool> hasAttributes() => Exec<bool>(new object[] { });

        public Task<bool> hasChildNodes() => Exec<bool>(new object[] { });


        public Task<bool> hidden
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> id
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> innerHTML
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<bool> inert
        {
            get => GetAsync<bool>();
            set=> _ = SetAsync(value);
        }

        public Task<string> innerText
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        
        public Task insertAdjacentElement(string position, DOMElement element)
        {
            return Exec<object>(new object[]{position,element});
        }

        public Task insertAdjacentHTML(string position, string html)
        {
            return Exec<object>(new object[]{position,html});
        }

        public Task insertAdjacentText(string position, string text)
        {
            return Exec<object>(new object[]{position, text});
        }

        public Task insertBefore(DOMElement newNode, DOMElement existingNode)
        {
            return Exec<object>(new object[] { newNode, existingNode });
        }

        public Task<bool> isContentEditable => GetAsync<bool>();

        public Task<bool> isDefaultNamespace(string nameSpace) => Exec<bool>(new object[] { nameSpace });

        public Task<bool> isEqualNode(DOMElement element) => Exec<bool>(new object[] { element });

        public Task<bool> isSameNode(DOMElement element) => Exec<bool>(new object[] { element});

        public Task<bool> isSupported(string feature, string version) => Exec<bool>(new object[] { feature, version });

        public Task<string> lang
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }
        
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

        public Task<string> nodeValue
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task normalize() => Exec<object>(new object[] { });

        public Task<int> offsetHeight => GetAsync<int>();
        public Task<int> offsetWidth => GetAsync<int>();
        public Task<int> offsetLeft => GetAsync<int>();
        public Task<int> offsetTop => GetAsync<int>();

        public Task<DOMElement > offsetParent
        {
            get => GetTypedVar<DOMElement>();

        }

        public Task<string> outerHTML
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> outerText
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

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

        public async Task<DOMElement> querySelector(string cssSelector)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }


        public Task remove() => Exec<object>(new object[] { });

        public Task removeAttribute(string name) => Exec<object>(new object[] { name });

        public Task removeAttributeNode(DOMAttribute attr) => Exec<object>(new object[] { attr });

        public Task removeChild(DOMElement elem) => Exec<object>(new object[] { elem});

        public Task replaceChild(DOMElement newNode, DOMElement oldNode) =>
            Exec<object>(new object[] { newNode, oldNode });

        public Task requestFullscreen() => Exec<object>(new object[] { });

        public Task<int> scrollHeight => GetAsync<int>();
        public Task scrollIntoView() => Exec<object>(new object[] { });
        public Task<int> scrollLeft => GetAsync<int>();

        public Task<int> scrollTop => GetAsync<int>();

        public Task setAttribute(string attributename, string attributevalue) =>
            Exec<object>(new object[] { attributename, attributevalue });


        public Task setAttributeNode(DOMVar attr) => Exec<object>(new object[] { attr.Name });

        public Task<string> title
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }
       
        public Task<int> tabIndex 
        {
            get => GetAsync<int>();
            set => _ = SetAsync(value);
        }

    }


}