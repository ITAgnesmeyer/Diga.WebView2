namespace Diga.WebView2.Scripting.DOM
{
    public class DOMResultString
    {
        private string _result;
        public string Result { get => CleanUp(_result); set => SetResult(value); }

        private void SetResult(string value)
        {
            if (value == null)
            {
                _result = "null";
            }
            else
            {
                if (string.IsNullOrEmpty(value))
                    _result = "\"\"";

                if (value.StartsWith("\"") && value.EndsWith("\""))
                {
                    _result = value;
                }
                else
                {
                    _result = $"\"{value}\"";
                }
            }

            
        }

        private string CleanUp(string result)
        {
            if (string.IsNullOrEmpty(result))
                result = "null";
            if(result.StartsWith("\"") && result.EndsWith("\""))
            {
                result = result.Substring(1, result.Length - 2);
            }
            return result.Trim();
        }
        public DOMResultString(string result)
        {
            this.Result = result;            
        }

        public static implicit operator string(DOMResultString result)
        {
            return result.Result;
        }
        public static implicit operator DOMResultString(string result)
        {
            return new DOMResultString(result);
        }

    }
}