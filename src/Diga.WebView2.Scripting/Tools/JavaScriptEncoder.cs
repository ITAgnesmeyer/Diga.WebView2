using System.Globalization;
using System.Text;

namespace Diga.WebView2.Scripting.Tools
{
    public class JavaScriptEncoder
    {
        private static void AppendCharAsUnicodeJavaScript(StringBuilder builder, char c)
        {
            builder.Append("\\u");
            builder.Append(((int)c).ToString("x4", CultureInfo.InvariantCulture));
        }

        private static bool CharRequiresJavaScriptEncoding(char c)
        {
            return c < 0x20 // control chars always have to be encoded
                   || c == '\"' // chars which must be encoded per JSON spec
                   || c == '\\'
                   || c == '\'' // HTML-sensitive chars encoded for safety
                   || c == '<'
                   || c == '>'
                   || c == '&' // Bug Dev11 #133237. Encode '&' to provide additional security for people who incorrectly call the encoding methods (unless turned off by backcompat switch)
                   || c == '\u0085' // newline chars (see Unicode 6.2, Table 5-1 [http://www.unicode.org/versions/Unicode6.2.0/ch05.pdf]) have to be encoded (DevDiv #663531)
                   || c == '\u2028'
                   || c == '\u2029';
        }
        public static string Encode(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;
            int startIndex = 0;
            int count = 0;

            StringBuilder sb = null;
            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];

                if (CharRequiresJavaScriptEncoding(c))
                {
                    if (sb == null) {
                        sb = new StringBuilder(value.Length + 5);
                    }
                    if (count > 0)
                    {
                        sb.Append(value, startIndex, count);
                    }
                    startIndex = i + 1;
                    count = 0;
                }

               
                switch (c)
                {
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    case '\"':
                        sb.Append("\\\"");
                        break;
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    default:
                        if (CharRequiresJavaScriptEncoding(c))
                        {
                            AppendCharAsUnicodeJavaScript(sb, c);
                        }
                        else
                        {
                            count++;
                        }
                        break;
                }
            }

            if (sb == null)
                return value;
            if (count > 0)
                sb.Append(value, startIndex, count);
            return sb.ToString();
        }
    }
}
