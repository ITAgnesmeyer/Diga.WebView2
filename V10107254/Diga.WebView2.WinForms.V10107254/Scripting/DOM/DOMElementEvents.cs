using System;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMElementEvents : DOMObject
    {
        public event EventHandler<DOMMouseEventArgs> AuxClick;
        public event EventHandler<DOMMouseEventArgs> Click;
        public event EventHandler<DOMMouseEventArgs> ContextMenu;
        public event EventHandler<DOMMouseEventArgs> DblClick;
        public event EventHandler<DOMMouseEventArgs> MouseDown;
        public event EventHandler<DOMMouseEventArgs> MouseEnter;
        public event EventHandler<DOMMouseEventArgs> MouseLeave;
        public event EventHandler<DOMMouseEventArgs> MouseMove;
        public event EventHandler<DOMMouseEventArgs> MouseOut;
        public event EventHandler<DOMMouseEventArgs> MouseOver;
        public event EventHandler<DOMMouseEventArgs> MouseUp;
        //AuxClick
        public event EventHandler<DOMKeyboardEventArgs> KeyDown;
        public event EventHandler<DOMKeyboardEventArgs> KeyPress;
        public event EventHandler<DOMKeyboardEventArgs> KeyUp;

        public DOMElementEvents(WebView control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public void addEventListener(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            Exec<object>(new object[] { eventName, scriptText, useCapture });
        }
        public Task addEventListenerAsync(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            return ExecAsync<object>(new object[] { eventName, scriptText, useCapture },nameof(addEventListener));
        }
        protected override void OnDomEvent(RpcEventHandlerArgs e)
        {
            switch (e.EventName)
            {
                case MouseEvents.AuxClick:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnAuxClickEvent(eventArgs);
                }
                    break;
                case MouseEvents.Click:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnClickEvent(eventArgs);
                }
                    break;
                case MouseEvents.ContextMenu:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnContextMenuEvent(eventArgs);
                }
                    break;
                case MouseEvents.DblClick:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnDblClickEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseDown:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseDownEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseEnter:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseEnterEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseLeave:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseLeaveEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseMove:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseMoveEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseOut:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);

                    OnMouseOutEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseOver:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseOverEvent(eventArgs);
                }
                    break;
                case MouseEvents.MouseUp:
                {
                    var me = this.GetDomObjectFromVarName<DOMMouseEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMMouseEventArgs(me);
                    OnMouseUpEvent(eventArgs);
                }
                    break;
                case KeyboardEvents.KeyDown:
                {
                    var ke = this.GetDomObjectFromVarName<DOMKeyboardEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMKeyboardEventArgs(ke);
                    OnKeyDownEvent(eventArgs);
                }
                    break;
                case KeyboardEvents.KeyPress:
                {
                    var ke = this.GetDomObjectFromVarName<DOMKeyboardEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMKeyboardEventArgs(ke);

                    OnKeyPressEvent(eventArgs);
                }
                    break;
                case KeyboardEvents.KeyUp:
                {
                    var ke = this.GetDomObjectFromVarName<DOMKeyboardEvent>(e.RpcObject.idFullName);
                    var eventArgs = new DOMKeyboardEventArgs(ke);
                    OnKeyUpEvent(eventArgs);

                }
                    break;
            }
            base.OnDomEvent(e);
        }

        protected virtual void OnClickEvent(DOMMouseEventArgs e)
        {
            Click?.Invoke(this, e);
        }

        protected virtual void OnMouseOverEvent(DOMMouseEventArgs e)
        {
            MouseOver?.Invoke(this, e);
        }

        protected virtual void OnMouseOutEvent(DOMMouseEventArgs e)
        {
            MouseOut?.Invoke(this, e);
        }

        protected virtual void OnAuxClickEvent(DOMMouseEventArgs e)
        {
            AuxClick?.Invoke(this, e);
        }

        protected virtual void OnContextMenuEvent(DOMMouseEventArgs e)
        {
            ContextMenu?.Invoke(this, e);
        }

        protected virtual void OnDblClickEvent(DOMMouseEventArgs e)
        {
            DblClick?.Invoke(this, e);
        }

        protected virtual void OnMouseDownEvent(DOMMouseEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }

        protected virtual void OnMouseEnterEvent(DOMMouseEventArgs e)
        {
            MouseEnter?.Invoke(this, e);
        }

        protected virtual void OnMouseLeaveEvent(DOMMouseEventArgs e)
        {
            MouseLeave?.Invoke(this, e);
        }

        protected virtual void OnMouseMoveEvent(DOMMouseEventArgs e)
        {
            MouseMove?.Invoke(this, e);
        }

        protected virtual void OnMouseUpEvent(DOMMouseEventArgs e)
        {
            MouseUp?.Invoke(this, e);
        }

        protected virtual void OnKeyDownEvent(DOMKeyboardEventArgs e)
        {
            KeyDown?.Invoke(this, e);
        }

        protected virtual void OnKeyPressEvent(DOMKeyboardEventArgs e)
        {
            KeyPress?.Invoke(this, e);
        }

        protected virtual void OnKeyUpEvent(DOMKeyboardEventArgs e)
        {
            KeyUp?.Invoke(this, e);
        }
    }
}