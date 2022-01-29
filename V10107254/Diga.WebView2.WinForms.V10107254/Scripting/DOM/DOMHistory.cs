using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMHistory : DOMObject
    {


        public DOMHistory(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public Task<int> length => GetAsync<int>();

        public Task back()
        {
            return ExecAsync<object>(new object[]{});
        }

        public Task forward()
        {
            return ExecAsync<object>(new object[]{});
        }

        public Task go(int number)
        {
            return ExecAsync<object>(new object[]{number});
        }


    }
}