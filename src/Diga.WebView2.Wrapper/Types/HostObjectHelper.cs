using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Types
{
    internal class RpcTypeInfo
    {
        public string Name { get; }
        public string FuncName { get; }
        public string GetKey()
        {
            return RpcTypeInfo.GeKey(this.Name, this.FuncName);
        }
        public static string GeKey(string name, string funcName)
        {
            StringBuilder sb = new StringBuilder(name);
            sb.Append("#@#");
            sb.Append(funcName);
            return sb.ToString();
        }
        public RpcTypeInfo(string name, string funcName)
        {
            this.Name = name;
            this.FuncName = funcName;
        }
    }

    public class StagingHostHelper : ICoreWebView2StagingHostObjectHelper
    {
        private const int DISP_E_MEMBERNOTFOUND = -2147352573;
        private const int DISP_E_TYPEMISMATCH = -2147352571;
        private const int WIN_BOOL_TRUE = 1;
        private const int WIN_BOOL_FALSE = 0;
        private Dictionary<string,RpcTypeInfo> TypeInfos = new Dictionary<string,RpcTypeInfo>();

        public int IsMethodMember(ref object rawObject, string memberName)
        {
            Type type = rawObject.GetType();
            RpcTypeInfo info = new RpcTypeInfo(type.AssemblyQualifiedName, memberName);
            if (TypeInfos.ContainsKey(info.GetKey()))
                return WIN_BOOL_TRUE;
            if (!type.IsClass || type.IsCOMObject)
                throw new COMException((string)null, DISP_E_TYPEMISMATCH);
            if (type.GetMember(memberName).Length == 0)
                throw new COMException((string)null, DISP_E_MEMBERNOTFOUND);
            foreach (MemberInfo memberInfo in type.GetMember(memberName))
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                {
                    TypeInfos.Add(info.GetKey(),info);
                    return WIN_BOOL_TRUE;
                }
            }
            return WIN_BOOL_FALSE;
        }
    }

#pragma warning disable 618
    [ClassInterface(ClassInterfaceType.AutoDual)]
#pragma warning restore 618
    [ComVisible(true)]
    public class HostObjectHelper
    {
        private const int DISP_E_MEMBERNOTFOUND = -2147352573;
        private const int DISP_E_TYPEMISMATCH = -2147352571;

        /// <summary>Check whether a member is a method of an object.</summary>
        /// <param name="obj">The host object to check.</param>
        /// <param name="name">The name of the member to check.</param>
        public bool IsMethod(object obj, string name)
        {
            Type type = obj.GetType();
            if (!type.IsClass || type.IsCOMObject)
                throw new COMException(null, DISP_E_TYPEMISMATCH);
            if (type.GetMember(name).Length == 0)
                throw new COMException(null, DISP_E_MEMBERNOTFOUND);
            foreach (MemberInfo memberInfo in type.GetMember(name))
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                    return true;
            }
            return false;
        }


    }
}