// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class BOOL
    {
        public BOOL()
        {
            this._Value = false;
        }

        public BOOL(int input)
        {this.Value = input;
        }
        public BOOL(bool value)
        {
            this._Value = value;
        }
        private bool _Value;
        public static implicit operator bool(BOOL input)
        {
            return input.Value == 1;
        }

        public static implicit operator BOOL(bool input)
        {
            return new BOOL(input);
        }

        public static implicit operator int(BOOL input)
        {
            return input.Value;
        }

        public static implicit operator BOOL(int input)
        {
            return new BOOL(input);
        }
        public int Value
        {
            get
            {
                if (this._Value)
                    return 1;
                else
                    return 0;
            }
            set
            {
                if (value != 0)
                    this._Value = false;
                else
                    this._Value = true;

            }
        }
    }
}