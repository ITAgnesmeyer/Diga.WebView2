using System;

namespace Diga.WebView2.WinForms
{
    public class ScriptException:Exception
    {
        public ScriptErrorObject ErrorObject{get;}
        public ScriptException(ScriptErrorObject errObj)
        {
            this.ErrorObject= errObj;

        }
    }
    public class ScriptErrorObject
    {
        public string name{get;set;}
        public string message{get;set;}
        public string fileName{get;set;}
        public string lineNumber{get;set;}
        public string columnNumber{get;set;}
        public string stack{get;set;}

    }
}
