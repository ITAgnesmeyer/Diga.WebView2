using System;
using System.Collections.Generic;
using System.Text;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    internal static class EventRegistrationTool
    {
        public static void UnWireToken(EventRegistrationToken token,
            Action<EventRegistrationToken> action)
        {
            if (token.value == 0) return;
            action.Invoke(token);
            token.value = 0;
        }
    }
}
