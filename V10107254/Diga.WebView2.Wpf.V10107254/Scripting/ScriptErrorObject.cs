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
            string result = $"Name:{this.name},Message:{this.message},FileName:{this.fileName},Line:{this.lineNumber},Column:{this.columnNumber},ScriptStack:{this.stack}";
            return result;
        }

    }
}
