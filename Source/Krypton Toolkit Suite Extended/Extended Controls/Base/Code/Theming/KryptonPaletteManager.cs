using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Drawing;

namespace ExtendedControls.Base.Code.Theming
{
    /// <summary>
    /// This class manages the <see cref="KryptonPalette"/> and its associated colours.
    /// </summary>
    public class KryptonPaletteManager
    {
        #region Variables
        private Color _baseColour, _darkColour, _middleColour, _lightColour, _lightestColour, _borderColour, _alternativeNormalTextColour, _normalTextColour, _disabledTextColour, _focusedTextColour, _pressedTextColour, _disabledColour, _linkNormalColour, _linkFocusedColour, _linkHoverColour, _linkVisitedColour, _customColourOne, _customColourTwo, _customColourThree, _customColourFour, _customColourFive, _customTextColourOne, _customTextColourTwo, _customTextColourThree, _customTextColourFour, _customTextColourFive, _menuTextColour, _statusTextColour, _ribbonTabTextColour;
        private PaletteMode _paletteMode;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the base colour.
        /// </summary>
        /// <value>
        /// The base colour.
        /// </value>
        public Color BaseColour { get => _baseColour; set => _baseColour = value; }

        /// <summary>
        /// Gets or sets the dark colour.
        /// </summary>
        /// <value>
        /// The dark colour.
        /// </value>
        public Color DarkColour { get => _darkColour; set => _darkColour = value; }

        /// <summary>
        /// Gets or sets the middle colour.
        /// </summary>
        /// <value>
        /// The middle colour.
        /// </value>
        public Color MiddleColour { get => _middleColour; set => _middleColour = value; }

        /// <summary>
        /// Gets or sets the light colour.
        /// </summary>
        /// <value>
        /// The light colour.
        /// </value>
        public Color LightColour { get => _lightColour; set => _lightColour = value; }

        /// <summary>
        /// Gets or sets the lightest colour.
        /// </summary>
        /// <value>
        /// The lightest colour.
        /// </value>
        public Color LightestColour { get => _lightestColour; set => _lightestColour = value; }

        /// <summary>
        /// Gets or sets the border colour.
        /// </summary>
        /// <value>
        /// The border colour.
        /// </value>
        public Color BorderColour { get => _borderColour; set => _borderColour = value; }

        /// <summary>
        /// Gets or sets the alternative normal text colour.
        /// </summary>
        /// <value>
        /// The alternative normal text colour.
        /// </value>
        public Color AlternativeNormalTextColour { get => _alternativeNormalTextColour; set => _alternativeNormalTextColour = value; }

        /// <summary>
        /// Gets or sets the normal text colour.
        /// </summary>
        /// <value>
        /// The normal text colour.
        /// </value>
        public Color NormalTextColour { get => _normalTextColour; set => _normalTextColour = value; }

        /// <summary>
        /// Gets or sets the diisabled text colour.
        /// </summary>
        /// <value>
        /// The diisabled text colour.
        /// </value>
        public Color DiisabledTextColour { get => _disabledTextColour; set => _disabledTextColour = value; }

        /// <summary>
        /// Gets or sets the focused text colour.
        /// </summary>
        /// <value>
        /// The focused text colour.
        /// </value>
        public Color FocusedTextColour { get => _focusedTextColour; set => _focusedTextColour = value; }

        /// <summary>
        /// Gets or sets the pressed text colour.
        /// </summary>
        /// <value>
        /// The pressed text colour.
        /// </value>
        public Color PressedTextColour { get => _pressedTextColour; set => _pressedTextColour = value; }

        /// <summary>
        /// Gets or sets the disabled colour.
        /// </summary>
        /// <value>
        /// The disabled colour.
        /// </value>
        public Color DisabledColour { get => _disabledColour; set => _disabledColour = value; }

        /// <summary>
        /// Gets or sets the link normal colour.
        /// </summary>
        /// <value>
        /// The link normal colour.
        /// </value>
        public Color LinkNormalColour { get => _linkNormalColour; set => _linkNormalColour = value; }

        /// <summary>
        /// Gets or sets the link focused colour.
        /// </summary>
        /// <value>
        /// The link focused colour.
        /// </value>
        public Color LinkFocusedColour { get => _linkFocusedColour; set => _linkFocusedColour = value; }

        /// <summary>
        /// Gets or sets the link hover colour.
        /// </summary>
        /// <value>
        /// The link hover colour.
        /// </value>
        public Color LinkHoverColour { get => _linkHoverColour; set => _linkHoverColour = value; }

        /// <summary>
        /// Gets or sets the link visited colour.
        /// </summary>
        /// <value>
        /// The link visited colour.
        /// </value>
        public Color LinkVisitedColour { get => _linkVisitedColour; set => _linkVisitedColour = value; }

        /// <summary>
        /// Gets or sets the custom colour one.
        /// </summary>
        /// <value>
        /// The custom colour one.
        /// </value>
        public Color CustomColourOne { get => _customColourOne; set => _customColourOne = value; }

        /// <summary>
        /// Gets or sets the custom colour two.
        /// </summary>
        /// <value>
        /// The custom colour two.
        /// </value>
        public Color CustomColourTwo { get => _customColourTwo; set => _customColourTwo = value; }

        /// <summary>
        /// Gets or sets the custom colour three.
        /// </summary>
        /// <value>
        /// The custom colour three.
        /// </value>
        public Color CustomColourThree { get => _customColourThree; set => _customColourThree = value; }

        /// <summary>
        /// Gets or sets the custom colour four.
        /// </summary>
        /// <value>
        /// The custom colour four.
        /// </value>
        public Color CustomColourFour { get => _customColourFour; set => _customColourFour = value; }

        /// <summary>
        /// Gets or sets the custom colour five.
        /// </summary>
        /// <value>
        /// The custom colour five.
        /// </value>
        public Color CustomColourFive { get => _customColourFive; set => _customColourFive = value; }

        /// <summary>
        /// Gets or sets the custom text colour one.
        /// </summary>
        /// <value>
        /// The custom text colour one.
        /// </value>
        public Color CustomTextColourOne { get => _customTextColourOne; set => _customTextColourOne = value; }

        /// <summary>
        /// Gets or sets the custom text colour two.
        /// </summary>
        /// <value>
        /// The custom text colour two.
        /// </value>
        public Color CustomTextColourTwo { get => _customTextColourTwo; set => _customTextColourTwo = value; }

        /// <summary>
        /// Gets or sets the custom text colour three.
        /// </summary>
        /// <value>
        /// The custom text colour three.
        /// </value>
        public Color CustomTextColourThree { get => _customTextColourThree; set => _customTextColourThree = value; }

        /// <summary>
        /// Gets or sets the custom text colour four.
        /// </summary>
        /// <value>
        /// The custom text colour four.
        /// </value>
        public Color CustomTextColourFour { get => _customTextColourFour; set => _customTextColourFour = value; }

        /// <summary>
        /// Gets or sets the custom text colour five.
        /// </summary>
        /// <value>
        /// The custom text colour five.
        /// </value>
        public Color CustomTextColourFive { get => _customTextColourFive; set => _customTextColourFive = value; }

        /// <summary>
        /// Gets or sets the menu text colour.
        /// </summary>
        /// <value>
        /// The menu text colour.
        /// </value>
        public Color MenuTextColour { get => _menuTextColour; set => _menuTextColour = value; }

        /// <summary>
        /// Gets or sets the status text colour.
        /// </summary>
        /// <value>
        /// The status text colour.
        /// </value>
        public Color StatusTextColour { get => _statusTextColour; set => _statusTextColour = value; }

        /// <summary>
        /// Gets or sets the ribbon tab text colour.
        /// </summary>
        /// <value>
        /// The ribbon tab text colour.
        /// </value>
        public Color RibbonTabTextColour { get => _ribbonTabTextColour; set => _ribbonTabTextColour = value; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public PaletteMode Mode { get => _paletteMode; set => _paletteMode = value; }
        #endregion

        #region Constructor
        public KryptonPaletteManager()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Creates the new palette.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="paletteMode">The palette mode.</param>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        /// <param name="invertColours">if set to <c>true</c> [invert colours].</param>
        /// <param name="silent">if set to <c>true</c> [silent].</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void CreateNewPalette(KryptonPalette palette, PaletteMode paletteMode, Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour, bool invertColours = false, bool silent = false)
        {
            try
            {
                if (palette == null)
                {
                    throw new ArgumentNullException();
                }

                palette = new KryptonPalette();

                palette.BasePaletteMode = paletteMode;

                if (invertColours)
                {
                    #region Button Cluster
                    palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                    palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = customColourOne;

                    palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = lightColour;

                    palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = lightestColour;
                    #endregion

                    #region Button Common
                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = customColourOne;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = customColourOne;

                    /*
                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = lightestColour;
                    */

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = customTextColourOne;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = customTextColourOne;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = normalTextColour;
                    #endregion

                    #region Common
                    palette.Common.StateCommon.Back.Color1 = baseColour;

                    palette.Common.StateCommon.Back.Color2 = lightestColour;

                    palette.Common.StateCommon.Border.Color1 = lightestColour;

                    palette.Common.StateCommon.Border.Color2 = lightColour;

                    palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.Common.StateCommon.Content.LongText.Color1 = normalTextColour;

                    palette.Common.StateCommon.Content.LongText.Color2 = normalTextColour;

                    palette.Common.StateCommon.Content.ShortText.Color1 = normalTextColour;

                    palette.Common.StateCommon.Content.ShortText.Color2 = normalTextColour;
                    #endregion

                    #region Form Styles
                    palette.FormStyles.FormCommon.StateActive.Back.Color1 = lightestColour;

                    palette.FormStyles.FormCommon.StateActive.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Grid Styles
                    palette.GridStyles.GridSheet.StateCommon.HeaderColumn.Content.Color1 = baseColour;

                    palette.GridStyles.GridSheet.StateCommon.HeaderRow.Content.Color1 = baseColour;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color1 = lightColour;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color2 = customColourOne;

                    palette.GridStyles.GridSheet.StateNormal.HeaderRow.Content.Color1 = lightColour;

                    palette.GridStyles.GridSheet.StateTracking.HeaderColumn.Content.Color1 = lightestColour;
                    #endregion

                    #region Header Styles
                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = customColourOne;

                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = darkColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = darkColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color2 = baseColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = customTextColourOne;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = lightestColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = customTextColourOne;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = lightestColour;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = customColourOne;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = darkColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = customColourTwo;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = lightestColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = customTextColourOne;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = customTextColourOne;
                    #endregion

                    #region Label Styles
                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = customTextColourThree;

                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = customTextColourThree;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = customTextColourFour;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = customTextColourFour;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = customTextColourFive;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = customTextColourFive;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = customTextColourTwo;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = customTextColourTwo;

                    palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = alternativeNormalTextColour;

                    palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = alternativeNormalTextColour;
                    #endregion

                    #region Ribbon
                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor2 = lightestColour;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor3 = customColourFive;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor5 = lightestColour;

                    palette.Ribbon.RibbonAppButton.StatePressed.BackColor5 = lightColour;

                    palette.Ribbon.RibbonAppButton.StateTracking.BackColor5 = customColourThree;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor1 = lightestColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor2 = customColourFour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor3 = lightestColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor4 = lightestColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor5 = lightestColour;

                    palette.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = customTextColourFour;

                    palette.Ribbon.RibbonGroupCheckBoxText.StateCommon.TextColor = customTextColourFour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor2 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor3 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor4 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor2 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor3 = baseColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor4 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor1 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor3 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor4 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor5 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor1 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor2 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor3 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor4 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor5 = lightestColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor1 = darkColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor2 = baseColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = normalTextColour;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor1 = lightestColour;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor1 = baseColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.TextColor = customTextColourOne;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor1 = baseColour;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonQATFullbar.BackColor1 = customColourOne;

                    palette.Ribbon.RibbonQATFullbar.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonQATFullbar.BackColor3 = customColourOne;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor1 = customColourOne;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor3 = customColourOne;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor4 = customColourOne;

                    palette.Ribbon.RibbonQATOverflow.BackColor1 = customColourOne;

                    palette.Ribbon.RibbonQATOverflow.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor1 = customColourOne;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor2 = baseColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor3 = lightColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor4 = customColourOne;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor1 = customColourOne;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor3 = customColourOne;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor4 = darkColour;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor5 = darkColour;

                    palette.Ribbon.RibbonTab.StateCommon.TextColor = alternativeNormalTextColour;

                    palette.Ribbon.RibbonTab.StateContextCheckedTracking.BackColor2 = customColourOne;

                    palette.Ribbon.RibbonTab.StateTracking.BackColor2 = customColourOne;
                    #endregion

                    #region Separator Styles
                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color1 = lightestColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color2 = lightestColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = lightestColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = lightestColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Tool Menu Status
                    palette.ToolMenuStatus.Button.ButtonPressedBorder = lightestColour;

                    palette.ToolMenuStatus.Button.ButtonSelectedBorder = lightestColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientBegin = lightColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientEnd = lightestColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientMiddle = customColourOne;

                    palette.ToolMenuStatus.Grip.GripDark = lightestColour;

                    palette.ToolMenuStatus.Grip.GripLight = customColourTwo;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientBegin = lightestColour;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientEnd = lightColour;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientMiddle = customColourOne;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = lightestColour;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = lightColour;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = customColourOne;

                    palette.ToolMenuStatus.Menu.MenuBorder = lightestColour;

                    palette.ToolMenuStatus.Menu.MenuItemBorder = lightColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = lightestColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = lightColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = customColourOne;

                    palette.ToolMenuStatus.Menu.MenuItemSelected = customColourOne;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = lightColour;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = lightestColour;

                    palette.ToolMenuStatus.Menu.MenuItemText = customTextColourFive;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = lightestColour;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = lightColour;

                    palette.ToolMenuStatus.MenuStrip.MenuStripText = alternativeNormalTextColour;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = customColourOne;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour;

                    palette.ToolMenuStatus.Separator.SeparatorDark = lightestColour;

                    palette.ToolMenuStatus.Separator.SeparatorLight = darkColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = lightestColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = baseColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripText = alternativeNormalTextColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripBorder = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = customColourOne;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = customColourOne;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripText = alternativeNormalTextColour;
                    #endregion

                    #region Trackbar
                    palette.TrackBar.StateCommon.Position.Color4 = lightColour;
                    #endregion
                }
                else
                {
                    #region Button Cluster
                    palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;

                    palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = middleColour;

                    palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = darkColour;

                    palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = baseColour;
                    #endregion

                    #region Button Common
                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColour;

                    /*
                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour;
                    */

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColour;
                    #endregion

                    #region Common
                    palette.Common.StateCommon.Back.Color1 = lightestColour;

                    palette.Common.StateCommon.Back.Color2 = baseColour;

                    palette.Common.StateCommon.Border.Color1 = baseColour;

                    palette.Common.StateCommon.Border.Color2 = darkColour;

                    palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColour;

                    palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColour;

                    palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColour;

                    palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColour;
                    #endregion

                    #region Form Styles
                    palette.FormStyles.FormCommon.StateActive.Back.Color1 = baseColour;

                    palette.FormStyles.FormCommon.StateActive.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Grid Styles
                    palette.GridStyles.GridSheet.StateCommon.HeaderColumn.Content.Color1 = lightestColour;

                    palette.GridStyles.GridSheet.StateCommon.HeaderRow.Content.Color1 = lightestColour;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color1 = darkColour;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color2 = middleColour;

                    palette.GridStyles.GridSheet.StateNormal.HeaderRow.Content.Color1 = darkColour;

                    palette.GridStyles.GridSheet.StateTracking.HeaderColumn.Content.Color1 = baseColour;
                    #endregion

                    #region Header Styles
                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = middleColour;

                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = lightColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = lightColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color2 = lightestColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColour;
                    #endregion

                    #region Label Styles
                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColour;

                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColour;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColour;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColour;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColour;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColour;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColour;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColour;

                    palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColour;

                    palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColour;
                    #endregion

                    #region Ribbon
                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor2 = baseColour;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor3 = customColourThree;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor5 = baseColour;

                    palette.Ribbon.RibbonAppButton.StatePressed.BackColor5 = darkColour;

                    palette.Ribbon.RibbonAppButton.StateTracking.BackColor5 = customColourFive;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor1 = baseColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor2 = customColourTwo;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor3 = baseColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor4 = baseColour;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor5 = baseColour;

                    palette.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = customTextColourTwo;

                    palette.Ribbon.RibbonGroupCheckBoxText.StateCommon.TextColor = customTextColourTwo;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor2 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor3 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor4 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor2 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor3 = lightestColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor4 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor1 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor2 = middleColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor3 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor4 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor5 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor1 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor2 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor3 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor4 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor5 = baseColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor1 = lightColour;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor2 = lightestColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColour;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor1 = baseColour;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor2 = middleColour;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor1 = lightestColour; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor2 = middleColour;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.TextColor = customTextColourFive;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor1 = lightestColour;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor2 = middleColour;

                    palette.Ribbon.RibbonQATFullbar.BackColor1 = middleColour;

                    palette.Ribbon.RibbonQATFullbar.BackColor2 = middleColour;

                    palette.Ribbon.RibbonQATFullbar.BackColor3 = middleColour;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor1 = middleColour;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor2 = middleColour;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor3 = middleColour;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor4 = middleColour;

                    palette.Ribbon.RibbonQATOverflow.BackColor1 = middleColour;

                    palette.Ribbon.RibbonQATOverflow.BackColor2 = middleColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor1 = middleColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor2 = lightColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor3 = darkColour;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor4 = middleColour;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor1 = middleColour;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor3 = middleColour;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor4 = lightColour;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor5 = lightColour;

                    palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColour;

                    palette.Ribbon.RibbonTab.StateContextCheckedTracking.BackColor2 = middleColour;

                    palette.Ribbon.RibbonTab.StateTracking.BackColor2 = middleColour;
                    #endregion

                    #region Separator Styles
                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color1 = baseColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color2 = baseColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Tool Menu Status
                    palette.ToolMenuStatus.Button.ButtonPressedBorder = baseColour;

                    palette.ToolMenuStatus.Button.ButtonSelectedBorder = baseColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientBegin = darkColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientEnd = baseColour;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientMiddle = middleColour;

                    palette.ToolMenuStatus.Grip.GripDark = baseColour;

                    palette.ToolMenuStatus.Grip.GripLight = customColourFive;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientBegin = baseColour;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientEnd = darkColour;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientMiddle = middleColour;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = baseColour;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = darkColour;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = middleColour;

                    palette.ToolMenuStatus.Menu.MenuBorder = baseColour;

                    palette.ToolMenuStatus.Menu.MenuItemBorder = darkColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = baseColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = darkColour;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = middleColour;

                    palette.ToolMenuStatus.Menu.MenuItemSelected = middleColour;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = darkColour;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = baseColour;

                    palette.ToolMenuStatus.Menu.MenuItemText = menuTextColour;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = baseColour;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = darkColour;

                    palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColour;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour;

                    palette.ToolMenuStatus.Separator.SeparatorDark = baseColour;

                    palette.ToolMenuStatus.Separator.SeparatorLight = lightColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripText = normalTextColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColour;
                    #endregion

                    #region Trackbar
                    palette.TrackBar.StateCommon.Position.Color4 = darkColour;
                    #endregion
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null);
            }
        }

        /// <summary>
        /// Populates the colours.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        public static void PopulateColours(Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour)
        {
            try
            {
                KryptonPaletteManager kpm = new KryptonPaletteManager();

                kpm.SetBaseColour(baseColour);

                kpm.SetDarkColour(darkColour);

                kpm.SetMiddleColour(middleColour);

                kpm.SetLightColour(lightColour);

                kpm.SetLightestColour(lightestColour);

                kpm.SetBorderColour(borderColour);

                kpm.SetAlternativeNormalTextColour(alternativeNormalTextColour);

                kpm.SetNormalTextColour(normalTextColour);

                kpm.SetDisabledTextColour(disabledTextColour);

                kpm.SetFocusedTextColour(focusedTextColour);

                kpm.SetPressedTextColour(pressedTextColour);

                kpm.SetDisabledColour(disabledColour);

                kpm.SetLinkNormalColour(linkNormalColour);

                kpm.SetLinkFocusedColour(linkFocusedColour);

                kpm.SetLinkHoverColour(linkHoverColour);

                kpm.SetLinkVisitedColour(linkVisitedColour);

                kpm.SetCustomColourOne(customColourOne);

                kpm.SetCustomColourTwo(customColourTwo);

                kpm.SetCustomColourThree(customColourThree);

                kpm.SetCustomColourFour(customColourFour);

                kpm.SetCustomColourFive(customColourFive);

                kpm.SetCustomTextColourOne(customTextColourOne);

                kpm.SetCustomTextColourTwo(customTextColourTwo);

                kpm.SetCustomTextColourThree(customTextColourThree);

                kpm.SetCustomTextColourFour(customTextColourFour);

                kpm.SetCustomTextColourFive(customTextColourFive);

                kpm.SetMenuTextColour(menuTextColour);

                kpm.SetStatusTextColour(statusTextColour);

                kpm.SetRibbonTabTextColour(ribbonTabTextColour);
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null);
            }
        }

        /// <summary>
        /// Populates the colours.
        /// </summary>
        /// <param name="paletteMode">The palette mode.</param>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        public static void PopulateColours(PaletteMode paletteMode, Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour)
        {
            try
            {
                KryptonPaletteManager kpm = new KryptonPaletteManager();

                kpm.SetBaseColour(baseColour);

                kpm.SetDarkColour(darkColour);

                kpm.SetMiddleColour(middleColour);

                kpm.SetLightColour(lightColour);

                kpm.SetLightestColour(lightestColour);

                kpm.SetBorderColour(borderColour);

                kpm.SetAlternativeNormalTextColour(alternativeNormalTextColour);

                kpm.SetNormalTextColour(normalTextColour);

                kpm.SetDisabledTextColour(disabledTextColour);

                kpm.SetFocusedTextColour(focusedTextColour);

                kpm.SetPressedTextColour(pressedTextColour);

                kpm.SetDisabledColour(disabledColour);

                kpm.SetLinkNormalColour(linkNormalColour);

                kpm.SetLinkFocusedColour(linkFocusedColour);

                kpm.SetLinkHoverColour(linkHoverColour);

                kpm.SetLinkVisitedColour(linkVisitedColour);

                kpm.SetCustomColourOne(customColourOne);

                kpm.SetCustomColourTwo(customColourTwo);

                kpm.SetCustomColourThree(customColourThree);

                kpm.SetCustomColourFour(customColourFour);

                kpm.SetCustomColourFive(customColourFive);

                kpm.SetCustomTextColourOne(customTextColourOne);

                kpm.SetCustomTextColourTwo(customTextColourTwo);

                kpm.SetCustomTextColourThree(customTextColourThree);

                kpm.SetCustomTextColourFour(customTextColourFour);

                kpm.SetCustomTextColourFive(customTextColourFive);

                kpm.SetMenuTextColour(menuTextColour);

                kpm.SetStatusTextColour(statusTextColour);

                kpm.SetRibbonTabTextColour(ribbonTabTextColour);

                kpm.SetPaletteMode(paletteMode);
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null);
            }
        }

        /// <summary>
        /// Populates the colours.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        public static void PopulateColours(CircularPictureBox baseColour, CircularPictureBox darkColour, CircularPictureBox middleColour, CircularPictureBox lightColour, CircularPictureBox lightestColour, CircularPictureBox borderColour, CircularPictureBox alternativeNormalTextColour, CircularPictureBox normalTextColour, CircularPictureBox disabledTextColour, CircularPictureBox focusedTextColour, CircularPictureBox pressedTextColour, CircularPictureBox disabledColour, CircularPictureBox linkNormalColour, CircularPictureBox linkFocusedColour, CircularPictureBox linkHoverColour, CircularPictureBox linkVisitedColour, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColour, CircularPictureBox statusTextColour, CircularPictureBox ribbonTabTextColour)
        {
            try
            {
                KryptonPaletteManager kpm = new KryptonPaletteManager();

                kpm.SetBaseColour(baseColour.BackColor);

                kpm.SetDarkColour(darkColour.BackColor);

                kpm.SetMiddleColour(middleColour.BackColor);

                kpm.SetLightColour(lightColour.BackColor);

                kpm.SetLightestColour(lightestColour.BackColor);

                kpm.SetBorderColour(borderColour.BackColor);

                kpm.SetAlternativeNormalTextColour(alternativeNormalTextColour.BackColor);

                kpm.SetNormalTextColour(normalTextColour.BackColor);

                kpm.SetDisabledTextColour(disabledTextColour.BackColor);

                kpm.SetFocusedTextColour(focusedTextColour.BackColor);

                kpm.SetPressedTextColour(pressedTextColour.BackColor);

                kpm.SetDisabledColour(disabledColour.BackColor);

                kpm.SetLinkNormalColour(linkNormalColour.BackColor);

                kpm.SetLinkFocusedColour(linkFocusedColour.BackColor);

                kpm.SetLinkHoverColour(linkHoverColour.BackColor);

                kpm.SetLinkVisitedColour(linkVisitedColour.BackColor);

                kpm.SetCustomColourOne(customColourOne.BackColor);

                kpm.SetCustomColourTwo(customColourTwo.BackColor);

                kpm.SetCustomColourThree(customColourThree.BackColor);

                kpm.SetCustomColourFour(customColourFour.BackColor);

                kpm.SetCustomColourFive(customColourFive.BackColor);

                kpm.SetCustomTextColourOne(customTextColourOne.BackColor);

                kpm.SetCustomTextColourTwo(customTextColourTwo.BackColor);

                kpm.SetCustomTextColourThree(customTextColourThree.BackColor);

                kpm.SetCustomTextColourFour(customTextColourFour.BackColor);

                kpm.SetCustomTextColourFive(customTextColourFive.BackColor);

                kpm.SetMenuTextColour(menuTextColour.BackColor);

                kpm.SetStatusTextColour(statusTextColour.BackColor);

                kpm.SetRibbonTabTextColour(ribbonTabTextColour.BackColor);
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null);
            }
        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the value of BaseColour to value.
        /// </summary>
        /// <param name="value">The value of BaseColour.</param>
        public void SetBaseColour(Color value)
        {
            BaseColour = value;
        }

        /// <summary>
        /// Returns the value of BaseColour.
        /// </summary>
        /// <returns>The value of BaseColour.</returns>
        public Color GetBaseColour()
        {
            return BaseColour;
        }

        /// <summary>
        /// Sets the value of DarkColour to value.
        /// </summary>
        /// <param name="value">The value of DarkColour.</param>
        public void SetDarkColour(Color value)
        {
            DarkColour = value;
        }

        /// <summary>
        /// Returns the value of DarkColour.
        /// </summary>
        /// <returns>The value of DarkColour.</returns>
        public Color GetDarkColour()
        {
            return DarkColour;
        }

        /// <summary>
        /// Sets the value of MiddleColour to value.
        /// </summary>
        /// <param name="value">The value of MiddleColour.</param>
        public void SetMiddleColour(Color value)
        {
            MiddleColour = value;
        }

        /// <summary>
        /// Returns the value of MiddleColour.
        /// </summary>
        /// <returns>The value of MiddleColour.</returns>
        public Color GetMiddleColour()
        {
            return MiddleColour;
        }

        /// <summary>
        /// Sets the value of LightColour to value.
        /// </summary>
        /// <param name="value">The value of LightColour.</param>
        public void SetLightColour(Color value)
        {
            LightColour = value;
        }

        /// <summary>
        /// Returns the value of LightColour.
        /// </summary>
        /// <returns>The value of LightColour.</returns>
        public Color GetLightColour()
        {
            return LightColour;
        }

        /// <summary>
        /// Sets the value of LightestColour to value.
        /// </summary>
        /// <param name="value">The value of LightestColour.</param>
        public void SetLightestColour(Color value)
        {
            LightestColour = value;
        }

        /// <summary>
        /// Returns the value of LightestColour.
        /// </summary>
        /// <returns>The value of LightestColour.</returns>
        public Color GetLightestColour()
        {
            return LightestColour;
        }

        /// <summary>
        /// Sets the value of BorderColour to value.
        /// </summary>
        /// <param name="value">The value of BorderColour.</param>
        public void SetBorderColour(Color value)
        {
            BorderColour = value;
        }

        /// <summary>
        /// Returns the value of BorderColour.
        /// </summary>
        /// <returns>The value of BorderColour.</returns>
        public Color GetBorderColour()
        {
            return BorderColour;
        }

        /// <summary>
        /// Sets the value of AlternativeNormalTextColour to value.
        /// </summary>
        /// <param name="value">The value of AlternativeNormalTextColour.</param>
        public void SetAlternativeNormalTextColour(Color value)
        {
            AlternativeNormalTextColour = value;
        }

        /// <summary>
        /// Returns the value of AlternativeNormalTextColour.
        /// </summary>
        /// <returns>The value of AlternativeNormalTextColour.</returns>
        public Color GetAlternativeNormalTextColour()
        {
            return AlternativeNormalTextColour;
        }

        /// <summary>
        /// Sets the value of NormalTextColour to value.
        /// </summary>
        /// <param name="value">The value of NormalTextColour.</param>
        public void SetNormalTextColour(Color value)
        {
            NormalTextColour = value;
        }

        /// <summary>
        /// Returns the value of NormalTextColour.
        /// </summary>
        /// <returns>The value of NormalTextColour.</returns>
        public Color GetNormalTextColour()
        {
            return NormalTextColour;
        }

        /// <summary>
        /// Sets the value of DisabledTextColour to value.
        /// </summary>
        /// <param name="value">The value of DisabledTextColour.</param>
        public void SetDisabledTextColour(Color value)
        {
            DiisabledTextColour = value;
        }

        /// <summary>
        /// Returns the value of DisabledTextColour.
        /// </summary>
        /// <returns>The value of DisabledTextColour.</returns>
        public Color GetDisabledTextColour()
        {
            return DiisabledTextColour;
        }

        /// <summary>
        /// Sets the value of FocusedTextColour to value.
        /// </summary>
        /// <param name="value">The value of FocusedTextColour.</param>
        public void SetFocusedTextColour(Color value)
        {
            FocusedTextColour = value;
        }

        /// <summary>
        /// Returns the value of FocusedTextColour.
        /// </summary>
        /// <returns>The value of FocusedTextColour.</returns>
        public Color GetFocusedTextColour()
        {
            return FocusedTextColour;
        }

        /// <summary>
        /// Sets the value of PressedTextColour to value.
        /// </summary>
        /// <param name="value">The value of PressedTextColour.</param>
        public void SetPressedTextColour(Color value)
        {
            PressedTextColour = value;
        }

        /// <summary>
        /// Returns the value of PressedTextColour.
        /// </summary>
        /// <returns>The value of PressedTextColour.</returns>
        public Color GetPressedTextColour()
        {
            return PressedTextColour;
        }

        /// <summary>
        /// Sets the value of DisabledColour to value.
        /// </summary>
        /// <param name="value">The value of DisabledColour.</param>
        public void SetDisabledColour(Color value)
        {
            DisabledColour = value;
        }

        /// <summary>
        /// Returns the value of DisabledColour.
        /// </summary>
        /// <returns>The value of DisabledColour.</returns>
        public Color GetDisabledColour()
        {
            return DisabledColour;
        }

        /// <summary>
        /// Sets the value of LinkNormalColour to value.
        /// </summary>
        /// <param name="value">The value of LinkNormalColour.</param>
        public void SetLinkNormalColour(Color value)
        {
            LinkNormalColour = value;
        }

        /// <summary>
        /// Returns the value of LinkNormalColour.
        /// </summary>
        /// <returns>The value of LinkNormalColour.</returns>
        public Color GetLinkNormalColour()
        {
            return LinkNormalColour;
        }

        /// <summary>
        /// Sets the value of LinkFocusedColour to value.
        /// </summary>
        /// <param name="value">The value of LinkFocusedColour.</param>
        public void SetLinkFocusedColour(Color value)
        {
            LinkFocusedColour = value;
        }

        /// <summary>
        /// Returns the value of LinkFocusedColour.
        /// </summary>
        /// <returns>The value of LinkFocusedColour.</returns>
        public Color GetLinkFocusedColour()
        {
            return LinkFocusedColour;
        }

        /// <summary>
        /// Sets the value of LinkHoverColour to value.
        /// </summary>
        /// <param name="value">The value of LinkHoverColour.</param>
        public void SetLinkHoverColour(Color value)
        {
            LinkHoverColour = value;
        }

        /// <summary>
        /// Returns the value of LinkHoverColour.
        /// </summary>
        /// <returns>The value of LinkHoverColour.</returns>
        public Color GetLinkHoverColour()
        {
            return LinkHoverColour;
        }

        /// <summary>
        /// Sets the value of LinkVisitedColour to value.
        /// </summary>
        /// <param name="value">The value of LinkVisitedColour.</param>
        public void SetLinkVisitedColour(Color value)
        {
            LinkVisitedColour = value;
        }

        /// <summary>
        /// Returns the value of LinkVisitedColour.
        /// </summary>
        /// <returns>The value of LinkVisitedColour.</returns>
        public Color GetLinkVisitedColour()
        {
            return LinkVisitedColour;
        }

        /// <summary>
        /// Sets the value of CustomColourOne to value.
        /// </summary>
        /// <param name="value">The value of CustomColourOne.</param>
        public void SetCustomColourOne(Color value)
        {
            CustomColourOne = value;
        }

        /// <summary>
        /// Returns the value of CustomColourOne.
        /// </summary>
        /// <returns>The value of CustomColourOne.</returns>
        public Color GetCustomColourOne()
        {
            return CustomColourOne;
        }

        /// <summary>
        /// Sets the value of CustomColourTwo to value.
        /// </summary>
        /// <param name="value">The value of CustomColourTwo.</param>
        public void SetCustomColourTwo(Color value)
        {
            CustomColourTwo = value;
        }

        /// <summary>
        /// Returns the value of CustomColourTwo.
        /// </summary>
        /// <returns>The value of CustomColourTwo.</returns>
        public Color GetCustomColourTwo()
        {
            return CustomColourTwo;
        }

        /// <summary>
        /// Sets the value of CustomColourThree to value.
        /// </summary>
        /// <param name="value">The value of CustomColourThree.</param>
        public void SetCustomColourThree(Color value)
        {
            CustomColourThree = value;
        }

        /// <summary>
        /// Returns the value of CustomColourThree.
        /// </summary>
        /// <returns>The value of CustomColourThree.</returns>
        public Color GetCustomColourThree()
        {
            return CustomColourThree;
        }

        /// <summary>
        /// Sets the value of CustomColourFour to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFour.</param>
        public void SetCustomColourFour(Color value)
        {
            CustomColourFour = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFour.
        /// </summary>
        /// <returns>The value of CustomColourFour.</returns>
        public Color GetCustomColourFour()
        {
            return CustomColourFour;
        }

        /// <summary>
        /// Sets the value of CustomColourFive to value.
        /// </summary>
        /// <param name="value">The value of CustomColourFive.</param>
        public void SetCustomColourFive(Color value)
        {
            CustomColourFive = value;
        }

        /// <summary>
        /// Returns the value of CustomColourFive.
        /// </summary>
        /// <returns>The value of CustomColourFive.</returns>
        public Color GetCustomColourFive()
        {
            return CustomColourFive;
        }

        /// <summary>
        /// Sets the value of CustomTextColourOne to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourOne.</param>
        public void SetCustomTextColourOne(Color value)
        {
            CustomTextColourOne = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourOne.
        /// </summary>
        /// <returns>The value of CustomTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return CustomTextColourOne;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwo to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color value)
        {
            CustomTextColourTwo = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwo.
        /// </summary>
        /// <returns>The value of CustomTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThree to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourThree.</param>
        public void SetCustomTextColourThree(Color value)
        {
            CustomTextColourThree = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourThree.
        /// </summary>
        /// <returns>The value of CustomTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return CustomTextColourThree;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFour to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFour.</param>
        public void SetCustomTextColourFour(Color value)
        {
            CustomTextColourFour = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFour.
        /// </summary>
        /// <returns>The value of CustomTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return CustomTextColourFour;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFive to value.
        /// </summary>
        /// <param name="value">The value of CustomTextColourFive.</param>
        public void SetCustomTextColourFive(Color value)
        {
            CustomTextColourFive = value;
        }

        /// <summary>
        /// Returns the value of CustomTextColourFive.
        /// </summary>
        /// <returns>The value of CustomTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return CustomTextColourFive;
        }

        /// <summary>
        /// Sets the value of MenuTextColour to value.
        /// </summary>
        /// <param name="value">The value of MenuTextColour.</param>
        public void SetMenuTextColour(Color value)
        {
            MenuTextColour = value;
        }

        /// <summary>
        /// Returns the value of MenuTextColour.
        /// </summary>
        /// <returns>The value of MenuTextColour.</returns>
        public Color GetMenuTextColour()
        {
            return MenuTextColour;
        }

        /// <summary>
        /// Sets the value of StatusTextColour to value.
        /// </summary>
        /// <param name="value">The value of StatusTextColour.</param>
        public void SetStatusTextColour(Color value)
        {
            StatusTextColour = value;
        }

        /// <summary>
        /// Returns the value of StatusTextColour.
        /// </summary>
        /// <returns>The value of StatusTextColour.</returns>
        public Color GetStatusTextColour()
        {
            return StatusTextColour;
        }

        /// <summary>
        /// Sets the value of RibbonTabTextColour to value.
        /// </summary>
        /// <param name="value">The value of RibbonTabTextColour.</param>
        public void SetRibbonTabTextColour(Color value)
        {
            RibbonTabTextColour = value;
        }

        /// <summary>
        /// Returns the value of RibbonTabTextColour.
        /// </summary>
        /// <returns>The value of RibbonTabTextColour.</returns>
        public Color GetRibbonTabTextColour()
        {
            return RibbonTabTextColour;
        }

        /// <summary>
        /// Sets the value of PaletteMode to value.
        /// </summary>
        /// <param name="value">The value of PaletteMode.</param>
        public void SetPaletteMode(PaletteMode value)
        {
            Mode = value;
        }

        /// <summary>
        /// Returns the value of PaletteMode.
        /// </summary>
        /// <returns>The value of PaletteMode.</returns>
        public PaletteMode GetPaletteMode()
        {
            return Mode;
        }
        #endregion
    }
}