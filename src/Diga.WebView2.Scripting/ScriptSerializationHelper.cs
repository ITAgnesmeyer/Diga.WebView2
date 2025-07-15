
using System;
using System.Text.Json;

namespace Diga.WebView2.Scripting
{
    public static class ScriptSerializationHelper
    {
        public static ScriptErrorObject GetScriptErrorObject(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            if (!value.StartsWith("\"{")) return null;
            try
            {
                string clanSer = value.Replace("\\u003C", "");
                clanSer = clanSer.Replace("\\", "");
                if (clanSer.StartsWith("\"") && clanSer.EndsWith("\""))
                    clanSer = clanSer.Substring(1, clanSer.Length - 2);

                ScriptErrorObject errObj = JsonSerializer.Deserialize<ScriptErrorObject>(clanSer);
                return errObj;
            }
            catch (JsonException)
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
