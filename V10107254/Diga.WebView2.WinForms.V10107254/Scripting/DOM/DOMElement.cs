using System;
using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMElement : DOMObject
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

        internal DOMElement(WebView control, DOMVar domVar) : base(control, domVar)
        {

        }

        public Task<string> accessKey
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> accessKeyLabel => GetAsync<string>();
       
        public Task addEventListener(string eventName, DOMScriptText scriptText, bool useCapture)
        {
            EventHandlerList.TryAdd(this.InstanceName, this);
            return ExecAsync<object>(new object[] { eventName, scriptText, useCapture });
        }

        public Task appendChild(DOMElement element)
        {
            return ExecAsync<object>(new object[] { element });
        }

        public Task blur() => ExecAsync<object>(new object[] { });

        public Task<int> childElementCount => GetAsync<int>();

        public Task<string> className
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);

        }

        public Task click() => ExecAsync<object>(new object[] { });

        public Task<int> clientHeight => GetAsync<int>();
        public Task<int> clientLeft => GetAsync<int>();

        public Task<int> clientTop => GetAsync<int>();

        public Task<int> clientWidth => GetAsync<int>();

        public async Task<DOMElement> cloneNode(bool deep)
        {
            DOMVar domVar = await ExecGetVarAsync(new object[] { deep });
            return new DOMElement(this._View2Control, domVar);
        }

        public async Task<DOMElement> closes(string selector)
        {
            DOMVar domVar = await ExecGetVarAsync(new object[] { selector });
            return new DOMElement(this._View2Control, domVar);
        }

        public Task<bool> contains(DOMElement element)
        {
            return ExecAsync<bool>(new object[] { element });
        }

        public Task<string> contentEditable
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> dir
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> enterKeyHint
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }
        public Task exitFullscreen() => ExecAsync<object>(new object[] { });

        public Task<DOMElement> firstChild
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<DOMElement> firstElementChild
        {
            get => GetTypedVarAsync<DOMElement>();
        }

        public Task focus() => ExecAsync<object>(new object[] { });


        public Task<bool> hasAttribute(string value) => ExecAsync<bool>(new object[] { value });

        public Task<bool> hasAttributes() => ExecAsync<bool>(new object[] { });

        public Task<bool> hasChildNodes() => ExecAsync<bool>(new object[] { });


        public Task<bool> hidden
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> id
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> innerHTML
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<bool> inert
        {
            get => GetAsync<bool>();
            set => _ = SetAsync(value);
        }

        public Task<string> innerText
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }


        public Task insertAdjacentElement(string position, DOMElement element)
        {
            return ExecAsync<object>(new object[] { position, element });
        }

        public Task insertAdjacentHTML(string position, string html)
        {
            return ExecAsync<object>(new object[] { position, html });
        }

        public Task insertAdjacentText(string position, string text)
        {
            return ExecAsync<object>(new object[] { position, text });
        }

        public Task insertBefore(DOMElement newNode, DOMElement existingNode)
        {
            return ExecAsync<object>(new object[] { newNode, existingNode });
        }

        public Task<bool> isContentEditable => GetAsync<bool>();

        public Task<bool> isDefaultNamespace(string nameSpace) => ExecAsync<bool>(new object[] { nameSpace });

        public Task<bool> isEqualNode(DOMElement element) => ExecAsync<bool>(new object[] { element });

        public Task<bool> isSameNode(DOMElement element) => ExecAsync<bool>(new object[] { element });

        public Task<bool> isSupported(string feature, string version) => ExecAsync<bool>(new object[] { feature, version });

        public Task<string> lang
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<DOMElement> lastChild
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<bool> matches(string selectors) => ExecAsync<bool>(new object[] { selectors });


        public Task<string> namespaceURI => GetAsync<string>();

        public Task<DOMElement> nextSibling
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<DOMElement> nextElementSibling
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<string> nodeName => GetAsync<string>();

        public Task<int> nodeType => GetAsync<int>();

        public Task<string> nodeValue
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task normalize() => ExecAsync<object>(new object[] { });

        public Task<int> offsetHeight => GetAsync<int>();
        public Task<int> offsetWidth => GetAsync<int>();
        public Task<int> offsetLeft => GetAsync<int>();
        public Task<int> offsetTop => GetAsync<int>();

        public Task<DOMElement> offsetParent
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<string> outerHTML
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<string> outerText
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<DOMDocument> ownerDocument
        {
            get => GetTypedVarAsync<DOMDocument>();
        }

        public Task<DOMElement> parentNode
        {
            get => GetTypedVarAsync<DOMElement>();
        }

        public Task<DOMElement> parentElement
        {
            get => GetTypedVarAsync<DOMElement>();

        }

        public Task<DOMElement> previousSibling
        {
            get => GetTypedVarAsync<DOMElement>();
        }

        public Task<DOMElement> previousElementSibling
        {
            get => GetTypedVarAsync<DOMElement>();
        }

        public async Task<DOMElement> querySelector(string cssSelector)
        {
            DOMVar var = await ExecGetVarAsync(new object[] { cssSelector });
            return new DOMElement(this._View2Control, var);
        }


        public Task remove() => ExecAsync<object>(new object[] { });

        public Task removeAttribute(string name) => ExecAsync<object>(new object[] { name });

        public Task removeAttributeNode(DOMAttribute attr) => ExecAsync<object>(new object[] { attr });

        public Task removeChild(DOMElement elem) => ExecAsync<object>(new object[] { elem });

        public Task replaceChild(DOMElement newNode, DOMElement oldNode) =>
            ExecAsync<object>(new object[] { newNode, oldNode });

        public Task requestFullscreen() => ExecAsync<object>(new object[] { });

        public Task<int> scrollHeight => GetAsync<int>();
        public Task scrollIntoView() => ExecAsync<object>(new object[] { });
        public Task<int> scrollLeft => GetAsync<int>();

        public Task<int> scrollTop => GetAsync<int>();

        public Task setAttribute(string attributename, string attributevalue) =>
            ExecAsync<object>(new object[] { attributename, attributevalue });


        public Task setAttributeNode(DOMVar attr) => ExecAsync<object>(new object[] { attr.Name });

        public Task<string> title
        {
            get => GetAsync<string>();
            set => _ = SetAsync(value);
        }

        public Task<int> tabIndex
        {
            get => GetAsync<int>();
            set => _ = SetAsync(value);
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