using System;
using System.Threading.Tasks;

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

        private void DeleteVar()
        {
            string scriptText = $"if({this.Name}) delete {this.Name};";
            ExecuteScript(scriptText);

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
