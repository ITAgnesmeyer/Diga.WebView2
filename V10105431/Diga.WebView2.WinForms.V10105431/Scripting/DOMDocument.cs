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

        public Task<string> baseURI => GetAsync<string>();
        public void close() => Exec(new object[] { });
        public Task<string> characterSet => GetAsync<string>();

        public DOMWindow defaultView
        {
            get
            {
                DOMVar var = GetGetVar();
                return new DOMWindow(this._View2Control, var);
            }
        }

        public Task<string> GetDesignMode => GetAsync<string>("designMode");

        public void SetDesingMode(string value) => Set( value , "desingMode");

        public Task<string> GetDocumentURI => GetAsync<string>("documentURI");

        public void SetDocumentURI(string value) => Set(value , "documentURI");

        public Task<string> domain => GetAsync<string>();

        public Task<bool> execCommand(string command, bool showUI, string value)
        {
            return Exec<bool>(new object[] { command, showUI, value });
        }

        public Task<bool> fullscreenEnabled() => Exec<bool>(new object[] { });

        public Task<bool> hasFocus() => Exec<bool>(new object[] { });

        public Task<string> inputEncoding => GetAsync<string>();

        public Task<string> lastModified => GetAsync<string>();

        public void normalize() => Exec(new object[] { });

        public void open() => Exec(new object[] { });

        public Task<string> readyState => GetAsync<string>();

        public Task<string> referrer => GetAsync<string>();

        public Task<bool> GetStrictErrorChecking => GetAsync<bool>("strictErrorChecking");
        public void SetStrictErrorChecking(bool value) => Set(value , "strictErrorChecking");

        public Task<string> GetTitle => GetAsync<string>("title");
        public void SetTitle(string value) => Set(value, "title");

        public Task<string> URL => GetAsync<string>();

        public void write(params object[] parameters) => Exec(parameters);

        public void writeln(params object[] parameters) => Exec(parameters);

    }
}