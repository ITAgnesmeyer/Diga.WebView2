using System;
using System.IO;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    //public class WebView2ContextMenuItem : WebView2ContextMenuItemInterface
    //{
    //    private ComObjctHolder<ICoreWebView2ContextMenuItem> _Holder;
    //    public event EventHandler<WebView2ContextMenuItem> CustomItemSelected;
    //    private EventRegistrationToken _CustomItemSelectedToken;

    //    public ICoreWebView2ContextMenuItem ToInterface()
    //    {
    //        return this._Holder.Interface;
    //    }
    //    public WebView2ContextMenuItem(ICoreWebView2ContextMenuItem native)
    //    {
    //        this._Holder = new ComObjctHolder<ICoreWebView2ContextMenuItem>(native);
    //        WireEvents();
    //    }

    //    private void WireEvents()
    //    {
    //        try
    //        {
    //            WebView2CustomItemSelectEventHanlder hanlder = new WebView2CustomItemSelectEventHanlder();
    //            hanlder.Selected += OnCustomItemSelectIntern;
    //            base.add_CustomItemSelected(hanlder, out this._CustomItemSelectedToken);
    //        }
    //        catch (InvalidCastException ex)
    //        {
    //            if (ex.HResult == -2147467262)
    //                throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
    //            throw;
    //        }
    //        catch (COMException ex)
    //        {
    //            if (ex.HResult == -2147019873)
    //                throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
    //            throw;
    //        }
    //    }
    //    private void UnWireEvents()
    //    {
    //        EventRegistrationTool.UnWireToken(this._CustomItemSelectedToken,
    //            base.remove_CustomItemSelected);
    //    }
    //    private void OnCustomItemSelectIntern(object sender, WebView2ContextMenuItem e)
    //    {
    //        OnCustomItemSelected(e);
    //    }
    //    protected virtual void OnCustomItemSelected(WebView2ContextMenuItem e)
    //    {
    //        CustomItemSelected?.Invoke(this, e);
    //    }

    //    protected override ICoreWebView2ContextMenuItem ContextMenuItem => _Holder.Interface;

    //    public new Stream Icon
    //    {
    //        get
    //        {
    //            try
    //            {
    //                return base.Icon == null ? null : (Stream)new COMStreamWrapper(base.Icon);
    //            }
    //            catch (InvalidCastException ex)
    //            {
    //                if (ex.HResult == -2147467262)
    //                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
    //                throw;
    //            }
    //            catch (COMException ex)
    //            {
    //                if (ex.HResult == -2147019873)
    //                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
    //                throw;
    //            }
    //        }
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            UnWireEvents();
    //        }

    //        base.Dispose(disposing);
    //    }
    //}
    public class WebView2ContextMenuItem:IDisposable
    {
        private ComObjctHolder<ICoreWebView2ContextMenuItem> _NativeObject;
       
        public event EventHandler<WebView2ContextMenuItem> CustomItemSelected;
        private EventRegistrationToken _CustomItemSelectedToken;
        
        private bool disposedValue;

        public ICoreWebView2ContextMenuItem ToInterface()
        {
            return this.ContextMenuItemIntrface;
        }
        internal ICoreWebView2ContextMenuItem ContextMenuItemIntrface => this._NativeObject.Interface;

        internal WebView2ContextMenuItem(object nativeObject)
        {
            this._NativeObject = new ComObjctHolder<ICoreWebView2ContextMenuItem>(nativeObject);
            WireEvents();
        }

        private void WireEvents()
        {
            AddCustomItemSelectedEvent();
        }

        private void UnWireEvents()
        {
            EventRegistrationTool.UnWireToken(this._CustomItemSelectedToken,
                this.ContextMenuItemIntrface.remove_CustomItemSelected);
        }
        
        private void AddCustomItemSelectedEvent()
        {
            try
            {
                WebView2CustomItemSelectEventHanlder hanlder = new WebView2CustomItemSelectEventHanlder();
                hanlder.Selected += OnCustomItemSelectIntern;
                this.ContextMenuItemIntrface.add_CustomItemSelected(hanlder, out this._CustomItemSelectedToken);
            }
            catch (InvalidCastException ex)
            {
                if (ex.HResult == -2147467262)
                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                throw;
            }
            catch (COMException ex)
            {
                if (ex.HResult == -2147019873)
                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                throw;
            }
        }

        private void OnCustomItemSelectIntern(object sender, WebView2ContextMenuItem e)
        {
            OnCustomItemSelected(e);
        }

        public string Name
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.name;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

     
        public string Label
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.Label;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the Command ID for the <see cref="T:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuItem" />.
        /// </summary>
        /// <remarks>
        /// Use this to report the <see cref="P:Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs.SelectedCommandId" /> in <see cref="E:Microsoft.Web.WebView2.Core.CoreWebView2.ContextMenuRequested" /> event.
        /// </remarks>
        public int CommandId
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.CommandId;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

        public string ShortcutKeyDescription
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.ShortcutKeyDescription;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

     
        public Stream Icon
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.Icon == null ? null : (Stream)new COMStreamWrapper(this.ContextMenuItemIntrface.Icon);
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

       
        public COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind
        {
            get
            {
                try
                {
                    return this.ContextMenuItemIntrface.Kind;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

    
        public bool IsEnabled
        {
            get
            {
                try
                {
                    return (CBOOL) this.ContextMenuItemIntrface.IsEnabled ;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
            set
            {
                try
                {
                    this.ContextMenuItemIntrface.IsEnabled =(CBOOL) value ;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

       
        public bool IsChecked
        {
            get
            {
                try
                {
                    return (CBOOL)this.ContextMenuItemIntrface.IsChecked ;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
            set
            {
                try
                {
                    this.ContextMenuItemIntrface.IsChecked = (CBOOL)value ;
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

 
        public ContextMenuItemCollection Children
        {
            get
            {
                try
                {
                    return new ContextMenuItemCollection( this.ContextMenuItemIntrface.Children);
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == -2147467262)
                        throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == -2147019873)
                        throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex);
                    throw;
                }
            }
        }

     
        //public event EventHandler<object> CustomItemSelected
        //{
        //    add
        //    {
        //        if (this.customItemSelected == null)
        //        {
        //            try
        //            {
        //                //this._nativeICoreWebView2ContextMenuItem.add_CustomItemSelected((ICoreWebView2CustomItemSelectedEventHandler) new CoreWebView2CustomItemSelectedEventHandler(new CoreWebView2CustomItemSelectedEventHandler.CallbackType(this.OnCustomItemSelected)), out this._customItemSelectedToken);
        //            }
        //            catch (InvalidCastException ex)
        //            {
        //                if (ex.HResult == -2147467262)
        //                    throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", (Exception)ex);
        //                throw;
        //            }
        //            catch (COMException ex)
        //            {
        //                if (ex.HResult == -2147019873)
        //                    throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", (Exception)ex);
        //                throw;
        //            }
        //        }
        //        this.customItemSelected += value;
        //    }
        //    remove
        //    {
        //        this.customItemSelected -= value;
        //        if (this.customItemSelected != null)
        //            return;
        //        try
        //        {
        //            this.ContextMenuItemIntrface.remove_CustomItemSelected(this._CustomItemSelectedToken);
        //        }
        //        catch (InvalidCastException ex)
        //        {
        //            if (ex.HResult == -2147467262)
        //                throw new InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", (Exception)ex);
        //            throw;
        //        }
        //        catch (COMException ex)
        //        {
        //            if (ex.HResult == -2147019873)
        //                throw new InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", (Exception)ex);
        //            throw;
        //        }
        //    }
        //}

        //internal void OnCustomItemSelected(object args)
        //{
        //    EventHandler<object> customItemSelected = this.customItemSelected;
        //    if (customItemSelected == null)
        //        return;
        //    customItemSelected((object)this, args);
        //}
        protected virtual void OnCustomItemSelected(WebView2ContextMenuItem e)
        {
            CustomItemSelected?.Invoke(this, e);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    UnWireEvents();
                }

                disposedValue = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    //public class WebView2ContextMenuItemOlld : WebView2ContextMenuItemInterface
    //{
    //    //private object _obj;
    //    private EventRegistrationToken _CustomItemSelectEventToken;
    //    public event EventHandler<WebView2ContextMenuItemOlld> CustomItemSelected;
    //    private bool _EvententsWired;
    //    public WebView2ContextMenuItemOlld(ICoreWebView2ContextMenuItem menuItem) : base(menuItem)
    //    {
    //        _EvententsWired = false;
    //        //this._obj = menuItem;
    //        WireEvents();
    //    }

    //    //public WebView2ContextMenuItem(object menuItem) : this((ICoreWebView2ContextMenuItem)menuItem)
    //    //{
    //    //    //this._obj = menuItem;
    //    //    //base.Children

    //    //}

    //    private void WireEvents()
    //    {
    //        //if (this._obj == null) return;
    //        if (this._EvententsWired == true) return;
    //        var selectHanlder = new WebView2CustomItemSelectEventHanlder();
    //        //selectHanlder.Selected += OnItmeSelectedIntenr;
    //        base.add_CustomItemSelected(selectHanlder, out this._CustomItemSelectEventToken);
    //        this._EvententsWired = true;
    //    }

    //    private void OnItmeSelectedIntenr(object sender, WebView2ContextMenuItemOlld e)
    //    {
    //        OnSelected(e);
    //    }
    //    [SecurityCritical]
    //    [HandleProcessCorruptedStateExceptions]
    //    private void UnWireEvents()
    //    {
    //        if (!this._EvententsWired) return;

    //        EventRegistrationTool.UnWireToken(this._CustomItemSelectEventToken, base.remove_CustomItemSelected);


    //    }

    //    //protected override void Dispose(bool disposing)
    //    //{
    //    //    if (disposing)
    //    //    {
    //    //        UnWireEvents();

    //    //    }
    //    //    base.Dispose(disposing);
    //    //}

    //    public new ContextMenuItemCollection Children => new ContextMenuItemCollection(base.Children);

    //    protected virtual void OnSelected(WebView2ContextMenuItemOlld e)
    //    {
    //        //Selected?.Invoke(this, e);
    //    }
    //}
}