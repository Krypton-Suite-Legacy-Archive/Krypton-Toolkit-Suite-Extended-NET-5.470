#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.Base.Code.Colours;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourAreaUserControl : UserControl
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
            this.SuspendLayout();
            // 
            // ColorAreaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ColourAreaUserControl";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColourAreaUserControl_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColourAreaUserControl_MouseMove);
            this.Leave += new System.EventHandler(this.ColourAreaUserControl_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColourAreaUserControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColourAreaUserControl_MouseDown);
            this.Enter += new System.EventHandler(this.ColourAreaUserControl_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion

        #region Variables
        private double _h, _s;
        private Bitmap _colourBitmap;
        #endregion

        public ColourAreaUserControl()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.Selectable | ControlStyles.AllPaintingInWmPaint, true);
        }

        public void SetHueSaturation(double h, double s)
        {
            _h = h;
            _s = s;

            // --

            Invalidate();

            NotifyHueSaturationChanged();
        }

        public void GetHueSaturation(out double h, out double s)
        {
            h = _h;
            s = _s;
        }

        private void TranslateCaretPositionToHueSaturation(Point caretPosition, out double h, out double s)
        {
            double facXBmpToScreen = 360.0 / ClientSize.Width;
            double facYBmpToScreen = 100.0 / ClientSize.Height;

            Point p = caretPosition;

            p.X = Math.Max(0, p.X);
            p.X = Math.Min(ClientSize.Width - 1, p.X);
            p.Y = Math.Max(0, p.Y);
            p.Y = Math.Min(ClientSize.Height - 1, p.Y);

            p.Y = ClientSize.Height - p.Y;

            h = (p.X * facXBmpToScreen);
            s = (p.Y * facYBmpToScreen);

            h = Math.Max(0.0, h);
            h = Math.Min(360.0, h);
            s = Math.Max(0.0, s);
            s = Math.Min(100.0, s);
        }

        private void TranslateHueSaturationToCaretPosition(out Point caretPosition, double h, double s)
        {
            double facXBmpToScreen = 360.0 / ClientSize.Width;
            double facYBmpToScreen = 100.0 / ClientSize.Height;

            h = Math.Max(0.0, h);
            h = Math.Min(360.0, h);
            s = Math.Max(0.0, s);
            s = Math.Min(100.0, s);

            double pX = (h / facXBmpToScreen);
            double pY = (s / facYBmpToScreen);

            pX = Math.Max(0, pX);
            pX = Math.Min(ClientSize.Width - 1, pX);
            pY = Math.Max(0, pY);
            pY = Math.Min(ClientSize.Height - 1, pY);

            pY = ClientSize.Height - pY;

            caretPosition = new Point((int)pX, (int)pY);
        }

        /// <summary>
        /// Handles the Paint event of the <see cref="ColorAreaUserControl"/> control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> 
        /// instance containing the event data.</param>
        private void ColourAreaUserControl_Paint(object sender, PaintEventArgs e)
        {
            if (_colourBitmap == null)
            {
                _colourBitmap = DrawColourBitmap();
            }

            double facXBmpToScreen = (double)_colourBitmap.Width / ClientSize.Width;
            double facYBmpToScreen = (double)_colourBitmap.Height / ClientSize.Height;

            Rectangle destinationRect =
                e.ClipRectangle;

            var sourceRect = new Rectangle(
                (int)(facXBmpToScreen * destinationRect.Left),
                (int)(facYBmpToScreen * destinationRect.Top),
                (int)(facXBmpToScreen * destinationRect.Width),
                (int)(facYBmpToScreen * destinationRect.Height));

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            e.Graphics.DrawImage(
                _colourBitmap,
                destinationRect,
                sourceRect,
                GraphicsUnit.Pixel);

            DrawCaret(e.Graphics);
        }

        private readonly Brush _blackBrush = new SolidBrush(Color.Black);
        private readonly Brush _whiteBrush = new SolidBrush(Color.White);

        /// <summary>
        /// Draws the caret.
        /// </summary>
        private void DrawCaret()
        {
            Invalidate();
        }

        /// <summary>
        /// Draws the caret.
        /// </summary>
        /// <param name="g">The g.</param>
        private void DrawCaret(Graphics g)
        {
            Brush b1, b2;

            if (Focused)
            {
                b1 = _blackBrush;
                b2 = _whiteBrush;
            }
            else
            {
                b1 = _whiteBrush;
                b2 = _blackBrush;
            }

            // --

            Point p;

            TranslateHueSaturationToCaretPosition(out p, _h, _s);

            int x = p.X, y = p.Y;

            // --
            // Outer.

            g.FillRectangle(b2, x - 2, y - 11, 5, 8);

            g.FillRectangle(b2, x - 2, y + 3 + 1, 5, 8);

            g.FillRectangle(b2, x - 11, y - 2, 8, 5);

            g.FillRectangle(b2, x + 3 + 1, y - 2, 8, 5);

            // --
            // Inner.

            g.FillRectangle(b1, x - 1, y - 10, 3, 6);

            g.FillRectangle(b1, x - 1, y + 4 + 1, 3, 6);

            g.FillRectangle(b1, x - 10, y - 1, 6, 3);

            g.FillRectangle(b1, x + 4 + 1, y - 1, 6, 3);
        }

        /// <summary>
        /// Draws the color bitmap.
        /// </summary>
        /// <returns></returns>
        private static Bitmap DrawColourBitmap()
        {
            const int width = 360 + 1, height = 100 + 1;

            var bmp = new Bitmap(width, height);

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    double h = x;
                    double s = 100 - y;
                    double l = 100 - y;

                    Color colour = new HSLColour(h, s, l).ToColour();

                    bmp.SetPixel(x, y, colour);
                }
            }

            return bmp;
        }

        /// <summary>
        /// Occurs when the user changed the hue and/or saturation.
        /// </summary>
        public event EventHandler HueSaturationChanged;

        /// <summary>
        /// Occurs when a value has been changed.
        /// </summary>
        public event EventHandler ValueChangedByUser;

        private void NotifyHueSaturationChanged()
        {
            if (HueSaturationChanged != null)
            {
                HueSaturationChanged(this, EventArgs.Empty);
            }
        }

        private void NotifyValueChangedByUser()
        {
            if (ValueChangedByUser != null)
            {
                ValueChangedByUser(this, EventArgs.Empty);
            }
        }

        private void ColourAreaUserControl_Enter(object sender, EventArgs e)
        {
            DrawCaret();
        }

        private void ColourAreaUserControl_Leave(object sender, EventArgs e)
        {
            DrawCaret();
        }

        private void ColourAreaUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TranslateCaretPositionToHueSaturation(e.Location, out _h, out _s);
                DrawCaret();

                NotifyValueChangedByUser();
                NotifyHueSaturationChanged();
            }
        }

        private void ColourAreaUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TranslateCaretPositionToHueSaturation(e.Location, out _h, out _s);
                DrawCaret();

                NotifyValueChangedByUser();
                NotifyHueSaturationChanged();
            }
        }

        private void ColourAreaUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TranslateCaretPositionToHueSaturation(e.Location, out _h, out _s);
                DrawCaret();

                NotifyValueChangedByUser();
                NotifyHueSaturationChanged();
            }
        }
    }
}