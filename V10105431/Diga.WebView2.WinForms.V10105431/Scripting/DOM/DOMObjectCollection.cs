﻿using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMObjectCollection : DOMObject
    {
 

        public DOMObjectCollection(WebView control, DOMVar var):base(control)
        {
            this._Var = var;
            this._InstanceName = var.Name;
        }

        public DOMElement item(int index)
        {
            DOMVar var = ExecGetVar(new object[] { index });
            return new DOMElement(this._View2Control, var);
        }
        public DOMElement this[int index] => item(index);

        public Task<int> length => GetAsync<int>();

        public DOMElement namedItem(string name)
        {
            DOMVar var = ExecGetVar(new object[] { name });

            return new DOMElement(this._View2Control, var);
        }

    }
}