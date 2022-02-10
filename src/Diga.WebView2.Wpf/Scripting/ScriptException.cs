using System;

namespace Diga.WebView2.Wpf.Scripting
{
    public class ScriptException : Exception
    {
        public ScriptErrorObject ErrorObject { get; }
        public ScriptException(ScriptErrorObject errObj) : base(errObj.message)
        {
            ErrorObject = errObj;

        }
        public override string ToString()
        {
            string result = "";
            if (ErrorObject != null)
                result = ErrorObject.ToString();
            result += base.ToString();

            return result;
        }
    }
}
