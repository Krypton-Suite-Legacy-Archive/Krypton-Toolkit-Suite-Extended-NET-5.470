using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Drawing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Drawing
{
    public partial class KryptonColourChooser1 : KryptonForm
    {
        #region System
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        internal System.Windows.Forms.Panel pnlSelectedColour;
        private KryptonTextBox ktxtWebColour;
        private KryptonButton kbtnCancel;
        internal System.Windows.Forms.Panel pnlBrightness;
        internal System.Windows.Forms.Panel pnlColour;
        private KryptonButton kbtnOk;
        private KryptonNumericUpDown knumHue;
        private KryptonNumericUpDown knumSaturation;
        private KryptonNumericUpDown knumBrightness;
        private KryptonNumericUpDown knumGreen;
        private KryptonNumericUpDown knumBlue;
        private KryptonNumericUpDown knumRed;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel5;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSelectedColour = new System.Windows.Forms.Panel();
            this.ktxtWebColour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumRed = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBlue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumGreen = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBrightness = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumSaturation = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumHue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.knumHue);
            this.kryptonPanel1.Controls.Add(this.knumSaturation);
            this.kryptonPanel1.Controls.Add(this.knumBrightness);
            this.kryptonPanel1.Controls.Add(this.knumGreen);
            this.kryptonPanel1.Controls.Add(this.knumBlue);
            this.kryptonPanel1.Controls.Add(this.knumRed);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.pnlSelectedColour);
            this.kryptonPanel1.Controls.Add(this.ktxtWebColour);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.pnlBrightness);
            this.kryptonPanel1.Controls.Add(this.pnlColour);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(476, 571);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(312, 475);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 60;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(312, 437);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 59;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(312, 399);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 58;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(236, 356);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(68, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 57;
            this.kryptonLabel1.Values.Text = "Colour:";
            // 
            // pnlSelectedColour
            // 
            this.pnlSelectedColour.Location = new System.Drawing.Point(310, 354);
            this.pnlSelectedColour.Name = "pnlSelectedColour";
            this.pnlSelectedColour.Size = new System.Drawing.Size(48, 29);
            this.pnlSelectedColour.TabIndex = 56;
            this.pnlSelectedColour.Visible = false;
            // 
            // ktxtWebColour
            // 
            this.ktxtWebColour.Location = new System.Drawing.Point(364, 354);
            this.ktxtWebColour.Name = "ktxtWebColour";
            this.ktxtWebColour.Size = new System.Drawing.Size(100, 29);
            this.ktxtWebColour.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtWebColour.TabIndex = 55;
            this.ktxtWebColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(404, 529);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 54;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // pnlBrightness
            // 
            this.pnlBrightness.Location = new System.Drawing.Point(415, 12);
            this.pnlBrightness.Name = "pnlBrightness";
            this.pnlBrightness.Size = new System.Drawing.Size(33, 325);
            this.pnlBrightness.TabIndex = 53;
            this.pnlBrightness.Visible = false;
            // 
            // pnlColour
            // 
            this.pnlColour.Location = new System.Drawing.Point(12, 12);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(362, 325);
            this.pnlColour.TabIndex = 52;
            this.pnlColour.Visible = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(107, 399);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 61;
            this.kryptonLabel5.Values.Text = "Hue:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(107, 437);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(97, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 59;
            this.kryptonLabel6.Values.Text = "Saturation:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(107, 475);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(98, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 62;
            this.kryptonLabel7.Values.Text = "Brightness:";
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(377, 399);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(87, 28);
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumRed.TabIndex = 63;
            this.knumRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(377, 475);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(87, 28);
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBlue.TabIndex = 64;
            this.knumBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(377, 437);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(87, 28);
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreen.TabIndex = 65;
            this.knumGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBrightness
            // 
            this.knumBrightness.Location = new System.Drawing.Point(217, 475);
            this.knumBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBrightness.Name = "knumBrightness";
            this.knumBrightness.Size = new System.Drawing.Size(87, 28);
            this.knumBrightness.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBrightness.TabIndex = 66;
            this.knumBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumSaturation
            // 
            this.knumSaturation.Location = new System.Drawing.Point(217, 437);
            this.knumSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumSaturation.Name = "knumSaturation";
            this.knumSaturation.Size = new System.Drawing.Size(87, 28);
            this.knumSaturation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumSaturation.TabIndex = 67;
            this.knumSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumHue
            // 
            this.knumHue.Location = new System.Drawing.Point(217, 399);
            this.knumHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumHue.Name = "knumHue";
            this.knumHue.Size = new System.Drawing.Size(87, 28);
            this.knumHue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumHue.TabIndex = 68;
            this.knumHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnOk.Location = new System.Drawing.Point(366, 529);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 69;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // KryptonColourChooser1
            // 
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(476, 571);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourChooser1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Colour";
            this.Load += new System.EventHandler(this.KryptonColourChooser1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KryptonColourChooser1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    if (components )
            //    {

            //    }
            //}

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
        private ChangeStyle _changeType = ChangeStyle.NONE;

        private Point _selectedPoint;

        private ColourWheel _colourWheel;

        private ColourHandler.RGB _RGB;

        private ColourHandler.HSV _HSV;

        private bool _isInUpdate = false;
        #endregion

        #region Constructor
        public KryptonColourChooser1()
        {
            InitializeComponent();
        }
        #endregion

        private void KryptonColourChooser1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SetStyle(ControlStyles.UserPaint, true);

            SetStyle(ControlStyles.DoubleBuffer, true);

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

            // Create the new ColourWheel class, indicating
            // the locations of the colour wheel itself, the
            // brightness area, and the position of the selected colour.
            _colourWheel = new ColourWheel(ColourRectangle, BrightnessRectangle, SelectedColourRectangle);

            _colourWheel.ColourChanged += new ColourWheel.ColourChangedEventHandler(ColourWheel_ColourChanged);

            // Set the RGB and HSV values 
            // of the NumericUpDown controls.
            SetRGB(_RGB);

            SetHSV(_HSV);
        }

        private void ColourWheel_ColourChanged(object sender, ColourChangedEventArgs e)
        {
            SetRGB(e.RGB);

            SetHSV(e.HSV);
        }

        #region Misc
        private void HandleMouse(object sender, MouseEventArgs e)
        {
            // If you have the left mouse button down, 
            // then update the selectedPoint value and 
            // force a repaint of the color wheel.
            if (e.Button == MouseButtons.Left)
            {
                _changeType = ChangeStyle.MOUSEMOVE;

                _selectedPoint = new Point(e.X, e.Y);

                Invalidate();
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            _colourWheel.SetMouseUp();

            _changeType = ChangeStyle.NONE;
        }

        private void HandleRGBChange(object sender, System.EventArgs e)
        {

            // If the R, G, or B values change, use this 
            // code to update the HSV values and invalidate
            // the color wheel (so it updates the pointers).
            // Check the isInUpdate flag to avoid recursive events
            // when you update the NumericUpdownControls.
            if (!_isInUpdate)
            {
                _changeType = ChangeStyle.RGB;

                _RGB = new ColourHandler.RGB((int)knumRed.Value, (int)knumGreen.Value, (int)knumBlue.Value);

                SetHSV(ColourHandler.RGBtoHSV(_RGB));
                Invalidate();
            }
        }

        private void HandleHSVChange(object sender, EventArgs e)
        {
            // If the H, S, or V values change, use this 
            // code to update the RGB values and invalidate
            // the color wheel (so it updates the pointers).
            // Check the isInUpdate flag to avoid recursive events
            // when you update the NumericUpdownControls.
            if (!_isInUpdate)
            {
                _changeType = ChangeStyle.HSV;

                _HSV = new ColourHandler.HSV((int)(knumHue.Value), (int)(knumSaturation.Value), (int)(knumBrightness.Value));

                SetRGB(ColourHandler.HSVtoRGB(_HSV));

                Invalidate();
            }
        }

        private void SetRGB(ColourHandler.RGB RGB)
        {
            // Update the RGB values on the form, but don't trigger
            // the ValueChanged event of the form. The isInUpdate
            // variable ensures that the event procedures
            // exit without doing anything.
            _isInUpdate = true;

            RefreshValue(knumRed, RGB.Red);

            RefreshValue(knumBlue, RGB.Blue);

            RefreshValue(knumGreen, RGB.Green);

            _isInUpdate = false;

            ktxtWebColour.Text = ColorTranslator.ToHtml(Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)).ToString();
        }

        private void SetHSV(ColourHandler.HSV HSV)
        {
            // Update the HSV values on the form, but don't trigger
            // the ValueChanged event of the form. The isInUpdate
            // variable ensures that the event procedures
            // exit without doing anything.
            _isInUpdate = true;

            RefreshValue(knumHue, HSV.Hue);

            RefreshValue(knumSaturation, HSV.Saturation);

            RefreshValue(knumBrightness, HSV.value);

            _isInUpdate = false;
        }

        private void HandleTextChanged(object sender, System.EventArgs e)
        {
            // This step works around a bug -- unless you actively
            // retrieve the value, the min and max settings for the 
            // control aren't honored when you type text. This may
            // be fixed in the 1.1 version, but in VS.NET 1.0, this 
            // step is required.
            Decimal x = ((NumericUpDown)sender).Value;
        }

        private void RefreshValue(KryptonNumericUpDown knum, int value)
        {
            // Update the value of the NumericUpDown control, 
            // if the value is different than the current value.
            // Refresh the control, causing an immediate repaint.
            if (knum.Value != value)
            {
                knum.Value = value;
                knum.Refresh();
            }
        }

        public Color Color
        {
            // Get or set the color to be
            // displayed in the color wheel.
            get
            {
                return _colourWheel.Colour;
            }

            set
            {
                // Indicate the color change type. Either RGB or HSV
                // will cause the color wheel to update the position
                // of the pointer.
                _changeType = ChangeStyle.RGB;

                _RGB = new ColourHandler.RGB(value.R, value.G, value.B);

                _HSV = ColourHandler.RGBtoHSV(_RGB);
            }
        }
        #endregion

        private void KryptonColourChooser1_Paint(object sender, PaintEventArgs e)
        {
            switch (_changeType)
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