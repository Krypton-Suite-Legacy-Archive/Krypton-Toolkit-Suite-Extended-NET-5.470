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
    /// Provide Red Theme colors
    /// </summary>
    public class ColourTableRed : ProfessionalColourTable
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
            rgbTable[KnownColours.ButtonSelectedGradientMiddle] = Color.FromArgb(255, 231, 162);
            rgbTable[KnownColours.ButtonSelectedHighlightBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.CheckBackground] = Color.FromArgb(255, 227, 149);
            rgbTable[KnownColours.CheckSelectedBackground] = Color.FromArgb(254, 128, 62);
            rgbTable[KnownColours.ContextMenuItem] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.ContextMenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.GripDark] = Color.FromArgb(226, 116, 116);
            rgbTable[KnownColours.GripLight] = Color.FromArgb(237, 182, 183);
            rgbTable[KnownColours.ImageMarginGradientBegin] = Color.FromArgb(250, 232, 233);
            rgbTable[KnownColours.MenuBorder] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColours.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.MenuItemPressedGradientBegin] = Color.FromArgb(250, 234, 233);
            rgbTable[KnownColours.MenuItemPressedGradientEnd] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColours.MenuItemPressedGradientMiddle] = Color.FromArgb(228, 145, 144);
            rgbTable[KnownColours.MenuItemSelected] = Color.FromArgb(255, 238, 194);
            rgbTable[KnownColours.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColours.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
            rgbTable[KnownColours.MenuItemText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.MenuStripGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColours.MenuStripGradientEnd] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColours.OverflowButtonGradientBegin] = Color.FromArgb(250, 232, 233);
            rgbTable[KnownColours.OverflowButtonGradientEnd] = Color.FromArgb(234, 130, 131);
            rgbTable[KnownColours.OverflowButtonGradientMiddle] = Color.FromArgb(234, 170, 170);
            rgbTable[KnownColours.RaftingContainerGradientBegin] = Color.FromArgb(234, 200, 200);
            rgbTable[KnownColours.RaftingContainerGradientEnd] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColours.SeparatorDark] = Color.FromArgb(226, 116, 116);
            rgbTable[KnownColours.SeparatorLight] = Color.FromArgb(237, 182, 183);
            rgbTable[KnownColours.StatusStripGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColours.StatusStripGradientEnd] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColours.StatusStripText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.ToolStripBorder] = Color.FromArgb(160, 0, 0);
            rgbTable[KnownColours.ToolStripContentPanelGradientBegin] = Color.FromArgb(250, 232, 233);
            rgbTable[KnownColours.ToolStripContentPanelGradientEnd] = Color.FromArgb(228, 146, 146);
            rgbTable[KnownColours.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColours.ToolStripGradientBegin] = Color.FromArgb(255, 180, 180);
            rgbTable[KnownColours.ToolStripGradientEnd] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColours.ToolStripGradientMiddle] = Color.FromArgb(255, 100, 100);
            rgbTable[KnownColours.ToolStripPanelGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColours.ToolStripPanelGradientEnd] = Color.FromArgb(192, 0, 0);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}