using Diga.WebView2.Wrapper.Types;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace WebView2WrapperWinFormsTest
{
#if CORE
// Class will bie auto Dual
#else
    #pragma warning disable 618
        [ClassInterface(ClassInterfaceType.AutoDual)]
    #pragma warning restore 618
#endif
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
//HostObjectHelper will be added automatically:
    public class Rpc
    {
        public string id { get; set; }
        public string objId { get; set; }
        public string action { get; set; }
        public string param { get; set; }

    }
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
