using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Diga.WebView2.Scripting.DOM
{
    public static class DOMGC
    {
        
        public static ConcurrentDictionary<Guid,DOMVar> _DomVars;
        public static ConcurrentDictionary<Guid,DOMVar> _DeleteVarQuery;

        static DOMGC()
        {
            SyncLock = new object();
            _DomVars = new ConcurrentDictionary<Guid,DOMVar>();
            _DeleteVarQuery = new ConcurrentDictionary<Guid, DOMVar>();
        }

        private static object SyncLock;
        public static void AddVar(DOMVar item)
        {
            _DomVars.TryAdd(item.ObjectGuid, item);

        }
        public static void RemoveVar(DOMVar item, bool noDirectRemove = false)
        {

            if (_DomVars.TryRemove(item.ObjectGuid, out DOMVar itemToRemove))
            {
                if (noDirectRemove)
                {
                    _DeleteVarQuery.TryAdd(item.ObjectGuid, itemToRemove);
                }
              
            }
        }

            

        public static void CleanUp()
        {

            var keys = _DeleteVarQuery.Keys.ToArray<Guid>();
            foreach (var key in keys)
            {
                if (_DeleteVarQuery.TryRemove(key, out DOMVar itemToRemove))
                {
                    itemToRemove.Dispose();
                }
            }


            
        }

    }
}