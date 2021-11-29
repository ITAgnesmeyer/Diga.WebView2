﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Text;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    internal static class EventRegistrationTool
    {
        [HandleProcessCorruptedStateExceptions]
        public static void UnWireToken(EventRegistrationToken token,
            Action<EventRegistrationToken> action)
        {
            if (token.value == 0) return;
            try
            {
                action.Invoke(token);
            }
            catch (Exception ex)
            {
                Debug.Print($"UnWireToken::{action.Method.Name}=>{ex.Message}");
            }
            
            token.value = 0;
        }
    }
}