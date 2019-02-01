using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxBitmap(typeof(GroupBox))]
    public class KryptonGroupBox : GroupBox
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        #region ... Properties - Enum ...
        private Color _bgColor = Color.Gray;

        public enum BorderMode
        {
            None,
            Header,
            FullCustom,
            Full
        }

        private BorderMode _borderMode = BorderMode.FullCustom;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("FullCustom")]
        public BorderMode BorderStyle
        {
            get { return _borderMode; }
            set { _borderMode = value; Invalidate(); }
        }

        private FlatStyle _flatStyle = FlatStyle.Standard;
        public new FlatStyle FlatStyle
        {
            get { return _flatStyle; }
            set { _flatStyle = FlatStyle.Standard; Invalidate(); }
        }

        private Boolean _darkerColors = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("true")]
        public Boolean DarkerColours
        {
            get { return _darkerColors; }
            set { _darkerColors = value; Invalidate(); }
        }

        private Boolean _drawBottomLine = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean DrawBottomLine
        {
            get { return _drawBottomLine; }
            set { _drawBottomLine = value; Invalidate(); }
        }

        private Boolean _drawShadows = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean DrawShadows
        {
            get { return _drawShadows; }
            set { _drawShadows = value; Invalidate(); }
        }

        private Boolean _paintDefault = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean PaintDefault
        {
            get { return _paintDefault; }
            set { _paintDefault = value; Invalidate(); }
        }

        private Boolean _forceTransparent = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean ForceTransparent
        {
            get { return _forceTransparent; }
            set { _forceTransparent = value; Invalidate(); }
        }

        private Boolean _useAlternateForeColor = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean UseAlternateForeColour
        {
            get { return _useAlternateForeColor; }
            set { _useAlternateForeColor = value; Invalidate(); }
        }

        #endregion

        #region ... Constructor ...
        public KryptonGroupBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();


        }
        #endregion

        private void InitColors()
        {
            if (this.BackColor == Color.Transparent) _forceTransparent = true;
            //set BackGroudColor
            _bgColor = _palette.ColorTable.ToolStripGradientMiddle;

            //if darker ..., reset background
            if (_darkerColors) _bgColor = _palette.ColorTable.MenuStripGradientEnd;

            //set ForeColor
            if (!_useAlternateForeColor)
            {
                this.ForeColor = _palette.ColorTable.StatusStripText;
            }
            else
            {
                this.ForeColor = _palette.ColorTable.MenuItemText;
            }

            //reset FlatStyle
            if (this.FlatStyle == FlatStyle.System) this.FlatStyle = FlatStyle.Standard;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_paintDefault || this._borderMode == BorderMode.Full) base.OnPaint(e);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //paint deafult
            base.OnPaintBackground(e);

            //call to reset colors
            InitColors();

            //transparent
            if (_forceTransparent)
            {
                this.BackColor = Color.Transparent;
                _bgColor = Color.Transparent;
                //_paintDefault = true;
            }

            //paint BackGround
            if (!_paintDefault)
            {
                //Fill Color
                e.Graphics.FillRectangle(new SolidBrush(_bgColor), e.ClipRectangle);

                // set Size
                Size sz = TextRenderer.MeasureText(Text, Font);

                switch (_borderMode)
                {
                    case BorderMode.Full:
                        break;

                    case BorderMode.FullCustom:
                        //text
                        TextRenderer.DrawText(e.Graphics, Text, Font, new Point(6, 0), ForeColor);
                        sz = TextRenderer.MeasureText(Text, Font);

                        //draw top line
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                            new Point(sz.Width + 6, sz.Height / 2 + 1),
                            new Point(Width - 3, sz.Height / 2 + 1));

                        //draw top shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                new Point(sz.Width + 6, sz.Height / 2 + 2),
                                new Point(Width - 3, sz.Height / 2 + 2));
                        }

                        //draw bottom line
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                                new Point(0 + 2, this.Height - 3),
                                new Point(this.Width - 3, this.Height - 3));

                        //draw bottom shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                   new Point(0 + 2, this.Height - 3 - 1),
                                   new Point(this.Width - 3, this.Height - 3 - 1));
                        }

                        //draw right
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                                new Point(Width - 2, sz.Height / 2 + 2),
                                new Point(this.Width - 2, this.Height - 4));

                        //draw right shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                    new Point(Width - 3, sz.Height / 2 + 2),
                                    new Point(this.Width - 3, this.Height - 4));
                        }

                        //draw left
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                                new Point(0 + 1, sz.Height / 2 + 2),
                                new Point(0 + 1, this.Height - 4));

                        //draw left shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                    new Point(0 + 2, sz.Height / 2 + 2),
                                    new Point(0 + 2, this.Height - 4));
                        }


                        //draw smallchunk
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                                new Point(0 + 2, sz.Height / 2 + 1),
                                new Point(0 + 5, sz.Height / 2 + 1));

                        //draw smallchunk shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                    new Point(0 + 3, sz.Height / 2 + 2),
                                    new Point(0 + 5, sz.Height / 2 + 2));
                        }

                        break;

                    case BorderMode.Header:
                        //text
                        TextRenderer.DrawText(e.Graphics, Text, Font, new Point(6, 0), ForeColor);
                        sz = TextRenderer.MeasureText(Text, Font);

                        //draw top line
                        e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                            new Point(sz.Width + 5, sz.Height / 2 + 1),
                            new Point(Width - 3, sz.Height / 2 + 1));

                        //draw shadow
                        if (_drawShadows)
                        {
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                new Point(sz.Width + 6, sz.Height / 2 + 2),
                                new Point(Width - 2, sz.Height / 2 + 2));
                        }

                        if (_drawBottomLine)
                        {
                            //draw bottom line
                            e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripDark),
                                new Point(0 + 1, this.Height - 3),
                                new Point(this.Width - 3, this.Height - 3));

                            //draw shadow
                            if (_drawShadows)
                            {
                                e.Graphics.DrawLine(new Pen(_palette.ColorTable.GripLight),
                                    new Point(0 + 2, this.Height - 3 + 1),
                                    new Point(this.Width - 2, this.Height - 3 + 1));
                            }
                        }
                        break;

                    case BorderMode.None:
                        //text
                        TextRenderer.DrawText(e.Graphics, Text, Font, new Point(6, 0), ForeColor);
                        sz = TextRenderer.MeasureText(Text, Font);
                        break;

                }

            }
        }

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

                InitColors();

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