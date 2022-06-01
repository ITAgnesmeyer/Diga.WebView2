using System;
using System.IO;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    
    public class WebView2ContextMenuItem:IDisposable
    {
        private ComObjectHolder<ICoreWebView2ContextMenuItem> _NativeObject;
       
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
            this._NativeObject = new ComObjectHolder<ICoreWebView2ContextMenuItem>(nativeObject);
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
                if (ex.HResult == HRESULT.E_NOINTERFACE)
                    throw new InvalidOperationException($"{nameof(AddCustomItemSelectedEvent)} accessed outside UI-Thread");
                throw;
            }
            catch (COMException ex)
            {
                if (ex.HResult == HRESULT.E_INVALID_STATE)
                    throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(Name)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(Label)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(CommandId)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(ShortcutKeyDescription)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    return this.ContextMenuItemIntrface.Icon == null ? null : (Stream)new ComStream(this.ContextMenuItemIntrface.Icon);
                }
                catch (InvalidCastException ex)
                {
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(Icon)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(Kind)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(IsEnabled)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(IsEnabled)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(IsChecked)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(IsChecked)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

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
                    if (ex.HResult == HRESULT.E_NOINTERFACE)
                        throw new InvalidOperationException($"{nameof(Children)} accessed outside UI-Thread");
                    throw;
                }
                catch (COMException ex)
                {
                    if (ex.HResult == HRESULT.E_INVALID_STATE)
                        throw new InvalidOperationException("WebView2 already disposed");

                    throw;
                }
            }
        }

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

 
}