using System.Threading.Tasks;

namespace Diga.WebView2.WinForms.Scripting.DOM
{
    public class DOMStyle : DOMElement
    {
        public DOMStyle(WebView control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public Task<string> alignContent { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> alignItems { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> alignSelf { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animation { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationDelay { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationDirection { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationDuration { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationFillMode { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationIterationCount { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationName { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationTimingFunction { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> animationPlayState { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> background { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundAttachment { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundImage { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundPosition { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundRepeat { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundClip { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundOrigin { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backgroundSize { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> backfaceVisibility { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> border { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottom { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottomColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottomLeftRadius { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottomRightRadius { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottomStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderBottomWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderCollapse { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImage { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImageOutset { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImageRepeat { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImageSlice { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImageSource { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderImageWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderLeft { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderLeftColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderLeftStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderLeftWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderRadius { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderRight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderRightColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderRightStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderRightWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderSpacing { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTop { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTopColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTopLeftRadius { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTopRightRadius { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTopStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderTopWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> borderWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> bottom { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> boxDecorationBreak { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> boxShadow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> boxSizing { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> captionSide { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> caretColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> clear { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> clip { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> color { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnCount { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnFill { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnGap { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnRule { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnRuleColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnRuleStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnRuleWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columns { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnSpan { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> columnWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> content { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> counterIncrement { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> counterReset { get => GetAsync<string>(); set => _ = SetAsync(value); }

        public Task<string> cssText
        {
            get => GetAsync<string>();
            set=> _ = SetAsync(value);
        }

        public Task<string> cursor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> direction { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> display { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> emptyCells { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> filter { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flex { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexBasis { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexDirection { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexFlow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexGrow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexShrink { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> flexWrap { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> cssFloat { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> font { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontFamily { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontSize { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontVariant { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontWeight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontSizeAdjust { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> fontStretch { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> hangingPunctuation { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> height { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> hyphens { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> icon { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> imageOrientation { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> isolation { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> justifyContent { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> left { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> letterSpacing { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> lineHeight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> listStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> listStyleImage { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> listStylePosition { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> listStyleType { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> margin { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> marginBottom { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> marginLeft { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> marginRight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> marginTop { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> maxHeight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> maxWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> minHeight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> minWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> navDown { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> navIndex { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> navLeft { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> navRight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> navUp { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> objectFit { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> objectPosition { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> opacity { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> order { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> orphans { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> outline { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> outlineColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> outlineOffset { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> outlineStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> outlineWidth { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> overflow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> overflowX { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> overflowY { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> padding { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> paddingBottom { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> paddingLeft { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> paddingRight { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> paddingTop { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> pageBreakAfter { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> pageBreakBefore { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> pageBreakInside { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> perspective { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> perspectiveOrigin { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> position { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> quotes { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> resize { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> right { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> scrollBehavior { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> tableLayout { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> tabSize { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textAlign { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textAlignLast { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textDecoration { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textDecorationColor { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textDecorationLine { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textDecorationStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textIndent { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textJustify { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textOverflow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textShadow { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> textTransform { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> top { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transform { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transformOrigin { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transformStyle { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transition { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transitionProperty { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transitionDuration { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transitionTimingFunction { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> transitionDelay { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> unicodeBidi { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> userSelect { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> verticalAlign { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> visibility { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> whiteSpace { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> width { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> wordBreak { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> wordSpacing { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> wordWrap { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> widows { get => GetAsync<string>(); set => _ = SetAsync(value); }
        public Task<string> zIndex { get => GetAsync<string>(); set => _ = SetAsync(value); }



    }
}