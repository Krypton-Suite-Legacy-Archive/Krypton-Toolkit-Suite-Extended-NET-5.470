using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
    /// Provides colors used for Microsoft Office display elements.
    /// </summary>
    public class ProfessionalColourTable : ProfessionalColorTable
    {
        #region Enums
        /// <summary>
        /// Gets or sets the KnownColors appearance of the ProfessionalColorTable.
        /// </summary>
        public enum KnownColours
        {
            /// <summary>
            /// The starting color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientBegin,
            /// <summary>
            /// The border color to use with the ButtonSelectedGradientBegin,
            /// ButtonSelectedGradientMiddle,
            /// and ButtonSelectedGradientEnd colors.
            /// </summary>
            ButtonSelectedBorder,
            /// <summary>
            /// The end color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientMiddle,
            /// <summary>
            /// The border color to use with ButtonSelectedHighlight.
            /// </summary>
            ButtonSelectedHighlightBorder,
            /// <summary>
            /// The solid color to use when the check box is selected and gradients are being used.
            /// </summary>
            CheckBackground,
            /// <summary>
            /// The solid color to use when the check box is selected and gradients are being used.
            /// </summary>
			CheckSelectedBackground,
            /// <summary>
            /// The text color of a top-level ContextMenuItem.
            /// </summary>
            ContextMenuItem,
            /// <summary>
            /// The text color of a top-level ContextMenuItemText.
            /// </summary>
            ContextMenuItemText,
            /// <summary>
            /// The color to use for shadow effects on the grip or move handle.
            /// </summary>
            GripDark,
            /// <summary>
            /// The color to use for highlight effects on the grip or move handle.
            /// </summary>
            GripLight,
            /// <summary>
            /// The starting color of the gradient used in the image margin
            /// of a ToolStripDropDownMenu.
            /// </summary>
            ImageMarginGradientBegin,
            /// <summary>
            /// The border color or a MenuStrip.
            /// </summary>
            MenuBorder,
            /// <summary>
            /// The border color to use with a ToolStripMenuItem.
            /// </summary>
            MenuItemBorder,
            /// <summary>
            /// The starting color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientMiddle,
            /// <summary>
            /// The text color of a top-level ToolStripMenuItem.
            /// </summary>
            MenuItemText,
            /// <summary>
            /// The solid color to use when a ToolStripMenuItem other
            /// than the top-level ToolStripMenuItem is selected.
            /// </summary>
			MenuItemSelected,
            /// <summary>
            /// The starting color of the gradient used when the ToolStripMenuItem is selected.
            /// </summary>
			MenuItemSelectedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when the ToolStripMenuItem is selected.
            /// </summary>
            MenuItemSelectedGradientEnd,
            /// <summary>
            /// The starting color of the gradient used in the MenuStrip.
            /// </summary>
            MenuStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the MenuStrip.
            /// </summary>
            MenuStripGradientEnd,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientEnd,
            /// <summary>
            /// The middle color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripContainer.
            /// </summary>
            RaftingContainerGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripContainer.
            /// </summary>
            RaftingContainerGradientEnd,
            /// <summary>
            /// The color to use to for shadow effects on the ToolStripSeparator.
            /// </summary>
            SeparatorDark,
            /// <summary>
            /// The color to use to for highlight effects on the ToolStripSeparator.
            /// </summary>
            SeparatorLight,
            /// <summary>
            /// The starting color of the gradient used on the StatusStrip.
            /// </summary>
            StatusStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used on the StatusStrip.
            /// </summary>
            StatusStripGradientEnd,
            /// <summary>
            /// The text color used on the StatusStrip.
            /// </summary>
			StatusStripText,
            /// <summary>
            /// The border color to use on the bottom edge of the ToolStrip.
            /// </summary>
            ToolStripBorder,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripContentPanel.
            /// </summary>
            ToolStripContentPanelGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripContentPanel.
            /// </summary>
            ToolStripContentPanelGradientEnd,
            /// <summary>
            /// The solid background color of the ToolStripDropDown.
            /// </summary>
            ToolStripDropDownBackground,
            /// <summary>
            /// The starting color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientEnd,
            /// <summary>
            /// The middle color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripPanel.
            /// </summary>
            ToolStripPanelGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripPanel.
            /// </summary>
            ToolStripPanelGradientEnd,
            /// <summary>
            /// 
            /// </summary>
            LastKnownColor = SeparatorLight
        }

        #endregion

        #region FieldsPrivate

        private bool m_bUseProfessionalColors;
        private Dictionary<KnownColours, Color> m_dictionaryRGBTable;
        private object m_colorFreshnessKey;
        [ThreadStatic]
        private static object m_objColorFreshnessKey;


        #endregion

        #region Properties
        #region Properties

        public virtual Color ContextMenuItem
        {
            get { return this.FromKnownColour(KnownColours.ContextMenuItem); }
        }
        public virtual Color ContextMenuItemText
        {
            get { return this.FromKnownColour(KnownColours.ContextMenuItemText); }
        }
        #endregion

        /// <summary>
        /// Gets the starting color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonPressedGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonPressedGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonPressedGradientMiddle);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedBorder
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonSelectedBorder);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonSelectedGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonSelectedGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonSelectedGradientMiddle);
            }
        }

        /// <summary>
        /// Gets the border color to use with ButtonSelectedHighlight.
        /// </summary>
        public override Color ButtonSelectedHighlightBorder
        {
            get
            {
                return this.FromKnownColour(KnownColours.ButtonSelectedHighlightBorder);
            }
        }
        /// <summary>
        /// Gets the solid color to use when the check box is selected and gradients are being used.
        /// </summary>
        public override Color CheckBackground
        {
            get
            {
                return this.FromKnownColour(KnownColours.CheckBackground);
            }
        }
        /// <summary>
        /// Gets the solid color to use when the check box is selected and gradients are being used.
        /// </summary>
        public override Color CheckSelectedBackground
        {
            get
            {
                return this.FromKnownColour(KnownColours.CheckSelectedBackground);
            }
        }

        /// <summary>
        /// Gets the color to use for shadow effects on the grip or move handle.
        /// </summary>
        public override Color GripDark
        {
            get
            {
                return this.FromKnownColour(KnownColours.GripDark);
            }
        }
        /// <summary>
        /// Gets the color to use for highlight effects on the grip or move handle.
        /// </summary>
        public override Color GripLight
        {
            get
            {
                return this.FromKnownColour(KnownColours.GripLight);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the image margin of a ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ImageMarginGradientBegin);
            }
        }
        /// <summary>
        /// Gets the border color or a MenuStrip.
        /// </summary>
        public override Color MenuBorder
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuBorder);
            }
        }
        /// <summary>
        /// Gets the border color to use with a ToolStripMenuItem.
        /// </summary>
        public override Color MenuItemBorder
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemBorder);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemPressedGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemPressedGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemPressedGradientMiddle);
            }
        }
        /// <summary>
        /// Gets the solid color to use when a ToolStripMenuItem other than the top-level ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelected
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemSelected);
            }
        }
        /// <summary>
        /// Gets the text color of a top-level ToolStripMenuItem.
        /// </summary>
        public virtual Color MenuItemText
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemText);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemSelectedGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuItemSelectedGradientEnd);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuStripGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.MenuStripGradientEnd);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.OverflowButtonGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.OverflowButtonGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return this.FromKnownColour(KnownColours.OverflowButtonGradientMiddle);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripContainer.
        /// </summary>
        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.RaftingContainerGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripContainer.
        /// </summary>
        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.RaftingContainerGradientEnd);
            }
        }
        /// <summary>
        /// Gets the color to use to for shadow effects on the ToolStripSeparator.
        /// </summary>
        public override Color SeparatorDark
        {
            get
            {
                return this.FromKnownColour(KnownColours.SeparatorDark);
            }
        }
        /// <summary>
        /// Gets the color to use to for highlight effects on the ToolStripSeparator.
        /// </summary>
        public override Color SeparatorLight
        {
            get
            {
                return this.FromKnownColour(KnownColours.SeparatorLight);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used on the StatusStrip.
        /// </summary>
        public override Color StatusStripGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.StatusStripGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used on the StatusStrip.
        /// </summary>
        public override Color StatusStripGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.StatusStripGradientEnd);
            }
        }
        /// <summary>
        /// Gets the text color used on the StatusStrip.
        /// </summary>
        public virtual Color StatusStripText
        {
            get
            {
                return this.FromKnownColour(KnownColours.StatusStripText);
            }
        }
        /// <summary>
        /// Gets the border color to use on the bottom edge of the ToolStrip.
        /// </summary>
        public override Color ToolStripBorder
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripBorder);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripContentPanel.
        /// </summary>
        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripContentPanelGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripContentPanel.
        /// </summary>
        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripContentPanelGradientEnd);
            }
        }
        /// <summary>
        /// Gets the solid background color of the ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripDropDownBackground);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientMiddle
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripGradientMiddle);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripPanel.
        /// </summary>
        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripPanelGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripPanel.
        /// </summary>
        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return this.FromKnownColour(KnownColours.ToolStripPanelGradientEnd);
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether to use the extended colors.
        /// </summary>
        public bool UseProfessionalColours
        {
            get { return this.m_bUseProfessionalColors; }
            set
            {
                if (value.Equals(this.m_bUseProfessionalColors) == false)
                {
                    this.m_bUseProfessionalColors = value;
                    if (this.m_dictionaryRGBTable != null)
                    {
                        this.m_dictionaryRGBTable.Clear();
                        this.m_dictionaryRGBTable = null;
                    }
                }
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether to use System.Drawing.SystemColors rather than colors that match the current visual style.
        /// </summary>
        public new bool UseSystemColours
        {
            get { return base.UseSystemColors; }
            set
            {
                if (value.Equals(base.UseSystemColors) == false)
                {
                    base.UseSystemColors = value;
                    if (this.m_dictionaryRGBTable != null)
                    {
                        this.m_dictionaryRGBTable.Clear();
                        this.m_dictionaryRGBTable = null;
                    }
                }
            }
        }
        internal static object ColourFreshnessKey
        {
            get
            {
                return m_objColorFreshnessKey;
            }
        }
        public Color FromKnownColour(KnownColours colour)
        {
            return (Color)this.ColourTable[colour];
        }

        public Dictionary<KnownColours, Color> ColourTable
        {
            get
            {
                if (ProfessionalColourTable.ColourFreshnessKey != this.m_colorFreshnessKey)
                {
                    if (this.m_dictionaryRGBTable != null)
                    {
                        this.m_dictionaryRGBTable.Clear();
                    }
                    this.m_dictionaryRGBTable = null;
                }
                this.m_colorFreshnessKey = ProfessionalColourTable.ColourFreshnessKey;
                if (this.m_dictionaryRGBTable == null)
                {
                    this.m_dictionaryRGBTable = new Dictionary<KnownColours, Color>(0xd4);
                    if ((this.UseSystemColours == true) ||
                        (this.m_bUseProfessionalColors == true) ||
                        (DisplayInformation.IsLunaTheme == false) && (DisplayInformation.IsAeroTheme == false))
                    {
                        InitBaseColours(ref m_dictionaryRGBTable);
                    }
                    else
                    {
                        InitColours(ref this.m_dictionaryRGBTable);
                    }
                }
                return this.m_dictionaryRGBTable;
            }
        }

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Initialize a new instance of the ProfessionalColorTable class.
        /// </summary>
        public ProfessionalColourTable()
        {
            Microsoft.Win32.SystemEvents.UserPreferenceChanged += new Microsoft.Win32.UserPreferenceChangedEventHandler(SystemEventsUserPreferenceChanged);
        }

        #endregion

        #region MethodsProtected
        /// <summary>
        /// Initialize a color Dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected virtual void InitColours(ref Dictionary<KnownColours, Color> rgbTable)
        {
            InitBaseColours(ref rgbTable);
        }
        #endregion

        #region MethodsPrivate

        private void InitBaseColours(ref Dictionary<KnownColours, Color> rgbTable)
        {
            rgbTable[KnownColours.ButtonPressedGradientBegin] = base.ButtonPressedGradientBegin;
            rgbTable[KnownColours.ButtonPressedGradientEnd] = base.ButtonPressedGradientEnd;
            rgbTable[KnownColours.ButtonPressedGradientMiddle] = base.ButtonPressedGradientMiddle;
            rgbTable[KnownColours.ButtonSelectedBorder] = base.ButtonSelectedBorder;
            rgbTable[KnownColours.ButtonSelectedGradientBegin] = base.ButtonSelectedGradientBegin;
            rgbTable[KnownColours.ButtonSelectedGradientEnd] = base.ButtonSelectedGradientEnd;
            rgbTable[KnownColours.ButtonSelectedGradientMiddle] = base.ButtonSelectedGradientMiddle;
            rgbTable[KnownColours.ButtonSelectedHighlightBorder] = base.ButtonSelectedHighlightBorder;
            rgbTable[KnownColours.CheckBackground] = base.CheckBackground;
            rgbTable[KnownColours.CheckSelectedBackground] = base.CheckSelectedBackground;
            rgbTable[KnownColours.ContextMenuItem] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.ContextMenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.GripDark] = base.GripDark;
            rgbTable[KnownColours.GripLight] = base.GripLight;
            rgbTable[KnownColours.ImageMarginGradientBegin] = base.ImageMarginGradientBegin;
            rgbTable[KnownColours.MenuBorder] = base.MenuBorder;
            rgbTable[KnownColours.MenuItemBorder] = base.MenuItemBorder;
            rgbTable[KnownColours.MenuItemPressedGradientBegin] = base.MenuItemPressedGradientBegin;
            rgbTable[KnownColours.MenuItemPressedGradientEnd] = base.MenuItemPressedGradientEnd;
            rgbTable[KnownColours.MenuItemPressedGradientMiddle] = base.MenuItemPressedGradientMiddle;
            rgbTable[KnownColours.MenuItemSelected] = base.MenuItemSelected;
            rgbTable[KnownColours.MenuItemSelectedGradientBegin] = base.MenuItemSelectedGradientBegin;
            rgbTable[KnownColours.MenuItemSelectedGradientEnd] = base.MenuItemSelectedGradientEnd;
            rgbTable[KnownColours.MenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.MenuStripGradientBegin] = base.MenuStripGradientBegin;
            rgbTable[KnownColours.MenuStripGradientEnd] = base.MenuStripGradientEnd;
            rgbTable[KnownColours.OverflowButtonGradientBegin] = base.OverflowButtonGradientBegin;
            rgbTable[KnownColours.OverflowButtonGradientEnd] = base.OverflowButtonGradientEnd;
            rgbTable[KnownColours.OverflowButtonGradientMiddle] = base.OverflowButtonGradientMiddle;
            rgbTable[KnownColours.RaftingContainerGradientBegin] = base.RaftingContainerGradientBegin;
            rgbTable[KnownColours.RaftingContainerGradientEnd] = base.RaftingContainerGradientEnd;
            rgbTable[KnownColours.SeparatorDark] = base.SeparatorDark;
            rgbTable[KnownColours.SeparatorLight] = base.SeparatorLight;
            rgbTable[KnownColours.StatusStripGradientBegin] = base.StatusStripGradientBegin;
            rgbTable[KnownColours.StatusStripGradientEnd] = base.StatusStripGradientEnd;
            rgbTable[KnownColours.StatusStripText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColours.ToolStripBorder] = base.ToolStripBorder;
            rgbTable[KnownColours.ToolStripContentPanelGradientBegin] = base.ToolStripContentPanelGradientBegin;
            rgbTable[KnownColours.ToolStripContentPanelGradientEnd] = base.ToolStripContentPanelGradientEnd;
            rgbTable[KnownColours.ToolStripDropDownBackground] = base.ToolStripDropDownBackground;
            rgbTable[KnownColours.ToolStripGradientBegin] = base.ToolStripGradientBegin;
            rgbTable[KnownColours.ToolStripGradientEnd] = base.ToolStripGradientEnd;
            rgbTable[KnownColours.ToolStripGradientMiddle] = base.ToolStripGradientMiddle;
            rgbTable[KnownColours.ToolStripPanelGradientBegin] = base.ToolStripPanelGradientBegin;
            rgbTable[KnownColours.ToolStripPanelGradientEnd] = base.ToolStripPanelGradientEnd;
        }

        private static void SystemEventsUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            m_objColorFreshnessKey = new object();
        }

        #endregion
    }
}