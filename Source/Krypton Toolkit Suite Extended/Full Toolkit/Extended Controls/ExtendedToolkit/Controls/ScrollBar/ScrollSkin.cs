using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.ScrollBar;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.ScrollBar
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.VScrollBar))]
    public class ScrollSkin : Panel
    {
        #region "   Members   "
        //private static List<WeakReference> __ENCList = new List<WeakReference>();

        [AccessedThroughProperty("_win")]
        private Control __win;

        [AccessedThroughProperty("VScrollBar1")]
        private CustomScroll.VScrollBar _VScrollBar1;

        [AccessedThroughProperty("HScrollBar1")]
        private CustomScroll.HScrollBar _HScrollBar1;

        private IContainer components;

        //public WIN32.ScrollInfo si;
        //public WIN32.ScrollInfo si2;



        private static IPalette _palette;
        private PaletteRedirect _paletteRedirect;
        #endregion

        #region "   Properties   "

        private WIN32.ScrollBarType _scrollBarVisibleType;
        public WIN32.ScrollBarType ScrollBarVisibleType
        {
            get
            {
                return this._scrollBarVisibleType;
            }

            set
            {
                this._scrollBarVisibleType = value;
            }
        }

        private Control _win
        {
            get
            {
                return this.__win;
            }
            set
            {
                this.__win = value;
            }
        }

        internal virtual CustomScroll.VScrollBar VScrollBar1
        {
            get
            {
                return this._VScrollBar1;
            }
            set
            {
                this._VScrollBar1 = value;
            }
        }

        internal virtual CustomScroll.HScrollBar HScrollBar1
        {
            get
            {
                return this._HScrollBar1;
            }
            set
            {
                this._HScrollBar1 = value;
            }
        }
        #endregion



        #region "   CTor   "
        public ScrollSkin()
        {
            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            //Init Colors
            CustomScroll.ControlPaint.InitColors(this, _palette);

            base.ControlAdded += new ControlEventHandler(this.scrollSkin_ControlAdded);
            //this._win = null;

            // This call is required by the Windows Form Designer.
            this.InitializeComponent();

        }

        public ScrollSkin(Control win)
        {

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            //Init Colors
            CustomScroll.ControlPaint.InitColors(this, _palette);

            base.ControlAdded += new ControlEventHandler(this.scrollSkin_ControlAdded);

            this._win = win;
            this.Controls.Add(win);

            // This call is required by the Windows Form Designer.
            this.InitializeComponent();

            // Fix the fake scrolling control to overlap the real scrollable control
            this.VScrollBar1.Size = new Size(0x12, this._win.Height);
            this.HScrollBar1.Size = new Size(this._win.Width, 0x12);

            this.Size = new Size(this._win.Width, this._win.Height);
            this.Location = new Point(this._win.Left, this._win.Top);
            this.Dock = this._win.Dock;
            this._win.Top = 0;
            this._win.Left = 0;
            this._win.SendToBack();
            this.Name = "skin" + this._win.Name;
        }

        #endregion

        #region "   Init   "
        private void InitializeComponent()
        {
            this.VScrollBar1 = new CustomScroll.VScrollBar();
            this.HScrollBar1 = new CustomScroll.HScrollBar();

            this.SuspendLayout();

            //this.VScrollBar1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right))); this.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar1.LargeChange = 10;
            this.VScrollBar1.Location = new Point(0x91, 0); // (145,0)
            this.VScrollBar1.Maximum = 100;
            this.VScrollBar1.Minimum = 0;
            this.VScrollBar1.MinimumSize = new Size(0x13, 15); //(19,15)
            this.VScrollBar1.Name = "VScrollBar1";
            this.VScrollBar1.Size = new Size(0x13, 0x7f);//(19,127)
            this.VScrollBar1.SmallChange = 1;
            this.VScrollBar1.TabIndex = 0;
            this.VScrollBar1.miScroll += VScrollBar1_miScroll;
            this.VScrollBar1.Visible = false;


            //this.HScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HScrollBar1.LargeChange = 10;
            this.HScrollBar1.Location = new Point(0, 0x6c);//(0,108)
            this.HScrollBar1.Maximum = 100;
            this.HScrollBar1.Minimum = 0;
            this.HScrollBar1.MinimumSize = new Size(15, 0x13);//(15,19)
            this.HScrollBar1.Name = "HScrollBar1";
            this.HScrollBar1.Size = new Size(0x96, 15);//(150,15)
            this.HScrollBar1.SmallChange = 1;
            this.HScrollBar1.TabIndex = 1;
            this.HScrollBar1.miScroll += HScrollBar1_miScroll;
            this.HScrollBar1.Visible = false;

            this.BackColor = Color.Transparent;

            this.Controls.Add(this.VScrollBar1);
            this.Controls.Add(this.HScrollBar1);

            this.Size = new Size(0xa4, 0x7f); //(164,127)
            this.ResumeLayout(false);

            if (_win != null)
                this.__win.Resize += win_Resize;

        }
        #endregion

        #region "   Scroll Related   "
        /// <summary>
        /// Linking the Scrollable control with Me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void scrollSkin_ControlAdded(object sender, ControlEventArgs e)
        {
            if ((this.Controls.Count != 1) && (_win == null))
            {
                this._win = e.Control;
            }
        }

        /// <summary>
        /// Comming from the customControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void VScrollBar1_miScroll(object sender, ScrollEventArgs e)
        {
            WIN32.PostMessageA(this._win.Handle, WIN32.WM_VSCROLL, WIN32.SB_THUMBPOSITION + (0x10000 * this.VScrollBar1.Value), 0);

            //previously explored:
            //SendMessage(_win.Handle, WM_VSCROLL, e.Type, 0)
        }
        private void HScrollBar1_miScroll(object sender, ScrollEventArgs e)
        {
            WIN32.PostMessageA(this._win.Handle, WIN32.WM_HSCROLL, WIN32.SB_THUMBPOSITION + (0x10000 * this.HScrollBar1.Value), 0);
        }

        /// <summary>
        /// Almost done move and resize the Scrollable control over Me 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void win_Resize(object sender, EventArgs e)
        {
            this.VScrollBar1.Size = new Size(0x12, this._win.Height); //for the gap 
            this.VScrollBar1.Left = this._win.Right - 0x12;

            //test code
            this.HScrollBar1.Size = new Size(this._win.Width, 0x12); //for the gap
            this.HScrollBar1.Top = this._win.Height - 0x12;

            this.Size = new Size(this._win.Width, this._win.Height);

            this._win.Top = 0;
            this._win.Left = 0;
        }

        /// <summary>
        /// Overrided to controll del scrolling of the customControl VScrollBar1
        /// </summary>
        /// <param name="m"></param>
        /// <remarks></remarks>
        protected override void WndProc(ref Message m)
        {
            if (!this.DesignMode && !(!this.Parent.CanFocus | (_win == null)))
            {

                int wndStyle = WIN32.GetWindowLong(this._win.Handle, WIN32.GWL_STYLE);
                bool hsVisible = (wndStyle & WIN32.WS_HSCROLL) != 0;
                bool vsVisible = (wndStyle & WIN32.WS_VSCROLL) != 0;

                //debug
                //Console.WriteLine("Visible ScrollBars: " + GetVisibleScrollbars(_win));
                //ShowScrollBar(this._win.Handle, (int)ScrollBarDirection.SB_HORZ, false /*false*/);


                //vertical
                if (true)// (vsVisible || hsVisible)
                {
                    int iWParam = (int)m.WParam;
                    int iLParam = (int)m.LParam;
                    uint sbCode = WIN32.LoWord(m.WParam);

                    if (sbCode == WIN32.SB_THUMBTRACK || sbCode == WIN32.SB_THUMBPOSITION)
                    {
                        WIN32.ScrollInfo siv = new WIN32.ScrollInfo();
                        siv.cbSize = Marshal.SizeOf(siv);
                        siv.fMask = (int)WIN32.ScrollInfoMask.SIF_ALL;
                        WIN32.ScrollInfo sih = siv;

                        uint nPos = WIN32.HiWord(m.WParam);


                        WIN32.GetScrollInfo(this._win.Handle, (int)WIN32.ScrollBarDirection.SB_VERT, ref siv);
                        WIN32.GetScrollInfo(this._win.Handle, (int)WIN32.ScrollBarDirection.SB_HORZ, ref sih);

                        if ((sih.nMax + 0) <= sih.nPage)
                        {
                            this.HScrollBar1.Visible = false;
                        }
                        else
                        {
                            this.HScrollBar1.Visible = true;
                            if (sih.nPage != 0)
                            {
                                this.HScrollBar1.Maximum = (sih.nMax - sih.nPage) + 1;
                                this.HScrollBar1.Minimum = sih.nMin;
                                this.HScrollBar1.Value = sih.nPos;
                                this.HScrollBar1.LargeChange = (int)Math.Round((double)(((double)sih.nMax) / ((double)sih.nPage)));
                                this.HScrollBar1.SyncThumbPositionWithLogicalValue();
                            }
                        }

                        if (vsVisible)
                        {
                            if ((siv.nMax + 0) < siv.nPage)
                            {
                                this.VScrollBar1.Visible = false;
                            }
                            else
                            {
                                this.VScrollBar1.Visible = true;
                                if (siv.nPage != 0)
                                {
                                    this.VScrollBar1.Maximum = (siv.nMax - siv.nPage) + 1;
                                    this.VScrollBar1.Minimum = siv.nMin;
                                    this.VScrollBar1.Value = siv.nPos;
                                    this.VScrollBar1.LargeChange = (int)Math.Round((double)(((double)siv.nMax) / ((double)siv.nPage)));
                                    this.VScrollBar1.SyncThumbPositionWithLogicalValue();
                                }
                            }
                        }
                    }
                }

            }
            base.WndProc(ref m);
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);
        }

        protected static ScrollBars GetVisibleScrollbars(Control ctl)
        {
            int wndStyle = WIN32.GetWindowLong(ctl.Handle, WIN32.GWL_STYLE);
            bool hsVisible = (wndStyle & WIN32.WS_HSCROLL) != 0;
            bool vsVisible = (wndStyle & WIN32.WS_VSCROLL) != 0;

            if (hsVisible)
                return vsVisible ? ScrollBars.Both : ScrollBars.Horizontal;
            else
                return vsVisible ? ScrollBars.Vertical : ScrollBars.None;
        }


        #endregion


        #region "   (Designer) Dispose   "
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            if (disposing)
            {
                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                    _palette = null;
                }

                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }
            base.Dispose(disposing);
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

                CustomScroll.ControlPaint.InitColors(this, _palette);
                VScrollBar1.RecreateImages();
                _HScrollBar1.RecreateImages();
            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        #endregion
    }
}