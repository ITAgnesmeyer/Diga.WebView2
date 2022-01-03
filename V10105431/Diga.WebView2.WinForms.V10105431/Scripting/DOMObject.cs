using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMObject:ScriptObjectBase
    {
        protected override string InstanceName
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        internal DOMObject(WebView control):base(control)
        {
            
        }

        protected DOMVar GetGetVar([CallerMemberName] string member = "")
        {
            DOMVar var = new DOMVar(this._View2Control);
            string scriptVal = $"{var.Name}={this.InstanceName}.{member};";
            InvokeScript(scriptVal);
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

        protected void DomSet(string id, string value, [CallerMemberName] string member = null)
        {
            this.InvokeScript($"document.getElementById(\"{id}\").{member}={value};");
        }

        protected async Task<string> DomGet(string id, [CallerMemberName] string member = null)
        {
            return await ExecuteScriptAsync($"return document.getElementById(\"{id}\").{member};");
        }

        //public async Task<string> Alert(string message)
        //{
        //    return await ExecuteScriptAsync($"return alert(\"{message}\");");
        //}

        //public async Task<string> Confirm(string message)
        //{
        //    return await ExecuteScriptAsync($"return confirm(\"{message}\");");
        //}

        //public async Task<string> Prompt(string message, string defaultResult = null)
        //{
        //    string promptScript = $"return prompt(\"{message}\",\"{defaultResult}\");";
        //    if (defaultResult == null)
        //    {
        //        promptScript = $"return prompt(\"{message}\");";
        //    }

        //    return await ExecuteScriptAsync(promptScript);
        //}


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
    }
}
