using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wpf.Scripting
{
    public abstract class ScriptObjectBase
    {
        protected readonly WebView _View2Control;
        protected abstract string InstanceName { get; set; }
        internal ScriptObjectBase(WebView control)
        {
            this._View2Control = control;
            this._View2Control.ExecuteScriptCompleted += OnScriptComplete;
        }

        //private ConcurrentDictionary<string,ExecuteScriptCompletedEventArgs> _CurrentScriptID=new ConcurrentDictionary<string, ExecuteScriptCompletedEventArgs>();
        private void OnScriptComplete(object sender, ExecuteScriptCompletedEventArgs e)
        {
            if (e.ErrorCode != 0)
            {
                Marshal.ThrowExceptionForHR(e.ErrorCode);
            }

            if (e.ResultObjectAsJson != null)
            {
                ScriptErrorObject err = Core.Json.DigaJson.Deserialize<ScriptErrorObject>(e.ResultObjectAsJson);
                if (err != null)
                {
                    if(err.message != null)
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
                    val = val.Replace("\"", "\\\"");
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

        protected async Task<T> Exec<T>(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"return {this.InstanceName}.{member}({argsString});";

            object retVal =await ExecuteScriptAsync(funcValue);

            return (T)Convert.ChangeType(retVal , typeof(T));

        }

        //protected void Exec(object[] args, [CallerMemberName] string member = "")
        //{
        //    string argsString = BuildArgs(args);
        //    string funcValue = $"{this.InstanceName}.{member}({argsString});";
        //    InvokeScript(funcValue);
        //}
        protected async Task<T> GetAsync<T>([CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member};";
            object result = await ExecuteScriptAsync(propVal);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        //protected T Get<T>([CallerMemberName] string member = "")
        //{
        //    string propVal = $"return {this.InstanceName}.{member};";
        //    object result = ExecuteScript(propVal);
        //    return (T)result;
        //}

        protected async Task SetAsync<T>(Task<T> value, [CallerMemberName] string member = "")
        {
            T val = await value;
            string argsValue = BuildArgs(new object[] { val });
            string funcValue = $"{this.InstanceName}.{member}={argsValue};";
            await ExecuteScriptAsync(funcValue);
        }
        //protected void Set<T>(T  value, [CallerMemberName] string member = "")
        //{
        //    string argsValue = BuildArgs(new object[] { value });
        //    string funcValue = $"{this.InstanceName}.{member}={argsValue};";
        //    InvokeScript(funcValue);
        //}

        protected async Task<string> ExecuteScriptAsync(string script)
        {
            return await this._View2Control.ExecuteScriptAsync(script);
        }
        //public static T AsyncCall<T>(Task<T> tsk)
        //{
        //    TaskAwaiter<T> awaiter = tsk.GetAwaiter();
        //    while (!awaiter.IsCompleted)
        //    {
        //        Thread.Sleep(10);
        //        Application.DoEvents();
        //    }
        //    return awaiter.GetResult();
        //}
        //protected string ExecuteScript(string script)
        //{
        //    string var = AsyncCall(ExecuteScriptAsync(script));

        //    return var;
        //}

        protected void InvokeScript(string script)
        {
            this._View2Control.InvokeScript(script);
        }
    }
}