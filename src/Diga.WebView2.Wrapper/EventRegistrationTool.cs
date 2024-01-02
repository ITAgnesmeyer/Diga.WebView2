using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{


    internal static class EventRegistrationTool
    {
        [SecurityCritical]

#pragma warning disable SYSLIB0032 // Typ oder Element ist veraltet
        [HandleProcessCorruptedStateExceptions]
#pragma warning restore SYSLIB0032 // Typ oder Element ist veraltet

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
