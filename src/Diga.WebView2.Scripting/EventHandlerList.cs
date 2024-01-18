using System.Collections.Concurrent;
using System.Collections.Generic;
using Diga.WebView2.Scripting.DOM;

namespace Diga.WebView2.Scripting
{
    internal static class EventHandlerList
    {
        private static readonly ConcurrentDictionary<string,DOMObject> EventObject;

        static EventHandlerList()
        {
            LockObject = new object();
            EventObject = new ConcurrentDictionary<string, DOMObject>();
        }

        public static bool TryAdd(string key, DOMObject obj)
        {
            if (EventObject.ContainsKey(key)) return false;
            return EventObject.TryAdd(key, obj);
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
            obj?.RaiseEvent(e);

        }

        private static readonly object LockObject;
        internal static void RemoveByObject(DOMObject domObj)
        {
            var idList = new List<string>();
            lock (LockObject)
            {
                var obj = EventObject.ToArray();
                foreach (var item in obj)
                {
                    if (item.Value == domObj)
                    {
                        idList.Add(item.Key);
                    }
                    
                }

                foreach (string key in idList)
                {
                    EventObject.TryRemove(key, out _);

                }
            }
        }
    }
}