using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Types
{
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
                throw new COMException(null, -2147352571);
            if (type.GetMember(name).Length == 0)
                throw new COMException(null, -2147352573);
            foreach (MemberInfo memberInfo in type.GetMember(name))
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                    return true;
            }
            return false;
        }


    }
}