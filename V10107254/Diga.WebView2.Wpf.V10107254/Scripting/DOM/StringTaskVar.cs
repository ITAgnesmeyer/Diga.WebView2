using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class StringTaskVar : TaskVar<string>
    {
        public StringTaskVar(string value):base(value)
        {
            
        }

        public static implicit operator Task<string>(StringTaskVar input)
        {
            var r = Task.FromResult<string>(input.Value);
            return r;
        }

        public static implicit operator StringTaskVar(string input)
        {
            return new StringTaskVar(input);
        }
    }
}