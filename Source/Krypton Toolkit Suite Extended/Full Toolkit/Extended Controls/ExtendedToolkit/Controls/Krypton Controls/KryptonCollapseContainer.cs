#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(Panel)), System.ComponentModel.DefaultProperty("HeaderText")]
    public partial class KryptonCollapseContainer : Panel
    {
        #region System
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonCollapseContainer));
            this.imgButtons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButtons.Images.SetKeyName(0, "Arrow_Up.ico");
            this.imgButtons.Images.SetKeyName(1, "Arrow_Down.ico");
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imgButtons;
        #endregion

        #region " Variables"
        // Colors
        private Color _BorderColour = Color.FromArgb(101, 147, 207);
        private Color _NormalLightColour = Color.FromArgb(227, 239, 255);
        private Color _NormalDarkColour = Color.FromArgb(214, 232, 255);
        private Color _RollOverLightColour = Color.White;
        private Color _RollOverDarkColour = Color.FromArgb(227, 239, 255);

        //Palette
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        private bool _MouseOver = false;

        //private bool _NoCheckControllAdded;

        private int _HeaderHeight = 20;
        private string _HeaderText;
        private Panel _ContentHider;

        private bool _Collapsable = true;
        private bool _PanelOpen = true;
        private int _OpenHeight;
        #endregion

        #region " Control New"
        public KryptonCollapseContainer()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            base.FontChanged += new EventHandler(this.CollapseContainer_FontChanged);
            base.Paint += new PaintEventHandler(this.CollapseContainer_Paint);
            base.SizeChanged += new EventHandler(this.CollapseContainer_SizeChanged);
            base.MouseMove += new MouseEventHandler(this.CollapseContainer_MouseMove);
            base.MouseLeave += new EventHandler(this.CollapseContainer_MouseLeave);
            base.Click += new EventHandler(this.CollapseContainer_Click);


            // Add any initialization after the InitializeComponent() call.
            this.BackColor = System.Drawing.SystemColors.Control;
            _HeaderText = this.Name.ToString();

            // When the CollapseContainer is docked-filled - we cant really change it's height can we?
            // So...instead of altering its height property, we have to 'fake it' by covering up any controls
            // the user may have placed inside the panel (we could have created a collection to grab the visible property of all controls
            // added to the container - then turning them all to false when hidden...and restoring them when opened up again
            // but I didnt want the overhead involved in this
            _ContentHider = new Panel();
            _ContentHider.Dock = DockStyle.Fill;
            _ContentHider.Visible = false;

            //_NoCheckControllAdded = true;
            this.Controls.Add(_ContentHider);
            //_NoCheckControllAdded = false;

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            //set colors
            _BorderColour = _palette.ColorTable.ButtonSelectedBorder;
            _NormalLightColour = _palette.ColorTable.ToolStripGradientBegin;
            _NormalDarkColour = _palette.ColorTable.ToolStripGradientEnd;
            _RollOverLightColour = Color.White;
            _RollOverDarkColour = _palette.ColorTable.ToolStripGradientEnd;


            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        #endregion

        #region "   Properties   "

        /// <summary>
        /// This returns the height of the control when it's fully opened
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int OpenHeight
        {
            get { return _OpenHeight; }
            set { _OpenHeight = value; }
        }


        /// <summary>
        /// The text to be displayed in the control
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string HeaderText
        {
            get { return _HeaderText; }
            set
            {
                _HeaderText = value;
                this.Refresh();
            }
        }


        /// <summary>
        /// If true, the control can be collapsed.  If false, it cannot
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool Collapsable
        {
            get { return _Collapsable; }
            set
            {
                _Collapsable = value;
                this.Refresh();
            }
        }

        /// <summary>
        /// Sets or returns the current panels open or closed status
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [RefreshProperties(RefreshProperties.All)]
        public bool PanelOpen
        {
            get { return _PanelOpen; }
            set
            {
                _PanelOpen = value;

                // If the user has collapsed the control in the designer - force Collapsable to true
                if (!_PanelOpen)
                {
                    this.Collapsable = true;
                }
                SetContentPanel();
            }
        }

        /// <summary>
        /// Override this to simulate the header panel
        /// Notice I leave one pixel at the bottom for the bottom line :)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public override System.Drawing.Rectangle DisplayRectangle
        {
            get
            {
                Padding myPadding = this.Padding;
                Rectangle myClientRect = new Rectangle(0 + myPadding.Left, _HeaderHeight + myPadding.Top, this.Width - myPadding.Right, (this.Height - (_HeaderHeight + 1)) - myPadding.Bottom);
                return myClientRect;
                //Return MyBase.DisplayRectangle
            }
        }

        #endregion



        #region "   Methods   "
        /// <summary>
        /// If the user changes the header font - resize the header area and refresh the controls layout engine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CollapseContainer_FontChanged(object sender, System.EventArgs e)
        {
            _HeaderHeight = (int)((Control)sender).Font.Size + 11;
            if (!_PanelOpen)
            {
                this.Height = _HeaderHeight;
            }

            // Recalc our layout
            this.PerformLayout();
        }


        /// <summary>
        /// The primary purpose of trapping the Paint is to add the seperator bar - but since we're trapping the entire paint event, 
        /// we need to fill in the backcolor as well
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CollapseContainer_Paint(object sender, PaintEventArgs e)
        {

            if (_palette == null)
            {
                EventArgs Ev = new EventArgs();
                OnGlobalPaletteChanged(this, Ev);
            }

            if (_PanelOpen) _OpenHeight = this.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, Bounds.Width, Bounds.Height);


            // Paint my background
            e.Graphics.FillRectangle(Brushes.White, 0, 0, Bounds.Width, Bounds.Height);

            // Setup our colors
            Color SepColor = _palette.ColorTable.SeparatorDark; //Color.FromArgb(173, 209, 255);
            Color ColorLight = _palette.ColorTable.ToolStripGradientBegin; // Color.FromArgb(226, 238, 255);
            Color ColorDark = _palette.ColorTable.ToolStripGradientMiddle; //Color.FromArgb(214, 232, 255);

            if (_MouseOver)
            {
                ColorDark = ColorLight;
                ColorLight = Color.White;
            }

            Rectangle HeaderRect = new Rectangle(0, 0, Bounds.Width, _HeaderHeight);
            LinearGradientBrush HeaderBrush = new LinearGradientBrush(HeaderRect, Color.White, Color.White, LinearGradientMode.Horizontal);
            HeaderBrush.WrapMode = WrapMode.TileFlipX;
            HeaderBrush.SetSigmaBellShape(0.1F);

            // Set the gradient colors
            ColorBlend cb = new ColorBlend(3);

            // The Positions properties tell the gradient where to change colors
            // For this panel - our gradient is horizontal - so our positions are along the horizontal axis
            // the 1st position is 0 - the very beginning of the gradient and we should be at the 1st color
            // the 2nd position is 0.5 which means at 50% of the WIDTH of the gradient, we should be on the 2nd color
            // the 3rd position is 1.0 which means at 100% of the WIDTH of the graidne we should be on the 3rd color

            // Far left color (when horizontal) - this would be the Far Top color if Vertical
            cb.Positions[0] = 0;
            cb.Colors[0] = ColorDark;

            // Middle color
            cb.Positions[1] = 0.5F;
            cb.Colors[1] = ColorLight;

            // Far right color (or bottom)
            cb.Positions[2] = 1;
            cb.Colors[2] = ColorDark;

            HeaderBrush.InterpolationColors = cb;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingMode = CompositingMode.SourceOver;
            e.Graphics.FillRectangle(HeaderBrush, HeaderRect);

            // Draw our button
            if (_Collapsable)
            {
                int ButtonY = (int)(_HeaderHeight / 2) - (imgButtons.Images[0].Height / 2);
                if (_PanelOpen)
                {
                    // Display the Up Arrows
                    e.Graphics.DrawImage(imgButtons.Images[0], Bounds.Width - 15, ButtonY);
                }
                else
                {
                    // Display the Down Arrows
                    e.Graphics.DrawImage(imgButtons.Images[1], Bounds.Width - 15, ButtonY);
                }
            }

            // Draw the borders (if not dock-filled)
            e.Graphics.DrawLine(new Pen(SepColor), 0, _HeaderHeight - 1, Bounds.Width, _HeaderHeight - 1);

            // Setup to draw the text (Font, Alignment, etc. etc.)
            Font ActiveFont = new Font(Font.FontFamily, Font.Size, Font.Style);
            StringFormat TextFormat = new StringFormat();
            SolidBrush FontBrush = new SolidBrush(_palette.ColorTable.StatusStripText);
            TextFormat.FormatFlags = StringFormatFlags.NoWrap;
            TextFormat.Trimming = StringTrimming.EllipsisCharacter;
            TextFormat.Alignment = StringAlignment.Near;
            TextFormat.LineAlignment = StringAlignment.Center;

            // Draw the font - but do it with style :)
            Rectangle FontBounds = new Rectangle(10, 2, Bounds.Width, _HeaderHeight - 2);
            FontBounds.X = 10;
            FontBounds.Y = 2;
            FontBounds.Width = Bounds.Width;
            FontBounds.Height = _HeaderHeight - 2;

            GraphicsPath TextGraphicsPath = new GraphicsPath();
            try
            {
                //TextGraphicsPath.AddString(_HeaderText, ActiveFont.FontFamily, ActiveFont.Style, ActiveFont.Size + 3, FontBounds, TextFormat)
                //e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.DrawString(_HeaderText, ActiveFont, FontBrush, FontBounds, TextFormat);
                //e.Graphics.FillPath(FontBrush, TextGraphicsPath)

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            TextGraphicsPath.Dispose();
            TextGraphicsPath = null;
            ActiveFont.Dispose();
            ActiveFont = null;
            TextFormat.Dispose();
            TextFormat = null;
            //FontBounds = null;




            // Draw the bottom Seperator line (if we're not dock-filled)
            if (this.Dock != DockStyle.Fill)
            {
                e.Graphics.DrawLine(new Pen(_palette.ColorTable.SeparatorDark), 0, Bounds.Height - 1, Bounds.Width, Bounds.Height - 1);
            }
        }

        /// <summary>
        /// When our size changes, we'll get ghosting from the custom lines - so to ensure the lines are drawn properly, we force a refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        [RefreshProperties(RefreshProperties.All)]
        private void CollapseContainer_SizeChanged(object sender, System.EventArgs e)
        {
            this.Refresh();
        }
        #endregion



        #region " HeaderPanel"

        /// <summary>
        /// We're only interested in lighting up the header when the control is collapsable
        /// We also only want to light up the header - if it's not ALREADY lit up...this prevents blinking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CollapseContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Collapsable)
            {
                if (e.Y > 0 & e.Y < 21)
                {
                    if (!_MouseOver)
                    {
                        _MouseOver = true;
                        this.Cursor = Cursors.Hand;
                        this.Refresh();
                    }
                }
                else
                {
                    if (_MouseOver)
                    {
                        _MouseOver = false;
                        this.Cursor = Cursors.Default;
                        this.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// If we're collapsable and the header was lit - go turn it off and refresh the painting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CollapseContainer_MouseLeave(object sender, System.EventArgs e)
        {
            if (_Collapsable)
            {
                _MouseOver = false;
                this.Refresh();
            }
        }

        /// <summary>
        /// If we're collapsable and the user clicked...toggle the collapse state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CollapseContainer_Click(object sender, System.EventArgs e)
        {
            if (_Collapsable)
            {
                _PanelOpen = (_PanelOpen == false);
                SetContentPanel();
            }
        }

        /// <summary>
        /// Adjusts the Height of the control based on the _PanelOpen settings
        /// </summary>
        /// <remarks></remarks>
        private void SetContentPanel()
        {
            if (_PanelOpen)
            {
                if (this.Dock == DockStyle.Fill)
                {
                    _ContentHider.Visible = false;
                }
                else
                {
                    this.Height = this.OpenHeight;
                }
            }
            else
            {
                if (this.Dock == DockStyle.Fill)
                {
                    _ContentHider.Visible = true;
                    _ContentHider.BringToFront();
                }
                else
                {
                    _OpenHeight = this.Height;
                    this.Height = _HeaderHeight;
                }
            }
            this.Refresh();
        }


        #endregion

        #region ... Krypton ...
        //Kripton Palette Events
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                //set colors
                _BorderColour = _palette.ColorTable.ButtonSelectedBorder;
                _NormalLightColour = _palette.ColorTable.ToolStripGradientBegin;
                _NormalDarkColour = _palette.ColorTable.ToolStripGradientEnd;
                _RollOverLightColour = Color.White;
                _RollOverDarkColour = _palette.ColorTable.ToolStripGradientEnd;
            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }
        #endregion

        #region " Hidden Properties"
        [Browsable(false)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        [Browsable(false)]
        public override bool AllowDrop
        {
            get { return base.AllowDrop; }
            set { base.AllowDrop = value; }
        }

        [Browsable(false)]
        public override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        [Browsable(false)]
        public override System.Drawing.Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }

        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout
        {
            get { return base.BackgroundImageLayout; }
            set { base.BackgroundImageLayout = value; }
        }

        #endregion

    }

}