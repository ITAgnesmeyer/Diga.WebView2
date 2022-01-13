using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
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
            return Exec<object>(new object[]{message});
        }


        public Task error(string message)
        {
            return Exec<object>(new object[]{message});
        }

        public Task clear()
        {
            return Exec<object>(new object[]{});
        }


        public Task group(string label = null)
        {
            return Exec<object>(new object[] { label });
        }

        public Task info(string message)
        {
            return this.Exec<object>(new object[]{message});
        }

        public Task time()
        {
            return this.Exec<object>(new object[]{});
        }

        public Task timeEnd()
        {
            return this.Exec<object>(new object[]{});
        }

        public Task trace(string label = null)
        {
            return this.Exec<object>(new object[]{label});

            
        }

    }
}