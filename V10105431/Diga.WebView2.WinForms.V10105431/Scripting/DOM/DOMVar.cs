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
        private readonly Guid _ObjectId;
        private bool disposedValue;
        private const string _VarBase = "window.diga._HEAP_";

        internal  DOMVar(WebView control, bool noCreate = false):base(control)
        {
            this._ObjectId = Guid.NewGuid();
            if (noCreate)
            {

            }
            else
            {
                CreateVar();    
            }
            
        }

        internal DOMVar(WebView control, Guid objectId) : base(control)
        {
            this._ObjectId = objectId;

        }
        public string Name => $"{_VarBase}{this._ObjectId.ToString().Replace("-","_")}";

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
            //string scritpTest2 = "if(window.diga._HEAP_==undefined) window.diga._heap = new Object();";
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
