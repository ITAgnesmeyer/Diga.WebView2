using System.Threading.Tasks;

namespace Diga.WebView2.Wpf.Scripting.DOM
{
    public class DOMStyle : DOMElement
    {
        public DOMStyle(WebView control, DOMVar domVar) : base(control, domVar)
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

        public Task<string> alignContentAsync { get => GetAsync<string>(nameof(alignContent)); set => _ = SetAsync(value, nameof(alignContent)); }
        public Task<string> alignItemsAsync { get => GetAsync<string>(nameof(alignItems)); set => _ = SetAsync(value, nameof(alignItems)); }
        public Task<string> alignSelfAsync { get => GetAsync<string>(nameof(alignSelf)); set => _ = SetAsync(value, nameof(alignSelf)); }
        public Task<string> animationAsync { get => GetAsync<string>(nameof(animation)); set => _ = SetAsync(value, nameof(animation)); }
        public Task<string> animationDelayAsync { get => GetAsync<string>(nameof(animationDelay)); set => _ = SetAsync(value, nameof(animationDelay)); }
        public Task<string> animationDirectionAsync { get => GetAsync<string>(nameof(animationDirection)); set => _ = SetAsync(value, nameof(animationDirection)); }
        public Task<string> animationDurationAsync { get => GetAsync<string>(nameof(animationDuration)); set => _ = SetAsync(value, nameof(animationDuration)); }
        public Task<string> animationFillModeAsync { get => GetAsync<string>(nameof(animationFillMode)); set => _ = SetAsync(value, nameof(animationFillMode)); }
        public Task<string> animationIterationCountAsync { get => GetAsync<string>(nameof(animationIterationCount)); set => _ = SetAsync(value, nameof(animationIterationCount)); }
        public Task<string> animationNameAsync { get => GetAsync<string>(nameof(animationName)); set => _ = SetAsync(value, nameof(animationName)); }
        public Task<string> animationTimingFunctionAsync { get => GetAsync<string>(nameof(animationTimingFunction)); set => _ = SetAsync(value, nameof(animationTimingFunction)); }
        public Task<string> animationPlayStateAsync { get => GetAsync<string>(nameof(animationPlayState)); set => _ = SetAsync(value, nameof(animationPlayState)); }
        public Task<string> backgroundAsync { get => GetAsync<string>(nameof(background)); set => _ = SetAsync(value, nameof(background)); }
        public Task<string> backgroundAttachmentAsync { get => GetAsync<string>(nameof(backgroundAttachment)); set => _ = SetAsync(value, nameof(backgroundAttachment)); }
        public Task<string> backgroundColorAsync { get => GetAsync<string>(nameof(backgroundColor)); set => _ = SetAsync(value, nameof(backgroundColor)); }
        public Task<string> backgroundImageAsync { get => GetAsync<string>(nameof(backgroundImage)); set => _ = SetAsync(value, nameof(backgroundImage)); }
        public Task<string> backgroundPositionAsync { get => GetAsync<string>(nameof(backgroundPosition)); set => _ = SetAsync(value, nameof(backgroundPosition)); }
        public Task<string> backgroundRepeatAsync { get => GetAsync<string>(nameof(backgroundRepeat)); set => _ = SetAsync(value, nameof(backgroundRepeat)); }
        public Task<string> backgroundClipAsync { get => GetAsync<string>(nameof(backgroundClip)); set => _ = SetAsync(value, nameof(backgroundClip)); }
        public Task<string> backgroundOriginAsync { get => GetAsync<string>(nameof(backgroundOrigin)); set => _ = SetAsync(value, nameof(backgroundOrigin)); }
        public Task<string> backgroundSizeAsync { get => GetAsync<string>(nameof(backgroundSize)); set => _ = SetAsync(value, nameof(backgroundSize)); }
        public Task<string> backfaceVisibilityAsync { get => GetAsync<string>(nameof(backfaceVisibility)); set => _ = SetAsync(value, nameof(backfaceVisibility)); }
        public Task<string> borderAsync { get => GetAsync<string>(nameof(border)); set => _ = SetAsync(value, nameof(border)); }
        public Task<string> borderBottomAsync { get => GetAsync<string>(nameof(borderBottom)); set => _ = SetAsync(value, nameof(borderBottom)); }
        public Task<string> borderBottomColorAsync { get => GetAsync<string>(nameof(borderBottomColor)); set => _ = SetAsync(value, nameof(borderBottomColor)); }
        public Task<string> borderBottomLeftRadiusAsync { get => GetAsync<string>(nameof(borderBottomLeftRadius)); set => _ = SetAsync(value, nameof(borderBottomLeftRadius)); }
        public Task<string> borderBottomRightRadiusAsync { get => GetAsync<string>(nameof(borderBottomRightRadius)); set => _ = SetAsync(value, nameof(borderBottomRightRadius)); }
        public Task<string> borderBottomStyleAsync { get => GetAsync<string>(nameof(borderBottomStyle)); set => _ = SetAsync(value, nameof(borderBottomStyle)); }
        public Task<string> borderBottomWidthAsync { get => GetAsync<string>(nameof(borderBottomWidth)); set => _ = SetAsync(value, nameof(borderBottomWidth)); }
        public Task<string> borderCollapseAsync { get => GetAsync<string>(nameof(borderCollapse)); set => _ = SetAsync(value, nameof(borderCollapse)); }
        public Task<string> borderColorAsync { get => GetAsync<string>(nameof(borderColor)); set => _ = SetAsync(value, nameof(borderColor)); }
        public Task<string> borderImageAsync { get => GetAsync<string>(nameof(borderImage)); set => _ = SetAsync(value, nameof(borderImage)); }
        public Task<string> borderImageOutsetAsync { get => GetAsync<string>(nameof(borderImageOutset)); set => _ = SetAsync(value, nameof(borderImageOutset)); }
        public Task<string> borderImageRepeatAsync { get => GetAsync<string>(nameof(borderImageRepeat)); set => _ = SetAsync(value, nameof(borderImageRepeat)); }
        public Task<string> borderImageSliceAsync { get => GetAsync<string>(nameof(borderImageSlice)); set => _ = SetAsync(value, nameof(borderImageSlice)); }
        public Task<string> borderImageSourceAsync { get => GetAsync<string>(nameof(borderImageSource)); set => _ = SetAsync(value, nameof(borderImageSource)); }
        public Task<string> borderImageWidthAsync { get => GetAsync<string>(nameof(borderImageWidth)); set => _ = SetAsync(value, nameof(borderImageWidth)); }
        public Task<string> borderLeftAsync { get => GetAsync<string>(nameof(borderLeft)); set => _ = SetAsync(value, nameof(borderLeft)); }
        public Task<string> borderLeftColorAsync { get => GetAsync<string>(nameof(borderLeftColor)); set => _ = SetAsync(value, nameof(borderLeftColor)); }
        public Task<string> borderLeftStyleAsync { get => GetAsync<string>(nameof(borderLeftStyle)); set => _ = SetAsync(value, nameof(borderLeftStyle)); }
        public Task<string> borderLeftWidthAsync { get => GetAsync<string>(nameof(borderLeftWidth)); set => _ = SetAsync(value, nameof(borderLeftWidth)); }
        public Task<string> borderRadiusAsync { get => GetAsync<string>(nameof(borderRadius)); set => _ = SetAsync(value, nameof(borderRadius)); }
        public Task<string> borderRightAsync { get => GetAsync<string>(nameof(borderRight)); set => _ = SetAsync(value, nameof(borderRight)); }
        public Task<string> borderRightColorAsync { get => GetAsync<string>(nameof(borderRightColor)); set => _ = SetAsync(value, nameof(borderRightColor)); }
        public Task<string> borderRightStyleAsync { get => GetAsync<string>(nameof(borderRightStyle)); set => _ = SetAsync(value, nameof(borderRightStyle)); }
        public Task<string> borderRightWidthAsync { get => GetAsync<string>(nameof(borderRightWidth)); set => _ = SetAsync(value, nameof(borderRightWidth)); }
        public Task<string> borderSpacingAsync { get => GetAsync<string>(nameof(borderSpacing)); set => _ = SetAsync(value, nameof(borderSpacing)); }
        public Task<string> borderStyleAsync { get => GetAsync<string>(nameof(borderStyle)); set => _ = SetAsync(value, nameof(borderStyle)); }
        public Task<string> borderTopAsync { get => GetAsync<string>(nameof(borderTop)); set => _ = SetAsync(value, nameof(borderTop)); }
        public Task<string> borderTopColorAsync { get => GetAsync<string>(nameof(borderTopColor)); set => _ = SetAsync(value, nameof(borderTopColor)); }
        public Task<string> borderTopLeftRadiusAsync { get => GetAsync<string>(nameof(borderTopLeftRadius)); set => _ = SetAsync(value, nameof(borderTopLeftRadius)); }
        public Task<string> borderTopRightRadiusAsync { get => GetAsync<string>(nameof(borderTopRightRadius)); set => _ = SetAsync(value, nameof(borderTopRightRadius)); }
        public Task<string> borderTopStyleAsync { get => GetAsync<string>(nameof(borderTopStyle)); set => _ = SetAsync(value, nameof(borderTopStyle)); }
        public Task<string> borderTopWidthAsync { get => GetAsync<string>(nameof(borderTopWidth)); set => _ = SetAsync(value, nameof(borderTopWidth)); }
        public Task<string> borderWidthAsync { get => GetAsync<string>(nameof(borderWidth)); set => _ = SetAsync(value, nameof(borderWidth)); }
        public Task<string> bottomAsync { get => GetAsync<string>(nameof(bottom)); set => _ = SetAsync(value, nameof(bottom)); }
        public Task<string> boxDecorationBreakAsync { get => GetAsync<string>(nameof(boxDecorationBreak)); set => _ = SetAsync(value, nameof(boxDecorationBreak)); }
        public Task<string> boxShadowAsync { get => GetAsync<string>(nameof(boxShadow)); set => _ = SetAsync(value, nameof(boxShadow)); }
        public Task<string> boxSizingAsync { get => GetAsync<string>(nameof(boxSizing)); set => _ = SetAsync(value, nameof(boxSizing)); }
        public Task<string> captionSideAsync { get => GetAsync<string>(nameof(captionSide)); set => _ = SetAsync(value, nameof(captionSide)); }
        public Task<string> caretColorAsync { get => GetAsync<string>(nameof(caretColor)); set => _ = SetAsync(value, nameof(caretColor)); }
        public Task<string> clearAsync { get => GetAsync<string>(nameof(clear)); set => _ = SetAsync(value, nameof(clear)); }
        public Task<string> clipAsync { get => GetAsync<string>(nameof(clip)); set => _ = SetAsync(value, nameof(clip)); }
        public Task<string> colorAsync { get => GetAsync<string>(nameof(color)); set => _ = SetAsync(value, nameof(color)); }
        public Task<string> columnCountAsync { get => GetAsync<string>(nameof(columnCount)); set => _ = SetAsync(value, nameof(columnCount)); }
        public Task<string> columnFillAsync { get => GetAsync<string>(nameof(columnFill)); set => _ = SetAsync(value, nameof(columnFill)); }
        public Task<string> columnGapAsync { get => GetAsync<string>(nameof(columnGap)); set => _ = SetAsync(value, nameof(columnGap)); }
        public Task<string> columnRuleAsync { get => GetAsync<string>(nameof(columnRule)); set => _ = SetAsync(value, nameof(columnRule)); }
        public Task<string> columnRuleColorAsync { get => GetAsync<string>(nameof(columnRuleColor)); set => _ = SetAsync(value, nameof(columnRuleColor)); }
        public Task<string> columnRuleStyleAsync { get => GetAsync<string>(nameof(columnRuleStyle)); set => _ = SetAsync(value, nameof(columnRuleStyle)); }
        public Task<string> columnRuleWidthAsync { get => GetAsync<string>(nameof(columnRuleWidth)); set => _ = SetAsync(value, nameof(columnRuleWidth)); }
        public Task<string> columnsAsync { get => GetAsync<string>(nameof(columns)); set => _ = SetAsync(value, nameof(columns)); }
        public Task<string> columnSpanAsync { get => GetAsync<string>(nameof(columnSpan)); set => _ = SetAsync(value, nameof(columnSpan)); }
        public Task<string> columnWidthAsync { get => GetAsync<string>(nameof(columnWidth)); set => _ = SetAsync(value, nameof(columnWidth)); }
        public Task<string> contentAsync { get => GetAsync<string>(nameof(content)); set => _ = SetAsync(value, nameof(content)); }
        public Task<string> counterIncrementAsync { get => GetAsync<string>(nameof(counterIncrement)); set => _ = SetAsync(value, nameof(counterIncrement)); }
        public Task<string> counterResetAsync { get => GetAsync<string>(nameof(counterReset)); set => _ = SetAsync(value, nameof(counterReset)); }

        public Task<string> cssTextAsync
        {
            get => GetAsync<string>(nameof(cssText));
            set => _ = SetAsync(value, nameof(cssText));
        }

        public Task<string> cursorAsync { get => GetAsync<string>(nameof(cursor)); set => _ = SetAsync(value, nameof(cursor)); }
        public Task<string> directionAsync { get => GetAsync<string>(nameof(direction)); set => _ = SetAsync(value, nameof(direction)); }
        public Task<string> displayAsync { get => GetAsync<string>(nameof(display)); set => _ = SetAsync(value, nameof(display)); }
        public Task<string> emptyCellsAsync { get => GetAsync<string>(nameof(emptyCells)); set => _ = SetAsync(value, nameof(emptyCells)); }
        public Task<string> filterAsync { get => GetAsync<string>(nameof(filter)); set => _ = SetAsync(value, nameof(filter)); }
        public Task<string> flexAsync { get => GetAsync<string>(nameof(flex)); set => _ = SetAsync(value, nameof(flex)); }
        public Task<string> flexBasisAsync { get => GetAsync<string>(nameof(flexBasis)); set => _ = SetAsync(value, nameof(flexBasis)); }
        public Task<string> flexDirectionAsync { get => GetAsync<string>(nameof(flexDirection)); set => _ = SetAsync(value, nameof(flexDirection)); }
        public Task<string> flexFlowAsync { get => GetAsync<string>(nameof(flexFlow)); set => _ = SetAsync(value, nameof(flexFlow)); }
        public Task<string> flexGrowAsync { get => GetAsync<string>(nameof(flexGrow)); set => _ = SetAsync(value, nameof(flexGrow)); }
        public Task<string> flexShrinkAsync { get => GetAsync<string>(nameof(flexShrink)); set => _ = SetAsync(value, nameof(flexShrink)); }
        public Task<string> flexWrapAsync { get => GetAsync<string>(nameof(flexWrap)); set => _ = SetAsync(value, nameof(flexWrap)); }
        public Task<string> cssFloatAsync { get => GetAsync<string>(nameof(cssFloat)); set => _ = SetAsync(value, nameof(cssFloat)); }
        public Task<string> fontAsync { get => GetAsync<string>(nameof(font)); set => _ = SetAsync(value, nameof(font)); }
        public Task<string> fontFamilyAsync { get => GetAsync<string>(nameof(fontFamily)); set => _ = SetAsync(value, nameof(fontFamily)); }
        public Task<string> fontSizeAsync { get => GetAsync<string>(nameof(fontSize)); set => _ = SetAsync(value, nameof(fontSize)); }
        public Task<string> fontStyleAsync { get => GetAsync<string>(nameof(fontStyle)); set => _ = SetAsync(value, nameof(fontStyle)); }
        public Task<string> fontVariantAsync { get => GetAsync<string>(nameof(fontVariant)); set => _ = SetAsync(value, nameof(fontVariant)); }
        public Task<string> fontWeightAsync { get => GetAsync<string>(nameof(fontWeight)); set => _ = SetAsync(value, nameof(fontWeight)); }
        public Task<string> fontSizeAdjustAsync { get => GetAsync<string>(nameof(fontSizeAdjust)); set => _ = SetAsync(value, nameof(fontSizeAdjust)); }
        public Task<string> fontStretchAsync { get => GetAsync<string>(nameof(fontStretch)); set => _ = SetAsync(value, nameof(fontStretch)); }
        public Task<string> hangingPunctuationAsync { get => GetAsync<string>(nameof(hangingPunctuation)); set => _ = SetAsync(value, nameof(hangingPunctuation)); }
        public Task<string> heightAsync { get => GetAsync<string>(nameof(height)); set => _ = SetAsync(value, nameof(height)); }
        public Task<string> hyphensAsync { get => GetAsync<string>(nameof(hyphens)); set => _ = SetAsync(value, nameof(hyphens)); }
        public Task<string> iconAsync { get => GetAsync<string>(nameof(icon)); set => _ = SetAsync(value, nameof(icon)); }
        public Task<string> imageOrientationAsync { get => GetAsync<string>(nameof(imageOrientation)); set => _ = SetAsync(value, nameof(imageOrientation)); }
        public Task<string> isolationAsync { get => GetAsync<string>(nameof(isolation)); set => _ = SetAsync(value, nameof(isolation)); }
        public Task<string> justifyContentAsync { get => GetAsync<string>(nameof(justifyContent)); set => _ = SetAsync(value, nameof(justifyContent)); }
        public Task<string> leftAsync { get => GetAsync<string>(nameof(left)); set => _ = SetAsync(value, nameof(left)); }
        public Task<string> letterSpacingAsync { get => GetAsync<string>(nameof(letterSpacing)); set => _ = SetAsync(value, nameof(letterSpacing)); }
        public Task<string> lineHeightAsync { get => GetAsync<string>(nameof(lineHeight)); set => _ = SetAsync(value, nameof(lineHeight)); }
        public Task<string> listStyleAsync { get => GetAsync<string>(nameof(listStyle)); set => _ = SetAsync(value, nameof(listStyle)); }
        public Task<string> listStyleImageAsync { get => GetAsync<string>(nameof(listStyleImage)); set => _ = SetAsync(value, nameof(listStyleImage)); }
        public Task<string> listStylePositionAsync { get => GetAsync<string>(nameof(listStylePosition)); set => _ = SetAsync(value, nameof(listStylePosition)); }
        public Task<string> listStyleTypeAsync { get => GetAsync<string>(nameof(listStyleType)); set => _ = SetAsync(value, nameof(listStyleType)); }
        public Task<string> marginAsync { get => GetAsync<string>(nameof(margin)); set => _ = SetAsync(value, nameof(margin)); }
        public Task<string> marginBottomAsync { get => GetAsync<string>(nameof(marginBottom)); set => _ = SetAsync(value, nameof(marginBottom)); }
        public Task<string> marginLeftAsync { get => GetAsync<string>(nameof(marginLeft)); set => _ = SetAsync(value, nameof(marginLeft)); }
        public Task<string> marginRightAsync { get => GetAsync<string>(nameof(marginRight)); set => _ = SetAsync(value, nameof(marginRight)); }
        public Task<string> marginTopAsync { get => GetAsync<string>(nameof(marginTop)); set => _ = SetAsync(value, nameof(marginTop)); }
        public Task<string> maxHeightAsync { get => GetAsync<string>(nameof(maxHeight)); set => _ = SetAsync(value, nameof(maxHeight)); }
        public Task<string> maxWidthAsync { get => GetAsync<string>(nameof(maxWidth)); set => _ = SetAsync(value, nameof(maxWidth)); }
        public Task<string> minHeightAsync { get => GetAsync<string>(nameof(minHeight)); set => _ = SetAsync(value, nameof(minHeight)); }
        public Task<string> minWidthAsync { get => GetAsync<string>(nameof(minWidth)); set => _ = SetAsync(value, nameof(minWidth)); }
        public Task<string> navDownAsync { get => GetAsync<string>(nameof(navDown)); set => _ = SetAsync(value, nameof(navDown)); }
        public Task<string> navIndexAsync { get => GetAsync<string>(nameof(navIndex)); set => _ = SetAsync(value, nameof(navIndex)); }
        public Task<string> navLeftAsync { get => GetAsync<string>(nameof(navLeft)); set => _ = SetAsync(value, nameof(navLeft)); }
        public Task<string> navRightAsync { get => GetAsync<string>(nameof(navRight)); set => _ = SetAsync(value, nameof(navRight)); }
        public Task<string> navUpAsync { get => GetAsync<string>(nameof(navUp)); set => _ = SetAsync(value, nameof(navUp)); }
        public Task<string> objectFitAsync { get => GetAsync<string>(nameof(objectFit)); set => _ = SetAsync(value, nameof(objectFit)); }
        public Task<string> objectPositionAsync { get => GetAsync<string>(nameof(objectPosition)); set => _ = SetAsync(value, nameof(objectPosition)); }
        public Task<string> opacityAsync { get => GetAsync<string>(nameof(opacity)); set => _ = SetAsync(value, nameof(opacity)); }
        public Task<string> orderAsync { get => GetAsync<string>(nameof(order)); set => _ = SetAsync(value, nameof(order)); }
        public Task<string> orphansAsync { get => GetAsync<string>(nameof(orphans)); set => _ = SetAsync(value, nameof(orphans)); }
        public Task<string> outlineAsync { get => GetAsync<string>(nameof(outline)); set => _ = SetAsync(value, nameof(outline)); }
        public Task<string> outlineColorAsync { get => GetAsync<string>(nameof(outlineColor)); set => _ = SetAsync(value, nameof(outlineColor)); }
        public Task<string> outlineOffsetAsync { get => GetAsync<string>(nameof(outlineOffset)); set => _ = SetAsync(value, nameof(outlineOffset)); }
        public Task<string> outlineStyleAsync { get => GetAsync<string>(nameof(outlineStyle)); set => _ = SetAsync(value, nameof(outlineStyle)); }
        public Task<string> outlineWidthAsync { get => GetAsync<string>(nameof(outlineWidth)); set => _ = SetAsync(value, nameof(outlineWidth)); }
        public Task<string> overflowAsync { get => GetAsync<string>(nameof(overflow)); set => _ = SetAsync(value, nameof(overflow)); }
        public Task<string> overflowXAsync { get => GetAsync<string>(nameof(overflowX)); set => _ = SetAsync(value, nameof(overflowX)); }
        public Task<string> overflowYAsync { get => GetAsync<string>(nameof(overflowY)); set => _ = SetAsync(value, nameof(overflowY)); }
        public Task<string> paddingAsync { get => GetAsync<string>(nameof(padding)); set => _ = SetAsync(value, nameof(padding)); }
        public Task<string> paddingBottomAsync { get => GetAsync<string>(nameof(paddingBottom)); set => _ = SetAsync(value, nameof(paddingBottom)); }
        public Task<string> paddingLeftAsync { get => GetAsync<string>(nameof(paddingLeft)); set => _ = SetAsync(value, nameof(paddingLeft)); }
        public Task<string> paddingRightAsync { get => GetAsync<string>(nameof(paddingRight)); set => _ = SetAsync(value, nameof(paddingRight)); }
        public Task<string> paddingTopAsync { get => GetAsync<string>(nameof(paddingTop)); set => _ = SetAsync(value, nameof(paddingTop)); }
        public Task<string> pageBreakAfterAsync { get => GetAsync<string>(nameof(pageBreakAfter)); set => _ = SetAsync(value, nameof(pageBreakAfter)); }
        public Task<string> pageBreakBeforeAsync { get => GetAsync<string>(nameof(pageBreakBefore)); set => _ = SetAsync(value, nameof(pageBreakBefore)); }
        public Task<string> pageBreakInsideAsync { get => GetAsync<string>(nameof(pageBreakInside)); set => _ = SetAsync(value, nameof(pageBreakInside)); }
        public Task<string> perspectiveAsync { get => GetAsync<string>(nameof(perspective)); set => _ = SetAsync(value, nameof(perspective)); }
        public Task<string> perspectiveOriginAsync { get => GetAsync<string>(nameof(perspectiveOrigin)); set => _ = SetAsync(value, nameof(perspectiveOrigin)); }
        public Task<string> positionAsync { get => GetAsync<string>(nameof(position)); set => _ = SetAsync(value, nameof(position)); }
        public Task<string> quotesAsync { get => GetAsync<string>(nameof(quotes)); set => _ = SetAsync(value, nameof(quotes)); }
        public Task<string> resizeAsync { get => GetAsync<string>(nameof(resize)); set => _ = SetAsync(value, nameof(resize)); }
        public Task<string> rightAsync { get => GetAsync<string>(nameof(right)); set => _ = SetAsync(value, nameof(right)); }
        public Task<string> scrollBehaviorAsync { get => GetAsync<string>(nameof(scrollBehavior)); set => _ = SetAsync(value, nameof(scrollBehavior)); }
        public Task<string> tableLayoutAsync { get => GetAsync<string>(nameof(tableLayout)); set => _ = SetAsync(value, nameof(tableLayout)); }
        public Task<string> tabSizeAsync { get => GetAsync<string>(nameof(tabSize)); set => _ = SetAsync(value, nameof(tabSize)); }
        public Task<string> textAlignAsync { get => GetAsync<string>(nameof(textAlign)); set => _ = SetAsync(value, nameof(textAlign)); }
        public Task<string> textAlignLastAsync { get => GetAsync<string>(nameof(textAlignLast)); set => _ = SetAsync(value, nameof(textAlignLast)); }
        public Task<string> textDecorationAsync { get => GetAsync<string>(nameof(textDecoration)); set => _ = SetAsync(value, nameof(textDecoration)); }
        public Task<string> textDecorationColorAsync { get => GetAsync<string>(nameof(textDecorationColor)); set => _ = SetAsync(value, nameof(textDecorationColor)); }
        public Task<string> textDecorationLineAsync { get => GetAsync<string>(nameof(textDecorationLine)); set => _ = SetAsync(value, nameof(textDecorationLine)); }
        public Task<string> textDecorationStyleAsync { get => GetAsync<string>(nameof(textDecorationStyle)); set => _ = SetAsync(value, nameof(textDecorationStyle)); }
        public Task<string> textIndentAsync { get => GetAsync<string>(nameof(textIndent)); set => _ = SetAsync(value, nameof(textIndent)); }
        public Task<string> textJustifyAsync { get => GetAsync<string>(nameof(textJustify)); set => _ = SetAsync(value, nameof(textJustify)); }
        public Task<string> textOverflowAsync { get => GetAsync<string>(nameof(textOverflow)); set => _ = SetAsync(value, nameof(textOverflow)); }
        public Task<string> textShadowAsync { get => GetAsync<string>(nameof(textShadow)); set => _ = SetAsync(value, nameof(textShadow)); }
        public Task<string> textTransformAsync { get => GetAsync<string>(nameof(textTransform)); set => _ = SetAsync(value, nameof(textTransform)); }
        public Task<string> topAsync { get => GetAsync<string>(nameof(top)); set => _ = SetAsync(value, nameof(top)); }
        public Task<string> transformAsync { get => GetAsync<string>(nameof(transform)); set => _ = SetAsync(value, nameof(transform)); }
        public Task<string> transformOriginAsync { get => GetAsync<string>(nameof(transformOrigin)); set => _ = SetAsync(value, nameof(transformOrigin)); }
        public Task<string> transformStyleAsync { get => GetAsync<string>(nameof(transformStyle)); set => _ = SetAsync(value, nameof(transformStyle)); }
        public Task<string> transitionAsync { get => GetAsync<string>(nameof(transition)); set => _ = SetAsync(value, nameof(transition)); }
        public Task<string> transitionPropertyAsync { get => GetAsync<string>(nameof(transitionProperty)); set => _ = SetAsync(value, nameof(transitionProperty)); }
        public Task<string> transitionDurationAsync { get => GetAsync<string>(nameof(transitionDuration)); set => _ = SetAsync(value, nameof(transitionDuration)); }
        public Task<string> transitionTimingFunctionAsync { get => GetAsync<string>(nameof(transitionTimingFunction)); set => _ = SetAsync(value, nameof(transitionTimingFunction)); }
        public Task<string> transitionDelayAsync { get => GetAsync<string>(nameof(transitionDelay)); set => _ = SetAsync(value, nameof(transitionDelay)); }
        public Task<string> unicodeBidiAsync { get => GetAsync<string>(nameof(unicodeBidi)); set => _ = SetAsync(value, nameof(unicodeBidi)); }
        public Task<string> userSelectAsync { get => GetAsync<string>(nameof(userSelect)); set => _ = SetAsync(value, nameof(userSelect)); }
        public Task<string> verticalAlignAsync { get => GetAsync<string>(nameof(verticalAlign)); set => _ = SetAsync(value, nameof(verticalAlign)); }
        public Task<string> visibilityAsync { get => GetAsync<string>(nameof(visibility)); set => _ = SetAsync(value, nameof(visibility)); }
        public Task<string> whiteSpaceAsync { get => GetAsync<string>(nameof(whiteSpace)); set => _ = SetAsync(value, nameof(whiteSpace)); }
        public Task<string> widthAsync { get => GetAsync<string>(nameof(width)); set => _ = SetAsync(value, nameof(width)); }
        public Task<string> wordBreakAsync { get => GetAsync<string>(nameof(wordBreak)); set => _ = SetAsync(value, nameof(wordBreak)); }
        public Task<string> wordSpacingAsync { get => GetAsync<string>(nameof(wordSpacing)); set => _ = SetAsync(value, nameof(wordSpacing)); }
        public Task<string> wordWrapAsync { get => GetAsync<string>(nameof(wordWrap)); set => _ = SetAsync(value, nameof(wordWrap)); }
        public Task<string> widowsAsync { get => GetAsync<string>(nameof(widows)); set => _ = SetAsync(value, nameof(widows)); }
        public Task<string> zIndexAsync { get => GetAsync<string>(nameof(zIndex)); set => _ = SetAsync(value, nameof(zIndex)); }

    }
}