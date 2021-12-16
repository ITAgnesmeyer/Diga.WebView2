using System.Runtime.InteropServices;

namespace WebView2WrapperWinFormsTest
{



    [ComVisible(true)]
    public class TestObject
    {

        public string Name { get; set; }

        public int GetStringLen()
        {
            return this.Name.Length;
        }
        public string GetValue(string input)
        {
            this.Name += input;
            return this.Name;
        }
    }
}