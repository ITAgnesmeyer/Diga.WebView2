using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diga.Core.Threading;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMObject : ScriptObjectBase, IDisposable
    {
        protected string _InstanceName;
        public event EventHandler<RpcEventHandlerArgs> DomEvent;
        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }

        protected DOMVar _Var;
        private bool disposedValue;

        protected T GetCopy<T>() where T : DOMObject
        {
            DOMVar var = this.GetAsVar();
            DOMVar newVar = var.Copy();
            return GetDomObjectFromDomVar<T>(newVar);
        }
        protected DOMVar GetAsVar()
        {
            if (this._Var == null)
            {
                return new DOMVar(this._View2Control, this.InstanceName);
            }

            return this._Var;
        }
        internal DOMObject(IWebViewControl control) : base(control)
        {

        }

        internal DOMObject(IWebViewControl control, DOMVar var) : base(control)
        {
            this._InstanceName = var.Name;
            this._Var = var;
        }

        private object CreateNew(IWebViewControl control, DOMVar var, Type t)
        {
            if (t == null)
                throw new ArgumentNullException(nameof(t));
            if (control == null)
                throw new ArgumentNullException(nameof(control));
            if (var == null)
                throw new ArgumentNullException(nameof(var));
            if (t == typeof(CSSRule))
                return new CSSRule(control, var);
            if (t == typeof(CSSRuleList))
                return new CSSRuleList(control, var);
            if (t == typeof(CSSImportRule))
                return new CSSImportRule(control, var);

            if (t == typeof(CSSStyleSheet))
                return new CSSStyleSheet(control, var);
            if (t == typeof(CSSStyleSheetList))
                return new CSSStyleSheetList(control, var);



            if (t == typeof(DOMStyleElement))
                return new DOMStyleElement(control, var);

            if (t == typeof(DOMEvent))
                return new DOMEvent(control, var);
            if (t == typeof(DOMMouseEvent))
                return new DOMMouseEvent(control, var);
            if (t == typeof(DOMFocusEvent))
                return new DOMFocusEvent(control, var);
            if (t == typeof(DOMKeyboardEvent))
                return new DOMKeyboardEvent(control, var);
            if(t == typeof(DOMInputEvent))
                return new DOMInputEvent(control, var);
            if(t == typeof(DOMTouchEvent))
                return new DOMTouchEvent(control, var);
            if(t == typeof(DOMTouchList))
                return new DOMTouchList(control, var);
            if (t == typeof(DOMTouch))
                return new DOMTouch(control, var);

            if (t == typeof(DOMAttribute))
                return new DOMAttribute(control, var);
            if (t == typeof(DOMConsole))
                return new DOMConsole(control, var);
            if (t == typeof(DOMDialog))
                return new DOMDialog(control, var);
            if (t == typeof(DOMDocument))
                return new DOMDocument(control, var);
            if (t == typeof(DOMElement))
                return new DOMElement(control, var);
            if (t == typeof(DOMHistory))
                return new DOMHistory(control, var);

            if (t == typeof(DOMLink))
                return new DOMLink(control, var);

            if (t == typeof(DOMObjectCollection))
                return new DOMObjectCollection(control, var);
            if (t == typeof(DOMScript))
                return new DOMScript(control, var);

            if (t == typeof(DOMScriptVar))
                return new DOMScriptVar(control, var);


            if (t == typeof(DOMStyle))
                return new DOMStyle(control, var);

            if (t == typeof(DOMStorage))
                return new DOMStorage(control, var);

            if (t == typeof(DOMScreen))
                return new DOMScreen(control, var);
            if (t == typeof(DOMLocation))
                return new DOMLocation(control, var);

            if(t == typeof(DOMCanvasElement))
                return new DOMCanvasElement(control, var);

            if(t == typeof(TextMetrics))
                return new TextMetrics(control, var);
            if(t == typeof(CanvasRenderingContext2DSettings))
                return new CanvasRenderingContext2DSettings(control, var);

            if(t== typeof(CanvasUserInterface))
                return new CanvasUserInterface(control, var);

            if(t== typeof(ImageData))
                return new ImageData(control, var);
            if(t== typeof(MediaStream))
                return new MediaStream(control, var);

            if (t == typeof(DOMTokenList))
                return new DOMTokenList(control, var);

            if (t == typeof(DOMWindow))
                return new DOMWindow(control, var);

            if (t == typeof(DOMObject))
                return new DOMObject(control, var);

            throw new ArgumentException($"Type not supported:{t.Name}");
        }

        public T GetDomObjectFromVarName<T>(string varName) where T : DOMObject
        {
            DOMVar var = new DOMVar(this._View2Control, varName);
            return GetDomObjectFromDomVar<T>(var);

        }

        protected object GetDomObjectFromDomVar(Type type, DOMVar var)
        {
            if (!type.IsAssignableFrom(typeof(DOMObject)))
            {
                throw new ArgumentException(type.Name + " is not assigned from DOMObject");
            }

            return CreateNew(this._View2Control, var, type);
        }

        internal T GetDomObjectFromDomVar<T>(DOMVar var) where T : DOMObject
        {
            T v = (T)CreateNew(this._View2Control, var, typeof(T));
            return v;
        }
        protected async Task<T> GetTypedVarAsync<T>([CallerMemberName] string member = "") where T : DOMObject
        {
            DOMVar domVar = await GetGetVarAsync(member);
            T v = (T)CreateNew(this._View2Control, domVar, typeof(T));
            return v;
        }

        protected T GetTypedVar<T>([CallerMemberName] string member = "") where T : DOMObject
        {
            DOMVar domVar = GetGetVar(member);
            T v = (T)CreateNew(this._View2Control, domVar, typeof(T));
            return v;
        }

        protected T GetTypedVarIndexed<T>(int index, [CallerMemberName] string member = "")
        {
            DOMVar domVar = GetGetIndexedVar(index, member);
            T v = (T)CreateNew(this._View2Control, domVar, typeof(T));
            return v;
        }
        internal void RaiseEvent(RpcEventHandlerArgs e)
        {
            UIDispatcher.UIThread.Post<RpcEventHandlerArgs>(OnDomEvent, e);




        }

        protected virtual void OnDomEvent(RpcEventHandlerArgs e)
        {
            try
            {
                using (DOMVar var = new DOMVar(this._View2Control, e.RpcObject.idFullName))
                {
                    DomEvent?.Invoke(this, e);
                }
            }
            catch (Exception exception)
            {
                Debug.Print("DOMObject OnDomEvent Error:" + exception.Message);
            }
         

        }

        private DOMVar GetGetIndexedVar(int index, [CallerMemberName] string memeber = "")
        {
            DOMVar var = new DOMVar(this._View2Control);
            string script = $"{var.Name}={this.InstanceName}.{memeber}[{index}]";
            ExecuteScript(script);
            return var;
        }
        private DOMVar GetGetVar([CallerMemberName] string member = "")
        {
            try
            {
                DOMVar var = new DOMVar(this._View2Control);
                string scriptVal = $"{var.Name}={this.InstanceName}.{member};";
                ExecuteScript(scriptVal);
                return var;

            }
            catch (Exception e)
            {
                Debug.Print("DOMOjbect.GetGetVar error:" + e.Message);
                return null;
            }
        }
        private async Task<DOMVar> GetGetVarAsync([CallerMemberName] string member = "")
        {
            DOMVar var = await DOMVar.CreateAsync(this._View2Control);
            string scriptVal = $"{var.Name}={this.InstanceName}.{member};";
            await ExecuteScriptAsync(scriptVal);
            return var;
        }


        protected async Task<DOMVar> ExecGetVarAsync(object[] args, [CallerMemberName] string member = "")
        {
            string argsValue = BuildArgs(args);

            DOMVar var = await DOMVar.CreateAsync(this._View2Control);
            string scripVal = $"{var.Name}={this.InstanceName}.{member}({argsValue});";
            _ = ExecuteScriptAsync(scripVal);
            return var;
        }

        protected DOMVar ExecGetVar(object[] args, [CallerMemberName] string member = "")
        {
            string argsValue = BuildArgs(args);
            DOMVar var = new DOMVar(this._View2Control);
            string scripVal = $"{var.Name}={this.InstanceName}.{member}({argsValue});";
            ExecuteScript(scripVal);
            return var;
        }
        protected Task DomSetAsync(string id, string value, [CallerMemberName] string member = null)
        {
            return ExecuteScriptAsync($"document.getElementById(\"{id}\").{member}={value};");
        }

        protected void DomSet(string id, string value, [CallerMemberName] string member = null)
        {
            ExecuteScript($"document.getElementById(\"{id}\").{member}={value};");
        }

        protected string DomGet(string id, [CallerMemberName] string member = null)
        {
            return ExecuteScript($"return document.getElementById(\"{id}\").{member};");
        }
        protected async Task<string> DomGetAsync(string id, [CallerMemberName] string member = null)
        {
            return await ExecuteScriptAsync($"return document.getElementById(\"{id}\").{member};");
        }




        public async Task<string> EncodeUriAsync(string url)
        {
            return await ExecuteScriptAsync($"return encodeURI(\"{url}\");");
        }

        public async Task<string> EncodeUriComponentAsync(string url)
        {
            return await ExecuteScriptAsync($"return encodeURIComponent(\"{url}\");");
        }


        public async Task<string> DecodeUriAsync(string encodedUrl)
        {
            return await ExecuteScriptAsync($"return decodeURI(\"{encodedUrl}\");");
        }

        public async Task<string> DecodeUriComponentAsync(string encodedUrl)
        {
            return await ExecuteScriptAsync($"return decodeURIComponent(\"{encodedUrl}\");");
        }

        public async Task<string> EvalAsync(string script)
        {
            return await ExecuteScriptAsync($"return eval(\"{script}\");");
        }

        public Task DocumentOpenAsync()
        {
            return ExecuteScriptAsync("document.open();");
        }

        public Task DocumentCloseAsync()
        {
            return ExecuteScriptAsync("document.close();");
        }

        public Task DocumentWriteAsync(string value)
        {
            return ExecuteScriptAsync($"document.write(\"{value}\");");
        }

        public Task DocumentWriteLnAsync(string value)
        {
            return ExecuteScriptAsync($"document.writeln(\"{value}\");");
        }

        public bool VarExist()
        {
            if (this._Var == null) return false;
            return this._Var.VarExist();
        }

        public Task<bool> VarExistAsync()
        {
            if (this._Var == null) return Task.FromResult(false);
            return this._Var.VarExistAsync();
        }
        public string GetVarName()
        {
            return this.InstanceName;
        }

        public override string ToString()
        {
            return this.InstanceName;
        }

        public T GetProperty<T>(string propertyName)
        {
            Type type = typeof(T);
            if (type.IsAssignableFrom(typeof(DOMObject)))
            {
                DOMVar domVar = GetGetVar(propertyName);
                T v = (T)CreateNew(this._View2Control, domVar, type);
                return v;
            }
            return Get<T>(propertyName);
        }

        public void SetProperty<T>(string propertyName, T value)
        {
            Set<T>(value, propertyName);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this._Var?.Dispose();
                }
                this.disposedValue = true;
            }
        }

        public string GetTypeName()
        {
            string script = $"return Object.prototype.toString.call({this.InstanceName})";
            string result = ExecuteScript(script);
            result = result.Replace("\"[object ", "").Replace("]\"","");
            return result;

        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
