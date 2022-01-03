using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMHistory : DOMObject
    {
        private string _InstanceName;

        protected override string InstanceName
        {
            get => this._InstanceName;
            set => this._InstanceName = value;
        }

        public DOMHistory(WebView control, DOMVar var):base(control)
        {
            this._InstanceName = var.Name;
        }

        public Task<int> length => GetAsync<int>();

        public void back()
        {
            Exec(new object[]{});
        }

        public void forward()
        {
            Exec(new object[]{});
        }

        public void go(int number)
        {
            Exec(new object[]{number});
        }


    }
}