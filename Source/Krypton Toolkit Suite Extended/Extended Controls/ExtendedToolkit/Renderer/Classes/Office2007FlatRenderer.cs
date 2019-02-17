using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    /// <summary>
    /// Draw ToolStrips using the Office 2007 themed appearance.
    /// </summary>
    public class Office2007FlatRenderer : ToolStripProfessionalRenderer
    {
        #region FieldsPrivate

        private static int m_iMarginInset = 2;
        private static Blend m_statusStripBlend;
        private bool m_bUseNetProfessionalColors;

        #endregion

        #region Properties

        private bool UseNetProfessionalColors
        {
            get
            {
                ProfessionalColourTable colourTable = ColorTable as ProfessionalColourTable;
                if (colourTable != null)
                {
                    this.m_bUseNetProfessionalColors = colourTable.UseProfessionalColours;
                }
                return this.m_bUseNetProfessionalColors;
            }
            set
            {
                if (value.Equals(this.m_bUseNetProfessionalColors) == false)
                {
                    this.m_bUseNetProfessionalColors = value;
                }
            }
        }

        #endregion

        #region MethodsPublic
        static Office2007FlatRenderer()
        {
            // One time creation of the blend for the status strip gradient brush
            m_statusStripBlend = new Blend();
            m_statusStripBlend.Positions = new float[] { 0.0F, 0.2F, 0.3F, 0.4F, 0.8F, 1.0F };
            m_statusStripBlend.Factors = new float[] { 0.3F, 0.4F, 0.5F, 1.0F, 0.8F, 0.7F };
        }
        /// <summary>
        /// Initialize a new instance of the Office2007Renderer class.
        /// </summary>
		public Office2007FlatRenderer()
            : base(new System.Windows.Forms.ProfessionalColorTable())
        {
            this.ColorTable.UseSystemColors = false;
            this.m_bUseNetProfessionalColors = true;
        }
        /// <summary>
        /// Initializes a new instance of the Office2007Renderer class.
        /// </summary>
        /// <param name="professionalColourTable">A <see cref="BSE.Windows.Forms.ProfessionalColorTable"/> to be used for painting.</param>
        public Office2007FlatRenderer(ProfessionalColourTable professionalColourTable)
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
            if ((ColorTable.UseSystemColors == false) && (this.UseNetProfessionalColors == false))
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
            }
            base.OnRenderArrow(e);
        }
        /// <summary>
        /// Raises the RenderItemText event.
        /// </summary>
        /// <param name="e">A ToolStripItemTextRenderEventArgs that contains the event data.</param>
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if ((ColorTable.UseSystemColors == false) && (this.UseNetProfessionalColors == false))
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
            if ((ColorTable.UseSystemColors == false) && (this.UseNetProfessionalColors == false))
            {
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
        }
        /// <summary>
        /// Raises the RenderSeparator event. 
        /// </summary>
        /// <param name="e">An ToolStripSeparatorRenderEventArgs containing the event data.</param>
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if ((ColorTable.UseSystemColors == false) && (this.UseNetProfessionalColors == false))
            {
                e.Item.ForeColor = ColorTable.RaftingContainerGradientBegin;
            }
            base.OnRenderSeparator(e);
        }
        /// <summary>
        /// Raises the RenderToolStripBackground event. 
        /// </summary>
        /// <param name="e">An ToolStripRenderEventArgs containing the event data.</param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if ((ColorTable.UseSystemColors == true) || (this.UseNetProfessionalColors == true))
            {
                base.OnRenderToolStripBackground(e);
            }
            else
            {
                if (e.ToolStrip is StatusStrip)
                {
                    // We do not paint the top two pixel lines, so are drawn by the status strip border render method
                    //RectangleF backRectangle = new RectangleF(0, 1.5f, e.ToolStrip.Width, e.ToolStrip.Height - 2);
                    RectangleF backRectangle = new RectangleF(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);

                    // Cannot paint a zero sized area
                    if ((backRectangle.Width > 0) && (backRectangle.Height > 0))
                    {
                        using (LinearGradientBrush backBrush = new LinearGradientBrush(backRectangle,
                                                                                       ColorTable.StatusStripGradientBegin,
                                                                                       ColorTable.StatusStripGradientEnd,
                                                                                       LinearGradientMode.Vertical))
                        {
                            backBrush.Blend = m_statusStripBlend;
                            e.Graphics.FillRectangle(backBrush, backRectangle);
                        }
                    }
                }
                else
                {
                    base.OnRenderToolStripBackground(e);
                }
            }
        }
        /// <summary>
        /// Raises the RenderImageMargin event. 
        /// </summary>
        /// <param name="e">An ToolStripRenderEventArgs containing the event data.</param>
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            if ((ColorTable.UseSystemColors == true) || (this.UseNetProfessionalColors == true))
            {
                base.OnRenderToolStripBackground(e);
            }
            else
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
                    {
                        e.Graphics.FillRectangle(backBrush, marginRectangle);
                    }
                }
                else
                {
                    base.OnRenderImageMargin(e);
                }
            }
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}