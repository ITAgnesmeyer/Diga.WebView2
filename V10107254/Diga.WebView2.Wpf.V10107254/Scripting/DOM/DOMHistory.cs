using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMHistory : DOMObject
    {


        public DOMHistory(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public Task<int> length => GetAsync<int>();

        public Task back()
        {
            return Exec<object>(new object[]{});
        }

        public Task forward()
        {
            return Exec<object>(new object[]{});
        }

        public Task go(int number)
        {
            return Exec<object>(new object[]{number});
        }


    }
}