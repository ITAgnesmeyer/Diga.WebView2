using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMHistory : DOMObject
    {


        public DOMHistory(WebView control, DOMVar var):base(control,var)
        {
           
        }

        public int length => Get<int>();
        public Task<int> lengthAsync => GetAsync<int>(nameof(length));

        public void back()
        {
            Exec(new object[]{});
        }
        public Task backAsync()
        {
            return ExecAsync(new object[]{},nameof(back));
        }

        public void forward()
        {
            Exec(new object[]{});
        }
        public Task forwardAsync()
        {
            return ExecAsync(new object[]{},nameof(forward));
        }

        public void go(int number)
        {
            Exec(new object[]{number});
        }
        public Task goAsync(int number)
        {
            return ExecAsync(new object[]{number},nameof(go));
        }


    }
}