using System.Collections.Generic;

namespace Diga.WebView2.Scripting.DOM
{
    public static class DOMGC
    {
        public static List<DOMVar> _DomVars;

        static DOMGC()
        {
            SyncLock = new object();
            _DomVars = new List<DOMVar>();
        }

        private static object SyncLock;
        public static void AddVar(DOMVar item)
        {
            lock (SyncLock)
            {
                _DomVars.Add(item);
            }
        }

        public static void CleanUp()
        {
            //UIDispatcher.UIThread.Post(() =>
            //{


                lock (SyncLock)
                {
                    List<DOMVar> deleted = new List<DOMVar>();
                    foreach (DOMVar domVar in _DomVars)
                    {
                        if(!domVar.VarExist())
                            deleted.Add(domVar);
                        
                    }

                    while (deleted.Count > 0)
                    {
                        var dw = deleted[0];
                        _DomVars.Remove(dw);
                        deleted.RemoveAt(0);
                        dw.Dispose();
                        dw = null;
                    }

                    deleted = null;
                }
            //});

        }

    }
}