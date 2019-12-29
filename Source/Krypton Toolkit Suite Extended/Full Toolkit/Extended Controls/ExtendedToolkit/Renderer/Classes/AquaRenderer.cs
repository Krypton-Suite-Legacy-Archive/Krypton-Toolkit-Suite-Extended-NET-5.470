#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
	/// Draw ToolStrips using the Office 2007 themed appearance.
	/// </summary>
	public class AquaRenderer : ToolStripProfessionalRenderer
    {
        #region FieldsPrivate

        private static int m_iMarginInset = 2;

        #endregion

        #region MethodsPublic
        /// <summary>
        /// Initialize a new instance of the Office2007Renderer class.
        /// </summary>
        public AquaRenderer() : base(new Office2007BlueColourTable())
        {
        }
        /// <summary>
        /// Initializes a new instance of the AquaRenderer class.
        /// </summary>
        /// <param name="professionalColourTable">A <see cref="ProfessionalColourTable"/> to be used for painting.</param>
        public AquaRenderer(ProfessionalColourTable professionalColourTable)
            : base(professionalColourTable)
        {
        }
        #endregion

        #region MethodsProtected
        /// <summary>
        /// Raises the RenderArrow event.
        /// </summary>
        /// <param name="e">A ToolStripArrowRenderEventArgs that contains the event data.</param>
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            ProfessionalColourTable colourTable = ColorTable as ProfessionalColourTable;
            if (colourTable != null)
            {
                if ((e.Item.Owner.GetType() == typeof(MenuStrip)) && (e.Item.Selected == false) && e.Item.Pressed == false)
                {
                    if (colourTable.MenuItemText != Color.Empty)
                    {
                        e.ArrowColor = colourTable.MenuItemText;
                    }
                }
                if ((e.Item.Owner.GetType() == typeof(StatusStrip)) && (e.Item.Selected == false) && e.Item.Pressed == false)
                {
                    if (colourTable.StatusStripText != Color.Empty)
                    {
                        e.ArrowColor = colourTable.StatusStripText;
                    }
                }
            }
            base.OnRenderArrow(e);
        }
        /// <summary>
        /// Raises the RenderItemText event.
        /// </summary>
        /// <param name="e">A ToolStripItemTextRenderEventArgs that contains the event data.</param>
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            ProfessionalColourTable colourTable = ColorTable as ProfessionalColourTable;
            if (colourTable != null)
            {
                if ((e.ToolStrip is MenuStrip) && (e.Item.Selected == false) && e.Item.Pressed == false)
                {
                    if (colourTable.MenuItemText != Color.Empty)
                    {
                        e.TextColor = colourTable.MenuItemText;
                    }
                }
                if ((e.ToolStrip is StatusStrip) && (e.Item.Selected == false) && e.Item.Pressed == false)
                {
                    if (colourTable.StatusStripText != Color.Empty)
                    {
                        e.TextColor = colourTable.StatusStripText;
                    }
                }
            }
            base.OnRenderItemText(e);
        }
        /// <summary>
        /// Raises the RenderToolStripContentPanelBackground event. 
        /// </summary>
        /// <param name="e">An ToolStripContentPanelRenderEventArgs containing the event data.</param>
        protected override void OnRenderToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs e)
        {
            // Must call base class, otherwise the subsequent drawing does not appear!
            base.OnRenderToolStripContentPanelBackground(e);

            // Cannot paint a zero sized area
            if ((e.ToolStripContentPanel.Width > 0) &&
                (e.ToolStripContentPanel.Height > 0))
            {
                using (LinearGradientBrush backBrush = new LinearGradientBrush(e.ToolStripContentPanel.ClientRectangle,
                                                                               ColorTable.ToolStripContentPanelGradientBegin,
                                                                               ColorTable.ToolStripContentPanelGradientEnd,
                                                                               LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(backBrush, e.ToolStripContentPanel.ClientRectangle);
                }
            }
        }
        /// <summary>
        /// Raises the RenderSeparator event. 
        /// </summary>
        /// <param name="e">An ToolStripSeparatorRenderEventArgs containing the event data.</param>
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            e.Item.ForeColor = ColorTable.RaftingContainerGradientBegin;
            base.OnRenderSeparator(e);
        }
        /// <summary>
        /// Raises the RenderToolStripBackground event. 
        /// </summary>
        /// <param name="e">An ToolStripRenderEventArgs containing the event data.</param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            ToolStrip toolStrip = e.ToolStrip;
            if (toolStrip is StatusStrip)
            {
                RectangleF backRectangle = new RectangleF(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);

                // Cannot paint a zero sized area
                if ((backRectangle.Width > 0) && (backRectangle.Height > 0))
                {
                    using (LinearGradientBrush outerLinearGradientBrush = new LinearGradientBrush(
                        backRectangle,
                        ColorTable.StatusStripGradientBegin,
                        ColorTable.StatusStripGradientEnd,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(outerLinearGradientBrush, backRectangle); //draw top bubble
                    }

                    RectangleF innerRectangle = backRectangle;
                    innerRectangle.Height = 10;

                    using (LinearGradientBrush innerRectangleBrush = new LinearGradientBrush(
                    innerRectangle,
                    Color.FromArgb(255, Color.White),
                    Color.FromArgb(32, Color.White),
                    LinearGradientMode.Vertical))
                    {
                        //
                        // draw shapes
                        //
                        e.Graphics.FillRectangle(innerRectangleBrush, innerRectangle); //draw top bubble
                    }
                }
            }
            else
            {
                base.OnRenderToolStripBackground(e);
            }
        }
        /// <summary>
        /// Raises the RenderImageMargin event. 
        /// </summary>
        /// <param name="e">An ToolStripRenderEventArgs containing the event data.</param>
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            if ((e.ToolStrip is ContextMenuStrip) ||
                (e.ToolStrip is ToolStripDropDownMenu))
            {
                // Start with the total margin area
                Rectangle marginRectangle = e.AffectedBounds;

                // Do we need to draw with separator on the opposite edge?
                bool bIsRightToLeft = (e.ToolStrip.RightToLeft == RightToLeft.Yes);

                marginRectangle.Y += m_iMarginInset;
                marginRectangle.Height -= m_iMarginInset * 2;

                // Reduce so it is inside the border
                if (bIsRightToLeft == false)
                {
                    marginRectangle.X += m_iMarginInset;
                }
                else
                {
                    marginRectangle.X += m_iMarginInset / 2;
                }

                // Draw the entire margine area in a solid color
                using (SolidBrush backBrush = new SolidBrush(
                    ColorTable.ImageMarginGradientBegin))
                    e.Graphics.FillRectangle(backBrush, marginRectangle);
            }
            else
            {
                base.OnRenderImageMargin(e);
            }
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}