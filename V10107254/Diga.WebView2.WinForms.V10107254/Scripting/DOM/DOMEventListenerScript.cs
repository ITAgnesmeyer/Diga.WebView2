namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMEventListenerScript : DOMScriptText
    {
        public DOMEventListenerScript(DOMObject obj, string eventName):base($"async (e) => {{ await window.external.raiseRpcEvent(\"{eventName}\",{obj.GetVarName()},\"{obj.GetVarName()}\",e); }}")
        {
            
        }
    }
}