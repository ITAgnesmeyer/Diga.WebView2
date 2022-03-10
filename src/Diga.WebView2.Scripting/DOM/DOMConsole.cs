using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMConsole : DOMObject
    {
        

        public DOMConsole(IWebViewControl control):base(control)
        {
            this._InstanceName = "console";
        }

        internal DOMConsole(IWebViewControl control, DOMVar var) : base(control,var)
        {

        }

        public void log(string message) => Exec(new object[] { message });
        public Task logAsync(string message)
        {
            return ExecAsync(new object[]{message},nameof(log));
        }

        public  void error(string message)
        {
            Exec(new object[]{message});
        }

        public Task errorAsync(string message)
        {
            return ExecAsync(new object[]{message},nameof(error));
        }

        public void clear()
        {
            Exec(new object[]{});
        }

        public Task clearAsync()
        {
            return ExecAsync(new object[]{},nameof(clear));
        }

        public void group(string label = null)
        {
            Exec(new object[] { label });
        }


        public Task groupAsync(string label = null)
        {
            return ExecAsync(new object[] { label },nameof(group));
        }
        public void info(string message)
        {
            Exec(new object[]{message});
        }
        public Task infoAsync(string message)
        {
            return this.ExecAsync(new object[]{message},nameof(info));
        }
        public void time()
        {
            Exec(new object[]{});
        }
        public Task timeAsync()
        {
            return this.ExecAsync(new object[]{},nameof(time));
        }

        public void timeEnd()
        {
            Exec(new object[]{});
        }

        public Task timeEndAsync()
        {
            return this.ExecAsync(new object[]{},nameof(timeEnd));
        }

        public void trace(string label = null)
        {
            Exec(new object[]{label});

            
        }

        public Task traceAsync(string label = null)
        {
            return this.ExecAsync(new object[]{label},nameof(trace));

            
        }

    }
}