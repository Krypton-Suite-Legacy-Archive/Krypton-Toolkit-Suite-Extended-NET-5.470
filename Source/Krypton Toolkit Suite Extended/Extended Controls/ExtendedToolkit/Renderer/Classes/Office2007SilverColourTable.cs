#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Collections.Generic;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
    /// Provide Office 2007 Silver Theme colors
    /// </summary>
    public class Office2007SilverColourTable : ProfessionalColourTable
    {
        #region FieldsPrivate
        #endregion

        #region Properties

        #endregion

        #region MethodsPublic
        #endregion

        #region MethodsProtected
        /// <summary>
        /// initialize a color Dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected override void InitColours(ref Dictionary<KnownColours, Color> rgbTable)
        {
            rgbTable[KnownColours.ButtonPressedGradientBegin] = Color.FromArgb(248, 181, 106);
            rgbTable[KnownColours.ButtonPressedGradientEnd] = Color.FromArgb(255, 208, 134);
            rgbTable[KnownColours.ButtonPressedGradientMiddle] = Color.FromArgb(251, 140, 60);
            rgbTable[KnownColours.ButtonSelectedBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.ButtonSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColours.ButtonSelectedGradientEnd] = Color.FromArgb(255, 219, 117);
            rgbTable[KnownColours.ButtonSelectedGradientMiddle] = Color.FromArgb(255, 232, 116);
            rgbTable[KnownColours.ButtonSelectedHighlightBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.CheckBackground] = Color.FromArgb(255, 227, 149);
            rgbTable[KnownColours.CheckSelectedBackground] = Color.FromArgb(254, 128, 62);
            rgbTable[KnownColours.ContextMenuItem] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.ContextMenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.GripDark] = Color.FromArgb(84, 84, 117);
            rgbTable[KnownColours.GripLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.ImageMarginGradientBegin] = Color.FromArgb(239, 239, 239);
            rgbTable[KnownColours.MenuBorder] = Color.FromArgb(124, 124, 148);
            rgbTable[KnownColours.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.MenuItemPressedGradientBegin] = Color.FromArgb(232, 233, 241);
            rgbTable[KnownColours.MenuItemPressedGradientEnd] = Color.FromArgb(186, 185, 205);
            rgbTable[KnownColours.MenuItemPressedGradientMiddle] = Color.FromArgb(209, 209, 223);
            rgbTable[KnownColours.MenuItemSelected] = Color.FromArgb(255, 238, 194);
            rgbTable[KnownColours.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColours.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
            rgbTable[KnownColours.MenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.MenuStripGradientBegin] = Color.FromArgb(215, 215, 229);
            rgbTable[KnownColours.MenuStripGradientEnd] = Color.FromArgb(243, 243, 247);
            rgbTable[KnownColours.OverflowButtonGradientBegin] = Color.FromArgb(179, 178, 200);
            rgbTable[KnownColours.OverflowButtonGradientEnd] = Color.FromArgb(118, 116, 146);
            rgbTable[KnownColours.OverflowButtonGradientMiddle] = Color.FromArgb(152, 151, 177);
            rgbTable[KnownColours.RaftingContainerGradientBegin] = Color.FromArgb(215, 215, 229);
            rgbTable[KnownColours.RaftingContainerGradientEnd] = Color.FromArgb(243, 243, 247);
            rgbTable[KnownColours.SeparatorDark] = Color.FromArgb(110, 109, 143);
            rgbTable[KnownColours.SeparatorLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.StatusStripGradientBegin] = Color.FromArgb(235, 238, 250);
            rgbTable[KnownColours.StatusStripGradientEnd] = Color.FromArgb(197, 199, 209);
            rgbTable[KnownColours.StatusStripText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.ToolStripBorder] = Color.FromArgb(124, 124, 148);
            rgbTable[KnownColours.ToolStripContentPanelGradientBegin] = Color.FromArgb(207, 211, 220);
            rgbTable[KnownColours.ToolStripContentPanelGradientEnd] = Color.FromArgb(207, 211, 220); Color.FromArgb(155, 159, 166);
            rgbTable[KnownColours.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColours.ToolStripGradientBegin] = Color.FromArgb(243, 244, 250);
            rgbTable[KnownColours.ToolStripGradientEnd] = Color.FromArgb(153, 151, 181);
            rgbTable[KnownColours.ToolStripGradientMiddle] = Color.FromArgb(218, 219, 231);
            rgbTable[KnownColours.ToolStripPanelGradientBegin] = Color.FromArgb(215, 215, 229);
            rgbTable[KnownColours.ToolStripPanelGradientEnd] = Color.FromArgb(243, 243, 247);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}