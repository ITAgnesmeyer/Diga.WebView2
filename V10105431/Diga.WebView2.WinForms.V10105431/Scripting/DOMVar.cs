﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting
{
    public class DOMVar:ScriptObjectBase
    {
        protected override string InstanceName
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        private readonly Guid _ObjectId;
        private const string _VarBase = "window.diga._HEAP_";
        internal DOMVar(WebView control):base(control)
        {
            this._ObjectId = Guid.NewGuid();
            CreateVar();
        }

        internal DOMVar(WebView control, Guid objectId) : base(control)
        {
            this._ObjectId = objectId;

        }
        public string Name => $"{_VarBase}{this._ObjectId.ToString().Replace("-","_")}";

        private void CreateVar()
        {
            string scritpTest = "if(window.diga == undefined) window.diga = new Object();";
            //string scritpTest2 = "if(window.diga._HEAP_==undefined) window.diga._heap = new Object();";
            InvokeScript(scritpTest);
            string scriptValue = $"{this.Name}=new Object();";
            InvokeScript(scriptValue);
        }

    }
}
