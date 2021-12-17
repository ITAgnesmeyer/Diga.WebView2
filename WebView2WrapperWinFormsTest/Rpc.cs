using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WebView2WrapperWinFormsTest
{
    [Guid("492AB1FF-FF27-4A23-93A8-540A4B9DAC37")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRpcCls
    {
        string id { get; set; }
        string objId { get; set; }
        string action { get; set; }
        string param { get; set; }
        object item { get; set; }

    }

    [ComVisible(true)]
    public class RpcCls:IRpcCls
    {
        public string id { get; set; }
        public string objId { get; set; }
        public string action { get; set; }
        public string param { get; set; }
        public object item { get; set; }
    }

    public class RpcEventHandlerArgs : EventArgs
    {
        public IRpcCls RpcObject { get; }
        public string EventName { get; }
        public string ObjectId { get; }

        public RpcEventHandlerArgs(string id, string eventName, IRpcCls rpc)
        {
            this.ObjectId = id;
            this.EventName=eventName;
            this.RpcObject = rpc;
        }
    }

    [ComVisible(true)]
    public class RpcHandler
    {

        public object GetNewRpc()
        {
            var rpc = new RpcCls
            {
                id = Guid.NewGuid().ToString(),
                item = null
                
            };
            return rpc;
        }
        public event EventHandler<RpcEventHandlerArgs> RpcEvent; 
        public bool Handle(string id,  string eventName, object obj )
        {
            IRpcCls o = (IRpcCls)obj;
            Debug.Print(o.id);
            RpcEventHandlerArgs args = new RpcEventHandlerArgs(id, eventName, o);
            OnRpcEvent(args);
            return true;
        }

        
        protected virtual void OnRpcEvent(RpcEventHandlerArgs e)
        {
            try
            {
                RpcEvent?.Invoke( this, e);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                
            }
            
        }

     
    }
}