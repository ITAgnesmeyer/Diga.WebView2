using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{

    //internal class WebView2PrivateHostObjectHelper
    //{
    //    private object _privateRawObject;
    //    private ICoreWebView2PrivateHostObjectHelper Holder
    //    {
    //        get
    //        {
    //            try
    //            {
    //                return (ICoreWebView2PrivateHostObjectHelper)_privateRawObject;
    //            }
    //            catch (Exception)
    //            {

    //                throw new NotImplementedException($"Unabel to cast {nameof(WebView2PrivateHostObjectHelperRaw)} to {nameof(ICoreWebView2PrivateHostObjectHelper)}");
    //            }
    //        }
    //    }

    //    private ICoreWebView2PrivateHostObjectHelper2 Holder2
    //    {
    //        get
    //        {
    //            try
    //            {
    //                return (ICoreWebView2PrivateHostObjectHelper2)_privateRawObject;
    //            }
    //            catch (Exception)
    //            {

    //                throw new NotImplementedException($"Unabel to cast {nameof(WebView2PrivateHostObjectHelperRaw)} to {nameof(ICoreWebView2PrivateHostObjectHelper2)}");
    //            }
    //        }   
    //    }
    //    public WebView2PrivateHostObjectHelper()
    //    {
    //        _privateRawObject = new WebView2PrivateHostObjectHelperRaw();

    //    }
    //    public int IsMethodMember(object @object, string memberName)
    //    {

    //        try
    //        {
    //            ICoreWebView2PrivateHostObjectHelper holder = this.Holder;

    //            object obj = @object;
    //            ref object obj1 = ref obj;
    //            return holder.IsMethodMember(ref obj1, memberName);
    //        }
    //        catch (InvalidCastException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_NOINTERFACE)
    //                throw new InvalidOperationException("Members can only be accessed from the UI thread.", (Exception)ex);
    //            throw ex;
    //        }
    //        catch (COMException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_INVALID_STATE)
    //                throw new InvalidOperationException("Members cannot be accessed after the WebView2 control is disposed.", (Exception)ex);
    //            throw ex;
    //        }


    //    }

    //    public int IsAsyncMethod(object @object, string methodName, int parameterCount)
    //    {

    //        try
    //        {
    //            ICoreWebView2PrivateHostObjectHelper2 holder = this.Holder2;
    //            object obj = @object;
    //            ref object obj1 = ref obj;
    //           return holder.IsAsyncMethod(ref obj1, methodName, parameterCount);
    //        }
    //        catch (InvalidCastException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_NOINTERFACE)
    //                throw new InvalidOperationException("Members can only be accessed from the UI thread.", (Exception)ex);
    //            throw ex;
    //        }
    //        catch (COMException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_INVALID_STATE)
    //                throw new InvalidOperationException("Members cannot be accessed after the WebView2 control is disposed.", (Exception)ex);
    //            throw ex;
    //        }


    //    }

    //    public void SetAsyncMethodContinuation(object @object, string methodName, int parameterCount, object methodResult, ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
    //    {

    //        try
    //        {
    //            ICoreWebView2PrivateHostObjectHelper2 holder = this.Holder2;
    //            object obj = @object;
    //            ref object obj1 = ref obj;
    //            object obj2 = methodResult;
    //            ref object obj3 = ref obj;
    //            ICoreWebView2PrivateHostObjectAsyncMethodContinuation cObj = continuation;
    //            holder.SetAsyncMethodContinuation(ref obj1, methodName, parameterCount, ref obj2, cObj);
    //        }
    //        catch (InvalidCastException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_NOINTERFACE)
    //                throw new InvalidOperationException("Members can only be accessed from the UI thread.", (Exception)ex);
    //            throw ex;
    //        }
    //        catch (COMException ex)
    //        {
    //            if (ex.HResult == HRESULT.E_INVALID_STATE)
    //                throw new InvalidOperationException("Members cannot be accessed after the WebView2 control is disposed.", (Exception)ex);
    //            throw ex;
    //        }


    //    }
    //}


    internal class AwaitableReflection
    {
        private Type _awaitable;
        private MethodInfo _getAwaiter;
        private Type _awaiter;
        private PropertyInfo _isCompleted;
        private MethodInfo _onCompleted;
        private MethodInfo _getResult;

        public static AwaitableReflection FromAwaitableType(Type type)
        {
            MethodInfo method1 = type.GetMethod("GetAwaiter");
            if (method1 == null || method1.GetParameters().Length != 0)
            {
                return null;
            }

            Type returnType = method1.ReturnType;
            PropertyInfo property = returnType.GetProperty("IsCompleted");
            if (property == null || !property.CanRead || property.PropertyType != typeof(bool))
            {
                return null;
            }

            MethodInfo method2 = returnType.GetMethod("OnCompleted");
            if (method2 == null)
            {
                return null;
            }

            ParameterInfo[] parameters = method2.GetParameters();
            if (parameters.Length != 1 || parameters[0].ParameterType != typeof(Action))
            {
                return null;
            }
            MethodInfo method3 = returnType.GetMethod("GetResult");
            if (method3 == null || method3.GetParameters().Length != 0)
            {
                return null;
            }

            return new AwaitableReflection(type, method1, returnType, property, method2, method3);

        }

        private AwaitableReflection(Type awaitable, MethodInfo getAwaiter, Type awaiter, PropertyInfo isCompleted, MethodInfo onCompleted, MethodInfo getResult)
        {
            this._awaitable = awaitable;
            this._getAwaiter = getAwaiter;
            this._awaiter = awaiter;
            this._isCompleted = isCompleted;
            this._onCompleted = onCompleted;
            this._getResult = getResult;
        }

        public object InvokeGetAwaiter(object awaitable)
        {

            if (awaitable.GetType() != this._awaitable)
            {
                throw new InvalidOperationException($"Invoking {this._getAwaiter.Name} on an object of type {awaitable.GetType()} when an awaitable object of type {this._awaitable} was expected.");
            }

            return this._getAwaiter.Invoke(awaitable, Array.Empty<object>());

        }

        public bool InvokeIsCompleted(object awaiter)
        {

            if (awaiter.GetType() != this._awaiter)
            {
                throw new InvalidOperationException($"Invoking {this._isCompleted.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {this._awaiter} was expected.");
            }
            return (bool)this._isCompleted.GetValue(awaiter);

        }

        public void InvokeOnCompleted(object awaiter, Action continuation)
        {
            if (awaiter.GetType() != this._awaiter)
            {
                throw new InvalidOperationException($"Invoking {this._onCompleted.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {this._awaiter} was expected.");
            }

            this._onCompleted.Invoke(awaiter, new object[1] { continuation });
        }

        public object InvokeGetResult(object awaiter)
        {
            if (awaiter.GetType() != this._awaiter)
            {
                throw new InvalidOperationException($"Invoking {this._getResult.Name} on an object of type {awaiter.GetType()} when an awaiter object of type {this._awaiter} was expected.");
            }

            return this._getResult.Invoke(awaiter, Array.Empty<object>());

        }
    }
    internal class WebView2PrivateHostObjectHelperRaw : ICoreWebView2PrivateHostObjectHelper, ICoreWebView2PrivateHostObjectHelper2
    {
        private Dictionary<string, MethodInfo> MehtodInfos = new Dictionary<string, MethodInfo>();
        private Dictionary<string, MethodInfo> AsyncMehtods = new Dictionary<string, MethodInfo>();
        private MethodInfo GetMethodInfo(Type type, string methodName, int parameterCount = -1)
        {
            if (!type.IsClass || type.IsCOMObject)
            {
                throw new COMException(null, HRESULT.DISP_E_TYPEMISMATCH);
            }

            MethodInfo methodInfo = type.GetMethod(methodName);

            if (methodInfo == null)
                return null;
            if (parameterCount == -1 || methodInfo.GetParameters().Length == parameterCount)
            {
                return methodInfo;
            }

            return null;
        }
        private string GetMethodKey(Type type, string methodName, int parmCount)
        {
            return type.Name + "_" + methodName + "_" + parmCount;
        }
        public int IsAsyncMethod([In] ref object @object, [In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In] int parameterCount)
        {
            if (string.IsNullOrEmpty(methodName))
                return 0;

            MethodInfo methodInfo = this.GetMethodInfo(@object.GetType(), methodName, parameterCount);
            if (methodInfo == null)
                throw new COMException(null, HRESULT.DISP_E_TYPEMISMATCH);
            if (AwaitableReflection.FromAwaitableType(methodInfo.ReturnType) != null)
            {
                return 1;//true
            }
            else
            {
                return 0;//false
            }
        }

        public void SetAsyncMethodContinuation([In] ref object @object, [In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In] int parameterCount, [In] ref object methodResult, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrivateHostObjectAsyncMethodContinuation continuation)
        {
            if (this.GetMethodInfo(@object.GetType(), methodName, parameterCount) == null)
                throw new COMException((string)null, -2147352571);
            AwaitableReflection ar = AwaitableReflection.FromAwaitableType(methodResult.GetType());
            object awaiter = ar != null ? ar.InvokeGetAwaiter(methodResult) : throw new COMException((string)null, -2147352571);
            Action continuation1 = () =>
            {
                object obj1 = null;
                int num = 0;
                try
                {
                    obj1 = ar.InvokeGetResult(awaiter);
                }
                catch (Exception ex)
                {
                    num = Marshal.GetHRForException(ex);
                }

                ICoreWebView2PrivateHostObjectAsyncMethodContinuation methodContinuation = continuation;
                int errorCode = num;
                object obj2 = obj1;
                ref object local = ref obj2;

                methodContinuation.Invoke(errorCode, ref local);
            };

            if (ar.InvokeIsCompleted(awaiter))
            {
                continuation1();
            }
            else
            {
                ar.InvokeOnCompleted(awaiter, continuation1);
            }
        }

        public int IsMethodMember([In] ref object @object, [In, MarshalAs(UnmanagedType.LPWStr)] string memberName)
        {
            int reuslt = 0;

            MethodInfo methodInfo = this.GetMethodInfo(@object.GetType(), memberName);

            if (methodInfo != null)
            {
                reuslt = 1;

            }
            return reuslt;
        }
    }
    public class WebView2DeferralInterface : IDisposable//,ICoreWebView2Deferral
    {
        //private ICoreWebView2Deferral _Deferral;
        private readonly ComObjectHolder<ICoreWebView2Deferral> _Native;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Deferral Deferral => this._Native.Interface;

        //set => this._Deferral = value;
        public WebView2DeferralInterface(ICoreWebView2Deferral deferral)
        {
            this._Native = new ComObjectHolder<ICoreWebView2Deferral>(deferral);
            //this._Native = deferral?? throw new ArgumentNullException(nameof(deferral));

        }

        public void Complete()
        {
            try
            {
                this.Deferral.Complete();
            }
            catch (InvalidCastException ex)
            {
                if (ex.HResult == HRESULT.E_NOINTERFACE)
                    throw new InvalidOperationException($"{nameof(Complete)} accessed outside UI-Thread");
                throw;
            }
            catch (COMException ex)
            {
                if (ex.HResult == HRESULT.E_INVALID_STATE)
                    throw new InvalidOperationException("WebView2 already disposed");

                throw;
            }

        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {

                    this.Complete();
                    this.handle.Dispose();
                    //this._Deferral = null;
                }


                this.disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}