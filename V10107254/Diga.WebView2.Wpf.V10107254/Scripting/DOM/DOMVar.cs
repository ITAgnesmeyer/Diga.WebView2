using System;
using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
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

        internal async Task CreateVarAsync()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";
            _ = await ExecuteScriptAsync(scriptTest);
            string scriptValue = $"{this.Name}=new Object();";
            _ = await ExecuteScriptAsync(scriptValue);
        }
        private void CreateVar()
        {
            string scriptTest = "if(window.diga == undefined) window.diga = new Object();";
           
            InvokeScript(scriptTest);
            string scriptValue = $"{this.Name}=new Object();";
            InvokeScript(scriptValue);
        }

        private void DeleteVar()
        {
            string scriptText = $"if({this.Name}) delete {this.Name};";
            InvokeScript(scriptText);

        }

 

        protected override string InstanceName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    DeleteVar();    
                }

                this.disposedValue = true;
            }
        }

       
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
