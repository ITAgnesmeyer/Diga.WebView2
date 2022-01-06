using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMObject : ScriptObjectBase, IDisposable

    {
        protected string _InstanceName;

        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }

        protected DOMVar _Var;
        private bool disposedValue;

        internal DOMObject(WebView control) : base(control)
        {

        }

        public object CreateNew(WebView control, DOMVar var, Type t)
        {
            if (t == null)
                throw new ArgumentNullException(nameof(t));
            if (control == null)
                throw new ArgumentNullException(nameof(control));
            if(var == null)
                throw new ArgumentNullException(nameof(var));

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
            
            if (t == typeof(DOMTokenList))
                return new DOMTokenList(control, var);

            if (t == typeof(DOMWindow))
                return new DOMWindow(control, var);

            throw new ArgumentException($"Type not supported:{t.Name}");
        }

        //protected DOMVar GetGetVar([CallerMemberName] string member = "")
        //{
        //    DOMVar var = new DOMVar(this._View2Control);
        //    string scriptVal = $"{var.Name}={this.InstanceName}.{member};";
        //    InvokeScript(scriptVal);
        //    return var;
        //}
        protected async Task<T> GetTypedVar<T>([CallerMemberName] string member = "") where T:DOMObject
        {
            DOMVar domVar = await GetGetVarAsync(member);
            T v = (T)CreateNew(this._View2Control, domVar, typeof(T));
            return v;
        }

        

        protected async Task<DOMVar> GetGetVarAsync([CallerMemberName] string member = "")
        {
            DOMVar var = await DOMVar.CreateAsync(this._View2Control);
            string scriptVal = $"{var.Name}={this.InstanceName}.{member};";
            await ExecuteScriptAsync(scriptVal);
            return var;
        }
        protected DOMVar ExecGetVar(object[] args, [CallerMemberName] string member = "")
        {
            string argsValue = BuildArgs(args);

            DOMVar var = new DOMVar(this._View2Control);

            string scripVal = $"{var.Name}={this.InstanceName}.{member}({argsValue});";
            InvokeScript(scripVal);
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

        protected void DomSet(string id, string value, [CallerMemberName] string member = null)
        {
            this.InvokeScript($"document.getElementById(\"{id}\").{member}={value};");
        }

        protected async Task<string> DomGet(string id, [CallerMemberName] string member = null)
        {
            return await ExecuteScriptAsync($"return document.getElementById(\"{id}\").{member};");
        }




        public async Task<string> EncodeUri(string url)
        {
            return await ExecuteScriptAsync($"return encodeURI(\"{url}\");");
        }

        public async Task<string> EncodeUriComponent(string url)
        {
            return await ExecuteScriptAsync($"return encodeURIComponent(\"{url}\");");
        }


        public async Task<string> DecodeUri(string encodedUrl)
        {
            return await ExecuteScriptAsync($"return decodeURI(\"{encodedUrl}\");");
        }

        public async Task<string> DecodeUriComponent(string encodedUrl)
        {
            return await ExecuteScriptAsync($"return decodeURIComponent(\"{encodedUrl}\");");
        }

        public async Task<string> Eval(string script)
        {
            return await ExecuteScriptAsync($"return eval(\"{script}\");");
        }

        public void DocumentOpen()
        {
            InvokeScript("document.open();");
        }

        public void DocumentClose()
        {
            InvokeScript("document.close();");
        }

        public void DocumentWrite(string value)
        {
            InvokeScript($"document.write(\"{value}\");");
        }

        public void DocumentWriteLn(string value)
        {
            InvokeScript($"document.writeln(\"{value}\");");
        }

        public string GetVarName()
        {
            return this.InstanceName;
        }

        public override string ToString()
        {
            return this.InstanceName;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   this._Var?.Dispose();
                }
                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
