#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    /// <summary> 
    /// print DataGridViewPrint 
    /// </summary> 

    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Drawing.Printing.PrintDocument))]
    public class DataGridViewPrint : PrintDocument
    {
        #region ... Fields ...
        private int startrow, endrow;
        private int startcolumn, endcolumn;
        private float btwidth;
        private int currentpage;
        #endregion

        #region ... Properties ...
        private bool _columnHeaderDoubleHeight = true;
        [Browsable(true), Category("Appearance-Extended")]
        public bool ColumnHeaderDoubleHeight
        {
            get
            {
                return _columnHeaderDoubleHeight;
            }
            set
            {
                _columnHeaderDoubleHeight = value;
            }
        }
        private Color _columnHeaderBackColor = Color.MistyRose;
        [Browsable(true), Category("Appearance-Extended")]
        public Color ColumnHeaderBackColour
        {
            get
            {
                return _columnHeaderBackColor;
            }
            set
            {
                _columnHeaderBackColor = value;
            }
        }

        private bool _enableColors = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public bool EnableColours
        {
            get
            {
                return _enableColors;
            }
            set
            {
                _enableColors = value;
            }
        }

        private bool _rulerTop = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public bool RulerTop
        {
            get
            {
                return _rulerTop;
            }
            set
            {
                _rulerTop = value;
            }
        }

        private bool _rulerBottom = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public bool RulerBottom
        {
            get
            {
                return _rulerBottom;
            }
            set
            {
                _rulerBottom = value;
            }
        }

        private string _subtitle = "";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("")]
        public string Subtitle
        {
            get
            {
                return _subtitle;
            }
            set
            {
                _subtitle = value;
            }
        }

        private bool _hasSubtitle = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean HasSubtitle
        {
            get
            {
                return _hasSubtitle;
            }
            set
            {
                _hasSubtitle = value;
            }
        }

        private StringAlignment _subtitleAlignment = StringAlignment.Center;
        [Browsable(true), Category("Appearance-Extended")]
        public StringAlignment SubtitleAlignment
        {
            get
            {
                return _subtitleAlignment;
            }
            set
            {
                _subtitleAlignment = value;
            }
        }

        private Font _subtitleFont = new Font("Arial", 10, FontStyle.Italic);
        [Browsable(true), Category("Appearance-Extended")]
        public Font SubtitleFont
        {
            get
            {
                return _subtitleFont;
            }
            set
            {
                _subtitleFont = value;
            }
        }

        private string _header = "";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("")]
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
            }
        }

        private bool _hasHeader = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean HasHeader
        {
            get
            {
                return _hasHeader;
            }
            set
            {
                _hasHeader = value;
            }
        }

        private StringAlignment _headerAlignment = StringAlignment.Center;
        [Browsable(true), Category("Appearance-Extended")]
        public StringAlignment HeaderAlignment
        {
            get
            {
                return _headerAlignment;
            }
            set
            {
                _headerAlignment = value;
            }
        }

        private Font _headerFont = new Font("Arial", 11, FontStyle.Bold);
        [Browsable(true), Category("Appearance-Extended")]
        public Font HeaderFont
        {
            get
            {
                return _headerFont;
            }
            set
            {
                _headerFont = value;
            }
        }

        private string _footer = "";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("")]
        public string Footer
        {
            get
            {
                return _footer;
            }
            set
            {
                _footer = value;
            }
        }

        private string _nullValue = "null";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("null")]
        public string NullValue
        {
            get
            {
                return _nullValue;
            }
            set
            {
                _nullValue = value;
            }
        }

        private string _noData = "No Data";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("No Data")]
        public string NoData
        {
            get
            {
                return _noData;
            }
            set
            {
                _noData = value;
            }
        }

        private string _dateText = "Date:";
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Date:")]
        public string DateText
        {
            get
            {
                return _dateText;
            }
            set
            {
                _dateText = value;
            }
        }

        private bool _dateOnSubtitle = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean DateOnSubtitle
        {
            get
            {
                return _dateOnSubtitle;
            }
            set
            {
                _dateOnSubtitle = value;
            }
        }

        private bool _dateOnFooter = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean DateOnFooter
        {
            get
            {
                return _dateOnFooter;
            }
            set
            {
                _dateOnFooter = value;
            }
        }

        private bool _hasFooter = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean HasFooter
        {
            get
            {
                return _hasFooter;
            }
            set
            {
                _hasFooter = value;
            }
        }

        private bool _hasFooterWithPageNum = true;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("True")]
        public Boolean HasFooterWithPageNum
        {
            get
            {
                return _hasFooterWithPageNum;
            }
            set
            {
                _hasFooterWithPageNum = value;
            }
        }

        private StringAlignment _footerAlignment = StringAlignment.Center;
        [Browsable(true), Category("Appearance-Extended")]
        public StringAlignment FooterAlignment
        {
            get
            {
                return _footerAlignment;
            }
            set
            {
                _footerAlignment = value;
            }
        }

        private Font _footerFont = new Font("Arial", 10);
        [Browsable(true), Category("Appearance-Extended")]
        public Font FooterFont
        {
            get
            {
                return _footerFont;
            }
            set
            {
                _footerFont = value;
            }
        }


        private DataGridView _dataGridView = null;
        [Browsable(true), Category("Appearance-Extended")]
        public DataGridView DataGridView
        {
            get
            {
                return _dataGridView;
            }
            set
            {
                _dataGridView = value;
            }
        }
        #endregion

        #region ... Constructor ...
        public DataGridViewPrint()
            : base()
        {

        }

        public DataGridViewPrint(DataGridView dg)
            : base()
        {
            this._dataGridView = dg;
        }
        public DataGridViewPrint(DataGridView dg, String header)
            : base()
        {
            this._dataGridView = dg;
            this._header = header;
        }
        #endregion

        #region ... Overridden Methods ...

        protected override void OnBeginPrint(PrintEventArgs ev)
        {
            base.OnBeginPrint(ev);
            startcolumn = 0;
            endcolumn = 0;
            startrow = 0;
            endrow = 0;
            currentpage = 0;
        }

        protected override void OnQueryPageSettings(QueryPageSettingsEventArgs ev)
        {
            ev.PageSettings.Margins = DefaultPageSettings.Margins;
        }

        protected override void OnPrintPage(PrintPageEventArgs ev)
        {
            base.OnPrintPage(ev);
            Graphics g = ev.Graphics;


            Brush brush = new SolidBrush(SystemColors.WindowText);
            StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
            if (_dataGridView == null)
            {

                //NO DATA
                format.Alignment = StringAlignment.Near;
                using (Font font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, ((System.Byte)(134))))
                {//((System.Byte)(134)))
                    g.DrawString(_noData, font, brush, ev.MarginBounds, format);
                }
            }
            else
            {
                Rectangle bounds = ev.MarginBounds;

                Font font = _dataGridView.Font;

                //Hedaer Rect
                bounds.Height = _headerFont.Height;
                format.Alignment = StringAlignment.Center;

                //Draw Header
                StringFormat headerFormat = new StringFormat(StringFormatFlags.NoWrap);
                headerFormat.Alignment = _headerAlignment;

                if (_hasHeader) g.DrawString(_header, _headerFont, brush, bounds, headerFormat);

                if (_rulerTop)
                    g.DrawLine(new Pen(brush, 1), new Point(ev.MarginBounds.Left, ev.MarginBounds.Top + _headerFont.Height * 3 / 2), new Point(ev.MarginBounds.Right, ev.MarginBounds.Top + _headerFont.Height * 3 / 2));


                //space
                bounds.Y += _headerFont.Height * 2;
                font = _dataGridView.Font;
                bounds.Height = font.Height * 3 / 2;

                //Draw subtitle
                string SubTitle = "";
                StringFormat subtitleFormat = new StringFormat(StringFormatFlags.NoWrap);
                subtitleFormat.Alignment = _subtitleAlignment;

                if (_hasSubtitle)
                    SubTitle += _subtitle;
                if (_dateOnSubtitle)
                    SubTitle += " " + String.Format(_dateText + " {0:dd-MM-yyyy}", DateTime.Now);

                g.DrawString(SubTitle, _subtitleFont, brush, bounds, subtitleFormat);


                int rowcount = _dataGridView.Rows.Count;

                bounds.Y += _subtitleFont.Height * 2;
                font = _dataGridView.Font;
                bounds.Height = font.Height * 2;

                bounds.X = ev.MarginBounds.Left;


                Pen outerpen = new Pen(brush, 2);
                Pen innerpen = new Pen(brush, 1);

                btwidth = 0;
                int i;
                for (i = startcolumn; i < _dataGridView.Columns.Count; i++)   //datagrid
                {
                    btwidth += (int)_dataGridView.Columns[i].Width;
                    if (btwidth >= ev.MarginBounds.Width)
                    {
                        btwidth -= (int)_dataGridView.Columns[i].Width;
                        break;
                    }
                }
                endcolumn = i;

                //Column Header
                StringFormat columnFormat = new StringFormat();
                columnFormat.Alignment = StringAlignment.Center;

                int dblHeight = 0;

                //test double heigth
                if (_columnHeaderDoubleHeight) dblHeight = bounds.Height;

                bounds.Height += dblHeight;

                for (int column = startcolumn; column < endcolumn; column++)
                {

                    if (_dataGridView.Columns[column].Width > 5)
                    {
                        bounds.Width = (int)_dataGridView.Columns[column].Width;

                        //Colored?
                        if (_enableColors)
                            g.FillRectangle(new SolidBrush(_columnHeaderBackColor), bounds);

                        Pen pen = column == startcolumn ? outerpen : innerpen;
                        g.DrawLine(pen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom);
                        g.DrawLine(outerpen, bounds.Left, bounds.Top, bounds.Right, bounds.Top);

                        bounds.Y += (bounds.Height - font.Height) / 2;

                        g.DrawString(_dataGridView.Columns[column].HeaderText, _dataGridView.Font, brush, bounds, columnFormat);
                        // Paint(g, bounds,  row, columnstyle, SystemBrushes.Window, brush);//???????????????????

                        bounds.Y -= (bounds.Height - font.Height) / 2;

                        bounds.X += bounds.Width;
                    }
                }

                //test double heigth
                bounds.Height -= dblHeight;

                g.DrawLine(outerpen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom + dblHeight);

                //test double heigth
                bounds.Y += dblHeight;

                if (endcolumn <= startcolumn)
                    endcolumn = _dataGridView.Columns.Count;

                if (endrow <= startrow)
                    endrow = rowcount;

                bounds.Y += font.Height * 2;
                font = _dataGridView.Font;
                bounds.Height = font.Height * 2;

                for (int row = startrow; row < rowcount; row++)
                {
                    bounds.X = ev.MarginBounds.Left;
                    for (int column = startcolumn; column < endcolumn; column++)
                    {

                        if (_dataGridView.Columns[column].Width > 5)
                        {
                            bounds.Width = (int)_dataGridView.Columns[column].Width;

                            //Colored?
                            if (_enableColors)
                                g.FillRectangle(new SolidBrush(_dataGridView.Rows[row].Cells[column].InheritedStyle.BackColor), bounds);

                            Pen pen = column == startcolumn ? outerpen : innerpen;
                            g.DrawLine(pen, bounds.Left, bounds.Bottom, bounds.Left, bounds.Top);
                            g.DrawLine(innerpen, bounds.Left, bounds.Top, bounds.Right, bounds.Top);


                            bounds.Y += (bounds.Height - font.Height) / 2;
                            //Paint(g, bounds,  row, columnstyle, SystemBrushes.Window, brush);//???????????????????
                            if (_dataGridView.Rows[row].Cells[column].Value != null)
                            {
                                if (_dataGridView.Rows[row].Cells[column].Value.ToString() != "System.Drawing.Bitmap")
                                {
                                    g.DrawString(_dataGridView.Rows[row].Cells[column].Value.ToString(), _dataGridView.Font, brush, bounds, format);
                                }

                                //is a bitmap
                                else
                                {
                                    //reset the height (Y pos)
                                    bounds.Y -= (bounds.Height - font.Height) / 2;

                                    Bitmap img = new Bitmap((Bitmap)_dataGridView.Rows[row].Cells[column].Value);
                                    g.DrawImage(img, bounds.X + (bounds.Width - img.Width) / 2, bounds.Y + (bounds.Height - img.Height) / 2);
                                    img.Dispose();

                                    //recorrect the height (Y pos)B
                                    bounds.Y += (bounds.Height - font.Height) / 2;
                                }
                            }
                            else
                            {
                                g.DrawString(_nullValue, _dataGridView.Font, brush, bounds);
                            }
                            bounds.Y -= (bounds.Height - font.Height) / 2;

                            bounds.X += bounds.Width;
                        }
                    }

                    g.DrawLine(outerpen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom);

                    bounds.Y += bounds.Height;

                    if (bounds.Bottom > ev.MarginBounds.Bottom - 4 * font.Height)
                    {
                        endrow = row;
                        break;
                    }
                }

                //Draw ??
                g.DrawLine(outerpen, ev.MarginBounds.Left, bounds.Top, bounds.Left, bounds.Top);

                currentpage++;


                //Bottom Line
                if (_rulerBottom)
                    g.DrawLine(new Pen(brush, 1), new Point(ev.MarginBounds.Left, ev.MarginBounds.Bottom - _footerFont.Height * 2), new Point(ev.MarginBounds.Right, ev.MarginBounds.Bottom - _footerFont.Height * 2));


                //Footer Part
                StringFormat footerFormat = new StringFormat(StringFormatFlags.NoWrap);
                footerFormat.Alignment = _footerAlignment;

                //Footer Rectangle
                Rectangle rectFooter = new Rectangle();
                rectFooter.X = ev.MarginBounds.Left;
                rectFooter.Y = ev.MarginBounds.Bottom - _footerFont.Height;
                rectFooter.Width = ev.MarginBounds.Width;
                rectFooter.Height = _footerFont.Height;

                //Footer String
                string Footer = "";


                //Has Footer
                if (_hasFooter)
                    Footer += _footer + " ";
                if (_hasFooterWithPageNum)
                    Footer += "-" + currentpage.ToString() + "- ";
                if (_dateOnFooter)
                    Footer += String.Format(_dateText + " {0:dd-MM-yyyy}", DateTime.Now);
                if (_hasFooter)
                    g.DrawString(Footer, _footerFont, brush, rectFooter, footerFormat);


                if (endcolumn < _dataGridView.Columns.Count || endrow < rowcount - 1)
                {
                    ev.HasMorePages = true;

                    if (endcolumn < _dataGridView.Columns.Count)
                    {
                        startcolumn = endcolumn;
                    }
                    else
                    {
                        startcolumn = 0;
                        startrow = endrow + 1;
                    }
                }
            }
        }
        #endregion

    }
}