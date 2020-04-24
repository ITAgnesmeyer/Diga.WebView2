// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace Diga.WebView2.Wrapper
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
    //public class BOOL:CBOOL
    //{
        
    //    public BOOL():base()
    //    {
            
    //    }

    //    public BOOL(int input):base(input)
    //    {
            
    //    }
    //    public BOOL(bool value):base(value)
    //    {
            
    //    }
        
    //    public static implicit operator bool(BOOL input)
    //    {
    //        return input._Value;
    //    }

    //    public static implicit operator BOOL(bool input)
    //    {
    //        return new BOOL(input);
    //    }

    //    public static implicit operator int(BOOL input)
    //    {
    //        return input.Value;
    //    }

    //    public static implicit operator BOOL(int input)
    //    {
    //        return new BOOL(input);
    //    }
    //    public override int Value
    //    {
    //        get
    //        {
    //            if (this._Value)
    //                return 0;
    //            else
    //                return 1;
    //        }
    //        set
    //        {
    //            if (value != 0)
    //                this._Value = false;
    //            else
    //                this._Value = true;

    //        }
    //    }
    //}
}