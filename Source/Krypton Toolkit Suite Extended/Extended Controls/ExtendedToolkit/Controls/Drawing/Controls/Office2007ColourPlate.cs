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
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls
{
    [DesignTimeVisible(false)]
    internal partial class Office2007ColourPlate : UserControl
    {
        #region Designer Code
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
            this.SuspendLayout();
            // 
            // Office2007ColorPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Office2007ColourPlate";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Office2007ColourPlate_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        #endregion

        private Size ColourBoxSize = new Size(12, 12);
        private const int ColourBoxUnit = 12;
        private const int ColourBoxMarginX = 3;
        private const int ColourMatrixX = 10;
        private const int ColourMatrixY = 7;
        private const int TopBoxMargin1 = ColourBoxUnit + 4;
        private const int TopBoxMargin2 = TopBoxMargin1 + ColourBoxUnit + 4;
        private const int TopBoxMargin3 = TopBoxMargin2 + 6 * ColourBoxUnit + 8;
        private Font _font = new Font("Tahoma", 8, FontStyle.Bold);
        private Point _selectedBox = new Point(-1, -1);
        private bool _isPaletteSelected = false;
        private Color[,] _colourMatrix;

        private Color _selectedColour = Color.Black;
        public Color SelectedColour
        {
            get { return _selectedColour; }
            set
            {
                _selectedColour = value;
                Refresh();
                OnSelectedColourChanged();
            }
        }

        public event EventHandler SelectedColourChanged;
        public delegate DialogResult ColourPaletteSelectedHandler(ref Color colour);
        public event ColourPaletteSelectedHandler ColourPaletteSelected;

        public Office2007ColourPlate()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            CreateColourMatrix();
        }

        private void CreateColourMatrix()
        {
            _colourMatrix = new Color[,] {
                    { C(255, 255, 255), C(210, 210, 210), C(186, 186, 186), C(154, 154, 154),
                        C(130, 130, 130), C(114, 114, 114), C(178, 014, 018) },
                    { C(000, 000, 000), C(114, 114, 114), C(106, 106, 106), C(078, 078, 078),
                        C(054, 054, 054), C(030, 030, 030), C(234, 022, 030) },
                    { C(246, 234, 210), C(182, 174, 166), C(154, 150, 142), C(114, 110, 106),
                        C(078, 074, 070), C(054, 050, 050), C(254, 186, 010) },
                    { C(026, 062, 114), C(194, 206, 218), C(134, 154, 182), C(078, 106, 150),
                        C(018, 046, 082), C(010, 030, 054), C(255, 255, 000) },
                    { C(082, 122, 174), C(210, 222, 243), C(166, 186, 214), C(122, 154, 194),
                        C(058, 086, 126), C(038, 054, 078), C(150, 214, 066) },
                    { C(186, 070, 066), C(238, 206, 206), C(218, 158, 158), C(202, 114, 110),
                        C(134, 050, 046), C(086, 034, 030), C(026, 170, 066) },
                    { C(150, 182, 086), C(226, 238, 210), C(202, 218, 170), C(174, 198, 126),
                        C(106, 130, 062), C(066, 082, 038), C(002, 178, 238) },
                    { C(128, 102, 160), C(223, 216, 231), C(191, 178, 207), C(159, 140, 183),
                        C(096, 076, 120), C(064, 051, 080), C(000, 114, 188) },
                    { C(075, 172, 198), C(210, 234, 240), C(165, 213, 226), C(120, 192, 212),
                        C(056, 129, 148), C(037, 086, 099), C(047, 054, 153) },
                    { C(245, 157, 086), C(252, 230, 212), C(250, 206, 170), C(247, 181, 128),
                        C(183, 117, 064), C(122, 078, 043), C(111, 049, 152) }
                };


        }

        private Color C(int red, int green, int blue)
        {
            return Color.FromArgb(red, green, blue);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            _selectedBox = GetSelectedBox(e.Location);
            Invalidate();
        }

        private Point GetSelectedBox(Point mouseLocation)
        {
            int x = -1;
            int y = -1;
            bool isPaletteSelected = false;
            if (mouseLocation.Y >= TopBoxMargin1
                && mouseLocation.Y <= TopBoxMargin1 + ColourBoxUnit)
            {
                y = 0;
            }
            else if (mouseLocation.Y >= TopBoxMargin2
                && mouseLocation.Y <= TopBoxMargin2 + 5 * ColourBoxUnit)
            {
                y = (mouseLocation.Y - TopBoxMargin2) / ColourBoxUnit + 1;
            }
            else if (mouseLocation.Y >= TopBoxMargin3
                && mouseLocation.Y <= TopBoxMargin3 + ColourBoxUnit)
            {
                y = 6;
            }
            else if (mouseLocation.Y > TopBoxMargin3 + ColourBoxUnit)
            {
                isPaletteSelected = true;
            }

            int tmp = (mouseLocation.X - ColourBoxMarginX)
                % (ColourBoxUnit + ColourBoxMarginX);
            if (tmp >= 0 && tmp <= ColourBoxUnit)
            {
                x = (mouseLocation.X - ColourBoxMarginX)
                    / (ColourBoxUnit + ColourBoxMarginX);
                if (x >= 10) x = -1;
            }
            _isPaletteSelected = isPaletteSelected;
            return new Point(x, y);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (_isPaletteSelected)
            {
                if (this.ColourPaletteSelected != null)
                {
                    Color color = Color.White;
                    if (this.ColourPaletteSelected(ref color) == DialogResult.OK)
                    {
                        this.SelectedColour = color;
                    }
                }
            }
            if (_selectedBox.X > -1 && _selectedBox.Y > -1)
            {
                _selectedColour = _colourMatrix[_selectedBox.X, _selectedBox.Y];
                OnSelectedColourChanged();
            }
        }

        private void OnSelectedColourChanged()
        {
            if (this.SelectedColourChanged != null)
                this.SelectedColourChanged(this, new EventArgs());
        }

        #region Drawing

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            DrawBackground(e.Graphics);
        }

        private void DrawBackground(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(250, 250, 250)),
                this.ClientRectangle);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(221, 231, 238)),
                new Rectangle(2, 2, this.Width - 4, ColourBoxUnit));

            graphics.FillRectangle(new SolidBrush(Color.FromArgb(221, 231, 238)),
                new Rectangle(2, TopBoxMargin2 + 5 * ColourBoxUnit + 5, this.Width - 4,
                ColourBoxUnit));
        }


        private void Office2007ColourPlate_Paint(object sender, PaintEventArgs e)
        {
            DrawColourBoxes(e.Graphics);
            DrawTexts(e.Graphics, _font);
            DrawBorder(e.Graphics);
            DrawSelectedBox(e.Graphics);
            DrawPalette(e.Graphics);
        }

        private void DrawBorder(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color.LightGray), 0, 0,
                (ColourBoxUnit + ColourBoxMarginX) * ColourMatrixX + ColourBoxMarginX + 1,
                TopBoxMargin3 + 30);
        }

        private void DrawTexts(Graphics graphics, Font font)
        {
            graphics.DrawString("Theme colors", font, new SolidBrush(Color.Navy), 1, 1);
            graphics.DrawString("Standard colors", font,
                new SolidBrush(Color.Navy), 1, TopBoxMargin2 + 5 * ColourBoxUnit + 4);
        }

        private void DrawColourBoxes(Graphics graphics)
        {
            DrawColourBelt(graphics, 0, TopBoxMargin1, true);
            for (int i = 1; i < ColourMatrixY - 1; i++)
            {
                DrawColourBelt(graphics, i, (i - 1) * ColourBoxUnit + TopBoxMargin2, false);
            }
            for (int i = 0; i < ColourMatrixX; i++)
            {
                graphics.DrawRectangle(new Pen(Color.Gray),
                    i * (ColourBoxUnit + ColourBoxMarginX) + ColourBoxMarginX,
                    TopBoxMargin2, ColourBoxUnit, ColourBoxUnit * 5);
            }
            DrawColourBelt(graphics, ColourMatrixY - 1, TopBoxMargin3, true);
        }

        private void DrawColourBelt(Graphics graphics, int no, int yOffSet, bool border)
        {
            for (int i = 0; i < ColourMatrixX; i++)
            {
                DrawColourBox(graphics, _colourMatrix[i, no],
                    new Point(i * (ColourBoxUnit + ColourBoxMarginX) + ColourBoxMarginX, yOffSet),
                    border);
            }
        }

        private void DrawColourBox(Graphics graphics, Color color, Point location, bool border)
        {
            graphics.FillRectangle(new SolidBrush(color), new Rectangle(location, ColourBoxSize));
            if (border)
            {
                graphics.DrawRectangle(new Pen(Color.LightGray),
                    new Rectangle(location, ColourBoxSize));
            }
        }

        private void DrawSelectedBox(Graphics graphics)
        {
            if (_selectedBox.X > -1 && _selectedBox.Y > -1)
            {
                Point point = new Point(0, 0);

                point.X = _selectedBox.X * (ColourBoxUnit + 3) + 3;

                if (_selectedBox.Y == 0)
                    point.Y = TopBoxMargin1;
                else if (_selectedBox.Y == 6)
                    point.Y = TopBoxMargin3;
                else
                    point.Y = TopBoxMargin2 + (_selectedBox.Y - 1) * ColourBoxUnit;

                graphics.DrawRectangle(new Pen(Color.White), new Rectangle(point, ColourBoxSize));
                graphics.DrawRectangle(new Pen(Color.OrangeRed), point.X - 1,
                    point.Y - 1, ColourBoxUnit + 2, ColourBoxUnit + 2);
            }
        }

        private void DrawPalette(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.palette, 2, TopBoxMargin3 + ColourBoxUnit + 2);
            graphics.DrawString("More colors..", _font, new SolidBrush(Color.Navy),
                20, TopBoxMargin3 + ColourBoxUnit + 2);
            if (_isPaletteSelected)
            {
                graphics.DrawRectangle(new Pen(Color.Gray), 2,
                    TopBoxMargin3 + ColourBoxUnit + 2, this.Width - 5, ColourBoxUnit + 2);
            }
        }

        #endregion
    }
}