#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.UI
{
    /// <summary>
    /// Summary description for ColorChooser1.
    /// </summary>
    [ToolboxBitmap(typeof(Form))]
    public class KryptonColourChooser1 : KryptonForm
    {
        #region Designer Code
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        internal KryptonLabel Label3;
        internal KryptonLabel Label7;
        internal System.Windows.Forms.Panel pnlColour;
        internal KryptonLabel Label6;
        internal KryptonLabel Label1;
        internal KryptonLabel Label5;
        internal System.Windows.Forms.Panel pnlSelectedColour;
        internal System.Windows.Forms.Panel pnlBrightness;
        internal KryptonLabel Label4;
        internal KryptonLabel Label2;
        private KryptonPanel kpbg;
        private KryptonTextBox ktxtWebColour;
        private KryptonNumericUpDown knumBlue;
        private KryptonNumericUpDown knumGreen;
        private KryptonNumericUpDown knumRed;
        private KryptonNumericUpDown knumBrightness;
        private KryptonNumericUpDown knumSaturation;
        private KryptonNumericUpDown knumHue;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public KryptonColourChooser1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlColour = new System.Windows.Forms.Panel();
            this.Label6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSelectedColour = new System.Windows.Forms.Panel();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.Label4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpbg = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knumHue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumSaturation = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBrightness = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBlue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumGreen = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumRed = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.ktxtWebColour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpbg)).BeginInit();
            this.kpbg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(192, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(120, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 24);
            this.btnOK.TabIndex = 54;
            this.btnOK.Values.Text = "OK";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(152, 280);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 20);
            this.Label3.TabIndex = 45;
            this.Label3.Values.Text = "Blue:";
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 280);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 20);
            this.Label7.TabIndex = 50;
            this.Label7.Values.Text = "Brightness:";
            // 
            // pnlColour
            // 
            this.pnlColour.Location = new System.Drawing.Point(8, 8);
            this.pnlColour.Name = "pnlColour";
            this.pnlColour.Size = new System.Drawing.Size(176, 176);
            this.pnlColour.TabIndex = 51;
            this.pnlColour.Visible = false;
            this.pnlColour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 256);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(69, 20);
            this.Label6.TabIndex = 49;
            this.Label6.Values.Text = "Saturation:";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(152, 232);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 20);
            this.Label1.TabIndex = 43;
            this.Label1.Values.Text = "Red:";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 232);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 20);
            this.Label5.TabIndex = 48;
            this.Label5.Values.Text = "Hue:";
            // 
            // pnlSelectedColour
            // 
            this.pnlSelectedColour.Location = new System.Drawing.Point(136, 203);
            this.pnlSelectedColour.Name = "pnlSelectedColour";
            this.pnlSelectedColour.Size = new System.Drawing.Size(48, 20);
            this.pnlSelectedColour.TabIndex = 53;
            this.pnlSelectedColour.Visible = false;
            // 
            // pnlBrightness
            // 
            this.pnlBrightness.Location = new System.Drawing.Point(208, 8);
            this.pnlBrightness.Name = "pnlBrightness";
            this.pnlBrightness.Size = new System.Drawing.Size(16, 176);
            this.pnlBrightness.TabIndex = 52;
            this.pnlBrightness.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(80, 203);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 20);
            this.Label4.TabIndex = 46;
            this.Label4.Values.Text = "Colour:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(152, 256);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 20);
            this.Label2.TabIndex = 44;
            this.Label2.Values.Text = "Green:";
            // 
            // kpbg
            // 
            this.kpbg.Controls.Add(this.ktxtWebColour);
            this.kpbg.Controls.Add(this.knumBlue);
            this.kpbg.Controls.Add(this.knumGreen);
            this.kpbg.Controls.Add(this.knumRed);
            this.kpbg.Controls.Add(this.knumBrightness);
            this.kpbg.Controls.Add(this.knumSaturation);
            this.kpbg.Controls.Add(this.knumHue);
            this.kpbg.Controls.Add(this.Label4);
            this.kpbg.Controls.Add(this.Label5);
            this.kpbg.Controls.Add(this.Label1);
            this.kpbg.Controls.Add(this.Label3);
            this.kpbg.Controls.Add(this.Label6);
            this.kpbg.Controls.Add(this.Label2);
            this.kpbg.Controls.Add(this.Label7);
            this.kpbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpbg.Location = new System.Drawing.Point(0, 0);
            this.kpbg.Name = "kpbg";
            this.kpbg.Size = new System.Drawing.Size(264, 349);
            this.kpbg.TabIndex = 57;
            // 
            // knumHue
            // 
            this.knumHue.Location = new System.Drawing.Point(98, 232);
            this.knumHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumHue.Name = "knumHue";
            this.knumHue.Size = new System.Drawing.Size(48, 22);
            this.knumHue.TabIndex = 51;
            // 
            // knumSaturation
            // 
            this.knumSaturation.Location = new System.Drawing.Point(98, 256);
            this.knumSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumSaturation.Name = "knumSaturation";
            this.knumSaturation.Size = new System.Drawing.Size(48, 22);
            this.knumSaturation.TabIndex = 52;
            // 
            // knumBrightness
            // 
            this.knumBrightness.Location = new System.Drawing.Point(98, 280);
            this.knumBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBrightness.Name = "knumBrightness";
            this.knumBrightness.Size = new System.Drawing.Size(48, 22);
            this.knumBrightness.TabIndex = 53;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(204, 280);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(48, 22);
            this.knumBlue.StateActive.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateActive.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.TabIndex = 56;
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(204, 256);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(48, 22);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumGreen.TabIndex = 55;
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(204, 232);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(48, 22);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.TabIndex = 54;
            // 
            // ktxtWebColour
            // 
            this.ktxtWebColour.Location = new System.Drawing.Point(190, 200);
            this.ktxtWebColour.MaxLength = 6;
            this.ktxtWebColour.Name = "ktxtWebColour";
            this.ktxtWebColour.Size = new System.Drawing.Size(66, 23);
            this.ktxtWebColour.TabIndex = 57;
            // 
            // KryptonColourChooser1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlColour);
            this.Controls.Add(this.pnlSelectedColour);
            this.Controls.Add(this.pnlBrightness);
            this.Controls.Add(this.kpbg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourChooser1";
            this.Text = "Select Colour";
            this.Load += new System.EventHandler(this.ColourChooser1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColourChooser1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.kpbg)).EndInit();
            this.kpbg.ResumeLayout(false);
            this.kpbg.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        #endregion

        private enum ChangeStyle
        {
            MouseMove,
            RGB,
            HSV,
            None
        }

        private ChangeStyle changeType = ChangeStyle.None;
        private Point selectedPoint;

        private ColourWheel myColourWheel;
        private ColourHandler.RGB RGB;
        private ColourHandler.HSV HSV;
        private bool isInUpdate = false;

        private void ColourChooser1_Load(object sender, System.EventArgs e)
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
            Rectangle SelectedColourRectangle =
              new Rectangle(pnlSelectedColour.Location, pnlSelectedColour.Size);
            Rectangle BrightnessRectangle =
              new Rectangle(pnlBrightness.Location, pnlBrightness.Size);
            Rectangle ColourRectangle =
              new Rectangle(pnlColour.Location, pnlColour.Size);

            // Create the new ColorWheel class, indicating
            // the locations of the color wheel itself, the
            // brightness area, and the position of the selected color.
            myColourWheel = new ColourWheel(
              ColourRectangle, BrightnessRectangle,
              SelectedColourRectangle);
            myColourWheel.ColourChanged +=
              new ColourWheel.ColourChangedEventHandler(
              this.myColourWheel_ColourChanged);

            // Set the RGB and HSV values 
            // of the NumericUpDown controls.
            SetRGB(RGB);
            SetHSV(HSV);

        }

        private void HandleMouse(object sender, MouseEventArgs e)
        {
            // If you have the left mouse button down, 
            // then update the selectedPoint value and 
            // force a repaint of the color wheel.
            if (e.Button == MouseButtons.Left)
            {
                changeType = ChangeStyle.MouseMove;
                selectedPoint = new Point(e.X, e.Y);
                this.Invalidate();
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            myColourWheel.SetMouseUp();
            changeType = ChangeStyle.None;
        }

        private void HandleRGBChange(object sender, System.EventArgs e)
        {

            // If the R, G, or B values change, use this 
            // code to update the HSV values and invalidate
            // the color wheel (so it updates the pointers).
            // Check the isInUpdate flag to avoid recursive events
            // when you update the NumericUpdownControls.
            if (!isInUpdate)
            {
                changeType = ChangeStyle.RGB;
                RGB = new ColourHandler.RGB((int)knumRed.Value, (int)knumGreen.Value, (int)knumBlue.Value);
                SetHSV(ColourHandler.RGBtoHSV(RGB));
                this.Invalidate();
            }
        }

        private void HandleHSVChange(object sender, EventArgs e)
        {
            // If the H, S, or V values change, use this 
            // code to update the RGB values and invalidate
            // the color wheel (so it updates the pointers).
            // Check the isInUpdate flag to avoid recursive events
            // when you update the NumericUpdownControls.
            if (!isInUpdate)
            {
                changeType = ChangeStyle.HSV;
                HSV = new ColourHandler.HSV((int)(knumHue.Value), (int)(knumSaturation.Value), (int)(knumBrightness.Value));
                SetRGB(ColourHandler.HSVtoRGB(HSV));
                this.Invalidate();
            }
        }

        private void SetRGB(ColourHandler.RGB RGB)
        {
            // Update the RGB values on the form, but don't trigger
            // the ValueChanged event of the form. The isInUpdate
            // variable ensures that the event procedures
            // exit without doing anything.
            isInUpdate = true;
            RefreshValue(knumRed, RGB.Red);
            RefreshValue(knumBlue, RGB.Blue);
            RefreshValue(knumGreen, RGB.Green);
            isInUpdate = false;
            this.ktxtWebColour.Text = ColorTranslator.ToHtml(Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)).ToString();
        }

        private void SetHSV(ColourHandler.HSV HSV)
        {
            // Update the HSV values on the form, but don't trigger
            // the ValueChanged event of the form. The isInUpdate
            // variable ensures that the event procedures
            // exit without doing anything.
            isInUpdate = true;
            RefreshValue(knumHue, HSV.Hue);
            RefreshValue(knumSaturation, HSV.Saturation);
            RefreshValue(knumBrightness, HSV.value);
            isInUpdate = false;
        }

        private void HandleTextChanged(object sender, System.EventArgs e)
        {
            // This step works around a bug -- unless you actively
            // retrieve the value, the min and max settings for the 
            // control aren't honored when you type text. This may
            // be fixed in the 1.1 version, but in VS.NET 1.0, this 
            // step is required.
            Decimal x = ((KryptonNumericUpDown)sender).Value;
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
                return myColourWheel.Colour;
            }

            set
            {
                // Indicate the color change type. Either RGB or HSV
                // will cause the color wheel to update the position
                // of the pointer.
                changeType = ChangeStyle.RGB;
                RGB = new ColourHandler.RGB(value.R, value.G, value.B);
                HSV = ColourHandler.RGBtoHSV(RGB);
            }
        }

        private void myColourWheel_ColourChanged(object sender, ColourChangedEventArgs e)
        {
            SetRGB(e.RGB);
            SetHSV(e.HSV);
            //this.txtWebColor.Text = ColorTranslator.ToHtml(Color).ToString();
        }

        private void ColourChooser1_Paint(object sender, PaintEventArgs e)
        {
            // Depending on the circumstances, force a repaint
            // of the color wheel passing different information.
            switch (changeType)
            {
                case ChangeStyle.HSV:
                    myColourWheel.Draw(e.Graphics, HSV);
                    break;
                case ChangeStyle.MouseMove:
                case ChangeStyle.None:
                    myColourWheel.Draw(e.Graphics, selectedPoint);
                    break;
                case ChangeStyle.RGB:
                    myColourWheel.Draw(e.Graphics, RGB);
                    break;
            }
        }
    }
}