#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PaletteExplorer.Classes
{
    public class PaletteComposerEngine
    {
        #region Variables
        private Color baseColour, darkColour, middleColour, lightColour, lightestColour, borderColour, alternativeNormalTextColour, normalTextColour, disabledTextColour, focusedTextColour, pressedTextColour, disabledColour, linkNormalColour, linkFocusedColour, linkHoverColour, linkVisitedColour, customColourOne, customColourTwo, customColourThree, customColourFour, customColourFive, customTextColourOne, customTextColourTwo, customTextColourThree, customTextColourFour, customTextColourFive, menuTextColour, statusTextColour, ribbonTabTextColour;
        #endregion

        #region Methods
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
        /// <param name="borderColour">The border colour .</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour .</param>
        /// <param name="normalTextColour">The normal text colour .</param>
        /// <param name="disabledTextColour">The disabled text colour .</param>
        /// <param name="focusedTextColour">The focused text colour .</param>
        /// <param name="pressedTextColour">The pressed text colour .</param>
        /// <param name="disabledColour">The disabled colour .</param>
        /// <param name="linkNormalColour">The link normal colour .</param>
        /// <param name="linkHoverColour">The link hover colour .</param>
        /// <param name="linkVisitedColour">The link visited colour .</param>
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
        public static void ExportPaletteTheme(KryptonPalette palette, PaletteMode paletteMode, PictureBox baseColour, PictureBox darkColour, PictureBox middleColour, PictureBox lightColour, PictureBox lightestColour, PictureBox borderColour, PictureBox alternativeNormalTextColour, PictureBox normalTextColour, PictureBox disabledTextColour, PictureBox focusedTextColour, PictureBox pressedTextColour, PictureBox disabledColour, PictureBox linkNormalColour, PictureBox linkFocusedColour, PictureBox linkHoverColour, PictureBox linkVisitedColour, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColour, PictureBox statusTextColour, PictureBox ribbonTabTextColour, ToolStripLabel statusState, bool invertColours = false)
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

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColour.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = lightColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = normalTextColour.BackColor;
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

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColour.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;
                #endregion

                #region Common
                palette.Common.StateCommon.Back.Color1 = lightestColour.BackColor;

                palette.Common.StateCommon.Back.Color2 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color1 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color2 = darkColour.BackColor;

                palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColour.BackColor;
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

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;
                #endregion

                #region Label Styles
                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColour.BackColor;
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

                palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColour.BackColor;

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

                palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColour.BackColor;

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

                palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColour.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorDark = baseColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorLight = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripText = normalTextColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColour.BackColor;
                #endregion
            }

            palette.Export();

            statusState.Text = $"Palette exported to: { palette.GetCustomisedKryptonPaletteFilePath() }";
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
        /// <param name="borderColour">The border colour .</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour .</param>
        /// <param name="normalTextColour">The normal text colour .</param>
        /// <param name="disabledTextColour">The disabled text colour .</param>
        /// <param name="focusedTextColour">The focused text colour .</param>
        /// <param name="pressedTextColour">The pressed text colour .</param>
        /// <param name="disabledColour">The disabled colour .</param>
        /// <param name="linkNormalColour">The link normal colour .</param>
        /// <param name="linkHoverColour">The link hover colour .</param>
        /// <param name="linkVisitedColour">The link visited colour .</param>
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
        public static void ExportPaletteTheme(KryptonPalette palette, PaletteMode paletteMode, Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour, ToolStripLabel statusState, bool invertColours = false)
        {
            try
            {
                palette.BasePaletteMode = paletteMode;

                if (invertColours)
                {
                    #region Button Cluster
                    palette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = darkColour;

                    palette.ButtonStyles.ButtonCluster.OverrideFocus.Back.Color1 = darkColour;

                    palette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = darkColour;

                    palette.ButtonStyles.ButtonCluster.StateCommon.Back.ColorStyle = PaletteColorStyle.GlassNormalFull;

                    palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1 = lightColour;

                    palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = baseColour;

                    palette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = darkColour;
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

                palette.Export();

                statusState.Text = $"Palette exported to: { Path.GetFullPath(palette.Export()) }";
            }
            catch (Exception exc)
            {
                statusState.Text = $"An error has occurred: { exc.Message }";
            }
        }


        public static void ExportPaletteTheme(KryptonPalette palette, PaletteMode paletteMode, CircularPictureBox baseColour, CircularPictureBox darkColour, CircularPictureBox middleColour, CircularPictureBox lightColour, CircularPictureBox lightestColour, CircularPictureBox borderColour, CircularPictureBox alternativeNormalTextColour, CircularPictureBox normalTextColour, CircularPictureBox disabledTextColour, CircularPictureBox focusedTextColour, CircularPictureBox pressedTextColour, CircularPictureBox disabledColour, CircularPictureBox linkNormalColour, CircularPictureBox linkFocusedColour, CircularPictureBox linkHoverColour, CircularPictureBox linkVisitedColour, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColour, CircularPictureBox statusTextColour, CircularPictureBox ribbonTabTextColour, ToolStripLabel statusState, bool invertColours = false)
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

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColour.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = lightColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = normalTextColour.BackColor;
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

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = PaletteColorStyle.GlassCheckedFull;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = PaletteColorStyle.GlassCheckedStump;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = PaletteDrawBorders.All;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCheckedTracking.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = disabledColour.BackColor;

                /*
                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color2 = baseColour.BackColor;
                */

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Back.Color2 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Color2 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Color2 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = lightestColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = lightColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.LongText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = normalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = baseColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = darkColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.ButtonStyles.ButtonCommon.StateTracking.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;
                #endregion

                #region Common
                palette.Common.StateCommon.Back.Color1 = lightestColour.BackColor;

                palette.Common.StateCommon.Back.Color2 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color1 = baseColour.BackColor;

                palette.Common.StateCommon.Border.Color2 = darkColour.BackColor;

                palette.Common.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;

                palette.Common.StateCommon.Content.LongText.Color1 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.LongText.Color2 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color1 = alternativeNormalTextColour.BackColor;

                palette.Common.StateCommon.Content.ShortText.Color2 = alternativeNormalTextColour.BackColor;
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

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = middleColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = lightColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color1 = disabledColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Back.Color2 = baseColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.LongText.Color1 = disabledTextColour.BackColor;

                palette.HeaderStyles.HeaderForm.StateDisabled.Content.ShortText.Color1 = disabledTextColour.BackColor;
                #endregion

                #region Label Styles
                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1 = linkNormalColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideNotVisited.ShortText.Color1 = linkNormalColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1 = linkHoverColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverridePressed.ShortText.Color1 = linkHoverColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1 = linkVisitedColour.BackColor;

                palette.LabelStyles.LabelNormalControl.OverrideVisited.ShortText.Color1 = linkVisitedColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.LongText.Color1 = disabledTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateDisabled.ShortText.Color1 = disabledTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.LongText.Color1 = normalTextColour.BackColor;

                palette.LabelStyles.LabelNormalControl.StateNormal.ShortText.Color1 = normalTextColour.BackColor;
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

                palette.Ribbon.RibbonGroupCollapsedText.StateCommon.TextColor = alternativeNormalTextColour.BackColor;

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

                palette.Ribbon.RibbonTab.StateCommon.TextColor = normalTextColour.BackColor;

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

                palette.ToolMenuStatus.MenuStrip.MenuStripText = normalTextColour.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = middleColour.BackColor;

                palette.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorDark = baseColour.BackColor;

                palette.ToolMenuStatus.Separator.SeparatorLight = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = baseColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.StatusStrip.StatusStripText = normalTextColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripBorder = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = middleColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = lightColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = darkColour.BackColor;

                palette.ToolMenuStatus.ToolStrip.ToolStripText = normalTextColour.BackColor;
                #endregion
            }

            palette.Export();

            statusState.Text = $"Palette exported to: { palette.GetCustomisedKryptonPaletteFilePath() }";
            //}
            //catch (Exception exc)
            //{
            //    statusState.Text = $"An error has occurred: { exc.Message }";
            //}
        }


        public static void PopulateColours(CircularPictureBox baseColour, CircularPictureBox darkColour, CircularPictureBox middleColour, CircularPictureBox lightColour, CircularPictureBox lightestColour, CircularPictureBox borderColour, CircularPictureBox alternativeNormalTextColour, CircularPictureBox normalTextColour, CircularPictureBox disabledTextColour, CircularPictureBox focusedTextColour, CircularPictureBox pressedTextColour, CircularPictureBox disabledColour, CircularPictureBox linkNormalColour, CircularPictureBox linkFocusedColour, CircularPictureBox linkHoverColour, CircularPictureBox linkVisitedColour, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColour, CircularPictureBox statusTextColour, CircularPictureBox ribbonTabTextColour)
        {
            try
            {

            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null);
            }
        }
        #endregion
    }
}