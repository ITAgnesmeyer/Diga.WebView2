using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMElementEvents : DOMObject
    {
        private void AddEvent<T>(string eventName, ref EventHandler<T> listener, EventHandler<T> listenerToAdd)
            where T : EventArgs
        {
            AsyncCheck(listenerToAdd);
            this.addEventListener(eventName, new DOMEventListenerScript(this, eventName), false);
            listener += listenerToAdd;
        }

        private void RemoveEvent<T>(string eventName, ref EventHandler<T> listener, EventHandler<T> listenerToRemove)
            where T : EventArgs
        {
            listener -= listenerToRemove;
            if (listener == null)
            {
                this.removeEventListener(eventName);
            }
        }

        private event EventHandler<DOMMouseEventArgs> _AuxClick;

        public event EventHandler<DOMMouseEventArgs> AuxClick
        {
            add => AddEvent(MouseEvents.AuxClick, ref _AuxClick, value);
            remove => RemoveEvent(MouseEvents.AuxClick, ref _AuxClick, value);
        }


        private event EventHandler<DOMMouseEventArgs> _Click;

        public event EventHandler<DOMMouseEventArgs> Click
        {
            add => AddEvent(MouseEvents.Click, ref _Click, value);
            remove => RemoveEvent(MouseEvents.Click, ref _Click, value);
        }

        private event EventHandler<DOMMouseEventArgs> _ContextMenu;

        public event EventHandler<DOMMouseEventArgs> ContextMenu
        {
            add => AddEvent(MouseEvents.ContextMenu, ref _ContextMenu, value);
            remove => RemoveEvent(MouseEvents.ContextMenu, ref _ContextMenu, value);
        }

        private event EventHandler<DOMMouseEventArgs> _DblClick;

        public event EventHandler<DOMMouseEventArgs> DblClick
        {
            add => AddEvent(MouseEvents.DblClick, ref _DblClick, value);
            remove => RemoveEvent(MouseEvents.DblClick, ref _DblClick, value);
        }

        public event EventHandler<DOMMouseEventArgs> _MouseDown;

        public event EventHandler<DOMMouseEventArgs> MouseDown
        {
            add => AddEvent(MouseEvents.MouseDown, ref _MouseDown, value);
            remove => RemoveEvent(MouseEvents.MouseDown, ref _MouseDown, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseEnter;

        public event EventHandler<DOMMouseEventArgs> MouseEnter
        {
            add => AddEvent(MouseEvents.MouseEnter, ref _MouseEnter, value);
            remove => RemoveEvent(MouseEvents.MouseEnter, ref _MouseEnter, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseLeave;

        public event EventHandler<DOMMouseEventArgs> MouseLeave
        {
            add => AddEvent(MouseEvents.MouseLeave, ref _MouseLeave, value);
            remove => RemoveEvent(MouseEvents.MouseLeave, ref _MouseLeave, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseMove;

        public event EventHandler<DOMMouseEventArgs> MouseMove
        {
            add => AddEvent(MouseEvents.MouseMove, ref _MouseMove, value);
            remove => RemoveEvent(MouseEvents.MouseMove, ref _MouseMove, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseOut;

        public event EventHandler<DOMMouseEventArgs> MouseOut
        {
            add => AddEvent(MouseEvents.MouseOut, ref _MouseOut, value);
            remove => RemoveEvent(MouseEvents.MouseOut, ref _MouseOut, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseOver;

        public event EventHandler<DOMMouseEventArgs> MouseOver
        {
            add => AddEvent(MouseEvents.MouseOver, ref _MouseOver, value);
            remove => RemoveEvent(MouseEvents.MouseOver, ref _MouseOver, value);
        }

        private event EventHandler<DOMMouseEventArgs> _MouseUp;

        public event EventHandler<DOMMouseEventArgs> MouseUp
        {
            add => AddEvent(MouseEvents.MouseUp, ref _MouseUp, value);
            remove => RemoveEvent(MouseEvents.MouseUp, ref _MouseUp, value);
        }

        //AuxClick
        private event EventHandler<DOMKeyboardEventArgs> _KeyDown;

        public event EventHandler<DOMKeyboardEventArgs> KeyDown
        {
            add => AddEvent(KeyboardEvents.KeyDown, ref _KeyDown, value);
            remove => RemoveEvent(KeyboardEvents.KeyDown, ref _KeyDown, value);
        }

        private event EventHandler<DOMKeyboardEventArgs> _KeyPress;

        public event EventHandler<DOMKeyboardEventArgs> KeyPress
        {
            add => AddEvent(KeyboardEvents.KeyPress, ref _KeyPress, value);
            remove => RemoveEvent(KeyboardEvents.KeyPress, ref _KeyPress, value);
        }

        private event EventHandler<DOMKeyboardEventArgs> _KeyUp;

        public event EventHandler<DOMKeyboardEventArgs> KeyUp
        {
            add => AddEvent(KeyboardEvents.KeyUp, ref _KeyUp, value);
            remove => RemoveEvent(KeyboardEvents.KeyUp, ref _KeyUp, value);
        }

        public DOMElementEvents(WebView control, DOMVar domVar) : base(control, domVar)
        {
        }

        private bool IsThisAsync(Delegate del)
        {
            return del.Method.IsDefined(typeof(AsyncStateMachineAttribute), false);
        }

        private void AsyncCheck(Delegate del)
        {
            if (IsThisAsync(del))
                throw new InvalidOperationException("You cannot assign a async function!");
        }

        private readonly Dictionary<string, DOMScriptVar> _ScriptVars = new Dictionary<string, DOMScriptVar>();

        public void addEventListener(string eventName, DOMEventListenerScript scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            if (!this._ScriptVars.ContainsKey(eventName))
            {
                DOMScriptVar var = new DOMScriptVar(this._View2Control, scriptText);

                Exec(new object[] { eventName, var, useCapture });

                this._ScriptVars.Add(eventName, var);
            }
        }

        public async Task addEventListenerAsync(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            await ExecAsync(new object[] { eventName, scriptText, useCapture }, nameof(addEventListener));
        }


        public void removeEventListener(string eventName, DOMVar var = null)
        {
            if (this._ScriptVars.ContainsKey(eventName))
            {
                DOMScriptVar varObj = this._ScriptVars[eventName];
                Exec(new object[] { eventName, varObj });
                varObj.Dispose();
            }
            else
            {
                if (var != null)
                {
                    Exec(new object[] { eventName, var });
                }
            }
        }

        public async Task removeEventListenerAsync(string eventName, DOMVar var = null)
        {
            if (this._ScriptVars.ContainsKey(eventName))
            {
                DOMScriptVar varObj = this._ScriptVars[eventName];
                await ExecAsync(new object[] { eventName, varObj });
                await varObj.DisposeAsync();
            }
            else
            {
                if (var != null)
                {
                    await ExecAsync(new object[] { eventName, var });
                }
            }
        }

        protected override void OnDomEvent(RpcEventHandlerArgs e)
        {
            DOMVar eventObj = new DOMVar(this._View2Control, e.RpcObject.idFullName);

            using (DOMVar copyEventObj = eventObj.Copy())
            {
                switch (e.EventName)
                {
                    case MouseEvents.AuxClick:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnAuxClickEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.Click:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);

                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnClickEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.ContextMenu:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);

                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnContextMenuEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.DblClick:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);

                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnDblClickEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseDown:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseDownEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseEnter:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseEnterEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseLeave:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseLeaveEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseMove:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseMoveEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseOut:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);

                            OnMouseOutEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseOver:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseOverEvent(eventArgs);
                        }
                    }
                        break;
                    case MouseEvents.MouseUp:
                    {
                        var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMMouseEventArgs(me);
                            OnMouseUpEvent(eventArgs);
                        }
                    }
                        break;
                    case KeyboardEvents.KeyDown:
                    {
                        var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMKeyboardEventArgs(ke);
                            OnKeyDownEvent(eventArgs);
                        }
                    }
                        break;
                    case KeyboardEvents.KeyPress:
                    {
                        var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMKeyboardEventArgs(ke);
                            OnKeyPressEvent(eventArgs);
                        }
                    }
                        break;
                    case KeyboardEvents.KeyUp:
                    {
                        var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj);
                        {
                            var eventArgs = new DOMKeyboardEventArgs(ke);
                            OnKeyUpEvent(eventArgs);
                        }
                    }
                        break;
                }
            }

            base.OnDomEvent(e);
        }

        protected virtual void OnClickEvent(DOMMouseEventArgs e)
        {
            _Click?.Invoke(this, e);
        }

        protected virtual void OnMouseOverEvent(DOMMouseEventArgs e)
        {
            _MouseOver?.Invoke(this, e);
        }

        protected virtual void OnMouseOutEvent(DOMMouseEventArgs e)
        {
            _MouseOut?.Invoke(this, e);
        }

        protected virtual void OnAuxClickEvent(DOMMouseEventArgs e)
        {
            _AuxClick?.Invoke(this, e);
        }

        protected virtual void OnContextMenuEvent(DOMMouseEventArgs e)
        {
            _ContextMenu?.Invoke(this, e);
        }

        protected virtual void OnDblClickEvent(DOMMouseEventArgs e)
        {
            _DblClick?.Invoke(this, e);
        }

        protected virtual void OnMouseDownEvent(DOMMouseEventArgs e)
        {
            _MouseDown?.Invoke(this, e);
        }

        protected virtual void OnMouseEnterEvent(DOMMouseEventArgs e)
        {
            _MouseEnter?.Invoke(this, e);
        }

        protected virtual void OnMouseLeaveEvent(DOMMouseEventArgs e)
        {
            _MouseLeave?.Invoke(this, e);
        }

        protected virtual void OnMouseMoveEvent(DOMMouseEventArgs e)
        {
            _MouseMove?.Invoke(this, e);
        }

        protected virtual void OnMouseUpEvent(DOMMouseEventArgs e)
        {
            _MouseUp?.Invoke(this, e);
        }

        protected virtual void OnKeyDownEvent(DOMKeyboardEventArgs e)
        {
            _KeyDown?.Invoke(this, e);
        }

        protected virtual void OnKeyPressEvent(DOMKeyboardEventArgs e)
        {
            _KeyPress?.Invoke(this, e);
        }

        protected virtual void OnKeyUpEvent(DOMKeyboardEventArgs e)
        {
            _KeyUp?.Invoke(this, e);
        }

        //protected virtual void OnClickEventAsync(DOMMouseEventArgs e)
        //{
        //    if (_ClickAsync == null) return;

        //    this._ClickAsync.Invoke(this, e);

        //}

        private bool disposedValue;

        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    EventHandlerList.RemoveByObject(this);
                }

                this.disposedValue = true;
            }

            base.Dispose(disposing);
        }
    }

}