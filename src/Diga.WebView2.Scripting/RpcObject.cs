using Diga.Core.Api.Win32.Com;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
namespace Diga.WebView2.Scripting
{


   

   
       
 

   

    [ComVisible(true)]
    public class RpcObject :MarshalByRefObject, IRpcObject,ICloneable
    {
        public string id { get; set; }
        public string objId { get; set; }
        public string varname { get; set; }
        public string action { get; set; }
        public string param { get; set; }
        private object _item;
        public object item 
        { 
            get 
            {
                return this._item;
            }
            set 
            { 
                
                this._item = value; 
            }
        }
        public string idFullName => "window.diga._HEAP_" + this.id.Replace("-", "_");
        public string idName=>"_HEAP_" + this.id.Replace("-", "_");
        public object Clone()
        {
            RpcObject destination = (RpcObject)this.MemberwiseClone();
            return destination;
        }
    }
}