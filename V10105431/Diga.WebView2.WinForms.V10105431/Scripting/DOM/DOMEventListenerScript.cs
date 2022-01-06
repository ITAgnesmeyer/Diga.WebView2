namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMEventListenerScript : DOMScriptText
    {
        public DOMEventListenerScript(DOMObject obj):base($"async () => {{ await window.external.raiseRpcEvent(\"click\",{obj.GetVarName()} ); }}")
        {
            
        }
    }
}