namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMConsole : DOMObject
    {
        private string _InstanceName = "console";

        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }

        internal DOMConsole(WebView control):base(control)
        {
            
        }

        internal DOMConsole(WebView control, DOMVar var) : base(control)
        {
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