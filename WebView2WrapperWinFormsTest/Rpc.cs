using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;


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
        object Clone();
    }

    [ComVisible(true)]
    public class RpcCls :MarshalByRefObject, IRpcCls,ICloneable
    {
        public string id { get; set; }
        public string objId { get; set; }
        public string action { get; set; }
        public string param { get; set; }
        public object item { get; set; }
        public object Clone()
        {
            RpcCls destination = (RpcCls)this.MemberwiseClone();
            return destination;
        }
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
        public Dictionary<string, object> RpcList = new Dictionary<string, object>();
        public object GetNewRpc()
        {
            var rpc = new RpcCls
            {
                id = Guid.NewGuid().ToString(),
                item = null
                
            };
            this.RpcList.Add(rpc.id,rpc);
            return rpc;
        }

       
        public bool ReleaseObject(object rpc)
        {
            
            
            
            IRpcCls rpcObj = (IRpcCls)rpc;

            if (this.RpcList.ContainsKey(rpcObj.id))
            {
                this.RpcList.Remove(rpcObj.id);
                return true;
            }

            return false;
        }
        public event EventHandler<RpcEventHandlerArgs> RpcEvent; 
        public bool Handle(string id,  string eventName, object obj )
        {
            IRpcCls o = (IRpcCls)obj;


            //IRpcCls clonedObject = (IRpcCls)o.Clone();

            Debug.Print(o.id);
            
            RpcEventHandlerArgs args = new RpcEventHandlerArgs(id, eventName, o);
            OnRpcEvent(args);
            return true;
        }


        protected virtual void OnRpcEvent(RpcEventHandlerArgs e)
        {
            try
            {
                //this.Tasks.Enqueue(new Task(()=>{this.RpcEvent?.Invoke(this,e);}));
                this.RpcEvent?.Invoke(this,e);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                
            }
            
        }

     
    }
}