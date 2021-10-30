﻿using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;

namespace Diga.WebView2.Wrapper
{
    public class Frame : ICoreWebView2Frame, IDisposable

    {
        private ICoreWebView2Frame _Frame;
        private EventRegistrationToken _FrameNameChangedToken;
        private EventRegistrationToken _DestroyedToken;
        private bool disposedValue;

        public event EventHandler<FrameNameChangedEventArgs> FrameNameChanged;
        public event EventHandler<FrameDestroyedEventArgs> FrameDestroyed;

        public Frame(ICoreWebView2Frame frame)
        {
            this._Frame = frame;
            WireEvents();
        }

        [SecurityCritical]
        [HandleProcessCorruptedStateExceptions]
        private void UnWireEvents()
        {
            if (this._Frame == null) return;
            try
            {
                EventRegistrationTool.UnWireToken(this._FrameNameChangedToken, this.remove_NameChanged);
                EventRegistrationTool.UnWireToken(this._DestroyedToken, this.remove_Destroyed);
            }
            catch (Exception ex)
            {

                Debug.Print("Frame UnWireEvents:" + ex.Message);
            }

        }

        private void WireEvents()
        {
            if (this._Frame == null) return;
            FrameNameChangedEventHandler frameNameChangedEventHandler = new FrameNameChangedEventHandler();
            frameNameChangedEventHandler.FrameNameChanged += OnFrameNameChangedIntern;
            this.add_NameChanged(frameNameChangedEventHandler, out this._FrameNameChangedToken);
            FrameDestroyedEventHandler frameDestroyedEventHandler = new FrameDestroyedEventHandler();
            frameDestroyedEventHandler.FrameDestroyed += OnFrameDestroyedIntern;
            this.add_Destroyed(frameDestroyedEventHandler, out this._DestroyedToken);
        }

        private void OnFrameDestroyedIntern(object sender, FrameDestroyedEventArgs e)
        {
            OnFrameDestroyed(e);
        }

        private void OnFrameNameChangedIntern(object sender, FrameNameChangedEventArgs e)
        {
            OnFrameNameChanged(e);
        }

        public string name => this._Frame.name;

        public void add_NameChanged(ICoreWebView2FrameNameChangedEventHandler eventHandler,
            out EventRegistrationToken token)
        {

            try
            {
                this._Frame.add_NameChanged(eventHandler, out token);
            }
            catch (Exception ex)
            {
                token = new EventRegistrationToken();
                Debug.Print(ex.Message);
            }

        }

        public void remove_NameChanged(EventRegistrationToken token)
        {
            this._Frame.remove_NameChanged(token);
        }

        public void AddHostObjectToScriptWithOrigins(string name, ref object @object, uint originsCount, ref string origins)
        {
            this._Frame.AddHostObjectToScriptWithOrigins(name, ref @object, originsCount, ref origins);
        }

        public void RemoveHostObjectFromScript(string name)
        {
            this._Frame.RemoveHostObjectFromScript(name);
        }

        public void add_Destroyed(ICoreWebView2FrameDestroyedEventHandler eventHandler, out EventRegistrationToken token)
        {
            try
            {
                this._Frame.add_Destroyed(eventHandler, out token);
            }
            catch (Exception ex)
            {
                token = new EventRegistrationToken();
                Debug.Print(ex.Message);
            }

        }

        public void remove_Destroyed(EventRegistrationToken token)
        {
            this._Frame.remove_Destroyed(token);
        }

        public int IsDestroyed()
        {
            return this._Frame.IsDestroyed();
        }

        protected virtual void OnFrameNameChanged(FrameNameChangedEventArgs e)
        {
            FrameNameChanged?.Invoke(this, e);
        }

        protected virtual void OnFrameDestroyed(FrameDestroyedEventArgs e)
        {
            FrameDestroyed?.Invoke(this, e);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.UnWireEvents();
                    this._Frame = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~Frame()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}