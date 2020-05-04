// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Diga.WebView2.Wrapper.Types
{
    public class CBOOL
    {
        protected bool _Value;

        public CBOOL()
        {
            this._Value = false;
        }

        public CBOOL(int input)
        {
            this.Value = input;
        }

        public CBOOL(bool input)
        {
            this._Value = input;
        }

        public static implicit operator bool(CBOOL input)
        {
            return input._Value;
        }

        public static implicit operator CBOOL(bool input)
        {
            return new CBOOL(input);
        }

        public static implicit operator int(CBOOL input)
        {
            return input.Value;
        }

        public static implicit operator CBOOL(int input)
        {
            return new CBOOL(input);
        }

        public virtual int Value
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
                if (value == 0)
                    this._Value = false;
                else
                    this._Value = true;

            }
        }
    }
    
}