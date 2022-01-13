using System;

namespace Diga.WebView2.Wpf.Scripting
{
    public class ScriptException : Exception
    {
        public ScriptErrorObject ErrorObject { get; }
        public ScriptException(ScriptErrorObject errObj) : base(errObj.message)
        {
            this.ErrorObject = errObj;

        }
        public override string ToString()
        {
            string result = "";
            if (this.ErrorObject != null)
                result = this.ErrorObject.ToString();
            result += base.ToString();

            return result;
        }
    }
}
