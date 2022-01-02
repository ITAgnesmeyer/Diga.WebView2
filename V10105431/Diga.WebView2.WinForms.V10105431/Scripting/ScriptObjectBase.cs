using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.WinForms.Scripting
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

        private void OnScriptComplete(object sender, ExecuteScriptCompletedEventArgs e)
        {
            Debug.Print(e.Id);
            Debug.Print(e.ErrorCode.ToString());
            Debug.Print(e.ResultObjectAsJson);
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
                    returnArgString += $"\"{val}\"";
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

        protected void Exec(object[] args, [CallerMemberName] string member = "")
        {
            string argsString = BuildArgs(args);
            string funcValue = $"{this.InstanceName}.{member}({argsString});";
            InvokeScript(funcValue);
        }
        protected async Task<T> GetAsync<T>([CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member};";
            object result = await ExecuteScriptAsync(propVal);
            return (T)result;
        }

        protected T Get<T>([CallerMemberName] string member = "")
        {
            string propVal = $"return {this.InstanceName}.{member};";
            object result = ExecuteScript(propVal);
            return (T)result;
        }
        

        protected void Set<T>(T  value, [CallerMemberName] string member = "")
        {
            string argsValue = BuildArgs(new object[] { value });
            string funcValue = $"{this.InstanceName}.{member}={argsValue};";
            InvokeScript(funcValue);
        }

        protected async Task<string> ExecuteScriptAsync(string script)
        {
            return await this._View2Control.ExecuteScriptAsync(script);
        }

        protected string ExecuteScript(string script)
        {
            return this._View2Control.ExecuteScriptAsync(script).Result;
        }

        protected void InvokeScript(string script)
        {
            this._View2Control.InvokeScript(script);
        }
    }
}