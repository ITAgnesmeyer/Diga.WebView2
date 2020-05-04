using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WebView2WrapperWinFormsTest
{

    //[ComVisible(true)]
    //[Guid("21A6CC64-8E9A-4659-85AA-32A07B2BDA0B")]
    public class TestObject
    {
        //[DispId(1)]
        public string FirstMessage {get;set;}
        //[DispId(2)]
        public string SecondMessage { get; set; } = "";
        //[DispId(3)]
        //[AllowReversePInvokeCalls]
        public bool GetStringLen()
        {
            return true;
        }
    }

    public class Rpc
    {
        public string id{get;set;}
        public string objId{get;set;}
        public string action{get;set;}
        public string param{get;set;}

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
