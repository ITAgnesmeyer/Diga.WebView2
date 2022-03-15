using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{

    public class TextMetrics : DOMObject
    {
        public TextMetrics(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public decimal actualBoundingBoxAscent => Get<decimal>();
        public decimal actualBoundingBoxDescent => Get<decimal>();

        public decimal actualBoundingBoxLeft => Get<decimal>();

        public decimal actualBoundingBoxRight => Get<decimal>();
        public decimal fontBoundingBoxAscent => Get<decimal>();
        public decimal fontBoundingBoxDescent => Get<decimal>();
        public decimal width => Get<decimal>();

    }
    
    public class CanvasShadowStyles : CanvasState
    {
        public CanvasShadowStyles(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public decimal shadowBlur
        {
            get => Get<decimal>();
            set => Set(value);
        }

        public string shadowColor
        {
            get => Get<string>();
            set => Set(value);
        }

        public decimal shadowOffsetX
        {
            get => Get<decimal>();
            set => Set(value);

        }

        public decimal shadowOffsetY
        {
            get => Get<decimal>();
            set => Set(value);

        }

    }


    public class CanvasRenderingContext2DSettings : DOMObject
    {
        public CanvasRenderingContext2DSettings(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public bool alpha
        {
            get => Get<bool>();
            set => Set(value);
        }

        public string colorSpace
        {
            get => Get<string>();
            set => Set(value);
        }

        public bool desynchronized
        {
            get => Get<bool>();
            set => Set(value);
        }

        public bool willReadFrequently
        {
            get => Get<bool>();
            set => Set(value);
        }
    }

    public class CanvasRenderingContext2D : CanvasCompositing
    {
        public CanvasRenderingContext2D(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public DOMCanvasElement canvas => GetTypedVar<DOMCanvasElement>();

        public CanvasRenderingContext2DSettings getContextAttributes()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new CanvasRenderingContext2DSettings(this._View2Control, var);
        }
    }
    public class CanvasState : CanvasText
    {
        public CanvasState(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public void restore()
        {
            Exec(new object[]{});
        }

        public void save()
        {
            Exec(new object[]{});
        }
    }

    public class CanvasTransform : CanvasUserInterface
    {
        public CanvasTransform(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
                
        }

        public DOMObject getTransform()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new DOMObject(this._View2Control, var);
        }

        public void resetTransform()
        {
            Exec(new object[]{});
        }

        public void rotate(decimal angle)
        {
            Exec(new object[]{angle});
        }

        public void scale(decimal x, decimal y)
        {
            Exec(new object[]{x,y});
        }

        public void setTransform(decimal  a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            Exec(new object[]{a,b,c,d,e,f});
        }

        public void transform(decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            Exec(new object[]{a,b,c,d,e,f});
        }

        public void translate(decimal x, decimal y)
        {
            Exec(new object[]{x,y});
        }

    }
    public class CanvasText : CanvasTextDrawingStyles 
    {
        public CanvasText(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
                
        }

        public void fillText(string text, decimal x, decimal y, decimal maxWidth)
        {
            Exec(new object[]{text, x, y, maxWidth});
        }

        public void fillText(string text, decimal x, decimal y)
        {
            Exec(new object[]{text, x, y});
        }

        public TextMetrics measureText(string text)
        {
            DOMVar var = ExecGetVar(new object[] { text });
            return new TextMetrics(this._View2Control, var);
        }

        public void strokeText(string text, decimal x, decimal y, decimal maxWidth)
        {
            Exec(new object[]{text, x, y, maxWidth});
        }

        public void strokeText(string text, decimal x, decimal y)
        {
            Exec(new object[]{text, x, y});
        }
    }
    public class CanvasTextDrawingStyles : CanvasTransform
    {
        public CanvasTextDrawingStyles(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public string direction
        {
            get => base.Get<string>();
            set => base.Set(value);
        }

        public string font
        {
            get => Get<string>();
            set => Set(value);
        }

        public string textAlign
        {
            get => Get<string>();
            set => Set(value);
        }

        public string textBaseline
        {
            get => Get<string>();
            set => Set(value);
        }


    }

    public class CanvasCompositing : CanvasDrawImage
    {
        public CanvasCompositing(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public decimal globalAlpha
        {
            get => Get<decimal>();
            set => Set(value);
        }

        public string globalCompositeOperation
        {
            get => Get<string>();
            set => Set(value);
        }


    }
    public class CanvasUserInterface : DOMObject
    {
        public CanvasUserInterface(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public void drawFocusIfNeeded(DOMElement element)
        {
            Exec(new object[]{element});
        }
    }
    public class CanvasDrawImage : CanvasDrawPath
    {
        public CanvasDrawImage(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public void drawImage(DOMElement image, decimal dx, decimal dy)
        {
            Exec(new object[]{image, dx, dy});
        }

        public void drawImage(DOMElement image, decimal dx, decimal dy, decimal dw, decimal dh)
        {
            Exec(new object[] { image, dx, dy, dw, dh });
        }


        public void drawImage(DOMElement image, decimal sx, decimal sy, decimal sw, decimal sh, decimal dx, decimal dy, decimal dw, decimal dh)
        {
            Exec(new object[] { image, sx, sy, sw, sh,dx,dy,dw,dh});
        }

    }
    public class ImageData : DOMObject
    {
        public ImageData(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public DOMObject data => GetTypedVar<DOMObject>();
        public decimal height => Get<decimal>();
        public decimal width => Get<decimal>();
    }

    public class CanvasFillStrokeStyles : CanvasFilters
    {
        public CanvasFillStrokeStyles(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public string fillStyle
        {
            get => Get<string>();
            set => Set(value);
        }

        public string strokeStyle
        {
            get => Get<string>();
            set => Set(value);
        }

        public string createConicGradient(int startAngle, decimal x, decimal y)
        {
            return Exec<string>(new object[] { startAngle, x, y });
        }

        public string createLinearGradient(decimal x0, decimal y0, decimal x1, decimal y1)
        {
            return Exec<string>(new object[] { x0, y0, x1, y1 });
        }

        public string createPattern(DOMElement image, string repetition = null)
        {
            return Exec<string>(new object[] { image, repetition });
        }

        public string createRadialGradient(decimal x0, decimal y0, decimal r0, decimal x1, decimal y1, decimal r1)
        {
            return Exec<string>(new object[] { x0, y0, r0, x1, y1, r1 });
        }


    }
    public class CanvasFilters : CanvasImageData
    {
        public CanvasFilters(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public string filter
        {
            get => Get<string>();
            set => Set(value);
        }
    }
    public class CanvasImageData : CanvasImageSmoothing
    {
        public CanvasImageData(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public ImageData createImageData(decimal sw, decimal sh, string settings=null)
        {
            DOMVar var = ExecGetVar( new object[]{sw,sh,settings});
            return new ImageData(this._View2Control, var);
        }

        public ImageData createImageData(ImageData imageData)
        {
            DOMVar var = ExecGetVar( new object[]{imageData});
            return new ImageData(this._View2Control, var);
        }

        public ImageData getImageData(decimal sx, decimal sy, decimal sw, decimal sh, string settings = null)
        {
            DOMVar var = ExecGetVar(new object[] { sx, sy, sw, sh, settings });
            return new ImageData(this._View2Control, var);
        }

        public void putImageData(ImageData imagedata, decimal dx, decimal dy)
        {
            Exec(new object[]{imagedata, dx, dy});
        }

        public void putImageData(ImageData imageData, decimal dx, decimal dy, decimal dirtyX, decimal dirtyY, decimal dirtyWidth,
            int dirtyHeight)
        {
            Exec(new object[] { imageData, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight });
        }
    }
    
    public class CanvasRect : CanvasShadowStyles
    {
        public CanvasRect(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public void clearRect(decimal x, decimal y, decimal w, decimal h)
        {
            Exec(new object[]{x,y, w,h });
        }

        public void fillRect(decimal x, decimal y, decimal w, decimal h)
        {
            Exec(new object[]{x,y, w,h });
        }

        public void strokeRect(decimal x, decimal y, decimal w, decimal h)
        {
            Exec(new object[]{x,y,w,h});
        }

    }
    public class CanvasImageSmoothing : CanvasPath
    {
        public CanvasImageSmoothing(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public bool imageSmoothingEnabled
        {
            get => Get<bool>();
            set => Set(value);
        }

        public string imageSmoothingQuality
        {
            get => Get<string>();
            set => Set(value);
        }
    }
    public class CanvasPathDrawingStyles : CanvasRect
    {
        public CanvasPathDrawingStyles(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public string lineCap
        {
            get => Get<string>();
            set => Set(value);
        }

        public decimal lineDashOffset
        {
            get => Get<decimal>();
            set => Set(value);
        }

        public string lineJoin
        {
            get => Get<string>();
            set => Set(value);
        }

        public decimal lineWidth
        {
            get => Get<decimal>();
            set => Set(value);
        }

        public decimal miterLimit
        {
            get => Get<decimal>();
            set => Set(value);
        }

    }

    public class CanvasDrawPath : CanvasFillStrokeStyles
    {
        public CanvasDrawPath(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
                
        }

        public void beginPath()
        {
            Exec(new object[]{});
        }

        public void clip(string fillRule)
        {
            Exec(new object[]{fillRule});
        }

        public void fill(string fillRule)
        {
            Exec(new object[]{fillRule});
        }

        public bool isPointInPath(decimal x, decimal y, string fillRule = null)
        {
            return Exec<bool>(new object[] { x, y, fillRule });
        }

        public bool isPointInStroke(decimal x, decimal y)
        {
            return Exec<bool>(new object[] { x, y });
        }

        public void stroke()
        {
            Exec(new object[]{});
        }

    }
    public class CanvasPath : CanvasPathDrawingStyles
    {
        public CanvasPath(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
                
        }

        public void arc(decimal x, decimal y, decimal radius, decimal startAngle, decimal endAngle, bool counterclockwise=false)
        {
            Exec(new object[]{x,y,radius, startAngle, endAngle, counterclockwise});
        }

        public void arcTo(decimal x1, decimal y1, decimal x2, decimal y2, decimal radius)
        {
            Exec(new object[]{x1, y1, x2, y2, radius});
        }

        public void bezierCurveTo(decimal cp1x, decimal cp1y, decimal cp2x, decimal cp2y, decimal x, decimal y)
        {
            Exec(new object[]{cp1x, cp1y, cp2x, cp2y, x, y});
        }

        public void closePath()
        {
            Exec(new object[]{});
        }

        public void ellipse(decimal x, decimal y, decimal radiusX, decimal radiusY, decimal rotation, decimal startAngle, decimal endAngle,
            bool counterclockwise = false)
        {
            Exec(new object[]{x,y,radiusX, radiusY, rotation, startAngle, endAngle,counterclockwise});
        }

        public void lineTo(decimal x, decimal y)
        {
            Exec(new object[]{x,y});
        }
        public void moveTo(decimal x, decimal y)
        {
            Exec(new object[]{x,y});
        }

        public void quadraticCurveTo(decimal cpx, decimal cpy, decimal x, decimal y)
        {
            Exec(new object[]{cpx, cpy, x, y});
        }

        public void rect(decimal x, decimal y, decimal w, decimal h)
        {
            Exec(new object[]{x,y,w,h});
        }

    }

    public class MediaStream : DOMObject
    {
        public MediaStream(IWebViewControl control, DOMVar domVar):base(control, domVar)
        {
            
        }

        public bool active => Get<bool>();
        public string id => Get<string>();

        public void addTrack(MediaStreamTrack track)
        {
            Exec(new object[]{track});
        }

        public MediaStream clone()
        {
            DOMVar var = ExecGetVar(new object[] { });
            return new MediaStream(this._View2Control, var);
        }

    }
    public class DOMCanvasElement : DOMElement
    {
        internal DOMCanvasElement(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {

        }

        public DOMCanvasElement(DOMElement element) : base(element.Control, element.Var)
        {

        }
        public decimal height
        {
            get => base.Get<decimal>();
            set => base.Set(value);
        }

        public decimal width
        {
            get => base.Get<decimal>();
            set => base.Set(value);
        }

        public MediaStream captureStream(int frameStreamRate)
        {
            DOMVar var = ExecGetVar(new object[] { frameStreamRate });
            return new MediaStream(this._View2Control, var);
        }

        public DOMObject getContext(string contextID)
        {
            DOMVar var = ExecGetVar(new object[] { contextID });
            return new DOMObject(this._View2Control, var);
        }

        public CanvasRenderingContext2D GetContext2D()
        {
            DOMVar var = ExecGetVar(new object[] { "2d" }, nameof(getContext));
            return new CanvasRenderingContext2D(this._View2Control, var);
        }
    }
}