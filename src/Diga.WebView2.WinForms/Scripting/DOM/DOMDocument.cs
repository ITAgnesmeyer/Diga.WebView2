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

        public DOMElement activeElement => GetTypedVar<DOMElement>();
        public Task< DOMElement> activeElementAsync => GetTypedVarAsync<DOMElement>(nameof(activeElement));

        public void addEventListener(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            if (EventHandlerList.TryAdd(this.InstanceName, this))
            {
                Exec(new object[]{eventName,scriptText, useCapture});
            }
            
        }

        public async Task addEventListenerAsync(string eventName, DOMScriptText scriptText , bool useCapture)
        {
            if (EventHandlerList.TryAdd(this.InstanceName, this))
            {
                await ExecAsync<object>(new object[]{eventName,scriptText, useCapture},nameof(addEventListener));
            }
            
        }


        public DOMElement adoptNode(DOMElement node)
        {
            DOMVar var = ExecGetVar(new object[] { node},nameof(adoptNode));
            return new DOMElement(this._View2Control, var);

        }
        public async Task<DOMElement> adoptNodeAsync(DOMElement node)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node},nameof(adoptNode));
            return new DOMElement(this._View2Control, var);
        }

        public DOMObjectCollection anchors => GetTypedVar<DOMObjectCollection>();
        public Task<DOMObjectCollection> anchorsAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(anchors));

        public DOMElement body
        {
            get => GetTypedVar<DOMElement>();
            set => Set(value);
        }
        public Task< DOMElement> bodyAsync
        {
            get=> GetTypedVarAsync<DOMElement>(nameof(body));
            set => _ = SetAsync(value,nameof(body));
        }


        public string baseURI => Get<string>();

        public Task<string> baseURIAsync => GetAsync<string>(nameof(baseURI));

        public void close() => Exec(new object[] { });
        public Task closeAsync() => ExecAsync<object>(new object[] { },nameof(close));

        public string cookie
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> cookieAsync
        {
            get => GetAsync<string>(nameof(cookie));
            set=> _ = SetAsync(value,nameof(cookie));
        }

        public string characterSet => Get<string>();
        public Task<string> characterSetAsync => GetAsync<string>(nameof(characterSet));


        public DOMAttribute createAttribute(string attributeName)
        {
            DOMVar var = ExecGetVar(new object[] { attributeName });
            return new DOMAttribute(this._View2Control, var);
        }
        public async Task< DOMAttribute> createAttributeAsync(string attributeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] {attributeName},nameof(createAttribute));
            return new DOMAttribute(this._View2Control, var);
        }

        public DOMElement createComment(string comment)
        {
            DOMVar var = ExecGetVar(new object[] { comment });
            return new DOMElement(this._View2Control, var);
        }
        public async Task< DOMElement> createCommentAsync(string comment)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { comment },nameof(createComment));
            return new DOMElement(this._View2Control, var);
        }

        public DOMElement createDocumentFragment()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMElement(this._View2Control, var);
        }
        public async Task< DOMElement> createDocumentFragmentAsync()
        {
            DOMVar var = await ExecGetVarAsync( new object[] { },nameof(createDocumentFragment));
            return new DOMElement(this._View2Control, var);
        }

        public DOMElement createElement(string nodeName)
        {
            DOMVar var = ExecGetVar(new object[] { nodeName });
            return new DOMElement(this._View2Control, var);
        }
        public async Task< DOMElement> createElementAsync(string nodeName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { nodeName },nameof(createElement));
            return new DOMElement(this._View2Control, var);
        }

        public DOMVar createEvent(string typeName)
        {
            DOMVar var = ExecGetVar(new object[] { typeName });
            return var;
        }
        public async  Task<DOMVar> createEventAsync(string typeName)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { typeName },nameof(createEvent));
            return var;
        }

        public DOMElement createTextNode(string text)
        {
            DOMVar var = ExecGetVar(new object[] { text });
            return new DOMElement(this._View2Control, var);
        }
        public async Task< DOMElement> createTextNodeAsync(string text)
        {
            DOMVar var = await  ExecGetVarAsync( new object[] { text },nameof(createTextNode));
            return new DOMElement(this._View2Control, var);
        }

        public DOMWindow defaultView => GetTypedVar<DOMWindow>();
        public Task<DOMWindow> defaultViewAsync => GetTypedVarAsync<DOMWindow>(nameof(defaultView));

        public DOMElement documentElement => GetTypedVar<DOMElement>();
        public Task<DOMElement> documentElementAsync => GetTypedVarAsync<DOMElement>(nameof(documentElement));

        public string designMode
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> designModeAsync
        {
            get => GetAsync<string>(nameof(designMode));
            set => _ = SetAsync(value,nameof(designMode));
        }

        public string documentURI
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> documentURIAsync
        {
            get => GetAsync<string>(nameof(documentURI));
            set => _ = SetAsync(value,nameof(documentURI));
        }


        public string domain => Get<string>();
        public Task<string> domainAsync => GetAsync<string>(nameof(domain));

        public DOMObjectCollection embeds => GetTypedVar<DOMObjectCollection>();
        
        public Task< DOMObjectCollection> embedsAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(embeds));

        public bool execCommand(string command, bool showUI, string value)
        {
            return Exec<bool>(new object[] { command, showUI, value });
        }
        public Task<bool> execCommandAsync(string command, bool showUI, string value)
        {
            return ExecAsync<bool>(new object[] { command, showUI, value },nameof(execCommand));
        }

        public DOMObjectCollection forms => GetTypedVar<DOMObjectCollection>();
        public Task<DOMObjectCollection> formsAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(forms));

        public DOMElement fullscreenElement => GetTypedVar<DOMElement>();
        public Task<DOMElement> fullscreenElementAsync => GetTypedVarAsync<DOMElement>(nameof(fullscreenElement));


        public bool fullscreenEnabled() => Exec<bool>(new object[] { });
        public Task<bool> fullscreenEnabledAsync() => ExecAsync<bool>(new object[] { },nameof(fullscreenEnabled));

        public DOMElement getElementById(string id)
        {
            DOMVar var = ExecGetVar(new object[] { id });
            return new DOMElement(this._View2Control, var);
        }
        public async  Task< DOMElement> getElementByIdAsync(string id)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { id },nameof(getElementById));
            return new DOMElement(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByClassName(string className)
        {
            DOMVar var = ExecGetVar(new object[] { className });
            return new DOMObjectCollection(this._View2Control, var);
        }
        public async Task< DOMObjectCollection> getElementsByClassNameAsync(string className)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { className },nameof(getElementsByClassName));
            return new DOMObjectCollection(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByName(string name)
        {
            DOMVar var = ExecGetVar(new object[] { name });
            return new DOMObjectCollection(this._View2Control, var);

        }
        public async  Task< DOMObjectCollection> getElementsByNameAsync(string name)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { name },nameof(getElementsByName));
            return new DOMObjectCollection(this._View2Control, var);
        }

        public DOMObjectCollection getElementsByTagName(string tagName)
        {
            DOMVar var = ExecGetVar(new object[] { tagName });
            return new DOMObjectCollection(this._View2Control, var);
        }
        public async Task< DOMObjectCollection> getElementsByTagNameAsyc(string tagName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { tagName },nameof(getElementsByTagName));
            return new DOMObjectCollection(this._View2Control, var);
        }

        public bool hasFocus() => Exec<bool>(new object[] { });
        public Task<bool> hasFocusAsync() => ExecAsync<bool>(new object[] { },nameof(hasFocus));
        private DOMElement _head;
        public DOMElement head
        {
            get
            {
                if (this._head == null)
                {
                    this._head = GetTypedVar<DOMElement>();
                }
                return this._head; 

            }
        }

        public Task<DOMElement> headAsync => GetTypedVarAsync<DOMElement>(nameof(head));

        public DOMObjectCollection images => GetTypedVar<DOMObjectCollection>();
        public Task<DOMObjectCollection> imagesAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(images));

        public DOMElement importNode(DOMElement node, bool deep)
        {
            DOMVar var = ExecGetVar(new object[] { node, deep });
            return new DOMElement(this._View2Control, var);

        }
        public async Task< DOMElement> importNodeAsync(DOMElement node, bool deep)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node, deep },nameof(importNode));
            return new DOMElement(this._View2Control, var);
        }

        public string inputEncoding => Get<string>();
        public Task<string> inputEncodingAsync => GetAsync<string>(nameof(inputEncoding));

        public string lastModified => Get<string>();
        public Task<string> lastModifiedAsync => GetAsync<string>(nameof(lastModified));

        public DOMObjectCollection links => GetTypedVar<DOMObjectCollection>();
        public Task<DOMObjectCollection> linksAsync => GetTypedVarAsync<DOMObjectCollection>(nameof(links));

        public void normalize() => Exec(new object[] { });
        public Task normalizeAsync() => ExecAsync<object>(new object[] { },nameof(normalize));

        public void open() => Exec(new object[] { });
        public Task openAsync() => ExecAsync<object>(new object[] { },nameof(open));

        public DOMElement querySelector(string cssSelector)
        {
            DOMVar var = ExecGetVar( new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }
        public async Task< DOMElement> querySelectorAsync(string cssSelector)
        {
            DOMVar var = await  ExecGetVarAsync( new object[] { cssSelector },nameof(querySelector));
            return new DOMElement(this._View2Control, var);
        }
        public DOMObjectCollection querySelectorAll(string cssSelector)
        {
            DOMVar var = ExecGetVar( new object[] { cssSelector });
            return new DOMObjectCollection(this._View2Control, var);
        }
        public async Task< DOMObjectCollection> querySelectorAllAsync(string cssSelector)
        {
            DOMVar var = await ExecGetVarAsync( new object[] { cssSelector },nameof(querySelectorAll));
            return new DOMObjectCollection(this._View2Control, var);
        }

        public string readyState => Get<string>();
        public Task<string> readyStateAsync => GetAsync<string>(nameof(readyState));

        public string referrer => Get<string>();
        public Task<string> referrerAsync => GetAsync<string>(nameof(referrer));

        public DOMElement renameNode(DOMElement node, string namespaceUri, string nodeName)
        {
            DOMVar var = ExecGetVar(new object[] { node, namespaceUri, nodeName });
            return new DOMElement(this._View2Control, var);
        }

        public async Task< DOMElement> renameNodeAsync(DOMElement node, string namespaceUri, string nodeName)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { node, namespaceUri, nodeName },nameof(renameNode));
            return new DOMElement(this._View2Control, var);
        }

        public bool strictErrorChecking
        {
            get => Get<bool>();
            set => Set(value);
        }
        public Task<bool> strictErrorCheckingAsync
        {
            get => GetAsync<bool>(nameof(strictErrorChecking));
            set=> _ = SetAsync(value,nameof(strictErrorChecking));
        }

        public CSSStyleSheetList styleSheets => GetTypedVar<CSSStyleSheetList>();
        public Task<CSSStyleSheetList> styleSheetsAsync => GetTypedVarAsync<CSSStyleSheetList>(nameof(styleSheets));

        public string title
        {
            get => Get<string>();
            set => Set(value);
        }
        public Task<string> titleAsync
        {
            get => GetAsync<string>(nameof(title));
            set => _ = SetAsync(value,nameof(title));
        }

        public string URL => Get<string>();       
        public Task<string> URLAsync => GetAsync<string>(nameof(URL));

        public void write(params object[] parameters) => Exec(parameters);
        public Task writeAsync(params object[] parameters) => ExecAsync<object>(parameters,nameof(write));

        public void writeln(params object[] parameters) => Exec(parameters);
        public Task writelnAsync(params object[] parameters) => ExecAsync<object>(parameters,nameof(writeln));

        private bool disposedValues=false;
        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValues)
            {
                if (disposing)
                {
                    _head?.Dispose();
                }
                this.disposedValues = true;
            }
            base.Dispose(disposing);
        }
    }
}