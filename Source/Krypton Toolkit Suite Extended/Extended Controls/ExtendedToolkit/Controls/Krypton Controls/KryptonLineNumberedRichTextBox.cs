#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [DefaultProperty("ParentRichTextBox")]
    public class KryptonLineNumberedRichTextBox : Control
    {
        #region Classes
        private class LineNumberItem
        {
            internal int _lineNumber;

            internal Rectangle _rectangle;

            internal LineNumberItem(int lineNumber, Rectangle rect)
            {
                _lineNumber = lineNumber;

                _rectangle = rect;
            }
        }
        #endregion

        #region Enumerations
        public enum LineNumberDockSide : byte
        {
            NONE = 0,
            LEFT = 1,
            RIGHT = 2,
            HEIGHT = 4
        }
        #endregion

        #region Variables
        private bool _autoSizing = true, _parentIsScrolling = false, _seeThroughMode = false, _gradient_Show = true, _gridLinesShow = true, _borderLinesShow = true, _borderLines_Show = true, _marginLines_Show = true, _lineNumbers_Show = true, _lineNumbers_ShowLeading_Zeros = true, _lineNumbers_ShowAsHexadecimal = false, _lineNumbers_ClipByItemRectangle = true, _lineNumbers_AntiAlias = true;
        private ContentAlignment _lineNumberAlignment = ContentAlignment.TopRight;
        private Size _autoSizingSize = new Size(0, 0), _lineNumbersOffset = new Size(0, 0);
        private LineNumberDockSide _dockSide = LineNumberDockSide.LEFT, _marginLineSide = LineNumberDockSide.RIGHT;
        private LinearGradientMode _gradientMode = LinearGradientMode.Horizontal;
        private Color _blockColour, _startColour = Color.FromArgb(0, 0, 0, 0), _endColour = Color.FromArgb(246, 240, 230), _marginLinesColour = Color.SlateGray, _gridLinesColour = Color.SlateGray, _borderLinesColour = Color.SlateGray, _lineNumberTextColour;
        private DashStyle _gridLinesStyle = DashStyle.Dot, _borderLinesStyle = DashStyle.Dot, _marginLinesStyle = DashStyle.Solid;
        private float _gridLineThickness = 1, _borderLineThickness = 1, _marginLineThickness = 1;
        private KryptonRichTextBox _parent = null;
        private KryptonPalette _palette;
        private Rectangle _contentRectangle;
        private Timer _timer = new Timer();
        private string _lineNumberFormat = "0";
        private List<LineNumberItem> _lineNumberItems = new List<LineNumberItem>();
        private Point _pointInParent = new Point(0, 0), _pointInMe = new Point(0, 0);
        private int _parentInMe = 0;
        #endregion

        #region Properties  
        [System.ComponentModel.Description("Use this property to automatically resi_e the control (and reposition it if needed).")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool AutoSizing
        {
            get { return _autoSizing; }
            set
            {
                _autoSizing = value;
                this.Refresh();
                this.Invalidate();
            }
        }

        //[System.ComponentModel.Description("Use this property to enable LineNumbers for the chosen RichTextBox.")]
        //[System.ComponentModel.Category("Add LineNumbers to")]
        //public RichTextBox ParentRichTextBox
        //{
        //    get { return _Parent; }
        //    set
        //    {
        //        _Parent = value;
        //        if (_Parent != null)
        //        {
        //            this.Parent = _Parent.Parent;
        //            _Parent.Refresh();
        //        }
        //        this.Text = "";
        //        this.Refresh();
        //        this.Invalidate();
        //    }
        //}

        [System.ComponentModel.Description("Use this property to dock the LineNumbers to a chosen side of the chosen RichTextBox.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public LineNumberDockSide DockSide
        {
            get { return _dockSide; }
            set
            {
                _dockSide = value;
                this.Refresh();
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this property to enable the control to act as an overlay ontop of the RichTextBox.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool SeeThroughMode
        {
            get { return _seeThroughMode; }
            set
            {
                _seeThroughMode = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("BorderLines are shown on all sides of the LineNumber control.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool ShowBorderLines
        {
            get { return _borderLinesShow; }
            set
            {
                _borderLinesShow = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public Color BorderLinesColour
        {
            get { return _borderLinesColour; }
            set
            {
                _borderLinesColour = value;
                this.Invalidate();
            }
        }

        [Category("Additional Appearance")]
        public Color BlockColour
        {
            get => _blockColour;

            set
            {
                _blockColour = value;

                Invalidate();
            }
        }

        [Category("Additional Appearance")]
        public Color LineNumberTextColour
        {
            get => _lineNumberTextColour;

            set
            {
                _lineNumberTextColour = value;

                Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public float BorderLinesThickness
        {
            get { return _borderLineThickness; }
            set
            {
                _borderLineThickness = Math.Max(1, Math.Min(255, value));
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public System.Drawing.Drawing2D.DashStyle BorderLinesStyle
        {
            get { return _borderLinesStyle; }
            set
            {
                if (value == System.Drawing.Drawing2D.DashStyle.Custom)
                    value = System.Drawing.Drawing2D.DashStyle.Solid;
                _borderLinesStyle = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("GridLines are the horizontal divider-lines shown above each LineNumber.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool ShowGridLines
        {
            get { return _gridLinesShow; }
            set
            {
                _gridLinesShow = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public Color GridLinesColour
        {
            get { return _gridLinesColour; }
            set
            {
                _gridLinesColour = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public float GridLinesThickness
        {
            get { return _gridLineThickness; }
            set
            {
                _gridLineThickness = Math.Max(1, Math.Min(255, value));
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public System.Drawing.Drawing2D.DashStyle GridLinesStyle
        {
            get { return _gridLinesStyle; }
            set
            {
                if (value == System.Drawing.Drawing2D.DashStyle.Custom)
                    value = System.Drawing.Drawing2D.DashStyle.Solid;
                _gridLinesStyle = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("MarginLines are shown on the Left or Right (or both in Height-mode) of the LineNumber control.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool ShowMarginLines
        {
            get { return _marginLines_Show; }
            set
            {
                _marginLines_Show = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public LineNumberDockSide MarginLinesSide
        {
            get { return _marginLineSide; }
            set
            {
                _marginLineSide = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public Color MarginLinesColour
        {
            get { return _marginLinesColour; }
            set
            {
                _marginLinesColour = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public float MarginLinesThickness
        {
            get { return _marginLineThickness; }
            set
            {
                _marginLineThickness = Math.Max(1, Math.Min(255, value));
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public System.Drawing.Drawing2D.DashStyle MarginLinesStyle
        {
            get { return _marginLinesStyle; }
            set
            {
                if (value == System.Drawing.Drawing2D.DashStyle.Custom)
                    value = System.Drawing.Drawing2D.DashStyle.Solid;
                _marginLinesStyle = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("The BackgroundGradient is a gradual blend of two colors, shown in the back of each LineNumber's item-area.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool ShowBackgroundGradient
        {
            get { return _gradient_Show; }
            set
            {
                _gradient_Show = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public Color BackgroundGradientAlphaColour
        {
            get { return _startColour; }
            set
            {
                _startColour = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public Color BackgroundGradientBetaColour
        {
            get { return _endColour; }
            set
            {
                _endColour = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Appearance")]
        public System.Drawing.Drawing2D.LinearGradientMode BackgroundGradientDirection
        {
            get { return _gradientMode; }
            set
            {
                _gradientMode = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Additional Behavior")]
        public bool Show_lineNrs
        {
            get { return _lineNumbers_Show; }
            set
            {
                _lineNumbers_Show = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this to set whether the LineNumbers are allowed to spill out of their item-area, or should be clipped by it.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool LineNrs_ClippedByItemRectangle
        {
            get { return _lineNumbers_ClipByItemRectangle; }
            set
            {
                _lineNumbers_ClipByItemRectangle = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this to set whether the LineNumbers should have leading _eroes (based on the total amount of textlines).")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool LineNrs_leading_Zeroes
        {
            get { return _lineNumbers_ShowLeading_Zeros; }
            set
            {
                _lineNumbers_ShowLeading_Zeros = value;
                this.Refresh();
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this to set whether the LineNumbers should be shown as hexadecimal values.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool LineNrs_AsHexadecimal
        {
            get { return _lineNumbers_ShowAsHexadecimal; }
            set
            {
                _lineNumbers_ShowAsHexadecimal = value;
                this.Refresh();
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this property to manually reposition the LineNumbers, relative to their current location.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public Size LineNrs_Offset
        {
            get { return _lineNumbersOffset; }
            set
            {
                _lineNumbersOffset = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this to align the LineNumbers to a chosen corner (or center) within their item-area.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public System.Drawing.ContentAlignment LineNrs_Alignment
        {
            get { return _lineNumberAlignment; }
            set
            {
                _lineNumberAlignment = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Description("Use this to apply Anti-Aliasing to the LineNumbers (high quality). Some fonts will look better without it, though.")]
        [System.ComponentModel.Category("Additional Behavior")]
        public bool LineNrs_AntiAlias
        {
            get { return _lineNumbers_AntiAlias; }
            set
            {
                _lineNumbers_AntiAlias = value;
                this.Refresh();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the parent container of the control.
        /// </summary>
        public KryptonRichTextBox ParentRichTextBox
        {
            get => _parent;

            set
            {
                if (_parent != null)
                {
                    _parent.LocationChanged -= Parent_Changed;

                    _parent.Move -= Parent_Changed;

                    _parent.Resize -= Parent_Changed;

                    _parent.DockChanged -= Parent_Changed;

                    _parent.TextChanged -= Parent_Changed;

                    _parent.MultilineChanged -= Parent_Changed;

                    _parent.HScroll -= Parent_Scroll;

                    _parent.VScroll -= Parent_Scroll;

                    _parent.RichTextBox.ContentsResized -= Parent_ContentsResized;

                    _parent.Disposed -= Parent_Disposed;
                }

                _parent = value;

                if (_parent != null)
                {
                    _parent.LocationChanged += Parent_Changed;

                    _parent.Move += Parent_Changed;

                    _parent.Resize += Parent_Changed;

                    _parent.DockChanged += Parent_Changed;

                    _parent.TextChanged += Parent_Changed;

                    _parent.MultilineChanged += Parent_Changed;

                    _parent.HScroll += Parent_Scroll;

                    _parent.VScroll += Parent_Scroll;

                    _parent.RichTextBox.ContentsResized += Parent_ContentsResized;

                    _parent.Disposed += Parent_Disposed;
                }
            }
        }

        public Timer Timer
        {
            get => _timer;

            set
            {
                if (_timer != null)
                {
                    _timer.Tick -= Timer_Tick;
                }

                _timer = value;

                if (_timer != null)
                {
                    _timer.Tick += Timer_Tick;
                }
            }
        }
        #endregion

        #region Constructor
        public KryptonLineNumberedRichTextBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            InitialiseColours();

            Margin = new Padding(0);

            Padding = new Padding(0, 0, 2, 0);

            _timer.Enabled = true;

            _timer.Interval = 200;

            _timer.Start();

            UpdateSizeAndPosition();

            Invalidate();
        }
        #endregion

        #region Overrides
        [Browsable(false)]
        public override bool AutoSize
        {
            get => base.AutoSize;
            set
            {
                base.AutoSize = value;

                Invalidate();
            }
        }

        [Browsable(true)]
        public override Font Font
        {
            get => base.Font;

            set
            {
                base.Font = value;

                Refresh();

                Invalidate();
            }
        }

        [AmbientValue(""), DefaultValue(""), Browsable(false)]
        public override string Text
        {
            get => base.Text;

            set
            {
                base.Text = "";


                Invalidate();
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            AutoSize = true;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (DesignMode)
            {
                Refresh();
            }

            base.OnSizeChanged(e);

            Invalidate();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            if (DesignMode)
            {
                Refresh();
            }

            base.OnLocationChanged(e);

            Invalidate();
        }

        public override void Refresh()
        {
            base.Refresh();

            UpdateSizeAndPosition();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateVisibleLineNumberItems();

            base.OnPaint(e);

            if (_lineNumbers_AntiAlias)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            }
            else
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
            }

            string textToShow = "", reminderToShow = "";

            StringFormat stringFormat = new StringFormat();

            SizeF textSize = default(SizeF);

            Pen pen = new Pen(ForeColor);

            SolidBrush brush = new SolidBrush(ForeColor);

            Point point = new Point(0, 0);

            Rectangle itemClipRectangle = new Rectangle(0, 0, 0, 0);

            GraphicsPath gpGridLines = new GraphicsPath(FillMode.Winding), gpBorderLines = new GraphicsPath(FillMode.Winding), gpMarginLines = new GraphicsPath(FillMode.Winding), gpLineNumbers = new GraphicsPath(FillMode.Winding);

            Region region = new Region(ClientRectangle);

            if (DesignMode)
            {
                if (ParentRichTextBox == null)
                {
                    reminderToShow = "-!- Set ParentRichTextBox -!-";
                }
                else
                {
                    if (_lineNumberItems.Count == 0)
                    {
                        reminderToShow = $"LineNrs ( { ParentRichTextBox.Name } )";
                    }
                }

                if (reminderToShow.Length > 0)
                {
                    e.Graphics.TranslateTransform(Width / 2, Height / 2);

                    e.Graphics.RotateTransform(-90);

                    stringFormat.Alignment = StringAlignment.Center;

                    stringFormat.LineAlignment = StringAlignment.Center;

                    textSize = e.Graphics.MeasureString(reminderToShow, Font, point, stringFormat);

                    e.Graphics.DrawString(reminderToShow, Font, Brushes.WhiteSmoke, 1, 1, stringFormat);

                    e.Graphics.DrawString(reminderToShow, Font, Brushes.Firebrick, 0, 0, stringFormat);

                    e.Graphics.ResetTransform();

                    Rectangle reminderRectangle = new Rectangle((int)(Width / 2 - textSize.Height / 2), (int)(Height / 2 - textSize.Width / 2), (int)(textSize.Height), (int)(textSize.Width));

                    gpLineNumbers.AddRectangle(reminderRectangle);

                    gpLineNumbers.CloseFigure();

                    if (_autoSizing)
                    {
                        reminderRectangle.Inflate((int)(textSize.Height * 0.2), (int)(textSize.Width * 0.1));

                        _autoSizingSize = new Size(reminderRectangle.Width, reminderRectangle.Height);
                    }
                }
            }

            if (_lineNumberItems.Count > 0)
            {
                LinearGradientBrush lgb = null;

                pen = new Pen(_gridLinesColour, _gridLineThickness);

                pen.DashStyle = _gridLinesStyle;

                stringFormat.Alignment = StringAlignment.Near;

                stringFormat.LineAlignment = StringAlignment.Near;

                stringFormat.FormatFlags = StringFormatFlags.FitBlackBox | StringFormatFlags.NoClip | StringFormatFlags.NoWrap;

                for (int a = 0; a <= _lineNumberItems.Count - 1; a++)
                {
                    if (_gradient_Show)
                    {
                        lgb = new LinearGradientBrush(_lineNumberItems[a]._rectangle, _startColour, _endColour, _gradientMode);

                        e.Graphics.FillRectangle(lgb, _lineNumberItems[a]._rectangle);
                    }
                    else
                    {
                        SolidBrush solidBrush = new SolidBrush(BlockColour);

                        e.Graphics.FillRectangle(solidBrush, _lineNumberItems[a]._rectangle);
                    }

                    if (_gridLinesShow)
                    {
                        e.Graphics.DrawLine(pen, new Point(0, _lineNumberItems[a]._rectangle.Y), new Point(Width, _lineNumberItems[a]._rectangle.Y));

                        gpGridLines.AddRectangle(new Rectangle((int)(-_gridLineThickness), (int)(_lineNumberItems[a]._rectangle.Y), (int)(Width + _gridLineThickness * 2), (int)(Height - _lineNumberItems[a]._rectangle.Y + _gridLineThickness)));

                        gpGridLines.CloseFigure();
                    }

                    if (_lineNumbers_Show)
                    {
                        if (_lineNumbers_ShowLeading_Zeros)
                        {
                            textToShow = (_lineNumbers_ShowAsHexadecimal ? _lineNumberItems[a]._lineNumber.ToString("X") : _lineNumberItems[a]._lineNumber.ToString(_lineNumberFormat));
                        }
                        else
                        {
                            textToShow = (_lineNumbers_ShowAsHexadecimal ? _lineNumberItems[a]._lineNumber.ToString("X") : _lineNumberItems[a]._lineNumber.ToString());
                        }

                        textSize = e.Graphics.MeasureString(textToShow, Font, point, stringFormat);

                        switch (_lineNumberAlignment)
                        {
                            case ContentAlignment.TopLeft:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Left + Padding.Left + _lineNumbersOffset.Width), (int)(_lineNumberItems[a]._rectangle.Top + Padding.Top + _lineNumbersOffset.Height));
                                break;
                            case ContentAlignment.MiddleLeft:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Left + this.Padding.Left + _lineNumbersOffset.Width), (int)(_lineNumberItems[a]._rectangle.Top + (_lineNumberItems[a]._rectangle.Height / 2) + _lineNumbersOffset.Height - textSize.Height / 2));
                                break;
                            case ContentAlignment.BottomLeft:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Left + this.Padding.Left + _lineNumbersOffset.Width), (int)(_lineNumberItems[a]._rectangle.Bottom - this.Padding.Bottom + 1 + _lineNumbersOffset.Height - textSize.Height));
                                break;
                            case ContentAlignment.TopCenter:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Width / 2 + _lineNumbersOffset.Width - textSize.Width / 2), (int)(_lineNumberItems[a]._rectangle.Top + this.Padding.Top + _lineNumbersOffset.Height));
                                break;
                            case ContentAlignment.MiddleCenter:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Width / 2 + _lineNumbersOffset.Width - textSize.Width / 2), (int)(_lineNumberItems[a]._rectangle.Top + (_lineNumberItems[a]._rectangle.Height / 2) + _lineNumbersOffset.Height - textSize.Height / 2));
                                break;
                            case ContentAlignment.BottomCenter:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Width / 2 + _lineNumbersOffset.Width - textSize.Width / 2), (int)(_lineNumberItems[a]._rectangle.Bottom - this.Padding.Bottom + 1 + _lineNumbersOffset.Height - textSize.Height));
                                break;
                            case ContentAlignment.TopRight:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Right - this.Padding.Right + _lineNumbersOffset.Width - textSize.Width), (int)(_lineNumberItems[a]._rectangle.Top + this.Padding.Top + _lineNumbersOffset.Height));
                                break;
                            case ContentAlignment.MiddleRight:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Right - this.Padding.Right + _lineNumbersOffset.Width - textSize.Width), (int)(_lineNumberItems[a]._rectangle.Top + (_lineNumberItems[a]._rectangle.Height / 2) + _lineNumbersOffset.Height - textSize.Height / 2));
                                break;
                            case ContentAlignment.BottomRight:
                                point = new Point((int)(_lineNumberItems[a]._rectangle.Right - this.Padding.Right + _lineNumbersOffset.Width - textSize.Width), (int)(_lineNumberItems[a]._rectangle.Bottom - this.Padding.Bottom + 1 + _lineNumbersOffset.Height - textSize.Height));
                                break;
                        }

                        itemClipRectangle = new Rectangle(point, textSize.ToSize());

                        if (_lineNumbers_ClipByItemRectangle)
                        {
                            itemClipRectangle.Intersect(_lineNumberItems[a]._rectangle);

                            e.Graphics.SetClip(itemClipRectangle);
                        }

                        e.Graphics.DrawString(textToShow, Font, brush, point, stringFormat);

                        e.Graphics.ResetClip();

                        gpLineNumbers.AddRectangle(itemClipRectangle);

                        gpLineNumbers.CloseFigure();
                    }
                }

                if (_gridLinesShow)
                {
                    pen.DashStyle = DashStyle.Solid;

                    gpGridLines.Widen(pen);
                }

                if (lgb != null) lgb.Dispose();
            }

            Point left = new Point((int)(Math.Floor(_borderLineThickness / 2)), (int)(Math.Floor(_borderLineThickness / 2))), right = new Point((int)(Width - Math.Ceiling(_borderLineThickness / 2)), (int)(Height - Math.Ceiling(_borderLineThickness / 2)));

            Point[] borderLinePoints = { new Point(left.X, left.Y), new Point(right.X, left.Y), new Point(right.X, right.Y), new Point(left.X, right.Y), new Point(left.X, left.Y) };

            if (_borderLinesShow)
            {
                pen = new Pen(_borderLinesColour, _borderLineThickness);

                pen.DashStyle = _borderLinesStyle;

                e.Graphics.DrawLines(pen, borderLinePoints);

                gpBorderLines.AddLines(borderLinePoints);

                gpBorderLines.CloseFigure();

                pen.DashStyle = DashStyle.Solid;

                gpBorderLines.Widen(pen);
            }

            if (_marginLines_Show && _marginLineSide > LineNumberDockSide.NONE)
            {
                left = new Point((int)(-_marginLineThickness), (int)(-_marginLineThickness));

                right = new Point((int)(Width + _marginLineThickness), (int)(Height + _marginLineThickness));

                pen = new Pen(_marginLinesColour, _marginLineThickness);

                pen.DashStyle = _marginLinesStyle;

                if (_marginLineSide == LineNumberDockSide.LEFT | _marginLineSide == LineNumberDockSide.HEIGHT)
                {
                    e.Graphics.DrawLine(pen, new Point((int)(Math.Floor(_marginLineThickness / 2)), 0), new Point((int)(Math.Floor(_marginLineThickness / 2)), Height - 1));

                    left = new Point((int)(Math.Ceiling(_marginLineThickness / 2)), (int)(_marginLineThickness));
                }

                if (_marginLineSide == LineNumberDockSide.LEFT | _marginLineSide == LineNumberDockSide.HEIGHT)
                {
                    e.Graphics.DrawLine(pen, new Point((int)(Width - Math.Ceiling(_marginLineThickness / 2)), 2), new Point((int)(Width - Math.Ceiling(_marginLineThickness / 2)), (int)(Height - 1)));

                    right = new Point((int)(Width - Math.Ceiling(_marginLineThickness / 2)), (int)(Height + _marginLineThickness));
                }

                gpMarginLines.AddRectangle(new Rectangle(left, new Size(right.X - left.X, right.Y - left.Y)));

                pen.DashStyle = DashStyle.Solid;

                gpMarginLines.Widen(pen);
            }

            if (_seeThroughMode)
            {
                region.MakeEmpty();

                region.Union(gpBorderLines);

                region.Union(gpMarginLines);

                region.Union(gpGridLines);

                region.Union(gpLineNumbers);
            }

            if (region.GetBounds(e.Graphics).IsEmpty)
            {
                gpBorderLines.AddLines(borderLinePoints);

                gpBorderLines.CloseFigure();

                pen = new Pen(_borderLinesColour, 1);

                pen.DashStyle = DashStyle.Solid;

                gpBorderLines.Widen(pen);

                region = new Region(gpBorderLines);
            }

            Region = region;

            if (pen != null) pen.Dispose();

            if (brush != null) pen.Dispose();

            if (region != null) region.Dispose();

            if (gpGridLines != null) gpGridLines.Dispose();

            if (gpBorderLines != null) gpBorderLines.Dispose();

            if (gpMarginLines != null) gpMarginLines.Dispose();

            if (gpLineNumbers != null) gpLineNumbers.Dispose();
        }
        #endregion

        #region Event Handlers
        private void Parent_Disposed(object sender, EventArgs e)
        {
            ParentRichTextBox = null;

            Refresh();

            Invalidate();
        }

        private void Parent_Scroll(object sender, EventArgs e)
        {
            _parentIsScrolling = true;

            Invalidate();
        }

        private void Parent_Changed(object sender, EventArgs e)
        {
            Refresh();

            Invalidate();
        }

        private void Parent_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            _contentRectangle = e.NewRectangle;

            Refresh();

            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _parentIsScrolling = false;

            _timer.Stop();

            Invalidate();
        }
        #endregion

        #region Methods
        private void InitialiseColours()
        {
            BlockColour = _palette.ColorTable.MenuStripGradientBegin;

            LineNumberTextColour = _palette.ColorTable.MenuItemText;
        }

        private void UpdateSizeAndPosition()
        {
            if (AutoSize)
            {
                return;
            }

            if (Dock == DockStyle.Bottom | Dock == DockStyle.Fill | Dock == DockStyle.Top)
            {
                return;
            }

            Point newLocationPoint = Location;

            Size newSize = Size;

            if (AutoSizing)
            {
                if (ParentRichTextBox == null)
                {
                    if (_autoSizingSize.Width > 0) newSize.Width = _autoSizingSize.Width;

                    if (_autoSizingSize.Height > 0) newSize.Height = _autoSizingSize.Height;

                    Size = newSize;
                }
                else if (Dock == DockStyle.Left | Dock == DockStyle.Right)
                {
                    if (_autoSizingSize.Width > 0) newSize.Width = _autoSizingSize.Width;

                    Width = newSize.Width;
                }
                else if (DockSide != LineNumberDockSide.NONE)
                {
                    if (_autoSizingSize.Width > 0) newSize.Width = _autoSizingSize.Width;

                    newSize.Height = ParentRichTextBox.Height;

                    if (DockSide == LineNumberDockSide.LEFT) newLocationPoint.X = ParentRichTextBox.Left - newSize.Width - 1;

                    if (DockSide == LineNumberDockSide.RIGHT) newLocationPoint.X = ParentRichTextBox.Right + 1;

                    newLocationPoint.Y = ParentRichTextBox.Top;

                    Location = newLocationPoint;

                    Size = newSize;
                }
                else if (DockSide == LineNumberDockSide.NONE)
                {
                    if (_autoSizingSize.Width > 0) newSize.Width = _autoSizingSize.Width;

                    Size = newSize;
                }
            }
            else
            {
                if (ParentRichTextBox == null)
                {
                    if (_autoSizingSize.Width > 0) newSize.Width = _autoSizingSize.Width;

                    if (_autoSizingSize.Height > 0) newSize.Height = _autoSizingSize.Height;

                    Size = newSize;
                }
                else if (DockSide != LineNumberDockSide.NONE)
                {
                    newSize.Height = ParentRichTextBox.Height;

                    if (DockSide == LineNumberDockSide.LEFT) newLocationPoint.X = ParentRichTextBox.Left - newSize.Width - 1;

                    if (DockSide == LineNumberDockSide.RIGHT) newLocationPoint.X = ParentRichTextBox.Right + 1;

                    newLocationPoint.Y = ParentRichTextBox.Top;

                    Location = newLocationPoint;

                    Size = newSize;
                }
            }
        }

        private void UpdateVisibleLineNumberItems()
        {
            int tmpY;

            _lineNumberItems.Clear();

            _autoSizingSize = new Size(0, 0);

            _lineNumberFormat = "0";

            if (AutoSizing)
            {
                _autoSizingSize = new Size(TextRenderer.MeasureText(_lineNumberFormat.Replace('0', 'W'), Font).Width, 0);
            }

            if (ParentRichTextBox == null || string.IsNullOrEmpty(ParentRichTextBox.Text)) return;

            _pointInParent = ParentRichTextBox.PointToScreen(ParentRichTextBox.ClientRectangle.Location);

            _pointInMe = PointToScreen(new Point(0, 0));

            _parentInMe = _pointInParent.Y - _pointInMe.Y + 1;

            _pointInParent = ParentRichTextBox.PointToClient(_pointInMe);

            string[] split = ParentRichTextBox.Text.Split(Constants.vbCrLf.ToCharArray());

            if (split.Length < 2)
            {
                Point point = ParentRichTextBox.GetPositionFromCharIndex(0);

                _lineNumberItems.Add(new LineNumberItem(1, new Rectangle(new Point(0, point.Y - 1 + _parentInMe), new Size(Width, _contentRectangle.Height - point.Y))));
            }
            else
            {
                TimeSpan timeSpan = new TimeSpan(DateAndTime.Now.Ticks);

                Point point = new Point(0, 0);

                int startIndex = 0, splitStartLine = 0, a = ParentRichTextBox.Text.Length - 1;

                tmpY = _pointInParent.Y;

                FindStartIndex(ref startIndex, ref a, ref tmpY);

                _pointInParent.Y = tmpY;

                startIndex = Math.Max(0, Math.Min(ParentRichTextBox.Text.Length - 1, ParentRichTextBox.Text.Substring(0, startIndex).LastIndexOf(Strings.Chr(10)) + 1));

                splitStartLine = Math.Max(0, ParentRichTextBox.Text.Substring(0, startIndex).Split(Constants.vbCrLf.ToCharArray()).Length - 1);

                for (a = splitStartLine; a <= split.Length - 1; a++)
                {
                    point = ParentRichTextBox.GetPositionFromCharIndex(startIndex);

                    startIndex += Math.Max(1, split[a].Length + 1);

                    if (point.Y + _parentInMe > Height) break;

                    _lineNumberItems.Add(new LineNumberItem(a + 1, new Rectangle(0, point.Y - 1 + _parentInMe, Width, 1)));

                    if (_parentIsScrolling && DateAndTime.Now.Ticks > timeSpan.Ticks + 500000)
                    {
                        if (_lineNumberItems.Count == 1) _lineNumberItems[0]._rectangle.Y = 0;

                        _parentIsScrolling = false;

                        _timer.Start();

                        break;
                    }

                    if (_lineNumberItems.Count == 0) break;

                    if (a < split.Length)
                    {
                        point = ParentRichTextBox.GetPositionFromCharIndex(Math.Min(startIndex, ParentRichTextBox.Text.Length - 1));

                        _lineNumberItems.Add(new LineNumberItem(-1, new Rectangle(0, point.Y - 1 + _parentInMe, 0, 0)));
                    }
                    else
                    {
                        _lineNumberItems.Add(new LineNumberItem(-1, new Rectangle(0, _contentRectangle.Bottom, 0, 0)));
                    }

                    for (a = 0; a <= _lineNumberItems.Count - 2; a++)
                    {
                        _lineNumberItems[a]._rectangle.Height = Math.Max(1, _lineNumberItems[a + 1]._rectangle.Y - _lineNumberItems[a]._rectangle.Y);
                    }

                    _lineNumberItems.RemoveAt(_lineNumberItems.Count - 1);

                    if (_lineNumbers_ShowAsHexadecimal)
                    {
                        _lineNumberFormat = "".PadRight(split.Length.ToString("X").Length, '0');
                    }
                    else
                    {
                        _lineNumberFormat = "".PadRight(split.Length.ToString().Length, '0');
                    }
                }
            }

            if (_autoSizing) _autoSizingSize = new Size(TextRenderer.MeasureText(_lineNumberFormat.Replace('0', 'W'), Font).Width, 0);
        }

        private void FindStartIndex(ref int min, ref int max, ref int target)
        {
            if (max == min + 1 | min == (max + min) / 2) return;

            if (ParentRichTextBox.GetPositionFromCharIndex((max + min) / 2).Y == target) min = (max + min) / 2;

            else if (ParentRichTextBox.GetPositionFromCharIndex((max + min) / 2).Y > target)
            {
                max = (max + min) / 2;

                FindStartIndex(ref min, ref max, ref target);
            }
            else if (ParentRichTextBox.GetPositionFromCharIndex((max + min) / 2).Y < 0)
            {
                min = (max + min) / 2;

                FindStartIndex(ref min, ref max, ref target);
            }
        }
        #endregion
    }
}