namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMScriptText
    {
        public static implicit operator string(DOMScriptText input)
        {
            return input.Value;
        }

        public static implicit operator DOMScriptText(string input)
        {
            return new DOMScriptText(input);
        }

        public string Value { get; set; }

        public DOMScriptText(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}