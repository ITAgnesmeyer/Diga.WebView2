using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Scripting.DOM
{
    public class DOMStyle : DOMElement
    {
        public DOMStyle(IWebViewControl control, DOMVar domVar) : base(control, domVar)
        {
            
        }
        public string alignContent { get => Get<string>(); set => Set(value); }
        public string alignItems { get => Get<string>(); set => Set(value); }
        public string alignSelf { get => Get<string>(); set => Set(value); }
        public string animation { get => Get<string>(); set => Set(value); }
        public string animationDelay { get => Get<string>(); set => Set(value); }
        public string animationDirection { get => Get<string>(); set => Set(value); }
        public string animationDuration { get => Get<string>(); set => Set(value); }
        public string animationFillMode { get => Get<string>(); set => Set(value); }
        public string animationIterationCount { get => Get<string>(); set => Set(value); }
        public string animationName { get => Get<string>(); set => Set(value); }
        public string animationTimingFunction { get => Get<string>(); set => Set(value); }
        public string animationPlayState { get => Get<string>(); set => Set(value); }
        public string background { get => Get<string>(); set => Set(value); }
        public string backgroundAttachment { get => Get<string>(); set => Set(value); }
        public string backgroundColor { get => Get<string>(); set => Set(value); }
        public string backgroundImage { get => Get<string>(); set => Set(value); }
        public string backgroundPosition { get => Get<string>(); set => Set(value); }
        public string backgroundRepeat { get => Get<string>(); set => Set(value); }
        public string backgroundClip { get => Get<string>(); set => Set(value); }
        public string backgroundOrigin { get => Get<string>(); set => Set(value); }
        public string backgroundSize { get => Get<string>(); set => Set(value); }
        public string backfaceVisibility { get => Get<string>(); set => Set(value); }
        public string border { get => Get<string>(); set => Set(value); }
        public string borderBottom { get => Get<string>(); set => Set(value); }
        public string borderBottomColor { get => Get<string>(); set => Set(value); }
        public string borderBottomLeftRadius { get => Get<string>(); set => Set(value); }
        public string borderBottomRightRadius { get => Get<string>(); set => Set(value); }
        public string borderBottomStyle { get => Get<string>(); set => Set(value); }
        public string borderBottomWidth { get => Get<string>(); set => Set(value); }
        public string borderCollapse { get => Get<string>(); set => Set(value); }
        public string borderColor { get => Get<string>(); set => Set(value); }
        public string borderImage { get => Get<string>(); set => Set(value); }
        public string borderImageOutset { get => Get<string>(); set => Set(value); }
        public string borderImageRepeat { get => Get<string>(); set => Set(value); }
        public string borderImageSlice { get => Get<string>(); set => Set(value); }
        public string borderImageSource { get => Get<string>(); set => Set(value); }
        public string borderImageWidth { get => Get<string>(); set => Set(value); }
        public string borderLeft { get => Get<string>(); set => Set(value); }
        public string borderLeftColor { get => Get<string>(); set => Set(value); }
        public string borderLeftStyle { get => Get<string>(); set => Set(value); }
        public string borderLeftWidth { get => Get<string>(); set => Set(value); }
        public string borderRadius { get => Get<string>(); set => Set(value); }
        public string borderRight { get => Get<string>(); set => Set(value); }
        public string borderRightColor { get => Get<string>(); set => Set(value); }
        public string borderRightStyle { get => Get<string>(); set => Set(value); }
        public string borderRightWidth { get => Get<string>(); set => Set(value); }
        public string borderSpacing { get => Get<string>(); set => Set(value); }
        public string borderStyle { get => Get<string>(); set => Set(value); }
        public string borderTop { get => Get<string>(); set => Set(value); }
        public string borderTopColor { get => Get<string>(); set => Set(value); }
        public string borderTopLeftRadius { get => Get<string>(); set => Set(value); }
        public string borderTopRightRadius { get => Get<string>(); set => Set(value); }
        public string borderTopStyle { get => Get<string>(); set => Set(value); }
        public string borderTopWidth { get => Get<string>(); set => Set(value); }
        public string borderWidth { get => Get<string>(); set => Set(value); }
        public string bottom { get => Get<string>(); set => Set(value); }
        public string boxDecorationBreak { get => Get<string>(); set => Set(value); }
        public string boxShadow { get => Get<string>(); set => Set(value); }
        public string boxSizing { get => Get<string>(); set => Set(value); }
        public string captionSide { get => Get<string>(); set => Set(value); }
        public string caretColor { get => Get<string>(); set => Set(value); }
        public string clear { get => Get<string>(); set => Set(value); }
        public string clip { get => Get<string>(); set => Set(value); }
        public string color { get => Get<string>(); set => Set(value); }
        public string columnCount { get => Get<string>(); set => Set(value); }
        public string columnFill { get => Get<string>(); set => Set(value); }
        public string columnGap { get => Get<string>(); set => Set(value); }
        public string columnRule { get => Get<string>(); set => Set(value); }
        public string columnRuleColor { get => Get<string>(); set => Set(value); }
        public string columnRuleStyle { get => Get<string>(); set => Set(value); }
        public string columnRuleWidth { get => Get<string>(); set => Set(value); }
        public string columns { get => Get<string>(); set => Set(value); }
        public string columnSpan { get => Get<string>(); set => Set(value); }
        public string columnWidth { get => Get<string>(); set => Set(value); }
        public string content { get => Get<string>(); set => Set(value); }
        public string counterIncrement { get => Get<string>(); set => Set(value); }
        public string counterReset { get => Get<string>(); set => Set(value); }

        public string cssText
        {
            get => Get<string>();
            set => Set(value);
        }

        public string cursor { get => Get<string>(); set => Set(value); }
        public string direction { get => Get<string>(); set => Set(value); }
        public string display { get => Get<string>(); set => Set(value); }
        public string emptyCells { get => Get<string>(); set => Set(value); }
        public string filter { get => Get<string>(); set => Set(value); }
        public string flex { get => Get<string>(); set => Set(value); }
        public string flexBasis { get => Get<string>(); set => Set(value); }
        public string flexDirection { get => Get<string>(); set => Set(value); }
        public string flexFlow { get => Get<string>(); set => Set(value); }
        public string flexGrow { get => Get<string>(); set => Set(value); }
        public string flexShrink { get => Get<string>(); set => Set(value); }
        public string flexWrap { get => Get<string>(); set => Set(value); }
        public string cssFloat { get => Get<string>(); set => Set(value); }
        public string font { get => Get<string>(); set => Set(value); }
        public string fontFamily { get => Get<string>(); set => Set(value); }
        public string fontSize { get => Get<string>(); set => Set(value); }
        public string fontStyle { get => Get<string>(); set => Set(value); }
        public string fontVariant { get => Get<string>(); set => Set(value); }
        public string fontWeight { get => Get<string>(); set => Set(value); }
        public string fontSizeAdjust { get => Get<string>(); set => Set(value); }
        public string fontStretch { get => Get<string>(); set => Set(value); }
        public string hangingPunctuation { get => Get<string>(); set => Set(value); }
        public string height { get => Get<string>(); set => Set(value); }
        public string hyphens { get => Get<string>(); set => Set(value); }
        public string icon { get => Get<string>(); set => Set(value); }
        public string imageOrientation { get => Get<string>(); set => Set(value); }
        public string isolation { get => Get<string>(); set => Set(value); }
        public string justifyContent { get => Get<string>(); set => Set(value); }
        public string left { get => Get<string>(); set => Set(value); }
        public string letterSpacing { get => Get<string>(); set => Set(value); }
        public string lineHeight { get => Get<string>(); set => Set(value); }
        public string listStyle { get => Get<string>(); set => Set(value); }
        public string listStyleImage { get => Get<string>(); set => Set(value); }
        public string listStylePosition { get => Get<string>(); set => Set(value); }
        public string listStyleType { get => Get<string>(); set => Set(value); }
        public string margin { get => Get<string>(); set => Set(value); }
        public string marginBottom { get => Get<string>(); set => Set(value); }
        public string marginLeft { get => Get<string>(); set => Set(value); }
        public string marginRight { get => Get<string>(); set => Set(value); }
        public string marginTop { get => Get<string>(); set => Set(value); }
        public string maxHeight { get => Get<string>(); set => Set(value); }
        public string maxWidth { get => Get<string>(); set => Set(value); }
        public string minHeight { get => Get<string>(); set => Set(value); }
        public string minWidth { get => Get<string>(); set => Set(value); }
        public string navDown { get => Get<string>(); set => Set(value); }
        public string navIndex { get => Get<string>(); set => Set(value); }
        public string navLeft { get => Get<string>(); set => Set(value); }
        public string navRight { get => Get<string>(); set => Set(value); }
        public string navUp { get => Get<string>(); set => Set(value); }
        public string objectFit { get => Get<string>(); set => Set(value); }
        public string objectPosition { get => Get<string>(); set => Set(value); }
        public string opacity { get => Get<string>(); set => Set(value); }
        public string order { get => Get<string>(); set => Set(value); }
        public string orphans { get => Get<string>(); set => Set(value); }
        public string outline { get => Get<string>(); set => Set(value); }
        public string outlineColor { get => Get<string>(); set => Set(value); }
        public string outlineOffset { get => Get<string>(); set => Set(value); }
        public string outlineStyle { get => Get<string>(); set => Set(value); }
        public string outlineWidth { get => Get<string>(); set => Set(value); }
        public string overflow { get => Get<string>(); set => Set(value); }
        public string overflowX { get => Get<string>(); set => Set(value); }
        public string overflowY { get => Get<string>(); set => Set(value); }
        public string padding { get => Get<string>(); set => Set(value); }
        public string paddingBottom { get => Get<string>(); set => Set(value); }
        public string paddingLeft { get => Get<string>(); set => Set(value); }
        public string paddingRight { get => Get<string>(); set => Set(value); }
        public string paddingTop { get => Get<string>(); set => Set(value); }
        public string pageBreakAfter { get => Get<string>(); set => Set(value); }
        public string pageBreakBefore { get => Get<string>(); set => Set(value); }
        public string pageBreakInside { get => Get<string>(); set => Set(value); }
        public string perspective { get => Get<string>(); set => Set(value); }
        public string perspectiveOrigin { get => Get<string>(); set => Set(value); }
        public string position { get => Get<string>(); set => Set(value); }
        public string quotes { get => Get<string>(); set => Set(value); }
        public string resize { get => Get<string>(); set => Set(value); }
        public string right { get => Get<string>(); set => Set(value); }
        public string scrollBehavior { get => Get<string>(); set => Set(value); }
        public string tableLayout { get => Get<string>(); set => Set(value); }
        public string tabSize { get => Get<string>(); set => Set(value); }
        public string textAlign { get => Get<string>(); set => Set(value); }
        public string textAlignLast { get => Get<string>(); set => Set(value); }
        public string textDecoration { get => Get<string>(); set => Set(value); }
        public string textDecorationColor { get => Get<string>(); set => Set(value); }
        public string textDecorationLine { get => Get<string>(); set => Set(value); }
        public string textDecorationStyle { get => Get<string>(); set => Set(value); }
        public string textIndent { get => Get<string>(); set => Set(value); }
        public string textJustify { get => Get<string>(); set => Set(value); }
        public string textOverflow { get => Get<string>(); set => Set(value); }
        public string textShadow { get => Get<string>(); set => Set(value); }
        public string textTransform { get => Get<string>(); set => Set(value); }
        public string top { get => Get<string>(); set => Set(value); }
        public string transform { get => Get<string>(); set => Set(value); }
        public string transformOrigin { get => Get<string>(); set => Set(value); }
        public string transformStyle { get => Get<string>(); set => Set(value); }
        public string transition { get => Get<string>(); set => Set(value); }
        public string transitionProperty { get => Get<string>(); set => Set(value); }
        public string transitionDuration { get => Get<string>(); set => Set(value); }
        public string transitionTimingFunction { get => Get<string>(); set => Set(value); }
        public string transitionDelay { get => Get<string>(); set => Set(value); }
        public string unicodeBidi { get => Get<string>(); set => Set(value); }
        public string userSelect { get => Get<string>(); set => Set(value); }
        public string verticalAlign { get => Get<string>(); set => Set(value); }
        public string visibility { get => Get<string>(); set => Set(value); }
        public string whiteSpace { get => Get<string>(); set => Set(value); }
        public string width { get => Get<string>(); set => Set(value); }
        public string wordBreak { get => Get<string>(); set => Set(value); }
        public string wordSpacing { get => Get<string>(); set => Set(value); }
        public string wordWrap { get => Get<string>(); set => Set(value); }
        public string widows { get => Get<string>(); set => Set(value); }
        public string zIndex { get => Get<string>(); set => Set(value); }

        public Task<string> alignContentAsync { get => GetAsync<string>(nameof(this.alignContent)); set => _ = SetAsync(value, nameof(this.alignContent)); }
        public Task<string> alignItemsAsync { get => GetAsync<string>(nameof(this.alignItems)); set => _ = SetAsync(value, nameof(this.alignItems)); }
        public Task<string> alignSelfAsync { get => GetAsync<string>(nameof(this.alignSelf)); set => _ = SetAsync(value, nameof(this.alignSelf)); }
        public Task<string> animationAsync { get => GetAsync<string>(nameof(this.animation)); set => _ = SetAsync(value, nameof(this.animation)); }
        public Task<string> animationDelayAsync { get => GetAsync<string>(nameof(this.animationDelay)); set => _ = SetAsync(value, nameof(this.animationDelay)); }
        public Task<string> animationDirectionAsync { get => GetAsync<string>(nameof(this.animationDirection)); set => _ = SetAsync(value, nameof(this.animationDirection)); }
        public Task<string> animationDurationAsync { get => GetAsync<string>(nameof(this.animationDuration)); set => _ = SetAsync(value, nameof(this.animationDuration)); }
        public Task<string> animationFillModeAsync { get => GetAsync<string>(nameof(this.animationFillMode)); set => _ = SetAsync(value, nameof(this.animationFillMode)); }
        public Task<string> animationIterationCountAsync { get => GetAsync<string>(nameof(this.animationIterationCount)); set => _ = SetAsync(value, nameof(this.animationIterationCount)); }
        public Task<string> animationNameAsync { get => GetAsync<string>(nameof(this.animationName)); set => _ = SetAsync(value, nameof(this.animationName)); }
        public Task<string> animationTimingFunctionAsync { get => GetAsync<string>(nameof(this.animationTimingFunction)); set => _ = SetAsync(value, nameof(this.animationTimingFunction)); }
        public Task<string> animationPlayStateAsync { get => GetAsync<string>(nameof(this.animationPlayState)); set => _ = SetAsync(value, nameof(this.animationPlayState)); }
        public Task<string> backgroundAsync { get => GetAsync<string>(nameof(this.background)); set => _ = SetAsync(value, nameof(this.background)); }
        public Task<string> backgroundAttachmentAsync { get => GetAsync<string>(nameof(this.backgroundAttachment)); set => _ = SetAsync(value, nameof(this.backgroundAttachment)); }
        public Task<string> backgroundColorAsync { get => GetAsync<string>(nameof(this.backgroundColor)); set => _ = SetAsync(value, nameof(this.backgroundColor)); }
        public Task<string> backgroundImageAsync { get => GetAsync<string>(nameof(this.backgroundImage)); set => _ = SetAsync(value, nameof(this.backgroundImage)); }
        public Task<string> backgroundPositionAsync { get => GetAsync<string>(nameof(this.backgroundPosition)); set => _ = SetAsync(value, nameof(this.backgroundPosition)); }
        public Task<string> backgroundRepeatAsync { get => GetAsync<string>(nameof(this.backgroundRepeat)); set => _ = SetAsync(value, nameof(this.backgroundRepeat)); }
        public Task<string> backgroundClipAsync { get => GetAsync<string>(nameof(this.backgroundClip)); set => _ = SetAsync(value, nameof(this.backgroundClip)); }
        public Task<string> backgroundOriginAsync { get => GetAsync<string>(nameof(this.backgroundOrigin)); set => _ = SetAsync(value, nameof(this.backgroundOrigin)); }
        public Task<string> backgroundSizeAsync { get => GetAsync<string>(nameof(this.backgroundSize)); set => _ = SetAsync(value, nameof(this.backgroundSize)); }
        public Task<string> backfaceVisibilityAsync { get => GetAsync<string>(nameof(this.backfaceVisibility)); set => _ = SetAsync(value, nameof(this.backfaceVisibility)); }
        public Task<string> borderAsync { get => GetAsync<string>(nameof(this.border)); set => _ = SetAsync(value, nameof(this.border)); }
        public Task<string> borderBottomAsync { get => GetAsync<string>(nameof(this.borderBottom)); set => _ = SetAsync(value, nameof(this.borderBottom)); }
        public Task<string> borderBottomColorAsync { get => GetAsync<string>(nameof(this.borderBottomColor)); set => _ = SetAsync(value, nameof(this.borderBottomColor)); }
        public Task<string> borderBottomLeftRadiusAsync { get => GetAsync<string>(nameof(this.borderBottomLeftRadius)); set => _ = SetAsync(value, nameof(this.borderBottomLeftRadius)); }
        public Task<string> borderBottomRightRadiusAsync { get => GetAsync<string>(nameof(this.borderBottomRightRadius)); set => _ = SetAsync(value, nameof(this.borderBottomRightRadius)); }
        public Task<string> borderBottomStyleAsync { get => GetAsync<string>(nameof(this.borderBottomStyle)); set => _ = SetAsync(value, nameof(this.borderBottomStyle)); }
        public Task<string> borderBottomWidthAsync { get => GetAsync<string>(nameof(this.borderBottomWidth)); set => _ = SetAsync(value, nameof(this.borderBottomWidth)); }
        public Task<string> borderCollapseAsync { get => GetAsync<string>(nameof(this.borderCollapse)); set => _ = SetAsync(value, nameof(this.borderCollapse)); }
        public Task<string> borderColorAsync { get => GetAsync<string>(nameof(this.borderColor)); set => _ = SetAsync(value, nameof(this.borderColor)); }
        public Task<string> borderImageAsync { get => GetAsync<string>(nameof(this.borderImage)); set => _ = SetAsync(value, nameof(this.borderImage)); }
        public Task<string> borderImageOutsetAsync { get => GetAsync<string>(nameof(this.borderImageOutset)); set => _ = SetAsync(value, nameof(this.borderImageOutset)); }
        public Task<string> borderImageRepeatAsync { get => GetAsync<string>(nameof(this.borderImageRepeat)); set => _ = SetAsync(value, nameof(this.borderImageRepeat)); }
        public Task<string> borderImageSliceAsync { get => GetAsync<string>(nameof(this.borderImageSlice)); set => _ = SetAsync(value, nameof(this.borderImageSlice)); }
        public Task<string> borderImageSourceAsync { get => GetAsync<string>(nameof(this.borderImageSource)); set => _ = SetAsync(value, nameof(this.borderImageSource)); }
        public Task<string> borderImageWidthAsync { get => GetAsync<string>(nameof(this.borderImageWidth)); set => _ = SetAsync(value, nameof(this.borderImageWidth)); }
        public Task<string> borderLeftAsync { get => GetAsync<string>(nameof(this.borderLeft)); set => _ = SetAsync(value, nameof(this.borderLeft)); }
        public Task<string> borderLeftColorAsync { get => GetAsync<string>(nameof(this.borderLeftColor)); set => _ = SetAsync(value, nameof(this.borderLeftColor)); }
        public Task<string> borderLeftStyleAsync { get => GetAsync<string>(nameof(this.borderLeftStyle)); set => _ = SetAsync(value, nameof(this.borderLeftStyle)); }
        public Task<string> borderLeftWidthAsync { get => GetAsync<string>(nameof(this.borderLeftWidth)); set => _ = SetAsync(value, nameof(this.borderLeftWidth)); }
        public Task<string> borderRadiusAsync { get => GetAsync<string>(nameof(this.borderRadius)); set => _ = SetAsync(value, nameof(this.borderRadius)); }
        public Task<string> borderRightAsync { get => GetAsync<string>(nameof(this.borderRight)); set => _ = SetAsync(value, nameof(this.borderRight)); }
        public Task<string> borderRightColorAsync { get => GetAsync<string>(nameof(this.borderRightColor)); set => _ = SetAsync(value, nameof(this.borderRightColor)); }
        public Task<string> borderRightStyleAsync { get => GetAsync<string>(nameof(this.borderRightStyle)); set => _ = SetAsync(value, nameof(this.borderRightStyle)); }
        public Task<string> borderRightWidthAsync { get => GetAsync<string>(nameof(this.borderRightWidth)); set => _ = SetAsync(value, nameof(this.borderRightWidth)); }
        public Task<string> borderSpacingAsync { get => GetAsync<string>(nameof(this.borderSpacing)); set => _ = SetAsync(value, nameof(this.borderSpacing)); }
        public Task<string> borderStyleAsync { get => GetAsync<string>(nameof(this.borderStyle)); set => _ = SetAsync(value, nameof(this.borderStyle)); }
        public Task<string> borderTopAsync { get => GetAsync<string>(nameof(this.borderTop)); set => _ = SetAsync(value, nameof(this.borderTop)); }
        public Task<string> borderTopColorAsync { get => GetAsync<string>(nameof(this.borderTopColor)); set => _ = SetAsync(value, nameof(this.borderTopColor)); }
        public Task<string> borderTopLeftRadiusAsync { get => GetAsync<string>(nameof(this.borderTopLeftRadius)); set => _ = SetAsync(value, nameof(this.borderTopLeftRadius)); }
        public Task<string> borderTopRightRadiusAsync { get => GetAsync<string>(nameof(this.borderTopRightRadius)); set => _ = SetAsync(value, nameof(this.borderTopRightRadius)); }
        public Task<string> borderTopStyleAsync { get => GetAsync<string>(nameof(this.borderTopStyle)); set => _ = SetAsync(value, nameof(this.borderTopStyle)); }
        public Task<string> borderTopWidthAsync { get => GetAsync<string>(nameof(this.borderTopWidth)); set => _ = SetAsync(value, nameof(this.borderTopWidth)); }
        public Task<string> borderWidthAsync { get => GetAsync<string>(nameof(this.borderWidth)); set => _ = SetAsync(value, nameof(this.borderWidth)); }
        public Task<string> bottomAsync { get => GetAsync<string>(nameof(this.bottom)); set => _ = SetAsync(value, nameof(this.bottom)); }
        public Task<string> boxDecorationBreakAsync { get => GetAsync<string>(nameof(this.boxDecorationBreak)); set => _ = SetAsync(value, nameof(this.boxDecorationBreak)); }
        public Task<string> boxShadowAsync { get => GetAsync<string>(nameof(this.boxShadow)); set => _ = SetAsync(value, nameof(this.boxShadow)); }
        public Task<string> boxSizingAsync { get => GetAsync<string>(nameof(this.boxSizing)); set => _ = SetAsync(value, nameof(this.boxSizing)); }
        public Task<string> captionSideAsync { get => GetAsync<string>(nameof(this.captionSide)); set => _ = SetAsync(value, nameof(this.captionSide)); }
        public Task<string> caretColorAsync { get => GetAsync<string>(nameof(this.caretColor)); set => _ = SetAsync(value, nameof(this.caretColor)); }
        public Task<string> clearAsync { get => GetAsync<string>(nameof(this.clear)); set => _ = SetAsync(value, nameof(this.clear)); }
        public Task<string> clipAsync { get => GetAsync<string>(nameof(this.clip)); set => _ = SetAsync(value, nameof(this.clip)); }
        public Task<string> colorAsync { get => GetAsync<string>(nameof(this.color)); set => _ = SetAsync(value, nameof(this.color)); }
        public Task<string> columnCountAsync { get => GetAsync<string>(nameof(this.columnCount)); set => _ = SetAsync(value, nameof(this.columnCount)); }
        public Task<string> columnFillAsync { get => GetAsync<string>(nameof(this.columnFill)); set => _ = SetAsync(value, nameof(this.columnFill)); }
        public Task<string> columnGapAsync { get => GetAsync<string>(nameof(this.columnGap)); set => _ = SetAsync(value, nameof(this.columnGap)); }
        public Task<string> columnRuleAsync { get => GetAsync<string>(nameof(this.columnRule)); set => _ = SetAsync(value, nameof(this.columnRule)); }
        public Task<string> columnRuleColorAsync { get => GetAsync<string>(nameof(this.columnRuleColor)); set => _ = SetAsync(value, nameof(this.columnRuleColor)); }
        public Task<string> columnRuleStyleAsync { get => GetAsync<string>(nameof(this.columnRuleStyle)); set => _ = SetAsync(value, nameof(this.columnRuleStyle)); }
        public Task<string> columnRuleWidthAsync { get => GetAsync<string>(nameof(this.columnRuleWidth)); set => _ = SetAsync(value, nameof(this.columnRuleWidth)); }
        public Task<string> columnsAsync { get => GetAsync<string>(nameof(this.columns)); set => _ = SetAsync(value, nameof(this.columns)); }
        public Task<string> columnSpanAsync { get => GetAsync<string>(nameof(this.columnSpan)); set => _ = SetAsync(value, nameof(this.columnSpan)); }
        public Task<string> columnWidthAsync { get => GetAsync<string>(nameof(this.columnWidth)); set => _ = SetAsync(value, nameof(this.columnWidth)); }
        public Task<string> contentAsync { get => GetAsync<string>(nameof(this.content)); set => _ = SetAsync(value, nameof(this.content)); }
        public Task<string> counterIncrementAsync { get => GetAsync<string>(nameof(this.counterIncrement)); set => _ = SetAsync(value, nameof(this.counterIncrement)); }
        public Task<string> counterResetAsync { get => GetAsync<string>(nameof(this.counterReset)); set => _ = SetAsync(value, nameof(this.counterReset)); }

        public Task<string> cssTextAsync
        {
            get => GetAsync<string>(nameof(this.cssText));
            set => _ = SetAsync(value, nameof(this.cssText));
        }

        public Task<string> cursorAsync { get => GetAsync<string>(nameof(this.cursor)); set => _ = SetAsync(value, nameof(this.cursor)); }
        public Task<string> directionAsync { get => GetAsync<string>(nameof(this.direction)); set => _ = SetAsync(value, nameof(this.direction)); }
        public Task<string> displayAsync { get => GetAsync<string>(nameof(this.display)); set => _ = SetAsync(value, nameof(this.display)); }
        public Task<string> emptyCellsAsync { get => GetAsync<string>(nameof(this.emptyCells)); set => _ = SetAsync(value, nameof(this.emptyCells)); }
        public Task<string> filterAsync { get => GetAsync<string>(nameof(this.filter)); set => _ = SetAsync(value, nameof(this.filter)); }
        public Task<string> flexAsync { get => GetAsync<string>(nameof(this.flex)); set => _ = SetAsync(value, nameof(this.flex)); }
        public Task<string> flexBasisAsync { get => GetAsync<string>(nameof(this.flexBasis)); set => _ = SetAsync(value, nameof(this.flexBasis)); }
        public Task<string> flexDirectionAsync { get => GetAsync<string>(nameof(this.flexDirection)); set => _ = SetAsync(value, nameof(this.flexDirection)); }
        public Task<string> flexFlowAsync { get => GetAsync<string>(nameof(this.flexFlow)); set => _ = SetAsync(value, nameof(this.flexFlow)); }
        public Task<string> flexGrowAsync { get => GetAsync<string>(nameof(this.flexGrow)); set => _ = SetAsync(value, nameof(this.flexGrow)); }
        public Task<string> flexShrinkAsync { get => GetAsync<string>(nameof(this.flexShrink)); set => _ = SetAsync(value, nameof(this.flexShrink)); }
        public Task<string> flexWrapAsync { get => GetAsync<string>(nameof(this.flexWrap)); set => _ = SetAsync(value, nameof(this.flexWrap)); }
        public Task<string> cssFloatAsync { get => GetAsync<string>(nameof(this.cssFloat)); set => _ = SetAsync(value, nameof(this.cssFloat)); }
        public Task<string> fontAsync { get => GetAsync<string>(nameof(this.font)); set => _ = SetAsync(value, nameof(this.font)); }
        public Task<string> fontFamilyAsync { get => GetAsync<string>(nameof(this.fontFamily)); set => _ = SetAsync(value, nameof(this.fontFamily)); }
        public Task<string> fontSizeAsync { get => GetAsync<string>(nameof(this.fontSize)); set => _ = SetAsync(value, nameof(this.fontSize)); }
        public Task<string> fontStyleAsync { get => GetAsync<string>(nameof(this.fontStyle)); set => _ = SetAsync(value, nameof(this.fontStyle)); }
        public Task<string> fontVariantAsync { get => GetAsync<string>(nameof(this.fontVariant)); set => _ = SetAsync(value, nameof(this.fontVariant)); }
        public Task<string> fontWeightAsync { get => GetAsync<string>(nameof(this.fontWeight)); set => _ = SetAsync(value, nameof(this.fontWeight)); }
        public Task<string> fontSizeAdjustAsync { get => GetAsync<string>(nameof(this.fontSizeAdjust)); set => _ = SetAsync(value, nameof(this.fontSizeAdjust)); }
        public Task<string> fontStretchAsync { get => GetAsync<string>(nameof(this.fontStretch)); set => _ = SetAsync(value, nameof(this.fontStretch)); }
        public Task<string> hangingPunctuationAsync { get => GetAsync<string>(nameof(this.hangingPunctuation)); set => _ = SetAsync(value, nameof(this.hangingPunctuation)); }
        public Task<string> heightAsync { get => GetAsync<string>(nameof(this.height)); set => _ = SetAsync(value, nameof(this.height)); }
        public Task<string> hyphensAsync { get => GetAsync<string>(nameof(this.hyphens)); set => _ = SetAsync(value, nameof(this.hyphens)); }
        public Task<string> iconAsync { get => GetAsync<string>(nameof(this.icon)); set => _ = SetAsync(value, nameof(this.icon)); }
        public Task<string> imageOrientationAsync { get => GetAsync<string>(nameof(this.imageOrientation)); set => _ = SetAsync(value, nameof(this.imageOrientation)); }
        public Task<string> isolationAsync { get => GetAsync<string>(nameof(this.isolation)); set => _ = SetAsync(value, nameof(this.isolation)); }
        public Task<string> justifyContentAsync { get => GetAsync<string>(nameof(this.justifyContent)); set => _ = SetAsync(value, nameof(this.justifyContent)); }
        public Task<string> leftAsync { get => GetAsync<string>(nameof(this.left)); set => _ = SetAsync(value, nameof(this.left)); }
        public Task<string> letterSpacingAsync { get => GetAsync<string>(nameof(this.letterSpacing)); set => _ = SetAsync(value, nameof(this.letterSpacing)); }
        public Task<string> lineHeightAsync { get => GetAsync<string>(nameof(this.lineHeight)); set => _ = SetAsync(value, nameof(this.lineHeight)); }
        public Task<string> listStyleAsync { get => GetAsync<string>(nameof(this.listStyle)); set => _ = SetAsync(value, nameof(this.listStyle)); }
        public Task<string> listStyleImageAsync { get => GetAsync<string>(nameof(this.listStyleImage)); set => _ = SetAsync(value, nameof(this.listStyleImage)); }
        public Task<string> listStylePositionAsync { get => GetAsync<string>(nameof(this.listStylePosition)); set => _ = SetAsync(value, nameof(this.listStylePosition)); }
        public Task<string> listStyleTypeAsync { get => GetAsync<string>(nameof(this.listStyleType)); set => _ = SetAsync(value, nameof(this.listStyleType)); }
        public Task<string> marginAsync { get => GetAsync<string>(nameof(this.margin)); set => _ = SetAsync(value, nameof(this.margin)); }
        public Task<string> marginBottomAsync { get => GetAsync<string>(nameof(this.marginBottom)); set => _ = SetAsync(value, nameof(this.marginBottom)); }
        public Task<string> marginLeftAsync { get => GetAsync<string>(nameof(this.marginLeft)); set => _ = SetAsync(value, nameof(this.marginLeft)); }
        public Task<string> marginRightAsync { get => GetAsync<string>(nameof(this.marginRight)); set => _ = SetAsync(value, nameof(this.marginRight)); }
        public Task<string> marginTopAsync { get => GetAsync<string>(nameof(this.marginTop)); set => _ = SetAsync(value, nameof(this.marginTop)); }
        public Task<string> maxHeightAsync { get => GetAsync<string>(nameof(this.maxHeight)); set => _ = SetAsync(value, nameof(this.maxHeight)); }
        public Task<string> maxWidthAsync { get => GetAsync<string>(nameof(this.maxWidth)); set => _ = SetAsync(value, nameof(this.maxWidth)); }
        public Task<string> minHeightAsync { get => GetAsync<string>(nameof(this.minHeight)); set => _ = SetAsync(value, nameof(this.minHeight)); }
        public Task<string> minWidthAsync { get => GetAsync<string>(nameof(this.minWidth)); set => _ = SetAsync(value, nameof(this.minWidth)); }
        public Task<string> navDownAsync { get => GetAsync<string>(nameof(this.navDown)); set => _ = SetAsync(value, nameof(this.navDown)); }
        public Task<string> navIndexAsync { get => GetAsync<string>(nameof(this.navIndex)); set => _ = SetAsync(value, nameof(this.navIndex)); }
        public Task<string> navLeftAsync { get => GetAsync<string>(nameof(this.navLeft)); set => _ = SetAsync(value, nameof(this.navLeft)); }
        public Task<string> navRightAsync { get => GetAsync<string>(nameof(this.navRight)); set => _ = SetAsync(value, nameof(this.navRight)); }
        public Task<string> navUpAsync { get => GetAsync<string>(nameof(this.navUp)); set => _ = SetAsync(value, nameof(this.navUp)); }
        public Task<string> objectFitAsync { get => GetAsync<string>(nameof(this.objectFit)); set => _ = SetAsync(value, nameof(this.objectFit)); }
        public Task<string> objectPositionAsync { get => GetAsync<string>(nameof(this.objectPosition)); set => _ = SetAsync(value, nameof(this.objectPosition)); }
        public Task<string> opacityAsync { get => GetAsync<string>(nameof(this.opacity)); set => _ = SetAsync(value, nameof(this.opacity)); }
        public Task<string> orderAsync { get => GetAsync<string>(nameof(this.order)); set => _ = SetAsync(value, nameof(this.order)); }
        public Task<string> orphansAsync { get => GetAsync<string>(nameof(this.orphans)); set => _ = SetAsync(value, nameof(this.orphans)); }
        public Task<string> outlineAsync { get => GetAsync<string>(nameof(this.outline)); set => _ = SetAsync(value, nameof(this.outline)); }
        public Task<string> outlineColorAsync { get => GetAsync<string>(nameof(this.outlineColor)); set => _ = SetAsync(value, nameof(this.outlineColor)); }
        public Task<string> outlineOffsetAsync { get => GetAsync<string>(nameof(this.outlineOffset)); set => _ = SetAsync(value, nameof(this.outlineOffset)); }
        public Task<string> outlineStyleAsync { get => GetAsync<string>(nameof(this.outlineStyle)); set => _ = SetAsync(value, nameof(this.outlineStyle)); }
        public Task<string> outlineWidthAsync { get => GetAsync<string>(nameof(this.outlineWidth)); set => _ = SetAsync(value, nameof(this.outlineWidth)); }
        public Task<string> overflowAsync { get => GetAsync<string>(nameof(this.overflow)); set => _ = SetAsync(value, nameof(this.overflow)); }
        public Task<string> overflowXAsync { get => GetAsync<string>(nameof(this.overflowX)); set => _ = SetAsync(value, nameof(this.overflowX)); }
        public Task<string> overflowYAsync { get => GetAsync<string>(nameof(this.overflowY)); set => _ = SetAsync(value, nameof(this.overflowY)); }
        public Task<string> paddingAsync { get => GetAsync<string>(nameof(this.padding)); set => _ = SetAsync(value, nameof(this.padding)); }
        public Task<string> paddingBottomAsync { get => GetAsync<string>(nameof(this.paddingBottom)); set => _ = SetAsync(value, nameof(this.paddingBottom)); }
        public Task<string> paddingLeftAsync { get => GetAsync<string>(nameof(this.paddingLeft)); set => _ = SetAsync(value, nameof(this.paddingLeft)); }
        public Task<string> paddingRightAsync { get => GetAsync<string>(nameof(this.paddingRight)); set => _ = SetAsync(value, nameof(this.paddingRight)); }
        public Task<string> paddingTopAsync { get => GetAsync<string>(nameof(this.paddingTop)); set => _ = SetAsync(value, nameof(this.paddingTop)); }
        public Task<string> pageBreakAfterAsync { get => GetAsync<string>(nameof(this.pageBreakAfter)); set => _ = SetAsync(value, nameof(this.pageBreakAfter)); }
        public Task<string> pageBreakBeforeAsync { get => GetAsync<string>(nameof(this.pageBreakBefore)); set => _ = SetAsync(value, nameof(this.pageBreakBefore)); }
        public Task<string> pageBreakInsideAsync { get => GetAsync<string>(nameof(this.pageBreakInside)); set => _ = SetAsync(value, nameof(this.pageBreakInside)); }
        public Task<string> perspectiveAsync { get => GetAsync<string>(nameof(this.perspective)); set => _ = SetAsync(value, nameof(this.perspective)); }
        public Task<string> perspectiveOriginAsync { get => GetAsync<string>(nameof(this.perspectiveOrigin)); set => _ = SetAsync(value, nameof(this.perspectiveOrigin)); }
        public Task<string> positionAsync { get => GetAsync<string>(nameof(this.position)); set => _ = SetAsync(value, nameof(this.position)); }
        public Task<string> quotesAsync { get => GetAsync<string>(nameof(this.quotes)); set => _ = SetAsync(value, nameof(this.quotes)); }
        public Task<string> resizeAsync { get => GetAsync<string>(nameof(this.resize)); set => _ = SetAsync(value, nameof(this.resize)); }
        public Task<string> rightAsync { get => GetAsync<string>(nameof(this.right)); set => _ = SetAsync(value, nameof(this.right)); }
        public Task<string> scrollBehaviorAsync { get => GetAsync<string>(nameof(this.scrollBehavior)); set => _ = SetAsync(value, nameof(this.scrollBehavior)); }
        public Task<string> tableLayoutAsync { get => GetAsync<string>(nameof(this.tableLayout)); set => _ = SetAsync(value, nameof(this.tableLayout)); }
        public Task<string> tabSizeAsync { get => GetAsync<string>(nameof(this.tabSize)); set => _ = SetAsync(value, nameof(this.tabSize)); }
        public Task<string> textAlignAsync { get => GetAsync<string>(nameof(this.textAlign)); set => _ = SetAsync(value, nameof(this.textAlign)); }
        public Task<string> textAlignLastAsync { get => GetAsync<string>(nameof(this.textAlignLast)); set => _ = SetAsync(value, nameof(this.textAlignLast)); }
        public Task<string> textDecorationAsync { get => GetAsync<string>(nameof(this.textDecoration)); set => _ = SetAsync(value, nameof(this.textDecoration)); }
        public Task<string> textDecorationColorAsync { get => GetAsync<string>(nameof(this.textDecorationColor)); set => _ = SetAsync(value, nameof(this.textDecorationColor)); }
        public Task<string> textDecorationLineAsync { get => GetAsync<string>(nameof(this.textDecorationLine)); set => _ = SetAsync(value, nameof(this.textDecorationLine)); }
        public Task<string> textDecorationStyleAsync { get => GetAsync<string>(nameof(this.textDecorationStyle)); set => _ = SetAsync(value, nameof(this.textDecorationStyle)); }
        public Task<string> textIndentAsync { get => GetAsync<string>(nameof(this.textIndent)); set => _ = SetAsync(value, nameof(this.textIndent)); }
        public Task<string> textJustifyAsync { get => GetAsync<string>(nameof(this.textJustify)); set => _ = SetAsync(value, nameof(this.textJustify)); }
        public Task<string> textOverflowAsync { get => GetAsync<string>(nameof(this.textOverflow)); set => _ = SetAsync(value, nameof(this.textOverflow)); }
        public Task<string> textShadowAsync { get => GetAsync<string>(nameof(this.textShadow)); set => _ = SetAsync(value, nameof(this.textShadow)); }
        public Task<string> textTransformAsync { get => GetAsync<string>(nameof(this.textTransform)); set => _ = SetAsync(value, nameof(this.textTransform)); }
        public Task<string> topAsync { get => GetAsync<string>(nameof(this.top)); set => _ = SetAsync(value, nameof(this.top)); }
        public Task<string> transformAsync { get => GetAsync<string>(nameof(this.transform)); set => _ = SetAsync(value, nameof(this.transform)); }
        public Task<string> transformOriginAsync { get => GetAsync<string>(nameof(this.transformOrigin)); set => _ = SetAsync(value, nameof(this.transformOrigin)); }
        public Task<string> transformStyleAsync { get => GetAsync<string>(nameof(this.transformStyle)); set => _ = SetAsync(value, nameof(this.transformStyle)); }
        public Task<string> transitionAsync { get => GetAsync<string>(nameof(this.transition)); set => _ = SetAsync(value, nameof(this.transition)); }
        public Task<string> transitionPropertyAsync { get => GetAsync<string>(nameof(this.transitionProperty)); set => _ = SetAsync(value, nameof(this.transitionProperty)); }
        public Task<string> transitionDurationAsync { get => GetAsync<string>(nameof(this.transitionDuration)); set => _ = SetAsync(value, nameof(this.transitionDuration)); }
        public Task<string> transitionTimingFunctionAsync { get => GetAsync<string>(nameof(this.transitionTimingFunction)); set => _ = SetAsync(value, nameof(this.transitionTimingFunction)); }
        public Task<string> transitionDelayAsync { get => GetAsync<string>(nameof(this.transitionDelay)); set => _ = SetAsync(value, nameof(this.transitionDelay)); }
        public Task<string> unicodeBidiAsync { get => GetAsync<string>(nameof(this.unicodeBidi)); set => _ = SetAsync(value, nameof(this.unicodeBidi)); }
        public Task<string> userSelectAsync { get => GetAsync<string>(nameof(this.userSelect)); set => _ = SetAsync(value, nameof(this.userSelect)); }
        public Task<string> verticalAlignAsync { get => GetAsync<string>(nameof(this.verticalAlign)); set => _ = SetAsync(value, nameof(this.verticalAlign)); }
        public Task<string> visibilityAsync { get => GetAsync<string>(nameof(this.visibility)); set => _ = SetAsync(value, nameof(this.visibility)); }
        public Task<string> whiteSpaceAsync { get => GetAsync<string>(nameof(this.whiteSpace)); set => _ = SetAsync(value, nameof(this.whiteSpace)); }
        public Task<string> widthAsync { get => GetAsync<string>(nameof(this.width)); set => _ = SetAsync(value, nameof(this.width)); }
        public Task<string> wordBreakAsync { get => GetAsync<string>(nameof(this.wordBreak)); set => _ = SetAsync(value, nameof(this.wordBreak)); }
        public Task<string> wordSpacingAsync { get => GetAsync<string>(nameof(this.wordSpacing)); set => _ = SetAsync(value, nameof(this.wordSpacing)); }
        public Task<string> wordWrapAsync { get => GetAsync<string>(nameof(this.wordWrap)); set => _ = SetAsync(value, nameof(this.wordWrap)); }
        public Task<string> widowsAsync { get => GetAsync<string>(nameof(this.widows)); set => _ = SetAsync(value, nameof(this.widows)); }
        public Task<string> zIndexAsync { get => GetAsync<string>(nameof(this.zIndex)); set => _ = SetAsync(value, nameof(this.zIndex)); }

    }
}