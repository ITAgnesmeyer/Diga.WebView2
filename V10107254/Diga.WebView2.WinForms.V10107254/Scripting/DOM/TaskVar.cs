using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class TaskVar<T>
    {
        public T Value { get; set; }

        public TaskVar(T value)
        {
            this.Value = value;
        }


        public static implicit operator Task<T>(TaskVar<T> input)
        {
            var r = Task.FromResult<T>(input.Value);
            return r;
        }

        public static implicit operator TaskVar<T>(T input)
        {
            return new TaskVar<T>(input);
        }
    }
}