using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMElementEvents : DOMObject
    {
        private event EventHandler<DOMMouseEventArgs> _AuxClick;

        public event EventHandler<DOMMouseEventArgs> AuxClick
        {
            add
            {
                this.addEventListener(MouseEvents.AuxClick, new DOMEventListenerScript(this, MouseEvents.AuxClick), false);
                _AuxClick += value;

            }
            remove => _AuxClick -= value;
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
        private event EventHandler<DOMMouseEventArgs> _Click;
        public event EventHandler<DOMMouseEventArgs> Click
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.Click, new DOMEventListenerScript(this, MouseEvents.Click), false);
                _Click += value;
               

            }
            remove => _Click -= value;
        }

        private event EventHandler<DOMMouseEventArgs> _ContextMenu;
        public event EventHandler<DOMMouseEventArgs> ContextMenu
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.ContextMenu, new DOMEventListenerScript(this, MouseEvents.ContextMenu), false);
                _ContextMenu += value;
            }
            remove => _ContextMenu += value;
        }
        private event EventHandler<DOMMouseEventArgs> _DblClick;
        public event EventHandler<DOMMouseEventArgs> DblClick
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.DblClick, new DOMEventListenerScript(this, MouseEvents.DblClick), false);
                _DblClick += value;
            }
            remove => _DblClick -= value;
        }
        public event EventHandler<DOMMouseEventArgs> _MouseDown;
        public event EventHandler<DOMMouseEventArgs> MouseDown
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseDown, new DOMEventListenerScript(this, MouseEvents.MouseDown), false);
                _MouseDown += value;
            }
            remove => _MouseDown -= value;
        }
        private event EventHandler<DOMMouseEventArgs> _MouseEnter;
        public event EventHandler<DOMMouseEventArgs> MouseEnter
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseEnter, new DOMEventListenerScript(this, MouseEvents.MouseEnter), false);
                _MouseEnter += value;
            }
            remove => _MouseEnter -= value;
        }

        private event EventHandler<DOMMouseEventArgs> _MouseLeave;
        public event EventHandler<DOMMouseEventArgs> MouseLeave
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseLeave, new DOMEventListenerScript(this, MouseEvents.MouseLeave), false);
                _MouseLeave += value;
            }
            remove => _MouseLeave -= value;
        }
        private event EventHandler<DOMMouseEventArgs> _MouseMove;
        public event EventHandler<DOMMouseEventArgs> MouseMove
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseMove, new DOMEventListenerScript(this, MouseEvents.MouseMove), false);
                _MouseMove += value;
            }
            remove => _MouseMove -= value;
        }
        private event EventHandler<DOMMouseEventArgs> _MouseOut;
        public event EventHandler<DOMMouseEventArgs> MouseOut
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseOut, new DOMEventListenerScript(this, MouseEvents.MouseOut), false);
                _MouseOut += value;
            }
            remove => _MouseOut -= value;
        }

        private event EventHandler<DOMMouseEventArgs> _MouseOver;
        public event EventHandler<DOMMouseEventArgs> MouseOver
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseOver, new DOMEventListenerScript(this, MouseEvents.MouseOver), false);
                _MouseOver += value;
            }
            remove => _MouseOver -= value;
        }

        private event EventHandler<DOMMouseEventArgs> _MouseUp;
        public event EventHandler<DOMMouseEventArgs> MouseUp
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(MouseEvents.MouseUp, new DOMEventListenerScript(this, MouseEvents.MouseUp), false);
                _MouseUp += value;
            }
            remove => _MouseUp -= value;
        }

        //AuxClick
        private event EventHandler<DOMKeyboardEventArgs> _KeyDown;
        public event EventHandler<DOMKeyboardEventArgs> KeyDown
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(KeyboardEvents.KeyDown, new DOMEventListenerScript(this, KeyboardEvents.KeyDown), false);
                _KeyDown += value;
            }
            remove => _KeyDown -= value;
        }

        private event EventHandler<DOMKeyboardEventArgs> _KeyPress;
        public event EventHandler<DOMKeyboardEventArgs> KeyPress
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(KeyboardEvents.KeyPress, new DOMEventListenerScript(this, KeyboardEvents.KeyPress), false);
                _KeyPress += value;
            }
            remove => _KeyPress -= value;
        }
        private event EventHandler<DOMKeyboardEventArgs> _KeyUp;
        public event EventHandler<DOMKeyboardEventArgs> KeyUp
        {
            add
            {
                AsyncCheck(value);
                this.addEventListener(KeyboardEvents.KeyUp, new DOMEventListenerScript(this, KeyboardEvents.KeyUp), false);
                _KeyUp += value;
            }
            remove => _KeyUp -= value;
        }

        public DOMElementEvents(WebView control, DOMVar domVar) : base(control, domVar)
        {

        }

        public void addEventListener(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            Exec(new object[] { eventName, scriptText, useCapture });
        }
        public async Task addEventListenerAsync(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            await ExecAsync(new object[] { eventName, scriptText, useCapture }, nameof(addEventListener));
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

        private bool disposedValue=false;
        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    EventHandlerList.RemoveByObject(this);
                }

            }
            base.Dispose(disposing);
        }
    }




}