using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.WinForms.Scripting
{
    [ComVisible(true)]
    public class RpcObject :MarshalByRefObject, IRpcObject,ICloneable
    {
        public string id { get; set; }
        public string objId { get; set; }
        public string varname { get; set; }
        public string action { get; set; }
        public string param { get; set; }
        public object item { get; set; }
        public object Clone()
        {
            RpcObject destination = (RpcObject)this.MemberwiseClone();
            return destination;
        }
    }
}