using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Represents information about an RPC (Remote Procedure Call) type, including its name and associated function
    /// name.
    /// </summary>
    /// <remarks>This structure is used to encapsulate the name and function name of an RPC type, providing
    /// methods to generate a unique key based on these properties.</remarks>
    internal struct RpcTypeInfo
    {
        /// <summary>
        /// Gets the name associated with the current instance.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gets the name of the function.
        /// </summary>
        public string FuncName { get; }
        /// <summary>
        /// Retrieves the key associated with the current RPC type information.
        /// </summary>
        /// <returns>A string representing the key derived from the current instance's name and function name.</returns>
        public string GetKey()
        {
            return RpcTypeInfo.GeKey(this.Name, this.FuncName);
        }

        /// <summary>
        /// Generates a unique key by combining the specified name and function name.
        /// </summary>
        /// <param name="name">The base name to be included in the key.</param>
        /// <param name="funcName">The function name to be appended to the base name.</param>
        /// <returns>A string representing the combined key, formatted as "name#@#funcName".</returns>
        public static string GeKey(string name, string funcName)
        {
            StringBuilder sb = new StringBuilder(name);
            sb.Append("#@#");
            sb.Append(funcName);
            return sb.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcTypeInfo"/> class with the specified name and function name.
        /// </summary>
        /// <param name="name">The name of the RPC type.</param>
        /// <param name="funcName">The name of the function associated with the RPC type.</param>
        public RpcTypeInfo(string name, string funcName)
        {
            this.Name = name;
            this.FuncName = funcName;
        }
    }

    /// <summary>
    /// Helper class for host object reflection and COM interop, providing methods to check for method members.
    /// </summary>
    public class StagingHostHelper : ICoreWebView2StagingHostObjectHelper
    {
        private const int DISP_E_MEMBERNOTFOUND = -2147352573;
        private const int DISP_E_TYPEMISMATCH = -2147352571;
        private const int WIN_BOOL_TRUE = 1;
        private const int WIN_BOOL_FALSE = 0;
        private Dictionary<string,RpcTypeInfo> ContainTypeInfos = new Dictionary<string,RpcTypeInfo>();
        private Dictionary<string, RpcTypeInfo> NotContainTypeInfos = new Dictionary<string,RpcTypeInfo>();
        /// <summary>
        /// Checks whether the specified member name is a method of the given object.
        /// </summary>
        /// <param name="rawObject">The object to check.</param>
        /// <param name="memberName">The name of the member to check.</param>
        /// <returns>1 if the member is a method, 0 otherwise.</returns>
        public int IsMethodMember(ref object rawObject, string memberName)
        {
            Type type = rawObject.GetType();
            RpcTypeInfo info = new RpcTypeInfo(type.FullName, memberName);
            string key = info.GetKey();
            if (this.ContainTypeInfos.ContainsKey(key))
                return WIN_BOOL_TRUE;
            if(this.NotContainTypeInfos.ContainsKey(key))
                return WIN_BOOL_FALSE;
            if (!type.IsClass || type.IsCOMObject)
                throw new COMException((string)null, DISP_E_TYPEMISMATCH);
            if (type.GetMember(memberName).Length == 0)
                throw new COMException((string)null, DISP_E_MEMBERNOTFOUND);
            foreach (MemberInfo memberInfo in type.GetMember(memberName))
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                {
                    this.ContainTypeInfos.Add(key,info);
                    return WIN_BOOL_TRUE;
                }
                else
                {
                    this.NotContainTypeInfos.Add(key, info);
                }
            }
            return WIN_BOOL_FALSE;
        }
    }

#pragma warning disable 618
    /// <summary>
    /// Helper class for host object reflection, providing a method to check if a member is a method.
    /// </summary>
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
        /// <returns>True if the member is a method, otherwise false.</returns>
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