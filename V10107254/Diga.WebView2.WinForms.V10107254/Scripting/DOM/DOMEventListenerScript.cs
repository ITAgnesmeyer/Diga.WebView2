namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMEventListenerScript : DOMScriptText
    {
        public DOMEventListenerScript(DOMObject obj):base($"async (e) => {{ await window.external.raiseRpcEvent(\"click\",{obj.GetVarName()},\"{obj.GetVarName()}\",e); }}")
        {
            
        }
    }
}