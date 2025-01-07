using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Diga.WebView2.Scripting.DOM
{
    public static class DOMGC
    {
        
        internal static ConcurrentDictionary<Guid,DOMVar> _DomVars;
        internal static ConcurrentDictionary<Guid,DOMVar> _DeleteVarQuery;
        internal static ConcurrentDictionary<Guid, ConcurrentDictionary<Guid, DOMVar>> _Transactions;
        public static Guid CurrnetTransaction;
        static DOMGC()
        {
            CurrnetTransaction = Guid.Empty;
            SyncLock = new object();
            _DomVars = new ConcurrentDictionary<Guid,DOMVar>();
            _DeleteVarQuery = new ConcurrentDictionary<Guid, DOMVar>();
            _Transactions = new ConcurrentDictionary<Guid, ConcurrentDictionary<Guid, DOMVar>>();
            
        }
        public static Guid BeginTransaction()
        {
            //lock (SyncLock)
            //{
                CurrnetTransaction = Guid.NewGuid();
                _Transactions.TryAdd(CurrnetTransaction, new ConcurrentDictionary<Guid, DOMVar>());
                return CurrnetTransaction;
            //}
        }
        public static void CommitTransaction()
        {
            //lock (SyncLock)
            //{
                if (_Transactions.TryRemove(CurrnetTransaction, out ConcurrentDictionary<Guid, DOMVar> transaction))
                {
                    foreach (var item in transaction)
                    {
                        item.Value.Dispose();
                    }
                    transaction.Clear();
                    CurrnetTransaction = Guid.Empty;
                }
            //}
        }

        public static void CommitTransaction(Guid transactionId)
        {
            //lock (SyncLock)
            //{
                if (_Transactions.TryRemove(transactionId, out ConcurrentDictionary<Guid, DOMVar> transaction))
                {
                    foreach (var item in transaction)
                    {
                        item.Value.Dispose();
                    }
                    transaction.Clear();
                    
                }
            //}
        }
        private static object SyncLock;
        public static void AddVar(DOMVar item)
        {
            if(CurrnetTransaction != Guid.Empty)
            {
                if (_Transactions.TryGetValue(CurrnetTransaction, out ConcurrentDictionary<Guid, DOMVar> transaction))
                {
                    transaction.TryAdd(item.ObjectGuid, item);
                }
            }
            else
            {
                _DomVars.TryAdd(item.ObjectGuid, item);
            }
                
            

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
            else
            {
                if (CurrnetTransaction != Guid.Empty)
                {
                    if (_Transactions.TryGetValue(CurrnetTransaction, out ConcurrentDictionary<Guid, DOMVar> transaction))
                    {
                        if (transaction.TryRemove(item.ObjectGuid, out DOMVar itemToRemove2))
                        {
                            if (noDirectRemove)
                            {
                                _DeleteVarQuery.TryAdd(item.ObjectGuid, itemToRemove2);
                            }
                        }
                    }
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