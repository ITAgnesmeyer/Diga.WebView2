using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows;

namespace WebView2WrapperWpfTest
{
    //HostObjectHelper will be added automatically:

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            AppDomain.CurrentDomain.FirstChanceException += OnFirstCheck;
            base.OnStartup(e);
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Debug.Print(ex.Message);
            }


        }

        private static void OnFirstCheck(object sender, FirstChanceExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            Debug.Print(ex.Message);
        }
    }
}
