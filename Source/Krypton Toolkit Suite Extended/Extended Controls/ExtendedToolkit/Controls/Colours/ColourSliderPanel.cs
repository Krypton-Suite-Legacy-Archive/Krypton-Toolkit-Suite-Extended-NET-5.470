using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Colours;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourSliderPanel : KryptonPanel // Panel
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
            // ColorSliderPanel
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColourSliderPanel_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion

        #region Events
        /// <summary>
        /// Occurs when a value has been changed.
        /// </summary>
        public event EventHandler ValueChangedByUser;

        /// <summary>
        /// Occurs when a value has been changed.
        /// </summary>
        public event EventHandler ValueChanged;
        #endregion

        #region Variables
        private Bitmap _colourBitmap;
        private double _h, _s, _l;
        #endregion

        public ColourSliderPanel()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.Selectable | ControlStyles.AllPaintingInWmPaint, true);
        }

        public void SetHueSaturation(double h, double s)
        {
            _h = h;
            _s = s;

            _colourBitmap = DrawColourBitmap();
            Invalidate();

            NotifyValueChanged();
        }

        private void NotifyValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }

        private Bitmap DrawColourBitmap()
        {
            const int width = 5;
            const int height = 100;

            double h = _h;
            double s = _s;

            var bmp = new Bitmap(width, height);

            for (int y = 0; y < height; ++y)
            {
                double l = height - y;

                Color colour = new HSLColour(h, s, l).ToColour();

                for (int x = 0; x < width; ++x)
                {
                    bmp.SetPixel(x, y, colour);
                }
            }

            return bmp;
        }

        private void ColourSliderPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_colourBitmap == null)
            {
                _colourBitmap = DrawColourBitmap();
            }

            var facYBmpToScreen = (double)_colourBitmap.Height / ClientSize.Height;

            var destinationRect =
                e.ClipRectangle;

            var sourceRect = new Rectangle(0, (int)(facYBmpToScreen * destinationRect.Top), 1, (int)(facYBmpToScreen * destinationRect.Height));

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            e.Graphics.DrawImage(_colourBitmap, destinationRect, sourceRect, GraphicsUnit.Pixel);
        }

        /// <summary>
        /// Gets the color at Y.
        /// </summary>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public Color GetColourAtY(int y)
        {
            return new HSLColour(_h, _s, _l).ToColour();
        }

        internal void TranslateCaretPositionYToLight(int caretPositionY, out double l)
        {
            double facYBmpToScreen = 100.0 / ClientSize.Height;

            double pY = caretPositionY;

            pY = Math.Max(0, pY);
            pY = Math.Min(ClientSize.Height - 1, pY);

            pY = ClientSize.Height - pY;

            l = pY * facYBmpToScreen;

            l = Math.Max(0.0, l);
            l = Math.Min(100.0, l);
        }

        internal void TranslateLightToCaretPositionY(out int caretPositionY, double l)
        {
            double facYBmpToScreen = 100.0 / ClientSize.Height;

            l = Math.Max(0, l);
            l = Math.Min(100, l);

            double pY = (l / facYBmpToScreen);

            pY = Math.Max(0.0, pY);
            pY = Math.Min(ClientSize.Height - 1, pY);

            pY = ClientSize.Height - pY;

            caretPositionY = ToParentPositionY((int)pY);
        }

        private int ToParentPositionY(int y)
        {
            var p = new Point(0, y);
            p = PointToScreen(p);

            return Parent.PointToClient(p).Y;
        }

        public void SetLight(double l)
        {
            _l = l;

            NotifyValueChanged();
        }

        public double GetLight()
        {
            return _l;
        }
    }
}