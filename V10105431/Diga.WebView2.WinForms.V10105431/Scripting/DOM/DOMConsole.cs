namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMConsole : DOMObject
    {
        

        internal DOMConsole(WebView control):base(control)
        {
            this._InstanceName = "console";
        }

        internal DOMConsole(WebView control, DOMVar var) : base(control)
        {
            this._Var = var;
            this._InstanceName = var.Name;
        }
        public void log(string message)
        {
            this.Exec(new object[]{message});
        }


        public void error(string message)
        {
            this.Exec(new object[]{message});
        }

        public void clear()
        {
            this.Exec(new object[]{});
        }


        public void group(string label = null)
        {
            if (label == null)
            {
                this.Exec(new object[]{});
            }
            else
            {
                this.Exec(new object[]{label});
            }
        }

        public void info(string message)
        {
            this.Exec(new object[]{message});
        }

        public void time()
        {
            this.Exec(new object[]{});
        }

        public void timeEnd()
        {
            this.Exec(new object[]{});
        }

        public void trace(string label = null)
        {
            if (label == null)
            {
                this.Exec(new object[]{});
            }
            else
            {
                this.Exec(new object[]{label});
            }
        }

    }
}