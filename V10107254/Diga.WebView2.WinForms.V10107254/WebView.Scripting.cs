using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Diga.WebView2.WinForms.Scripting;
using Diga.WebView2.WinForms.Scripting.DOM;
using Diga.WebView2.Wrapper.EventArguments;


namespace Diga.WebView2.WinForms
{
    public partial class WebView
    {
        private readonly RpcHandler _RpcHandler;

        private const string JAVASCRIPT_CANNOT_BE_NULL_OR_EMPTY = "javaScript cannot be NULL or empty";


        private static void ScriptZeroTest(string javaScript)
        {
            if (string.IsNullOrEmpty(javaScript))
                throw new ArgumentNullException(JAVASCRIPT_CANNOT_BE_NULL_OR_EMPTY);
        }

        public void ExecuteScript(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded)
                return;

            ScriptZeroTest(javaScript);

            string scrptToExecute = $"window.external.executeScript(\"{{{javaScript.Replace("\"", "\\'")}}}\")";
            this._WebViewControl.ExecuteScript(scrptToExecute);
        }

        public void EvalScript(string javaScript)
        {
            if (!this.CheckIsCreatedOrEnded) return;

            ScriptZeroTest(javaScript);

            string scriptToExecute = $"window.external.evalScript(\"{javaScript.Replace("\"", "\\'")}\")";
            this._WebViewControl.ExecuteScript(scriptToExecute);
        }

        /// <summary>
        /// Evaluate script async with Exception Check
        /// </summary>
        /// <remarks>
        /// For exception check the added Function window.external.evalScript will bie executed
        /// </remarks>
        /// <param name="javaScript"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ScriptException"></exception>
        public async Task<string> EvalScriptAsync(string javaScript)
        {
            CheckIsCreatedOrEndedWithThrow();
            ScriptZeroTest(javaScript);

            string scriptToExecute = $"window.external.evalScript(\"{javaScript.Replace("\"", "\\'")}\")";
            string result = await this._WebViewControl.ExecuteScriptAsync(scriptToExecute);
            ScriptErrorObject errObj = ScriptSerializationHelper.GetScriptErrorObject(result);
            if (errObj != null)
            {
                throw new ScriptException(errObj);
            }

            return result;
        }


        /// <summary>
        /// Execute the Script directly no Exception will be thrown
        /// </summary>
        /// <param name="javaScript">Script to execute</param>
        /// <returns>Result String</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<string> ExecuteScriptDirectAsync(string javaScript)
        {
            CheckIsCreatedOrEndedWithThrow();
            ScriptZeroTest(javaScript);
            string result = await this._WebViewControl.ExecuteScriptAsync(javaScript);
            return result;
        }

        public void ExecuteScriptDirect(string javaScript)
        {
            CheckIsCreatedOrEndedWithThrow();
            ScriptZeroTest(javaScript);
            this._WebViewControl.ExecuteScript(javaScript);
        }

        /// <summary>
        /// Execute the Script with Exception - Check => window.external.executeScript
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns>string</returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="ScriptException"></exception>
        public async Task<string> ExecuteScriptAsync(string javaScript)
        {
            CheckIsCreatedOrEndedWithThrow();
            ScriptZeroTest(javaScript);

            string scrptToExecute = $"window.external.executeScript(\"{{{javaScript.Replace("\"", "\\'")}}}\")";
            string result = await this._WebViewControl.ExecuteScriptAsync(scrptToExecute);
            ScriptErrorObject errorObj = ScriptSerializationHelper.GetScriptErrorObject(result);
            if (errorObj != null)
            {
                throw new ScriptException(errorObj);
            }

            return result;
        }


        /// <summary>
        /// Invoke a script and returns a unique ID for the script 
        /// </summary>
        /// <param name="javaScript"></param>
        /// <returns>Unique ID which can be used to identify the Return - Event</returns>
        /// <exception cref="InvalidOperationException">Throws if the Control is not ready</exception>
        public string InvokeScript(string javaScript)
        {
            CheckIsCreatedOrEndedWithThrow();

            ScriptZeroTest(javaScript);

            string result = this._WebViewControl.InvokeScript(javaScript,
                (id, errorCode, jsonResult) =>
                {
                    OnExecuteScriptCompleted(new ExecuteScriptCompletedEventArgs(errorCode, jsonResult, id));
                });

            return result;
        }


        public DOMDocument GetDOMDocument()
        {
            CheckIsCreatedOrEndedWithThrow();
            return new DOMDocument(this);
        }

        public DOMConsole GetDOMConsole()
        {
            CheckIsCreatedOrEndedWithThrow();
            return new DOMConsole(this);
        }

        public DOMWindow GetDOMWindow()
        {
            CheckIsCreatedOrEndedWithThrow();
            return new DOMWindow(this);
        }


        private async Task<string> GetDocumentText()
        {
            CheckIsCreatedOrEndedWithThrow();

            DOMDocument doc = this.GetDOMDocument();
            try
            {
                DOMElement domElement = await doc.documentElement;
                string html = await domElement.outerHTML;
                if (html.StartsWith("\""))
                    html = html.Substring(1);
                if (html.EndsWith("\""))
                {
                    html = html.Substring(0, html.Length - 1);
                }

                html = System.Text.RegularExpressions.Regex.Unescape(html);
                //string enc = html= System.Text.RegularExpressions.Regex.Escape(html);
                html = html.Replace("\n", Environment.NewLine);
                return html;
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                throw;
            }
        }
    }
}