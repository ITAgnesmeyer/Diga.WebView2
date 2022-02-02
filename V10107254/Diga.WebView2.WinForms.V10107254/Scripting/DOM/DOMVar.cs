using System;
using System.Threading.Tasks;
using Diga.Core.Threading;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMVar:ScriptObjectBase,IDisposable
    {

        public static async Task<DOMVar> CreateAsync(WebView control)
        {
            DOMVar dvar = new DOMVar(control, true);
            await dvar.CreateVarAsync();
            return dvar;

        }
        private readonly string _ObjectId;
        private bool disposedValue;
        private const string _VarBase = "window.diga._HEAP_";

        internal DOMVar(WebView control) : this(control, false)
        {

        }
        private DOMVar(WebView control, bool noCreate = false):base(control)
        {
            this._ObjectId =$"{_VarBase}{Guid.NewGuid().ToString().Replace("-","_")}" ;
            if (noCreate)
            {

            }
            else
            {
                CreateVar();    
            }
            
        }

        internal DOMVar(WebView control, string objectId) : base(control)
        {
            this._ObjectId = objectId;

        }
        public string Name => this._ObjectId;

        private async Task CreateVarAsync()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";
            _ = await ExecuteScriptAsync(scriptTest);
            string scriptValue = $"{this.Name}=new Object();";
            _ = await ExecuteScriptAsync(scriptValue);
        }
        private void CreateVar()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";
           
            ExecuteScript(scriptTest);
            string scriptValue = $"{this.Name}=new Object();";
            ExecuteScript(scriptValue);
        }

        public async Task<bool> VarExistAsync()
        {
            string scriptText = $"return {this.Name}!=undefined;";
            object retVal = await ExecuteScriptAsync(scriptText);
            return (bool)Convert.ChangeType(retVal, TypeCode.Boolean);
        }
        public bool VarExist()
        {
            string scriptText = $"return {this.Name}!=undefined;";
            object retVal = ExecuteScript(scriptText);
            return (bool)Convert.ChangeType(retVal, TypeCode.Boolean);
        }
        private void DeleteVar()
        {
            string scriptText = $"if({this.Name}!=undefined) delete {this.Name};";
            ExecuteScript(scriptText);

        }

        private async Task DeleteVarAsync()
        {
            string scriptText = $"if({this.Name}!=undefined) delete {this.Name};";
            await ExecuteScriptAsync(scriptText);
        }
        public async Task<DOMVar> CopyAsync()
        {
            DOMVar var = await DOMVar.CreateAsync(this._View2Control);
            bool exist = await this.VarExistAsync();
            if(!exist)
                throw new InvalidOperationException($"the var({this.Name}) does not exist");
            string scriptText = $"{var.Name}={this.Name};";
            await ExecuteScriptAsync(scriptText);
            return var;
        }
        public DOMVar Copy()
        {
            DOMVar var = new DOMVar(this._View2Control);
            if (!this.VarExist())
                throw new InvalidOperationException($"the var({this.Name}) does not exist");

            string scriptText = $"{var.Name}={this.Name};";
            ExecuteScript(scriptText);
            return var;
        }

        protected override string InstanceName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(UIDispatcher.UIThread.CheckAccess())
                        DeleteVar();    
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
