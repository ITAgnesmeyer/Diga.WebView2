using System.Threading.Tasks;

namespace Diga.WebView2.Scripting.DOM
{
    public class BoolTaskVar : TaskVar<bool>
    {
        public BoolTaskVar(bool value):base(value)
        {

        }

        public static implicit operator Task<bool>(BoolTaskVar input)
        {
            var r = Task.FromResult<bool>(input.Value);
            return r;
        }

        public static implicit operator BoolTaskVar(bool input)
        {
            return new BoolTaskVar(input);
        }

    }
}