using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.Wrapper.interop
{
    internal static class NativeUiThread
    {
       
       
        
        private static void DoEventsIntern()
        {
            while (NativeUser32.PeekMessage(out NativeUser32.MSG msg, IntPtr.Zero, 0, 0, 0x0001 | 0x0002))
            {
                NativeUser32.TranslateMessage(ref msg);
                NativeUser32.DispatchMessage(ref msg);
            }

        }

        public static T AsyncCall<T>(Task<T> tsk)
        {
            TaskAwaiter<T> awaiter = tsk.GetAwaiter();
            while (!awaiter.IsCompleted)
            {
                //Thread.Sleep(10);
                DoEventsIntern();
            }
            return awaiter.GetResult();
        }

    }
}