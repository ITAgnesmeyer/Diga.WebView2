using System;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMElement : DOMElementEvents
    {


        internal DOMElement(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {

        }

        public IWebViewControl Control => this._View2Control;
        public DOMVar Var => this._Var;
        public virtual DOMElement GetCopy()
        {
            return base.GetCopy<DOMElement>();
        }
        public string accessKey
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> accessKeyAsync
        {
            get => GetAsync<string>(nameof(this.accessKey));
            set => _ = SetAsync(value, nameof(this.accessKey));
        }

        public string accessKeyLabel => Get<string>();
        public Task<string> accessKeyLabelAsync => GetAsync<string>(nameof(this.accessKeyLabel));


        public void appendChild(DOMElement element)
        {
            Exec(new object[] { element });
        }
        public Task appendChildAsync(DOMElement element)
        {
            return ExecAsync<object>(new object[] { element }, nameof(appendChild));
        }

        public void blur() => Exec(new object[] { });
        public Task blurAsync() => ExecAsync<object>(new object[] { }, nameof(blur));


        public int childElementCount => Get<int>();
        public Task<int> childElementCountAsync => GetAsync<int>(nameof(this.childElementCount));

        public string className
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> classNameAsync
        {
            get => GetAsync<string>(nameof(this.className));
            set => _ = SetAsync(value, nameof(this.className));

        }

        public void click() => Exec(new object[] { });
        public Task clickAsync() => ExecAsync<object>(new object[] { }, nameof(click));

        public int clientHeight => Get<int>();
        public Task<int> clientHeightAsync => GetAsync<int>(nameof(this.clientHeight));
        public int clientLeft => Get<int>();
        public Task<int> clientLeftAsync => GetAsync<int>(nameof(this.clientLeft));
        public int clientTop => Get<int>();
        public Task<int> clientTopAsync => GetAsync<int>(nameof(this.clientTop));

        public int clientWidth => Get<int>();
        public Task<int> clientWidthAsync => GetAsync<int>(nameof(this.clientWidth));

        public DOMElement cloneNode(bool deep)
        {
            DOMVar domVar = ExecGetVar(new object[] { deep });
            return new DOMElement(this._View2Control, domVar);
        }
        public async Task<DOMElement> cloneNodeAsync(bool deep)
        {
            DOMVar domVar = await ExecGetVarAsync(new object[] { deep }, nameof(cloneNode));
            return new DOMElement(this._View2Control, domVar);
        }

        public DOMElement closes(string selector)
        {
            DOMVar domVar = ExecGetVar(new object[] { selector });
            return new DOMElement(this._View2Control, domVar);
        }
        public async Task<DOMElement> closesAsync(string selector)
        {
            DOMVar domVar = await ExecGetVarAsync(new object[] { selector }, nameof(closes));
            return new DOMElement(this._View2Control, domVar);
        }

        public bool contains(DOMElement element)
        {
            return Exec<bool>(new object[] { element });
        }
        public Task<bool> containsAsync(DOMElement element)
        {
            return ExecAsync<bool>(new object[] { element }, nameof(contains));
        }

        public string contentEditable
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> contentEditableAsync
        {
            get => GetAsync<string>(nameof(this.contentEditable));
            set => _ = SetAsync(value);
        }

        public string dir
        {
            get => Get<string>();
            set => Set(value);

        }
        public Task<string> dirAsync
        {
            get => GetAsync<string>(nameof(this.dir));
            set => _ = SetAsync(value, nameof(this.dir));
        }

        public string enterKeyHint
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> enterKeyHintAsync
        {
            get => GetAsync<string>(nameof(this.enterKeyHint));
            set => _ = SetAsync(value, nameof(this.enterKeyHint));
        }
        public void exitFullscreen() => Exec(new object[] { });
        public Task exitFullscreenAsync() => ExecAsync<object>(new object[] { }, nameof(exitFullscreen));
        
        public DOMElement firstChild => GetTypedVar<DOMElement>();
        public Task<DOMElement> firstChildAsync => GetTypedVarAsync<DOMElement>(nameof(this.firstChild));

        public DOMElement firstElementChild => GetTypedVar<DOMElement>();
        public Task<DOMElement> firstElementChildAsync => GetTypedVarAsync<DOMElement>(nameof(this.firstElementChild));
        public void focus() => Exec(new object[] { });

        public Task focusAsync() => ExecAsync<object>(new object[] { }, nameof(focus));

        public bool hasAttribute(string value) => Exec<bool>(new object[] { value });
        public Task<bool> hasAttributeAsync(string value) => ExecAsync<bool>(new object[] { value }, nameof(hasAttribute));

        public bool hasAttributes() => Exec<bool>(new object[] { });
        public Task<bool> hasAttributesAsync() => ExecAsync<bool>(new object[] { }, nameof(hasAttributes));

        public bool hasChildNodes() => Exec<bool>(new object[] { });
        public Task<bool> hasChildNodesAsync() => ExecAsync<bool>(new object[] { }, nameof(hasChildNodes));

        public bool hidden
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> hiddenAsync
        {
            get => GetAsync<bool>(nameof(this.hidden));
            set => _ = SetAsync(value, nameof(this.hidden));
        }

        public string id
        {
            get => Get<string>();
            set => Set(value);

        }
        public Task<string> idAsync
        {
            get => GetAsync<string>(nameof(this.id));
            set => _ = SetAsync(value, nameof(this.id));
        }

        public string innerHTML
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> innerHTMLAsync
        {
            get => GetAsync<string>(nameof(this.innerHTML));
            set => _ = SetAsync(value, nameof(this.innerHTML));
        }

        public bool inert
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> inertAsync
        {
            get => GetAsync<bool>(nameof(this.inert));
            set => _ = SetAsync(value, nameof(this.inert));
        }

        public string innerText
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> innerTextAsync
        {
            get => GetAsync<string>(nameof(this.innerText));
            set => _ = SetAsync(value, nameof(this.innerText));
        }

        public void insertAdjacentElement(string position, DOMElement element) =>
            Exec(new object[] { position, element });
        public Task insertAdjacentElementAsync(string position, DOMElement element)
        {
            return ExecAsync<object>(new object[] { position, element }, nameof(insertAdjacentElement));
        }

        public void insertAdjacentHTML(string position, string html)
        {
            Exec(new object[] { position, html });
        }

        public Task insertAdjacentHTMLAsync(string position, string html)
        {
            return ExecAsync<object>(new object[] { position, html }, nameof(insertAdjacentHTML));
        }

        public void insertAdjacentText(string position, string text)
        {
            Exec(new object[] { position, text });
        }

        public Task insertAdjacentTextAsync(string position, string text)
        {
            return ExecAsync<object>(new object[] { position, text }, nameof(insertAdjacentText));
        }

        public void insertBefore(DOMElement newNode, DOMElement existingNode)
        {
            Exec(new object[] { newNode, existingNode });
        }

        public Task insertBeforeAsync(DOMElement newNode, DOMElement existingNode)
        {
            return ExecAsync<object>(new object[] { newNode, existingNode }, nameof(insertBefore));
        }

        public bool isContentEditable => Get<bool>();
        public Task<bool> isContentEditableAsync => GetAsync<bool>(nameof(this.isContentEditable));

        public bool isDefaultNamespace(string nameSpace) => Exec<bool>(new object[] { nameSpace });
        public Task<bool> isDefaultNamespaceAsync(string nameSpace) => ExecAsync<bool>(new object[] { nameSpace }, nameof(isDefaultNamespace));

        public bool isEqualNode(DOMElement element) => Exec<bool>(new object[] { element });

        public Task<bool> isEqualNodeAsync(DOMElement element) => ExecAsync<bool>(new object[] { element }, nameof(isEqualNode));

        public bool isSameNode(DOMElement element) => Exec<bool>(new object[] { element });
        public Task<bool> isSameNodeAsync(DOMElement element) => ExecAsync<bool>(new object[] { element }, nameof(isSameNode));

        public bool isSupported(string feature, string version) => Exec<bool>(new object[] { feature, version });
        public Task<bool> isSupportedAsync(string feature, string version) => ExecAsync<bool>(new object[] { feature, version }, nameof(isSupported));

        public string lang
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> langAsync
        {
            get => GetAsync<string>(nameof(this.lang));
            set => _ = SetAsync(value, nameof(this.lang));
        }

        public DOMElement lastChild => GetTypedVar<DOMElement>();
        public Task<DOMElement> lastChildAsync => GetTypedVarAsync<DOMElement>(nameof(this.lastChild));
        public bool matches(string selectors) => Exec<bool>(new object[] { selectors });
        public Task<bool> matchesAsync(string selectors) => ExecAsync<bool>(new object[] { selectors }, nameof(matches));

        public string namespaceURI => Get<string>();
        public Task<string> namespaceURIAsync => GetAsync<string>(nameof(this.namespaceURI));

        public DOMElement nextSibling => GetTypedVar<DOMElement>();


        public Task<DOMElement> nextSiblingAsync => GetTypedVarAsync<DOMElement>(nameof(this.nextSibling));


        public DOMElement nextElementSibling => GetTypedVar<DOMElement>();


        public Task<DOMElement> nextElementSiblingAsync => GetTypedVarAsync<DOMElement>(nameof(this.nextElementSibling));

        public string nodeName => Get<string>();
        public Task<string> nodeNameAsync => GetAsync<string>(nameof(this.nodeName));

        public int nodeType => Get<int>();
        public Task<int> nodeTypeAsync => GetAsync<int>(nameof(this.nodeType));

        public string nodeValue
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> nodeValueAsync
        {
            get => GetAsync<string>(nameof(this.nodeValue));
            set => _ = SetAsync(value, nameof(this.nodeValue));
        }

        public void normalize() => Exec(new object[] { });
        public Task normalizeAsync() => ExecAsync<object>(new object[] { }, nameof(normalize));

        public int offsetHeight => Get<int>();
        public Task<int> offsetHeightAsync => GetAsync<int>(nameof(this.offsetHeight));
        public int offsetWidth => Get<int>();
        public Task<int> offsetWidthAsync => GetAsync<int>(nameof(this.offsetWidth));

        public int offsetLeft => Get<int>();
        public Task<int> offsetLeftAsync => GetAsync<int>(nameof(this.offsetLeft));
        public int offsetTop => Get<int>();
        public Task<int> offsetTopAsync => GetAsync<int>(nameof(this.offsetTop));

        public DOMElement offsetParent => GetTypedVar<DOMElement>();

        public Task<DOMElement> offsetParentAsync => GetTypedVarAsync<DOMElement>(nameof(this.offsetParent));

        public string outerHTML
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> outerHTMLAsync
        {
            get => GetAsync<string>(nameof(this.outerHTML));
            set => _ = SetAsync(value, nameof(this.outerHTML));
        }

        public string outerText
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> outerTextAsync
        {
            get => GetAsync<string>(nameof(this.outerText));
            set => _ = SetAsync(value, nameof(this.outerText));
        }

        private DOMDocument _ownerDocument;
        public DOMDocument ownerDocument
        {
            get
            {
                if (this._ownerDocument == null)
                {
                    this._ownerDocument = GetTypedVar<DOMDocument>();
                }
                else
                {
                    if (!this._ownerDocument.VarExist())
                        this._ownerDocument = GetTypedVar<DOMDocument>();
                }
                return this._ownerDocument;
            }
        }

        public Task<DOMDocument> ownerDocumentAsync
        {
            get => GetTypedVarAsync<DOMDocument>(nameof(this.ownerDocument));
        }


        public DOMElement parentNode => GetTypedVar<DOMElement>();

        public Task<DOMElement> parentNodeAsync => GetTypedVarAsync<DOMElement>(nameof(this.parentNode));


        public DOMElement parentElement => GetTypedVar<DOMElement>();

        public Task<DOMElement> parentElementAsync => GetTypedVarAsync<DOMElement>(nameof(this.parentElement));
        public DOMElement previousSibling => GetTypedVar<DOMElement>();
        public Task<DOMElement> previousSiblingAsync => GetTypedVarAsync<DOMElement>(nameof(this.parentElement));

        public DOMElement previousElementSibling => GetTypedVar<DOMElement>(nameof(this.previousElementSibling));
        public Task<DOMElement> previousElementSiblingAsync => GetTypedVarAsync<DOMElement>(nameof(this.previousElementSibling));

        public DOMElement querySelector(string cssSelector)
        {
            DOMVar var = ExecGetVar(new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }

        public async Task<DOMElement> querySelectorAsync(string cssSelector)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { cssSelector }, nameof(querySelector));
            return new DOMElement(this._View2Control, var);
        }

        public void remove() => Exec(new object[] { });
        public Task removeAsync() => ExecAsync<object>(new object[] { }, nameof(remove));

        public void removeAttribute(string name) => Exec(new object[] { name });

        public Task removeAttributeAsync(string name) => ExecAsync<object>(new object[] { name }, nameof(removeAttribute));


        public void removeAttributeNode(DOMAttribute attr) => Exec(new object[] { attr });
        public Task removeAttributeNodeAsync(DOMAttribute attr) => ExecAsync<object>(new object[] { attr }, nameof(removeAttributeNode));

        public void removeChild(DOMElement elem) => Exec(new object[] { elem });
        public Task removeChildAsync(DOMElement elem) => ExecAsync<object>(new object[] { elem }, nameof(removeChild));

        public void replaceChild(DOMElement newNode, DOMElement oldNode) =>
            Exec(new object[] { newNode, oldNode });

        public Task replaceChildAsync(DOMElement newNode, DOMElement oldNode) =>
            ExecAsync<object>(new object[] { newNode, oldNode }, nameof(replaceChild));

        public void requestFullscreen() => Exec(new object[] { });
        public Task requestFullscreenAsync() => ExecAsync<object>(new object[] { }, nameof(requestFullscreen));

        public int scrollHeight => Get<int>();
        public Task<int> scrollHeightAsync => GetAsync<int>(nameof(this.scrollHeight));

        public void scrollIntoView() => Exec(new object[] { });
        public Task scrollIntoViewAsync() => ExecAsync<object>(new object[] { }, nameof(scrollIntoView));
        public int scrollLeft => Get<int>();
        public Task<int> scrollLeftAsync => GetAsync<int>(nameof(this.scrollLeft));

        public int scrollTop => Get<int>();
        public Task<int> scrollTopAsync => GetAsync<int>(nameof(this.scrollTop));

        public void setAttribute(string attributeName, string attributeValue) =>
            Exec(new object[] { attributeName, attributeValue });

        public Task setAttributeAsync(string attributeName, string attributeValue) =>
            ExecAsync<object>(new object[] { attributeName, attributeValue }, nameof(setAttribute));


        public void setAttributeNode(DOMVar attr) => Exec(new object[] { attr.Name });

        public Task setAttributeNodeAsync(DOMVar attr) => ExecAsync<object>(new object[] { attr.Name }, nameof(setAttributeNode));

        private DOMStyle _style;
        public DOMStyle style
        {
            get
            {
                //if (this._style == null)
                //{
                //    this._style = GetTypedVar<DOMStyle>();
                //}

                return GetTypedVar< DOMStyle>();
            }
        }

        public Task<DOMStyle> styleAsync => GetTypedVarAsync<DOMStyle>(nameof(this.style));

        public string title
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> titleAsync
        {
            get => GetAsync<string>(nameof(this.title));
            set => _ = SetAsync(value, nameof(this.title));
        }

        public int tabIndex
        {
            get => Get<int>();
            set => Set(value);
        }
        public Task<int> tabIndexAsync
        {
            get => GetAsync<int>(nameof(this.tabIndex));
            set => _ = SetAsync(value, nameof(this.tabIndex));
        }

        public T GetElementProperty<T>(string propertyName)
        {
            return Get<T>(propertyName);
        }

        public Task<T> GetElementPropertyAsync<T>(string propertyName)
        {
            return GetAsync<T>(propertyName);
        }

        public void SetPropertyValue<T>(string propertyName, T value)
        {
            Set<T>(value, propertyName);
        }

        public Task SetPropertyValueAsync<T>(string propertyName, T value)
        {
            return SetAsync<T>((TaskVar<T>)value, propertyName);

        }

        public T ExecuteElementFunction<T>(string functionName, params object[] values)
        {
            Type type = typeof(T);
            if (type.IsAssignableFrom(typeof(DOMObject)))
            {
                DOMVar var = ExecGetVar(values, functionName);
                return (T)GetDomObjectFromDomVar(type, var);

            }

            return Exec<T>(values, functionName);

        }

        public async Task<T> ExecuteElementFunctionAsync<T>(string functionName, params object[] values)
        {
            Type type = typeof(T);
            if (type.IsAssignableFrom(typeof(DOMObject)))
            {
                DOMVar var = await ExecGetVarAsync(values, functionName);
                return (T)GetDomObjectFromDomVar(type, var);

            }
            else
            {
                return await ExecAsync<T>(values, functionName);
            }
        }
        private bool disposedValue = false;
        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this._ownerDocument?.Dispose();
                    this._style?.Dispose();
                }

                this.disposedValue = true;
            }
            base.Dispose(disposing);
        }
    }


}