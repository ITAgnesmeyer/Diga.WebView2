namespace Diga.WebView2.Wrapper
{
    public class HeaderItem
    {
        public HeaderItem(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
        public string Name{get;}
        public string Value{get;}
    }
}