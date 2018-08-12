using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PaletteEditor.Classes
{
    /// <summary>
    /// This class contains the logic, and does the heavy lifting to create a new <seealso cref="KryptonPalette"/> so you don't have to!
    /// </summary>
    public static class PaletteEditorEngine
    {
        /// <summary>
        /// Exports the palette theme.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="paletteMode">The palette mode.</param>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColourPreview">The border colour preview.</param>
        /// <param name="alternativeNormalTextColourPreview">The alternative normal text colour preview.</param>
        /// <param name="normalTextColourPreview">The normal text colour preview.</param>
        /// <param name="disabledTextColourPreview">The disabled text colour preview.</param>
        /// <param name="focusedTextColourPreview">The focused text colour preview.</param>
        /// <param name="pressedTextColourPreview">The pressed text colour preview.</param>
        /// <param name="disabledColourPreview">The disabled colour preview.</param>
        /// <param name="linkNormalColourPreview">The link normal colour preview.</param>
        /// <param name="linkHoverColourPreview">The link hover colour preview.</param>
        /// <param name="linkVisitedColourPreview">The link visited colour preview.</param>
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
        /// <param name="statusState">State of the status.</param>
        /// <param name="invertColours">if set to <c>true</c> [invert colours].</param>
        public static void ExportPaletteTheme(KryptonPalette palette, PaletteMode paletteMode, PictureBox baseColour, PictureBox darkColour, PictureBox middleColour, PictureBox lightColour, PictureBox lightestColour, PictureBox borderColourPreview, PictureBox alternativeNormalTextColourPreview, PictureBox normalTextColourPreview, PictureBox disabledTextColourPreview, PictureBox focusedTextColourPreview, PictureBox pressedTextColourPreview, PictureBox disabledColourPreview, PictureBox linkNormalColourPreview, PictureBox linkHoverColourPreview, PictureBox linkVisitedColourPreview, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColour, PictureBox statusTextColour, ToolStripLabel statusState, bool invertColours = false)
        {
            palette = new KryptonPalette();

            //try
            //{
            palette.BasePaletteMode = paletteMode;

            if (lightestColour.BackColor == Color.Transparent)
            {
                lightestColour.BackColor = lightColour.BackColor;
            }

            if (invertColours)
            {
                #region Button Cluster
                palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;

                palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = middleColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = darkColour.BackColor;
                #endregion

                #region Button Common
                palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColourPreview.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = lightColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = normalTextColourPreview.BackColor;
                #endregion
            }
            else
            {
                #region Button Cluster
                palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;

                palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = middleColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = baseColour.BackColor;
                #endregion

                #region Button Common
                palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColourPreview.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;
                #endregion

                #region Common
                palette.Common.StateCommon.Back.Color1 = lightestColour.BackColor;

                palette.Common.StateCommon.Back.Color2 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color1 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color2 = darkColour.BackColor;

                palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColourPreview.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColourPreview.BackColor;
                #endregion

                #region Form Styles
                palette.FormStyles.FormCommon.StateActive.Back.Color1 = baseColour.BackColor;

                palette.FormStyles.FormCommon.StateActive.Border.DrawBorders = PaletteDrawBorders.All;
                #endregion

                #region Grid Styles
                palette.GridStyles.GridSheet.StateCommon.HeaderColumn.Content.Color1 = lightestColour.BackColor;

                palette.GridStyles.GridSheet.StateCommon.HeaderRow.Content.Color1 = lightestColour.BackColor;

                palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color1 = darkColour.BackColor;

                palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color2 = middleColour.BackColor;

                palette.GridStyles.GridSheet.StateNormal.HeaderRow.Content.Color1 = darkColour.BackColor;

                palette.GridStyles.GridSheet.StateTracking.HeaderColumn.Content.Color1 = baseColour.BackColor;
                #endregion

                #region Header Styles
                palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = middleColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = lightColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = lightColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color2 = lightestColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColourPreview.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;
                #endregion

                #region Label Styles
                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColourPreview.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColourPreview.BackColor;
                #endregion

                #region Ribbon
                palette.Ribbon.RibbonAppButton.StateCommon.BackColor2 = baseColour.BackColor;

                palette.Ribbon.RibbonAppButton.StateCommon.BackColor3 = customColourThree.BackColor;

                palette.Ribbon.RibbonAppButton.StateCommon.BackColor5 = baseColour.BackColor;

                palette.Ribbon.RibbonAppButton.StatePressed.BackColor5 = darkColour.BackColor;

                palette.Ribbon.RibbonAppButton.StateTracking.BackColor5 = customColourFive.BackColor;

                palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor1 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor2 = customColourTwo.BackColor;

                palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor3 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor4 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor5 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = customTextColourTwo.BackColor;

                palette.Ribbon.RibbonGroupCheckBoxText.StateCommon.TextColor = customTextColourTwo.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor1 = SystemColors.Window;

                palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor2 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor3 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor4 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor1 = SystemColors.Window;

                palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor2 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor3 = lightestColour.BackColor; // Or 230, 230, 230

                palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor4 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor1 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor3 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor4 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor5 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor1 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor2 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor3 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor4 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor5 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor1 = lightColour.BackColor;

                palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor2 = lightestColour.BackColor; // Or 230, 230, 230

                palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColourPreview.BackColor;

                palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor1 = baseColour.BackColor;

                palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor1 = lightestColour.BackColor; // Or 230, 230, 230

                palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonGroupNormalTitle.StateCommon.TextColor = customTextColourFive.BackColor;

                palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor1 = lightestColour.BackColor;

                palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonQATFullbar.BackColor1 = middleColour.BackColor;

                palette.Ribbon.RibbonQATFullbar.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonQATFullbar.BackColor3 = middleColour.BackColor;

                palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor1 = middleColour.BackColor;

                palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor3 = middleColour.BackColor;

                palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor4 = middleColour.BackColor;

                palette.Ribbon.RibbonQATOverflow.BackColor1 = middleColour.BackColor;

                palette.Ribbon.RibbonQATOverflow.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor1 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor2 = lightColour.BackColor;

                palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor3 = darkColour.BackColor;

                palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor4 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateCommon.BackColor1 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateCommon.BackColor3 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateCommon.BackColor4 = lightColour.BackColor;

                palette.Ribbon.RibbonTab.StateCommon.BackColor5 = lightColour.BackColor;

                palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColourPreview.BackColor;

                palette.Ribbon.RibbonTab.StateContextCheckedTracking.BackColor2 = middleColour.BackColor;

                palette.Ribbon.RibbonTab.StateTracking.BackColor2 = middleColour.BackColor;
                #endregion

                #region Separator Styles
                palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color2 = baseColour.BackColor;

                palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour.BackColor;

                palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour.BackColor;

                palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                #endregion

                #region Tool Menu Status
                palette.ToolMenuStatus.Button.ButtonPressedBorder = baseColour.BackColor;

                palette.ToolMenuStatus.Button.ButtonSelectedBorder = baseColour.BackColor;

                palette.ToolMenuStatus.Button.OverflowButtonGradientBegin = darkColour.BackColor;

                palette.ToolMenuStatus.Button.OverflowButtonGradientEnd = baseColour.BackColor;

                palette.ToolMenuStatus.Button.OverflowButtonGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.Grip.GripDark = baseColour.BackColor;

                palette.ToolMenuStatus.Grip.GripLight = customColourFive.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuBorder = baseColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemBorder = darkColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemSelected = middleColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = darkColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = baseColour.BackColor;

                palette.ToolMenuStatus.Menu.MenuItemText = menuTextColour.BackColor;

                palette.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColourPreview.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorDark = baseColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorLight = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripText = normalTextColourPreview.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColourPreview.BackColor;
                #endregion
            }

            palette.Export();

            statusState.Text = $"Palette exported to: { palette.GetFilePath() }";
            //}
            //catch (Exception exc)
            //{
            //    statusState.Text = $"An error has occurred: { exc.Message }";
            //}
        }

        /// <summary>
        /// Exports the palette theme.
        /// </summary>
        /// <param name="palette">The palette.</param>
        /// <param name="paletteMode">The palette mode.</param>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColourPreview">The border colour preview.</param>
        /// <param name="alternativeNormalTextColourPreview">The alternative normal text colour preview.</param>
        /// <param name="normalTextColourPreview">The normal text colour preview.</param>
        /// <param name="disabledTextColourPreview">The disabled text colour preview.</param>
        /// <param name="focusedTextColourPreview">The focused text colour preview.</param>
        /// <param name="pressedTextColourPreview">The pressed text colour preview.</param>
        /// <param name="disabledColourPreview">The disabled colour preview.</param>
        /// <param name="linkNormalColourPreview">The link normal colour preview.</param>
        /// <param name="linkHoverColourPreview">The link hover colour preview.</param>
        /// <param name="linkVisitedColourPreview">The link visited colour preview.</param>
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
        /// <param name="statusState">State of the status.</param>
        /// <param name="invertColours">if set to <c>true</c> [invert colours].</param>
        public static void ExportPaletteTheme(KryptonPalette palette, PaletteMode paletteMode, Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColourPreview, Color alternativeNormalTextColourPreview, Color normalTextColourPreview, Color disabledTextColourPreview, Color focusedTextColourPreview, Color pressedTextColourPreview, Color disabledColourPreview, Color linkNormalColourPreview, Color linkHoverColourPreview, Color linkVisitedColourPreview, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, ToolStripLabel statusState, bool invertColours = false)
        {
            try
            {
                palette.BasePaletteMode = paletteMode;

                if (invertColours)
                {

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

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColourPreview;

                    /*
                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour;
                    */

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColourPreview;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColourPreview;
                    #endregion

                    #region Common
                    palette.Common.StateCommon.Back.Color1 = lightestColour;

                    palette.Common.StateCommon.Back.Color2 = baseColour;

                    palette.Common.StateCommon.Border.Color1 = baseColour;

                    palette.Common.StateCommon.Border.Color2 = darkColour;

                    palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColourPreview;

                    palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColourPreview;

                    palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColourPreview;

                    palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColourPreview;
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

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColourPreview;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview;
                    #endregion

                    #region Label Styles
                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColourPreview;

                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColourPreview;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColourPreview;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColourPreview;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColourPreview;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColourPreview;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColourPreview;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColourPreview;

                    palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColourPreview;

                    palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColourPreview;
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

                    palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColourPreview;

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

                    palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColourPreview;

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

                    palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColourPreview;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour;

                    palette.ToolMenuStatus.Separator.SeparatorDark = baseColour;

                    palette.ToolMenuStatus.Separator.SeparatorLight = lightColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour;

                    palette.ToolMenuStatus.StatusStrip.StatusStripText = normalTextColourPreview;

                    palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour;

                    palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColourPreview;
                    #endregion

                    #region Trackbar
                    palette.TrackBar.StateCommon.Position.Color4 = darkColour;
                    #endregion
                }

                palette.Export();

                statusState.Text = $"Palette exported to: { Path.GetFullPath(palette.Export()) }";
            }
            catch (Exception exc)
            {
                statusState.Text = $"An error has occurred: { exc.Message }";
            }
        }

        #region !EXPERIMENTAL CODE!       
        /// <summary>
        /// Exports the palette.
        /// </summary>
        /// <param name="paletteMode">The palette mode.</param>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColourPreview">The border colour preview.</param>
        /// <param name="alternativeNormalTextColourPreview">The alternative normal text colour preview.</param>
        /// <param name="normalTextColourPreview">The normal text colour preview.</param>
        /// <param name="disabledTextColourPreview">The disabled text colour preview.</param>
        /// <param name="focusedTextColourPreview">The focused text colour preview.</param>
        /// <param name="pressedTextColourPreview">The pressed text colour preview.</param>
        /// <param name="disabledColourPreview">The disabled colour preview.</param>
        /// <param name="linkNormalColourPreview">The link normal colour preview.</param>
        /// <param name="linkHoverColourPreview">The link hover colour preview.</param>
        /// <param name="linkVisitedColourPreview">The link visited colour preview.</param>
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
        /// <param name="statusState">State of the status.</param>
        /// <param name="invertColours">if set to <c>true</c> [invert colours].</param>
        public static void ExportPalette(PaletteMode paletteMode, PictureBox baseColour, PictureBox darkColour, PictureBox middleColour, PictureBox lightColour, PictureBox lightestColour, PictureBox borderColourPreview, PictureBox alternativeNormalTextColourPreview, PictureBox normalTextColourPreview, PictureBox disabledTextColourPreview, PictureBox focusedTextColourPreview, PictureBox pressedTextColourPreview, PictureBox disabledColourPreview, PictureBox linkNormalColourPreview, PictureBox linkHoverColourPreview, PictureBox linkVisitedColourPreview, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColour, PictureBox statusTextColour, ToolStripLabel statusState, bool invertColours = false)
        {
            KryptonPalette palette = new KryptonPalette();

            try
            {
                palette.BasePaletteMode = paletteMode;

                if (lightestColour.BackColor == Color.Transparent)
                {
                    lightestColour.BackColor = lightColour.BackColor;
                }

                if (invertColours)
                {

                }
                else
                {
                    #region Button Cluster
                    palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;

                    palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = middleColour.BackColor;

                    palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = darkColour.BackColor;

                    palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = baseColour.BackColor;
                    #endregion

                    #region Button Common
                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColourPreview.BackColor;

                    /*
                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour.BackColor;
                    */

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;
                    #endregion

                    #region Common
                    palette.Common.StateCommon.Back.Color1 = lightestColour.BackColor;

                    palette.Common.StateCommon.Back.Color2 = baseColour.BackColor;

                    palette.Common.StateCommon.Border.Color1 = baseColour.BackColor;

                    palette.Common.StateCommon.Border.Color2 = darkColour.BackColor;

                    palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                    palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColourPreview.BackColor;

                    palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColourPreview.BackColor;

                    palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColourPreview.BackColor;
                    #endregion

                    #region Form Styles
                    palette.FormStyles.FormCommon.StateActive.Back.Color1 = baseColour.BackColor;

                    palette.FormStyles.FormCommon.StateActive.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Grid Styles
                    palette.GridStyles.GridSheet.StateCommon.HeaderColumn.Content.Color1 = lightestColour.BackColor;

                    palette.GridStyles.GridSheet.StateCommon.HeaderRow.Content.Color1 = lightestColour.BackColor;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color1 = darkColour.BackColor;

                    palette.GridStyles.GridSheet.StateNormal.HeaderColumn.Content.Color2 = middleColour.BackColor;

                    palette.GridStyles.GridSheet.StateNormal.HeaderRow.Content.Color1 = darkColour.BackColor;

                    palette.GridStyles.GridSheet.StateTracking.HeaderColumn.Content.Color1 = baseColour.BackColor;
                    #endregion

                    #region Header Styles
                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = middleColour.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = lightColour.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = lightColour.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Back.Color2 = lightestColour.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;

                    palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour.BackColor;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour.BackColor;

                    palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour.BackColor;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColourPreview.BackColor;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour.BackColor;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColourPreview.BackColor;

                    palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColourPreview.BackColor;
                    #endregion

                    #region Label Styles
                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColourPreview.BackColor;

                    palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColourPreview.BackColor;
                    #endregion

                    #region Ribbon
                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor2 = baseColour.BackColor;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor3 = customColourThree.BackColor;

                    palette.Ribbon.RibbonAppButton.StateCommon.BackColor5 = baseColour.BackColor;

                    palette.Ribbon.RibbonAppButton.StatePressed.BackColor5 = darkColour.BackColor;

                    palette.Ribbon.RibbonAppButton.StateTracking.BackColor5 = customColourFive.BackColor;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor1 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor2 = customColourTwo.BackColor;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor3 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor4 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupArea.StateCheckedNormal.BackColor5 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupButtonText.StateCommon.TextColor = customTextColourTwo.BackColor;

                    palette.Ribbon.RibbonGroupCheckBoxText.StateCommon.TextColor = customTextColourTwo.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor2 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor3 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateNormal.BackColor4 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor1 = SystemColors.Window;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor2 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor3 = lightestColour.BackColor; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedBack.StateTracking.BackColor4 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor1 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor3 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor4 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedBorder.StateCommon.BackColor5 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor1 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor2 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor3 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor4 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBack.StateCommon.BackColor5 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor1 = lightColour.BackColor;

                    palette.Ribbon.RibbonGroupCollapsedFrameBorder.StateCommon.BackColor2 = lightestColour.BackColor; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColourPreview.BackColor;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor1 = baseColour.BackColor;

                    palette.Ribbon.RibbonGroupNormalBorder.StateCommon.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor1 = lightestColour.BackColor; // Or 230, 230, 230

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonGroupNormalTitle.StateCommon.TextColor = customTextColourFive.BackColor;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor1 = lightestColour.BackColor;

                    palette.Ribbon.RibbonGroupNormalTitle.StateTracking.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATFullbar.BackColor1 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATFullbar.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATFullbar.BackColor3 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor1 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor3 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATMinibar.StateCommon.BackColor4 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATOverflow.BackColor1 = middleColour.BackColor;

                    palette.Ribbon.RibbonQATOverflow.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor1 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor2 = lightColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor3 = darkColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCheckedTracking.BackColor4 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor1 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor3 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor4 = lightColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCommon.BackColor5 = lightColour.BackColor;

                    palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColourPreview.BackColor;

                    palette.Ribbon.RibbonTab.StateContextCheckedTracking.BackColor2 = middleColour.BackColor;

                    palette.Ribbon.RibbonTab.StateTracking.BackColor2 = middleColour.BackColor;
                    #endregion

                    #region Separator Styles
                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Back.Color2 = baseColour.BackColor;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour.BackColor;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.Color1 = baseColour.BackColor;

                    palette.SeparatorStyles.SeparatorCommon.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    #endregion

                    #region Tool Menu Status
                    palette.ToolMenuStatus.Button.ButtonPressedBorder = baseColour.BackColor;

                    palette.ToolMenuStatus.Button.ButtonSelectedBorder = baseColour.BackColor;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientBegin = darkColour.BackColor;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientEnd = baseColour.BackColor;

                    palette.ToolMenuStatus.Button.OverflowButtonGradientMiddle = middleColour.BackColor;

                    palette.ToolMenuStatus.Grip.GripDark = baseColour.BackColor;

                    palette.ToolMenuStatus.Grip.GripLight = customColourFive.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientBegin = baseColour.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginGradientMiddle = middleColour.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = baseColour.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = middleColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuBorder = baseColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemBorder = darkColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = baseColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = middleColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemSelected = middleColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = darkColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = baseColour.BackColor;

                    palette.ToolMenuStatus.Menu.MenuItemText = menuTextColour.BackColor;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = baseColour.BackColor;

                    palette.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColourPreview.BackColor;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour.BackColor;

                    palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.Separator.SeparatorDark = baseColour.BackColor;

                    palette.ToolMenuStatus.Separator.SeparatorLight = lightColour.BackColor;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour.BackColor;

                    palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour.BackColor;

                    palette.ToolMenuStatus.StatusStrip.StatusStripText = statusTextColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour.BackColor;

                    palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColourPreview.BackColor;
                    #endregion

                    #region Trackbar
                    palette.TrackBar.StateCommon.Position.Color4 = middleColour.BackColor;

                    palette.TrackBar.StateCommon.Position.Color5 = lightColour.BackColor;

                    palette.TrackBar.StateCommon.Tick.Color3 = darkColour.BackColor;

                    palette.TrackBar.StateCommon.Tick.Color4 = middleColour.BackColor;

                    palette.TrackBar.StateCommon.Tick.Color5 = lightColour.BackColor;

                    palette.TrackBar.StateCommon.Track.Color1 = baseColour.BackColor;

                    palette.TrackBar.StateCommon.Track.Color2 = darkColour.BackColor;

                    palette.TrackBar.StateCommon.Track.Color3 = middleColour.BackColor;

                    palette.TrackBar.StateCommon.Track.Color4 = lightColour.BackColor;

                    palette.TrackBar.StateCommon.Track.Color5 = lightestColour.BackColor;

                    palette.TrackBar.StateNormal.Track.Color1 = baseColour.BackColor;

                    palette.TrackBar.StateNormal.Track.Color2 = darkColour.BackColor;

                    palette.TrackBar.StateNormal.Track.Color3 = middleColour.BackColor;

                    palette.TrackBar.StateNormal.Track.Color4 = lightColour.BackColor;

                    palette.TrackBar.StateNormal.Track.Color5 = lightestColour.BackColor;
                    #endregion
                }

                palette.Export();

                statusState.Text = $"Palette exported to: { palette.GetFilePath() }";
            }
            catch (Exception exc)
            {
                statusState.Text = $"An error has occurred: { exc.Message }";
            }
        }
        #endregion
    }
}