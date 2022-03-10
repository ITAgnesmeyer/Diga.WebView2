using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMScriptVar : DOMVar
    {
        private readonly DOMScriptText _ScriptText;
        public DOMScriptVar(IWebViewControl control,DOMScriptText scriptText):base(control)
        {
            this._ScriptText = scriptText;
            SetVar();
        }

        public DOMScriptVar(IWebViewControl control, DOMVar var):base(control, var.Name)
        {
            this._ScriptText = new DOMScriptText("");
        }

        private void SetVar()
        {
            string argsValue = BuildArgs(new object[] { this._ScriptText });
            string script = $"{this.Name}={argsValue};";
            ExecuteScript(script);
        }
        public DOMScriptText ScriptText => this._ScriptText;
        
    }
}