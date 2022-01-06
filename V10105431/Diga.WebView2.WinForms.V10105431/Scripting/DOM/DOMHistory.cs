using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMHistory : DOMObject
    {


        public DOMHistory(WebView control, DOMVar var):base(control)
        {
            this._Var = var;
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