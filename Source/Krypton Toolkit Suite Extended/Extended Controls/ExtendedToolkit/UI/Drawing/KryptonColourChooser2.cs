using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Drawing;
using ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Drawing
{
    public partial class KryptonColourChooser2 : KryptonForm
    {
        #region System
        private KryptonPanel kryptonPanel1;
        internal System.Windows.Forms.Panel pnlColour;
        internal System.Windows.Forms.Panel pnlBrightness;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbHue;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbBlue;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbGreen;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbRed;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbBrightness;
        private Controls.ScrollBar.CustomScrollBar.KryptonScrollBar ksbSaturation;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        internal System.Windows.Forms.Panel pnlSelectedColour;
        private KryptonTextBox ktxtWebColour;
        private KryptonLabel klblBlue;
        private KryptonLabel klblGreen;
        private KryptonLabel klblRed;
        private KryptonLabel klblBrightness;
        private KryptonLabel klblSaturation;
        private KryptonLabel klblHue;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblBlue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblGreen = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblRed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBrightness = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSaturation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblHue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ksbBlue = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbGreen = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbRed = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbBrightness = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbSaturation = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSelectedColour = new System.Windows.Forms.Panel();
            this.ktxtWebColour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.ksbHue = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.klblBlue);
            this.kryptonPanel1.Controls.Add(this.klblGreen);
            this.kryptonPanel1.Controls.Add(this.klblRed);
            this.kryptonPanel1.Controls.Add(this.klblBrightness);
            this.kryptonPanel1.Controls.Add(this.klblSaturation);
            this.kryptonPanel1.Controls.Add(this.klblHue);
            this.kryptonPanel1.Controls.Add(this.ksbBlue);
            this.kryptonPanel1.Controls.Add(this.ksbGreen);
            this.kryptonPanel1.Controls.Add(this.ksbRed);
            this.kryptonPanel1.Controls.Add(this.ksbBrightness);
            this.kryptonPanel1.Controls.Add(this.ksbSaturation);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.pnlSelectedColour);
            this.kryptonPanel1.Controls.Add(this.ktxtWebColour);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.pnlColour);
            this.kryptonPanel1.Controls.Add(this.pnlBrightness);
            this.kryptonPanel1.Controls.Add(this.ksbHue);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(661, 647);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // klblBlue
            // 
            this.klblBlue.Location = new System.Drawing.Point(594, 608);
            this.klblBlue.Name = "klblBlue";
            this.klblBlue.Size = new System.Drawing.Size(6, 2);
            this.klblBlue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlue.TabIndex = 94;
            this.klblBlue.Values.Text = "";
            // 
            // klblGreen
            // 
            this.klblGreen.Location = new System.Drawing.Point(594, 570);
            this.klblGreen.Name = "klblGreen";
            this.klblGreen.Size = new System.Drawing.Size(6, 2);
            this.klblGreen.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreen.TabIndex = 93;
            this.klblGreen.Values.Text = "";
            // 
            // klblRed
            // 
            this.klblRed.Location = new System.Drawing.Point(594, 532);
            this.klblRed.Name = "klblRed";
            this.klblRed.Size = new System.Drawing.Size(6, 2);
            this.klblRed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRed.TabIndex = 92;
            this.klblRed.Values.Text = "";
            // 
            // klblBrightness
            // 
            this.klblBrightness.Location = new System.Drawing.Point(594, 467);
            this.klblBrightness.Name = "klblBrightness";
            this.klblBrightness.Size = new System.Drawing.Size(6, 2);
            this.klblBrightness.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBrightness.TabIndex = 91;
            this.klblBrightness.Values.Text = "";
            // 
            // klblSaturation
            // 
            this.klblSaturation.Location = new System.Drawing.Point(594, 429);
            this.klblSaturation.Name = "klblSaturation";
            this.klblSaturation.Size = new System.Drawing.Size(6, 2);
            this.klblSaturation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSaturation.TabIndex = 90;
            this.klblSaturation.Values.Text = "";
            // 
            // klblHue
            // 
            this.klblHue.Location = new System.Drawing.Point(594, 391);
            this.klblHue.Name = "klblHue";
            this.klblHue.Size = new System.Drawing.Size(6, 2);
            this.klblHue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHue.TabIndex = 89;
            this.klblHue.Values.Text = "";
            // 
            // ksbBlue
            // 
            this.ksbBlue.Location = new System.Drawing.Point(129, 611);
            this.ksbBlue.Maximum = 255;
            this.ksbBlue.Name = "ksbBlue";
            this.ksbBlue.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbBlue.Size = new System.Drawing.Size(459, 19);
            this.ksbBlue.TabIndex = 84;
            this.ksbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleRGBScroll);
            // 
            // ksbGreen
            // 
            this.ksbGreen.Location = new System.Drawing.Point(129, 572);
            this.ksbGreen.Maximum = 255;
            this.ksbGreen.Name = "ksbGreen";
            this.ksbGreen.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbGreen.Size = new System.Drawing.Size(459, 19);
            this.ksbGreen.TabIndex = 83;
            this.ksbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleRGBScroll);
            // 
            // ksbRed
            // 
            this.ksbRed.Location = new System.Drawing.Point(129, 535);
            this.ksbRed.Maximum = 255;
            this.ksbRed.Name = "ksbRed";
            this.ksbRed.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbRed.Size = new System.Drawing.Size(459, 19);
            this.ksbRed.TabIndex = 82;
            this.ksbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleRGBScroll);
            // 
            // ksbBrightness
            // 
            this.ksbBrightness.Location = new System.Drawing.Point(129, 471);
            this.ksbBrightness.Name = "ksbBrightness";
            this.ksbBrightness.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbBrightness.Size = new System.Drawing.Size(459, 19);
            this.ksbBrightness.TabIndex = 81;
            this.ksbBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleHSVScroll);
            // 
            // ksbSaturation
            // 
            this.ksbSaturation.Location = new System.Drawing.Point(129, 433);
            this.ksbSaturation.Name = "ksbSaturation";
            this.ksbSaturation.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbSaturation.Size = new System.Drawing.Size(459, 19);
            this.ksbSaturation.TabIndex = 80;
            this.ksbSaturation.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleHSVScroll);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 467);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(98, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 79;
            this.kryptonLabel7.Values.Text = "Brightness:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 429);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(97, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 75;
            this.kryptonLabel6.Values.Text = "Saturation:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 391);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 78;
            this.kryptonLabel5.Values.Text = "Hue:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 608);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 77;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 570);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 76;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 532);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 74;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // pnlSelectedColour
            // 
            this.pnlSelectedColour.Location = new System.Drawing.Point(553, 101);
            this.pnlSelectedColour.Name = "pnlSelectedColour";
            this.pnlSelectedColour.Size = new System.Drawing.Size(96, 29);
            this.pnlSelectedColour.TabIndex = 73;
            this.pnlSelectedColour.Visible = false;
            // 
            // ktxtWebColour
            // 
            this.ktxtWebColour.Location = new System.Drawing.Point(553, 136);
            this.ktxtWebColour.Name = "ktxtWebColour";
            this.ktxtWebColour.Size = new System.Drawing.Size(96, 29);
            this.ktxtWebColour.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtWebColour.TabIndex = 72;
            this.ktxtWebColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnOk.Location = new System.Drawing.Point(553, 12);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(96, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 71;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(553, 48);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(96, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 70;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // pnlColour
            // 
            this.pnlColour.Location = new System.Drawing.Point(12, 12);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(387, 347);
            this.pnlColour.TabIndex = 40;
            // 
            // pnlBrightness
            // 
            this.pnlBrightness.Location = new System.Drawing.Point(425, 12);
            this.pnlBrightness.Name = "pnlBrightness";
            this.pnlBrightness.Size = new System.Drawing.Size(36, 347);
            this.pnlBrightness.TabIndex = 41;
            this.pnlBrightness.Visible = false;
            // 
            // ksbHue
            // 
            this.ksbHue.Location = new System.Drawing.Point(129, 394);
            this.ksbHue.Name = "ksbHue";
            this.ksbHue.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbHue.Size = new System.Drawing.Size(459, 19);
            this.ksbHue.TabIndex = 1;
            this.ksbHue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HandleHSVScroll);
            // 
            // KryptonColourChooser2
            // 
            this.AcceptButton = this.kbtnOk;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(661, 647);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourChooser2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Colour";
            this.Load += new System.EventHandler(this.KryptonColourChooser2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KryptonColourChooser2_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #endregion

        #region Enums
        private enum ChangeStyle
        {
            MOUSEMOVE,
            RGB,
            HSV,
            NONE
        }
        #endregion

        #region Variables
        private ChangeStyle _changeStyle = ChangeStyle.NONE;

        private Point _selectedPoint;

        private ColourWheel _colourWheel;

        private ColourHandler.RGB _RGB;

        private ColourHandler.HSV _HSV;
        #endregion

        public KryptonColourChooser2()
        {
            InitializeComponent();
        }

        private void KryptonColourChooser2_Load(object sender, EventArgs e)
        {
            // Turn on double-buffering, so the form looks better. 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            // These properties are set in design view, as well, but they
            // have to be set to false in order for the Paint
            // event to be able to display their contents.
            // Never hurts to make sure they're invisible.
            pnlSelectedColour.Visible = false;
            pnlBrightness.Visible = false;
            pnlColour.Visible = false;


            // Calculate the coordinates of the three
            // required regions on the form.
            Rectangle SelectedColourRectangle = new Rectangle(pnlSelectedColour.Location, pnlSelectedColour.Size);
            Rectangle BrightnessRectangle = new Rectangle(pnlBrightness.Location, pnlBrightness.Size);
            Rectangle ColourRectangle = new Rectangle(pnlColour.Location, pnlColour.Size);

            // Create the new ColorWheel class, indicating
            // the locations of the color wheel itself, the
            // brightness area, and the position of the selected color.
            _colourWheel = new ColourWheel(ColourRectangle, BrightnessRectangle, SelectedColourRectangle);

            _colourWheel.ColourChanged += new ColourWheel.ColourChangedEventHandler(this.ColourWheel_ColourChanged);

            // Set the RGB and HSV values 
            // of the NumericUpDown controls.
            SetRGB(_RGB);
            SetHSV(_HSV);
        }

        private void HandleMouse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _changeStyle = ChangeStyle.MOUSEMOVE;

                _selectedPoint = new Point(e.X, e.Y);

                Invalidate();
            }
        }

        private void Window_MouseUp(object sender, MouseEventArgs e)
        {
            _colourWheel.SetMouseUp();

            _changeStyle = ChangeStyle.NONE;
        }

        private void SetRGBLabels(ColourHandler.RGB RGB)
        {
            RefreshText(klblRed, RGB.Red);
            RefreshText(klblBlue, RGB.Blue);
            RefreshText(klblGreen, RGB.Green);
            this.ktxtWebColour.Text = ColorTranslator.ToHtml(Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)).ToString();
        }

        private void SetHSVLabels(ColourHandler.HSV HSV)
        {
            RefreshText(klblHue, HSV.Hue);
            RefreshText(klblSaturation, HSV.Saturation);
            RefreshText(klblBrightness, HSV.value);
        }

        private void SetRGB(ColourHandler.RGB RGB)
        {
            // Update the RGB values on the form.
            RefreshValue(ksbRed, RGB.Red);
            RefreshValue(ksbBlue, RGB.Blue);
            RefreshValue(ksbGreen, RGB.Green);
            SetRGBLabels(RGB);
        }

        private void SetHSV(ColourHandler.HSV HSV)
        {
            // Update the HSV values on the form.
            RefreshValue(ksbHue, HSV.Hue);
            RefreshValue(ksbSaturation, HSV.Saturation);
            RefreshValue(ksbBrightness, HSV.value);
            SetHSVLabels(HSV);
        }

        private void RefreshValue(KryptonScrollBar scrollBar, int value)
        {
            scrollBar.Value = value;
        }

        private void RefreshText(KryptonLabel label, int value)
        {
            label.Text = value.ToString();
        }

        public Color Colour
        {
            get
            {
                return _colourWheel.Colour;
            }

            set
            {
                _changeStyle = ChangeStyle.RGB;

                _RGB = new ColourHandler.RGB(value.R, value.G, value.B);

                _HSV = ColourHandler.RGBtoHSV(_RGB);
            }
        }

        private void ColourWheel_ColourChanged(object sender, ColourChangedEventArgs e)
        {
            SetRGB(e.RGB);

            SetHSV(e.HSV);
        }

        private void HandleHSVScroll(object sender, ScrollEventArgs e)
        {
            _changeStyle = ChangeStyle.HSV;

            _HSV = new ColourHandler.HSV(ksbHue.Value, ksbSaturation.Value, ksbBrightness.Value);

            SetRGB(ColourHandler.HSVtoRGB(_HSV));

            SetHSV(_HSV);

            Invalidate();
        }

        private void HandleRGBScroll(object sender, ScrollEventArgs e)
        {
            _changeStyle = ChangeStyle.RGB;

            _RGB = new ColourHandler.RGB(ksbRed.Value, ksbGreen.Value, ksbBlue.Value);

            SetHSV(ColourHandler.RGBtoHSV(_RGB));

            SetRGBLabels(_RGB);

            Invalidate();
        }

        private void KryptonColourChooser2_Paint(object sender, PaintEventArgs e)
        {
            switch (_changeStyle)
            {
                case ChangeStyle.MOUSEMOVE:
                    break;
                case ChangeStyle.RGB:
                    _colourWheel.Draw(e.Graphics, _RGB);
                    break;
                case ChangeStyle.HSV:
                    _colourWheel.Draw(e.Graphics, _HSV);
                    break;
                case ChangeStyle.NONE:
                    _colourWheel.Draw(e.Graphics, _selectedPoint);
                    break;
                default:
                    break;
            }
        }
    }
}