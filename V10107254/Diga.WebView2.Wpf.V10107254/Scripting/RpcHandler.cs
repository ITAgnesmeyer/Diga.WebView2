using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wpf.Scripting.DOM;

namespace Diga.WebView2.Wpf.Scripting
{
    internal static class EventHandlerList
    {
        public static readonly ConcurrentDictionary<string,DOMObject> EventObject;

        static EventHandlerList()
        {
            EventObject = new ConcurrentDictionary<string, DOMObject>();
        }

        public static void TryAdd(string key, DOMObject obj)
        {
            EventObject.TryAdd(key, obj);
        }

        public static DOMObject FindObject(string key)
        {
            if (key == null) return null;

            if (EventObject.TryGetValue(key, out DOMObject obj))
            {
                return obj;
            }

            return null;
        }

        public static void RaiseEvent(RpcEventHandlerArgs e)
        {

            DOMObject obj = FindObject(e.RpcObject.varname);
            if (obj != null)
                obj.RaiseEvent(e);

        }
    }

    [ComVisible(true)]
    public class RpcHandler
    {
        public Dictionary<string, object> RpcList = new Dictionary<string, object>();
        public object GetNewRpc()
        {
            var rpc = new RpcObject
            {
                id = Guid.NewGuid().ToString(),
                item = null
                
            };
            this.RpcList.Add(rpc.id,rpc);
            return rpc;
        }

       
        public bool ReleaseObject(object rpc)
        {
            
            
            
            IRpcObject rpcObj = (IRpcObject)rpc;

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
            IRpcObject o = (IRpcObject)obj;
            
            RpcEventHandlerArgs args = new RpcEventHandlerArgs(id, eventName, o);
            EventHandlerList.RaiseEvent(args);
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