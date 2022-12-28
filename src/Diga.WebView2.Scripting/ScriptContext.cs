using System;
using System.Threading.Tasks;
using Diga.Core.Threading;

namespace Diga.WebView2.Scripting
{
    public class ScriptContext
    {
        //private readonly IWebViewControl _View2Control;
        //public ScriptContext(IWebViewControl view2Control)
        //{
        //    this._View2Control = view2Control;
        //}

        public static void Run(Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            UIDispatcher.UIThread.Post(action);

        }

        public static void Run<T>(Action<T> action, T arg)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            UIDispatcher.UIThread.Post(action, arg);
        }
        public static TResult Run<TResult>(Func<TResult> func)
        {
            if (func == null) throw new ArgumentNullException(nameof(func));

            return UIDispatcher.UIThread.Invoke(func);
        }

        public static Task RunAsync(Action action) => UIDispatcher.UIThread.InvokeAsync(action);


        //public static bool InvokeRequeired => UIDispatcher.UIThread.InvokeRequired;


    }
}