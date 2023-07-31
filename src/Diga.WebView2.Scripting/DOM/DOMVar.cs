using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Diga.Core.Threading;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMVar : ScriptObjectBase, IDisposable
    {

        public static async Task<DOMVar> CreateAsync(IWebViewControl control)
        {
            DOMVar dvar = new DOMVar(control, true);
            await dvar.CreateVarAsync();
            return dvar;

        }
        private readonly string _ObjectId;
        private bool disposedValue;
        private const string _VarBase = "window.diga._HEAP_";

        internal DOMVar(IWebViewControl control) : this(control, false)
        {

        }
        private DOMVar(IWebViewControl control, bool noCreate = false) : base(control)
        {
            this._ObjectId = $"{_VarBase}{Guid.NewGuid().ToString().Replace("-", "_")}";
            if (noCreate)
            {

            }
            else
            {
                CreateVar();
            }
            //DOMGC.AddVar(this);
        }

        internal DOMVar(IWebViewControl control, string objectId) : base(control)
        {
            this._ObjectId = objectId;
            //DOMGC.AddVar(this);
        }
        public string Name => this._ObjectId;

        private async Task CreateVarAsync()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";
            //_ = await ExecuteScriptAsync(scriptTest);
            string scriptValue = $"{scriptTest}{this.Name}=new Object();";
            _ = await ExecuteScriptAsync(scriptValue);
        }
        private void CreateVar()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";

            //ExecuteScript(scriptTest);
            string scriptValue = $"{scriptTest}{this.Name}=new Object();";
            ExecuteScript(scriptValue);
        }

        public async Task<bool> VarExistAsync()
        {
            string scriptText = $"return {this.Name}!=undefined;";
            try
            {
                object retVal = await ExecuteScriptAsync(scriptText);
                return (bool)Convert.ChangeType(retVal, TypeCode.Boolean);

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool VarExist()
        {
            string scriptText = $"if(window.diga == undefined) return false;return {this.Name}!=undefined;";
            try
            {
                object retVal = ExecuteScript(scriptText);
                return (bool)Convert.ChangeType(retVal, TypeCode.Boolean);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void DeleteVar()
        {
            try
            {

                string scriptText = $"if({this.Name}!=undefined) delete {this.Name};";
                ExecuteScript(scriptText);
            }
            catch (Exception e)
            {
                Debug.Print("DOMVar.DeleteVar Error:" + e.Message);
            }

        }

        private async Task DeleteVarAsync()
        {
            try
            {
                string scriptText = $"if({this.Name}!=undefined) delete {this.Name};";
                await ExecuteScriptAsync(scriptText);
            }
            catch (Exception e)
            {
                Debug.Print("DOMVar.DeleteVarAsync Error:" + e.Message);
            }

        }
        public async Task<DOMVar> CopyAsync()
        {
            DOMVar var = await DOMVar.CreateAsync(this._View2Control);
            bool exist = await this.VarExistAsync();
            if (!exist)
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

        public override string ToString()
        {
            return this.Name;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    if (UIDispatcher.UIThread.CheckAccess())
                    {
                        if (VarExist())
                            DeleteVar();

                    }
                }
                this.disposedValue = true;
            }
        }

        //~DOMVar()
        //{
        //    Dispose(false);
        //}
        public async Task DisposeAsync()
        {
            await DeleteVarAsync();
            this.Dispose(false);
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
