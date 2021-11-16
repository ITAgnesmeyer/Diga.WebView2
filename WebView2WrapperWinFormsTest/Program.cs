using Diga.WebView2.Wrapper.Types;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Windows.Forms;

namespace WebView2WrapperWinFormsTest
{
//#if CORE
//// Class will be auto Dual
//#else
//    #pragma warning disable 618
    ////[ClassInterface(ClassInterfaceType.AutoDual)]
//    #pragma warning restore 618
//#endif
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
            Application.ThreadException +=OnTreadException;
            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException+=OnUnHandledException;
            currentDomain.FirstChanceException+=OnFirsChanceException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void OnFirsChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            if(e.Exception != null)
            {
                Debug.Print("OnFirsChanceException:" + e.Exception.ToString());
            }
        }

        private static void OnTreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            if(ex != null)
            {
                Debug.Print("OnTreadException:" + ex.ToString());
            }
           
        }

        private static void OnUnHandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;

            if (ex != null)
            {
                Debug.Print("OnUnHandledException:" + ex.ToString());
            }
        }
    }
}
