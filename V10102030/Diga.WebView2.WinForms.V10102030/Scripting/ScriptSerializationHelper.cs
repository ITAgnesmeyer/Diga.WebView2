﻿using Newtonsoft.Json;
using System;

namespace Diga.WebView2.WinForms.Scripting
{
    internal static class ScriptSerializationHelper
    {
        public static ScriptErrorObject GetScriptErrorObject(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            try
            {
                string clanSer = value.Replace("\\u003C", "");
                clanSer = clanSer.Replace("\\", "");
                if (clanSer.StartsWith("\"") && clanSer.EndsWith("\""))
                    clanSer = clanSer.Substring(1, clanSer.Length - 2);

                ScriptErrorObject errObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ScriptErrorObject>(clanSer);
                return errObj;
            }
            catch (JsonSerializationException)
            {
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
