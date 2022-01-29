using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMConsole : DOMObject
    {
        

        internal DOMConsole(WebView control):base(control)
        {
            this._InstanceName = "console";
        }

        internal DOMConsole(WebView control, DOMVar var) : base(control,var)
        {

        }
        public Task log(string message)
        {
            return ExecAsync<object>(new object[]{message});
        }


        public Task error(string message)
        {
            return ExecAsync<object>(new object[]{message});
        }

        public Task clear()
        {
            return ExecAsync<object>(new object[]{});
        }


        public Task group(string label = null)
        {
            return ExecAsync<object>(new object[] { label });
        }

        public Task info(string message)
        {
            return this.ExecAsync<object>(new object[]{message});
        }

        public Task time()
        {
            return this.ExecAsync<object>(new object[]{});
        }

        public Task timeEnd()
        {
            return this.ExecAsync<object>(new object[]{});
        }

        public Task trace(string label = null)
        {
            return this.ExecAsync<object>(new object[]{label});

            
        }

    }
}