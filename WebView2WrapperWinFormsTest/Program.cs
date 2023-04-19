using Diga.WebView2.Wrapper.Types;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
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
//HostObjectHelper will be added automatically:
static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WriteLog("Application Start");
            Application.ThreadException +=OnTreadException;
            Application.ApplicationExit += OnApplicationExit;
            Application.ThreadExit += OnThreadExit;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException+=OnUnHandledException;
            currentDomain.FirstChanceException+=OnFirsChanceException;
            currentDomain.ProcessExit += OnProcessExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            WriteLog("Process Exit");


            DateTime n = DateTime.Now;
            DateTime x = DateTime.Now;
            TimeSpan diff = x - n;
            while (diff.Seconds < 5)
            {
                Application.DoEvents();
                x = DateTime.Now;
                diff = x - n;
            }


        }

        private static void OnThreadExit(object sender, EventArgs e)
        {
            WriteLog("Thread Exit");
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            WriteLog("Application Exit");
        }

        private static void OnFirsChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            if(e.Exception != null)
            {
                WriteLog("OnFirsChanceException:" + e.Exception);
            }
        }

        private static void OnTreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            if(ex != null)
            {
                WriteLog("OnTreadException:" + ex);
            }
           
        }

        private static void OnUnHandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;

            if (ex != null)
            {
                WriteLog("OnUnHandledException:" + ex);
            }
        }

        private static void WriteLog(string message)
        {
            try
            {
                Debug.Print(message);
                message = Environment.NewLine + DateTime.Now.ToString("O") + "=>" +  message;
                File.AppendAllText("unexpected.log", message);
            }
            catch (Exception e)
            {
                Debug.Print("WriteLog Exception:" + e);
            }
        }
    }
}
