using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Scripting.DOM;
namespace Diga.WebView2.Scripting
{
    public abstract class ScriptObjectBase
    {
        protected readonly IWebViewControl _View2Control;
        protected abstract string InstanceName { get; set; }
        internal ScriptObjectBase(IWebViewControl control)
        {
            this._View2Control = control;
            WireEvents();
        }
        protected void WireEvents()
        {
            this._View2Control.ExecuteScriptCompleted += OnScriptComplete;
        }
        protected void UnWireEvents()
        {
            this._View2Control.ExecuteScriptCompleted -= OnScriptComplete;
        }
        //private ConcurrentDictionary<string,ExecuteScriptCompletedEventArgs> _CurrentScriptID=new ConcurrentDictionary<string, ExecuteScriptCompletedEventArgs>();
        private void OnScriptComplete(object sender, IExecuteScriptCompletedEventArgs e)
        {
            if (e.ErrorCode != 0)
            {
                Marshal.ThrowExceptionForHR(e.ErrorCode);
            }

            if (e.ResultObjectAsJson != null)
            {
                ScriptErrorObject err = JsonSerializer.Deserialize<ScriptErrorObject>(e.ResultObjectAsJson);
                if (err != null)
                {
                    if (err.message != null)
                        throw new ScriptException(err);
                }
            }
        }

        protected string BuildArgs(object[] args)
        {
            string returnArgString = "";
            foreach (var arg in args)
            {
                if (!string.IsNullOrEmpty(returnArgString))
                    returnArgString += ",";
                if (arg is string)
                {
                    string val = (string)arg;
                    //val = val.Replace("\\", "/");
                    //val = Tools.JavaScriptEncoder.Encode(val);
                    //val = val.Replace("\\", "\\\\");
                    //val = val.Replace("\r", "\\r");
                    //val = val.Replace("\n", "\\n");
                    //val = val.Replace("\"", "\\\"");
                    val = Tools.JavaScriptEncoder.Encode(val);
                    returnArgString += $"\"{val}\"";
                }
                else if (arg is bool)
                {
                    if ((bool)arg)
                    {
                        returnArgString += "true";
                    }
                    else
                    {
                        returnArgString += "false";
                    }
                }
                else if (arg is DateTime)
                {
                    DateTime val = (DateTime)arg;
                    returnArgString += $"\"{val:MM/dd/yyyy}\"";
                }
                else if (arg is decimal)
                {
                    decimal val = (decimal)arg;
                    returnArgString += $"{val.ToString("N", new CultureInfo("en-EN"))}";

                }
                else if (arg is double)
                {
                    double val = (double)arg;
                    returnArgString += $"{val.ToString("N", new CultureInfo("en-EN"))}";

                }
                else if(arg is DOMResultString)
                {
                    string val = (DOMResultString)arg;
                    val = Tools.JavaScriptEncoder.Encode(val);
                    returnArgString += $"\"{val}\"";
                }
                else
                {
                    string val = "null";
                    if (arg != null)
                    {
                        val = arg.ToString();
                    }

                    returnArgString += val;

                }

            }

            return returnArgString;
        }

        protected void Exec(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"return {this.InstanceName}.{member}({argsString});";
            ExecuteScript(funcValue);
        }
        protected T Exec<T>(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"return {this.InstanceName}.{member}({argsString});";
            object retVal = ExecuteScript(funcValue);
            return (T)Convert.ChangeType(retVal, typeof(T));
        }
        protected async Task<T> ExecAsync<T>(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"return {this.InstanceName}.{member}({argsString});";

            object retVal = await ExecuteScriptAsync(funcValue);

            return (T)Convert.ChangeType(retVal, typeof(T));

        }

        public async Task ExecAsync(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"return {this.InstanceName}.{member}({argsString});";

            await ExecuteScriptAsync(funcValue);

        }

        protected async Task<T> GetAsync<T>([CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member};";
            object result = await ExecuteScriptAsync(propVal);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        protected T Get<T>([CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member};";
            object result = ExecuteScript(propVal);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        protected T GetIndexed<T>(int index, [CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member}[{index}];";
            object result = ExecuteScript(propVal);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public async Task<T> GetIndexedAsync<T>(int index, [CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member}[{index}];";
            object result = await ExecuteScriptAsync(propVal);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        protected async Task SetAsync<T>(Task<T> value, [CallerMemberName] string member = "")
        {
            T val = await value;
            string argsValue = BuildArgs(new object[] { val });
            string funcValue = $"{this.InstanceName}.{member}={argsValue};";
            await ExecuteScriptAsync(funcValue);
        }
        protected void Set<T>(T value, [CallerMemberName] string member = "")
        {
            string argsValue = BuildArgs(new object[] { value });
            string funcValue = $"{this.InstanceName}.{member}={argsValue};";
            ExecuteScript(funcValue);
        }

        protected async Task<string> ExecuteScriptAsync(string script)
        {
            return await this._View2Control.ExecuteScriptAsync(script);
        }


        private object _SyncLockObj = new object();
        private static int ScriptCounter;
        protected string ExecuteScript(string script)
        {
            try
            {

                ScriptCounter++;
                Debug.Print("ScriptCounter:" + ScriptCounter);
                string var = Diga.Core.Threading.UIDispatcher.UIThread.Invoke(ExecuteScriptAsync(script));
                ScriptCounter--;
                return var;

            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ScriptObjectBase) + "/" + nameof(ExecuteScript) + ex.ToString());
                ScriptCounter--;
                throw;
            }




        }

        protected void InvokeScript(string script)
        {
            this._View2Control.InvokeScript(script);
        }
    }
}