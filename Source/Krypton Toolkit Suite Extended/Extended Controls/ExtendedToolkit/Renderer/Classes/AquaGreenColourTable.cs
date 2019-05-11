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
    /// Provide Office 2007 Blue Theme colors
    /// </summary>
    public class AquaGreenColorTable : ProfessionalColourTable
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
            rgbTable[KnownColours.ContextMenuItem] = Color.DarkGreen;
            rgbTable[KnownColours.ContextMenuItemText] = Color.DarkGreen;
            rgbTable[KnownColours.GripDark] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.GripLight] = Color.FromArgb(151, 219, 181);
            rgbTable[KnownColours.ImageMarginGradientBegin] = Color.FromArgb(239, 239, 239);
            rgbTable[KnownColours.MenuBorder] = Color.FromArgb(46, 122, 87);
            rgbTable[KnownColours.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.MenuItemPressedGradientBegin] = Color.FromArgb(242, 248, 244);
            rgbTable[KnownColours.MenuItemPressedGradientEnd] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.MenuItemPressedGradientMiddle] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColours.MenuItemSelected] = Color.FromArgb(255, 238, 194);
            rgbTable[KnownColours.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColours.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
            rgbTable[KnownColours.MenuItemText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.MenuStripGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColours.MenuStripGradientEnd] = Color.FromArgb(189, 219, 202);
            rgbTable[KnownColours.OverflowButtonGradientBegin] = Color.FromArgb(68, 202, 115);
            rgbTable[KnownColours.OverflowButtonGradientEnd] = Color.FromArgb(46, 122, 87);
            rgbTable[KnownColours.OverflowButtonGradientMiddle] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.RaftingContainerGradientBegin] = Color.FromArgb(83, 83, 83);
            rgbTable[KnownColours.RaftingContainerGradientEnd] = Color.FromArgb(83, 83, 83);
            rgbTable[KnownColours.SeparatorDark] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.SeparatorLight] = Color.FromArgb(151, 219, 181);
            rgbTable[KnownColours.StatusStripGradientBegin] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.StatusStripGradientEnd] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.StatusStripText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.ToolStripBorder] = Color.FromArgb(46, 122, 87);
            rgbTable[KnownColours.ToolStripContentPanelGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColours.ToolStripContentPanelGradientEnd] = Color.FromArgb(189, 219, 202);
            rgbTable[KnownColours.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColours.ToolStripGradientBegin] = Color.FromArgb(242, 248, 244);
            rgbTable[KnownColours.ToolStripGradientEnd] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColours.ToolStripGradientMiddle] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColours.ToolStripPanelGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColours.ToolStripPanelGradientEnd] = Color.FromArgb(189, 219, 202);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}