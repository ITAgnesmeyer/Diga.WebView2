using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
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