using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Diga.Core.Threading;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public static class DOMGC
    {
        public static List<DOMVar> _DomVars;

        static DOMGC()
        {
            SyncLock = new object();
            _DomVars = new List<DOMVar>();
        }

        private static object SyncLock;
        public static void AddVar(DOMVar item)
        {
            lock (SyncLock)
            {
                _DomVars.Add(item);
            }
        }

        public static void CleanUp()
        {
            UIDispatcher.UIThread.Post(() =>
            {


                lock (SyncLock)
                {
                    List<DOMVar> deleted = new List<DOMVar>();
                    foreach (DOMVar domVar in _DomVars)
                    {
                        if(!domVar.VarExist())
                            deleted.Add(domVar);
                        
                    }

                    while (deleted.Count > 0)
                    {
                        var dw = deleted[0];
                        _DomVars.Remove(dw);
                        deleted.RemoveAt(0);
                        dw.Dispose();
                        dw = null;
                    }

                    deleted = null;
                }
            });

        }

    }
    public class DOMVar : ScriptObjectBase, IDisposable
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
        private DOMVar(WebView control, bool noCreate = false) : base(control)
        {
            this._ObjectId = $"{_VarBase}{Guid.NewGuid().ToString().Replace("-", "_")}";
            if (noCreate)
            {

            }
            else
            {
                CreateVar();
            }
            DOMGC.AddVar(this);
        }

        internal DOMVar(WebView control, string objectId) : base(control)
        {
            this._ObjectId = objectId;
            DOMGC.AddVar(this);
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
            string scriptText = $"if(window.diga == undefined) return false;return {this.Name}!=undefined;";
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
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (UIDispatcher.UIThread.CheckAccess())
                    {
                        if (VarExist())
                            DeleteVar();

                    }

                }
               
                disposedValue = true;
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
