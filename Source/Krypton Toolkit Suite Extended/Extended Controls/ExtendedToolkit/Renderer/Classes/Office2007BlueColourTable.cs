using System.Collections.Generic;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
    /// Provide Office 2007 Blue Theme colors
    /// </summary>
    public class Office2007BlueColourTable : ProfessionalColourTable
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
            rgbTable[KnownColours.ContextMenuItem] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColours.ContextMenuItemText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColours.GripDark] = Color.FromArgb(111, 157, 217);
            rgbTable[KnownColours.GripLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.ImageMarginGradientBegin] = Color.FromArgb(233, 238, 238);
            rgbTable[KnownColours.MenuBorder] = Color.FromArgb(134, 134, 134);
            rgbTable[KnownColours.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColours.MenuItemPressedGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColours.MenuItemPressedGradientEnd] = Color.FromArgb(152, 186, 230);
            rgbTable[KnownColours.MenuItemPressedGradientMiddle] = Color.FromArgb(222, 236, 255);
            rgbTable[KnownColours.MenuItemSelected] = Color.FromArgb(255, 238, 194);
            rgbTable[KnownColours.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColours.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
            rgbTable[KnownColours.MenuItemText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColours.MenuStripGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.MenuStripGradientEnd] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.OverflowButtonGradientBegin] = Color.FromArgb(167, 204, 251);
            rgbTable[KnownColours.OverflowButtonGradientEnd] = Color.FromArgb(101, 147, 207);
            rgbTable[KnownColours.OverflowButtonGradientMiddle] = Color.FromArgb(167, 204, 251);
            rgbTable[KnownColours.RaftingContainerGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.RaftingContainerGradientEnd] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.SeparatorDark] = Color.FromArgb(173, 209, 255);
            rgbTable[KnownColours.SeparatorLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColours.StatusStripGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColours.StatusStripGradientEnd] = Color.FromArgb(173, 209, 255);
            rgbTable[KnownColours.StatusStripText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColours.ToolStripBorder] = Color.FromArgb(111, 157, 217);
            rgbTable[KnownColours.ToolStripContentPanelGradientBegin] = Color.FromArgb(191, 219, 255); //Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.ToolStripContentPanelGradientEnd] = Color.FromArgb(191, 219, 255); //Color.FromArgb(101, 145, 205);
            rgbTable[KnownColours.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColours.ToolStripGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColours.ToolStripGradientEnd] = Color.FromArgb(152, 186, 230);
            rgbTable[KnownColours.ToolStripGradientMiddle] = Color.FromArgb(222, 236, 255);
            rgbTable[KnownColours.ToolStripPanelGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColours.ToolStripPanelGradientEnd] = Color.FromArgb(191, 219, 255);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}