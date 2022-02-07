namespace Diga.WebView2.Wpf.Scripting
{
    public class ScriptErrorObject
    {
        public string name { get; set; }
        public string message { get; set; }
        public string fileName { get; set; }
        public string lineNumber { get; set; }
        public string columnNumber { get; set; }
        public string stack { get; set; }

        public override string ToString()
        {
            string result = $"Name:{name},Message:{message},FileName:{fileName},Line:{lineNumber},Column:{columnNumber},ScriptStack:{stack}";
            return result;
        }

    }
}
