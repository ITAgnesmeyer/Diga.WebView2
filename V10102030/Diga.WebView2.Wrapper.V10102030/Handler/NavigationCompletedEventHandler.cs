﻿using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Handler
{
    public class NavigationCompletedEventHandler : ICoreWebView2NavigationCompletedEventHandler
    {
        public event EventHandler<NavigationCompletedEventArgs> NavigaionCompleted;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2NavigationCompletedEventArgs args)
        {
            try
            {


                CBOOL isSuccess = args.IsSuccess;
                NavigationCompletedEventArgs eventArgs = new NavigationCompletedEventArgs((ErrorStatus)args.WebErrorStatus, isSuccess, args.NavigationId);
                OnNavigaionCompleted(eventArgs);
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(NavigationCompletedEventHandler) + " Exception:" + ex.ToString());
            }
        }

        protected virtual void OnNavigaionCompleted(NavigationCompletedEventArgs e)
        {
            NavigaionCompleted?.Invoke(this, e);
        }
    }
}