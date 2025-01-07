using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
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
                try
                {
                    this.removeEventListener(eventName);
                }
                catch (Exception exception)
                {
                    Debug.Print("Exception:" + exception.Message);
                }

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


        private event EventHandler<DOMFocusEventArgs> _Blur;
        public event EventHandler<DOMFocusEventArgs> Blur
        {
            add => AddEvent(FocusEvents.Blur, ref _Blur, value);
            remove => RemoveEvent(FocusEvents.Blur, ref _Blur, value);
        }

        private event EventHandler<DOMFocusEventArgs> _Focus;
        public event EventHandler<DOMFocusEventArgs> Focus
        {
            add => AddEvent(FocusEvents.Focus, ref _Focus, value);
            remove => RemoveEvent(FocusEvents.Focus, ref _Focus, value);
        }

        private event EventHandler<DOMFocusEventArgs> _FocusIn;
        public event EventHandler<DOMFocusEventArgs> FocusIn
        {
            add => AddEvent(FocusEvents.FocusIn, ref _FocusIn, value);
            remove => RemoveEvent(FocusEvents.FocusIn, ref _FocusIn, value);
        }
        private event EventHandler<DOMFocusEventArgs> _FocusOut;
        public event EventHandler<DOMFocusEventArgs> FocusOut
        {
            add => AddEvent(FocusEvents.FocusOut, ref _FocusOut, value);
            remove => RemoveEvent(FocusEvents.FocusOut, ref _FocusOut, value);
        }

        private event EventHandler<DOMInputEventArgs> _Input;
        public event EventHandler<DOMInputEventArgs> Input
        {
            add => AddEvent(InputEvents.Input, ref _Input, value);
            remove => RemoveEvent(InputEvents.Input, ref _Input, value);
        }

        private event EventHandler<DOMTouchEventArgs> _TouchMove;
        public event EventHandler<DOMTouchEventArgs> TouchMove
        {
            add => AddEvent(TouchEvents.TouchMove, ref _TouchMove, value);
            remove => RemoveEvent(TouchEvents.TouchMove, ref _TouchMove, value);
        }

        public event EventHandler<DOMTouchEventArgs> _TouchStart;
        public event EventHandler<DOMTouchEventArgs> TouchStart
        {
            add => AddEvent(TouchEvents.TouchStart, ref _TouchStart, value);
            remove => RemoveEvent(TouchEvents.TouchStart, ref _TouchStart, value);
        }

        public event EventHandler<DOMTouchEventArgs> _TouchEnd;
        public event EventHandler<DOMTouchEventArgs> TouchEnd
        {
            add => AddEvent(TouchEvents.TouchEnd, ref _TouchEnd, value);
            remove => RemoveEvent(TouchEvents.TouchEnd, ref _TouchEnd, value);
        }
        public event EventHandler<DOMTouchEventArgs> _TouchCancel;
        public event EventHandler<DOMTouchEventArgs> TouchCancel
        {
            add => AddEvent(TouchEvents.TouchCancel, ref _TouchCancel, value);
            remove => RemoveEvent(TouchEvents.TouchCancel, ref _TouchCancel, value);
        }

        public DOMElementEvents(IWebViewControl control, DOMVar domVar) : base(control, domVar)
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
            Guid transactionId = DOMGC.BeginTransaction();
            DOMVar eventObj = new DOMVar(this._View2Control, e.RpcObject.idFullName);
            
            try
            {
                if (!eventObj.VarExist())
                    return;
                using (DOMVar copyEventObj = eventObj.Copy())
                {
                    switch (e.EventName)
                    {
                        case MouseEvents.AuxClick:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnAuxClickEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.Click:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnClickEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.ContextMenu:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnContextMenuEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.DblClick:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnDblClickEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseDown:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseDownEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseEnter:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseEnterEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseLeave:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseLeaveEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseMove:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseMoveEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseOut:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj)) 
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);

                                    OnMouseOutEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseOver:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseOverEvent(eventArgs);
                                }
                            }
                            break;
                        case MouseEvents.MouseUp:
                            {
                                using (var me = this.GetDomObjectFromDomVar<DOMMouseEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMMouseEventArgs(me);
                                    OnMouseUpEvent(eventArgs);
                                }
                            }
                            break;
                        case KeyboardEvents.KeyDown:
                            {
                                using (var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMKeyboardEventArgs(ke);
                                    OnKeyDownEvent(eventArgs);
                                }
                            }
                            break;
                        case KeyboardEvents.KeyPress:
                            {
                                using (var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMKeyboardEventArgs(ke);
                                    OnKeyPressEvent(eventArgs);
                                }
                            }
                            break;
                        case KeyboardEvents.KeyUp:
                            {
                                using (var ke = this.GetDomObjectFromDomVar<DOMKeyboardEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMKeyboardEventArgs(ke);
                                    OnKeyUpEvent(eventArgs);
                                }
                            }
                            break;
                        case FocusEvents.Blur:
                            {
                                using (var fe = this.GetDomObjectFromDomVar<DOMFocusEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMFocusEventArgs(fe);
                                    OnBlur(eventArgs);
                                }
                            }
                            break;
                        case FocusEvents.Focus:
                            {
                                using (var fe = this.GetDomObjectFromDomVar<DOMFocusEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMFocusEventArgs(fe);
                                    OnFocus(eventArgs);
                                }
                            }
                            break;
                        case FocusEvents.FocusIn:
                            {
                                using (var fe = this.GetDomObjectFromDomVar<DOMFocusEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMFocusEventArgs(fe);
                                    OnFocusIn(eventArgs);
                                }
                            }
                            break;
                        case FocusEvents.FocusOut:
                            {
                                using (var fe = this.GetDomObjectFromDomVar<DOMFocusEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMFocusEventArgs(fe);
                                    OnFocusOut(eventArgs);
                                }
                            }
                            break;
                        case InputEvents.Input:
                            {
                                using (var ie = this.GetDomObjectFromDomVar<DOMInputEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMInputEventArgs(ie);
                                    OnInput(eventArgs);
                                }
                            }
                            break;
                        case TouchEvents.TouchMove:
                            {
                                using (var te = this.GetDomObjectFromDomVar<DOMTouchEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMTouchEventArgs(te);
                                    OnTouchMove(eventArgs);
                                }
                            }
                            break;
                        case TouchEvents.TouchEnd:
                            {
                                using (var te = this.GetDomObjectFromDomVar<DOMTouchEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMTouchEventArgs(te);
                                    OnTouchEnd(this, eventArgs);
                                }
                            }
                            break;
                        case TouchEvents.TouchStart:
                            {
                                using (var te = this.GetDomObjectFromDomVar<DOMTouchEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMTouchEventArgs(te);
                                    OnTouchStart(this, eventArgs);
                                }
                            }
                            break;
                        case TouchEvents.TouchCancel:
                            {
                                using (var te = this.GetDomObjectFromDomVar<DOMTouchEvent>(copyEventObj))
                                {
                                    var eventArgs = new DOMTouchEventArgs(te);
                                    OnTouchCancel(eventArgs);
                                }
                            }
                            break;


                    }
                }

                base.OnDomEvent(e);

            }
            catch (Exception ex)
            {
                throw new DOMElementEventsException("Error in OnDomEvent", ex);

            }
            finally
            {
                DOMGC.CommitTransaction(transactionId);
                eventObj.Dispose();
            }


        }

        private void OnTouchCancel(DOMTouchEventArgs eventArgs)
        {
            _TouchCancel?.Invoke(this, eventArgs);
        }

        private void OnTouchStart(DOMElementEvents dOMElementEvents, DOMTouchEventArgs eventArgs)
        {
            _TouchStart?.Invoke(this, eventArgs);
        }

        private void OnTouchEnd(DOMElementEvents dOMElementEvents, DOMTouchEventArgs eventArgs)
        {
            _TouchEnd?.Invoke(this, eventArgs);
        }

        private void OnTouchMove(DOMTouchEventArgs eventArgs)
        {
            _TouchMove?.Invoke(this, eventArgs);
        }

        private void OnInput(DOMInputEventArgs eventArgs)
        {
            _Input?.Invoke(this, eventArgs);
        }

        private void OnFocusOut(DOMFocusEventArgs eventArgs)
        {
            _FocusOut?.Invoke(this, eventArgs);
        }

        private void OnFocusIn(DOMFocusEventArgs eventArgs)
        {
            _FocusIn?.Invoke(this, eventArgs);
        }

        private void OnFocus(DOMFocusEventArgs eventArgs)
        {
            _Focus?.Invoke(this, eventArgs);
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

        protected virtual void OnBlur(DOMFocusEventArgs e)
        {
            _Blur?.Invoke(this, e);
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