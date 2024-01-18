using System.Threading.Tasks;

namespace Diga.WebView2.Scripting.DOM
{

    public class IntTaskVar : TaskVar<int>
    {
        public IntTaskVar(int value):base(value)
        {
            
        }

        public static implicit operator Task<int>(IntTaskVar input)
        {
            var r = Task.FromResult<int>(input.Value);
            return r;
        }

        public static implicit operator IntTaskVar(int input)
        {
            return new IntTaskVar(input);
        }
    }
}