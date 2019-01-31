using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls;
using ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.UI
{
    public class KryptonColourChooser2 : KryptonForm
    {
        internal KryptonLabel lblBlue;
        internal KryptonLabel lblGreen;
        internal KryptonLabel lblRed;
        internal KryptonLabel lblBrightness;
        internal KryptonLabel lblSaturation;
        internal KryptonLabel lblHue;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        internal KryptonLabel Label3;
        internal KryptonLabel Label7;
        internal System.Windows.Forms.Panel pnlColor;
        internal KryptonLabel Label6;
        internal KryptonLabel Label1;
        internal KryptonLabel Label5;
        internal System.Windows.Forms.Panel pnlSelectedColor;
        internal System.Windows.Forms.Panel pnlBrightness;
        internal KryptonLabel Label2;
        private KryptonPanel kpnlbg;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbHue;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbBlue;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbGreen;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbRed;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbBrightness;
        private ScrollBar.CustomScrollBar.KryptonScrollBar ksbSaturation;
        private KryptonTextBox ktxtWebColour;
        private System.ComponentModel.IContainer components;

        public KryptonColourChooser2()
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
            this.components = new System.ComponentModel.Container();
            this.lblBlue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblGreen = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBrightness = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSaturation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblHue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.Label6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlSelectedColor = new System.Windows.Forms.Panel();
            this.pnlBrightness = new System.Windows.Forms.Panel();
            this.Label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpnlbg = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtWebColour = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ksbBlue = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbGreen = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbRed = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbBrightness = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbSaturation = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            this.ksbHue = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.KryptonScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlbg)).BeginInit();
            this.kpnlbg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBlue
            // 
            this.lblBlue.Location = new System.Drawing.Point(317, 360);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(39, 20);
            this.lblBlue.TabIndex = 54;
            // 
            // lblGreen
            // 
            this.lblGreen.Location = new System.Drawing.Point(317, 336);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 20);
            this.lblGreen.TabIndex = 53;
            // 
            // lblRed
            // 
            this.lblRed.Location = new System.Drawing.Point(317, 312);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 20);
            this.lblRed.TabIndex = 52;
            // 
            // lblBrightness
            // 
            this.lblBrightness.Location = new System.Drawing.Point(317, 280);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(39, 20);
            this.lblBrightness.TabIndex = 51;
            // 
            // lblSaturation
            // 
            this.lblSaturation.Location = new System.Drawing.Point(317, 256);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(39, 20);
            this.lblSaturation.TabIndex = 50;
            // 
            // lblHue
            // 
            this.lblHue.Location = new System.Drawing.Point(317, 232);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(39, 20);
            this.lblHue.TabIndex = 49;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(296, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 24);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(296, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 24);
            this.btnOK.TabIndex = 41;
            this.btnOK.Values.Text = "OK";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 360);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 20);
            this.Label3.TabIndex = 34;
            this.Label3.Values.Text = "Blue";
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(8, 280);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(67, 20);
            this.Label7.TabIndex = 37;
            this.Label7.Values.Text = "Brightness";
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(8, 8);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(224, 216);
            this.pnlColor.TabIndex = 38;
            this.pnlColor.Visible = false;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(8, 256);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(67, 20);
            this.Label6.TabIndex = 36;
            this.Label6.Values.Text = "Saturation";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 312);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 20);
            this.Label1.TabIndex = 32;
            this.Label1.Values.Text = "Red";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(8, 232);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(33, 20);
            this.Label5.TabIndex = 35;
            this.Label5.Values.Text = "Hue";
            // 
            // pnlSelectedColor
            // 
            this.pnlSelectedColor.Location = new System.Drawing.Point(296, 72);
            this.pnlSelectedColor.Name = "pnlSelectedColor";
            this.pnlSelectedColor.Size = new System.Drawing.Size(64, 24);
            this.pnlSelectedColor.TabIndex = 40;
            this.pnlSelectedColor.Visible = false;
            // 
            // pnlBrightness
            // 
            this.pnlBrightness.Location = new System.Drawing.Point(240, 8);
            this.pnlBrightness.Name = "pnlBrightness";
            this.pnlBrightness.Size = new System.Drawing.Size(24, 216);
            this.pnlBrightness.TabIndex = 39;
            this.pnlBrightness.Visible = false;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 336);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 20);
            this.Label2.TabIndex = 33;
            this.Label2.Values.Text = "Green";
            // 
            // kpnlbg
            // 
            this.kpnlbg.Controls.Add(this.ktxtWebColour);
            this.kpnlbg.Controls.Add(this.ksbBlue);
            this.kpnlbg.Controls.Add(this.ksbGreen);
            this.kpnlbg.Controls.Add(this.ksbRed);
            this.kpnlbg.Controls.Add(this.ksbBrightness);
            this.kpnlbg.Controls.Add(this.ksbSaturation);
            this.kpnlbg.Controls.Add(this.ksbHue);
            this.kpnlbg.Controls.Add(this.Label5);
            this.kpnlbg.Controls.Add(this.lblBlue);
            this.kpnlbg.Controls.Add(this.Label6);
            this.kpnlbg.Controls.Add(this.lblGreen);
            this.kpnlbg.Controls.Add(this.Label7);
            this.kpnlbg.Controls.Add(this.lblRed);
            this.kpnlbg.Controls.Add(this.lblBrightness);
            this.kpnlbg.Controls.Add(this.Label1);
            this.kpnlbg.Controls.Add(this.lblSaturation);
            this.kpnlbg.Controls.Add(this.Label2);
            this.kpnlbg.Controls.Add(this.lblHue);
            this.kpnlbg.Controls.Add(this.Label3);
            this.kpnlbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlbg.Location = new System.Drawing.Point(0, 0);
            this.kpnlbg.Name = "kpnlbg";
            this.kpnlbg.Size = new System.Drawing.Size(368, 389);
            this.kpnlbg.TabIndex = 58;
            // 
            // ktxtWebColour
            // 
            this.ktxtWebColour.Location = new System.Drawing.Point(296, 102);
            this.ktxtWebColour.Name = "ktxtWebColour";
            this.ktxtWebColour.Size = new System.Drawing.Size(64, 23);
            this.ktxtWebColour.TabIndex = 60;
            // 
            // ksbBlue
            // 
            this.ksbBlue.Location = new System.Drawing.Point(80, 359);
            this.ksbBlue.Maximum = 255;
            this.ksbBlue.Name = "ksbBlue";
            this.ksbBlue.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbBlue.Size = new System.Drawing.Size(224, 19);
            this.ksbBlue.TabIndex = 59;
            // 
            // ksbGreen
            // 
            this.ksbGreen.Location = new System.Drawing.Point(80, 335);
            this.ksbGreen.Maximum = 255;
            this.ksbGreen.Name = "ksbGreen";
            this.ksbGreen.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbGreen.Size = new System.Drawing.Size(224, 19);
            this.ksbGreen.TabIndex = 59;
            // 
            // ksbRed
            // 
            this.ksbRed.Location = new System.Drawing.Point(80, 311);
            this.ksbRed.Maximum = 255;
            this.ksbRed.Name = "ksbRed";
            this.ksbRed.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbRed.Size = new System.Drawing.Size(224, 19);
            this.ksbRed.TabIndex = 59;
            // 
            // ksbBrightness
            // 
            this.ksbBrightness.Location = new System.Drawing.Point(80, 279);
            this.ksbBrightness.Maximum = 255;
            this.ksbBrightness.Name = "ksbBrightness";
            this.ksbBrightness.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbBrightness.Size = new System.Drawing.Size(224, 19);
            this.ksbBrightness.TabIndex = 59;
            // 
            // ksbSaturation
            // 
            this.ksbSaturation.Location = new System.Drawing.Point(80, 255);
            this.ksbSaturation.Maximum = 255;
            this.ksbSaturation.Name = "ksbSaturation";
            this.ksbSaturation.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbSaturation.Size = new System.Drawing.Size(224, 19);
            this.ksbSaturation.TabIndex = 56;
            // 
            // ksbHue
            // 
            this.ksbHue.Location = new System.Drawing.Point(80, 230);
            this.ksbHue.Maximum = 255;
            this.ksbHue.Name = "ksbHue";
            this.ksbHue.Orientation = ExtendedControls.Base.Code.ScrollBar.CustomScrollBar.ScrollBarOrientation.HORIZONTAL;
            this.ksbHue.Size = new System.Drawing.Size(224, 19);
            this.ksbHue.TabIndex = 55;
            // 
            // KryptonColourChooser2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 389);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlSelectedColor);
            this.Controls.Add(this.pnlBrightness);
            this.Controls.Add(this.kpnlbg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourChooser2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Colour";
            this.Load += new System.EventHandler(this.ColourChooser2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorChooser2_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlbg)).EndInit();
            this.kpnlbg.ResumeLayout(false);
            this.kpnlbg.PerformLayout();
            this.ResumeLayout(false);

        }
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

        private void ColourChooser2_Load(object sender, System.EventArgs e)
        {
            // Turn on double-buffering, so the form looks better. 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            // These properties are set in design view, as well, but they
            // have to be set to false in order for the Paint
            // event to be able to display their contents.
            // Never hurts to make sure they're invisible.
            pnlSelectedColor.Visible = false;
            pnlBrightness.Visible = false;
            pnlColor.Visible = false;


            // Calculate the coordinates of the three
            // required regions on the form.
            Rectangle SelectedColourRectangle = new Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size);
            Rectangle BrightnessRectangle = new Rectangle(pnlBrightness.Location, pnlBrightness.Size);
            Rectangle ColourRectangle = new Rectangle(pnlColor.Location, pnlColor.Size);

            // Create the new ColorWheel class, indicating
            // the locations of the color wheel itself, the
            // brightness area, and the position of the selected color.
            myColourWheel = new ColourWheel(ColourRectangle, BrightnessRectangle, SelectedColourRectangle);
            myColourWheel.ColourChanged +=
                new ColourWheel.ColourChangedEventHandler(this.myColourWheel_ColourChanged);

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

        private void SetRGBLabels(ColourHandler.RGB RGB)
        {
            RefreshText(lblRed, RGB.Red);
            RefreshText(lblBlue, RGB.Blue);
            RefreshText(lblGreen, RGB.Green);
            this.ktxtWebColour.Text = ColorTranslator.ToHtml(Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)).ToString();
        }

        private void SetHSVLabels(ColourHandler.HSV HSV)
        {
            RefreshText(lblHue, HSV.Hue);
            RefreshText(lblSaturation, HSV.Saturation);
            RefreshText(lblBrightness, HSV.value);
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

        private void RefreshValue(KryptonScrollBar hsb, int value)
        {
            hsb.Value = value;
        }

        private void RefreshText(KryptonLabel lbl, int value)
        {
            lbl.Text = value.ToString();
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

        private void HandleHSVScroll(object sender, ScrollEventArgs e)
        // If the H, S, or V values change, use this 
        // code to update the RGB values and invalidate
        // the color wheel (so it updates the pointers).
        // Check the isInUpdate flag to avoid recursive events
        // when you update the NumericUpdownControls.
        {
            changeType = ChangeStyle.HSV;
            HSV = new ColourHandler.HSV(ksbHue.Value, ksbSaturation.Value, ksbBrightness.Value);
            SetRGB(ColourHandler.HSVtoRGB(HSV));
            SetHSVLabels(HSV);
            this.Invalidate();
        }

        private void HandleRGBScroll(object sender, ScrollEventArgs e)
        {
            // If the R, G, or B values change, use this 
            // code to update the HSV values and invalidate
            // the color wheel (so it updates the pointers).
            // Check the isInUpdate flag to avoid recursive events
            // when you update the NumericUpdownControls.
            changeType = ChangeStyle.RGB;
            RGB = new ColourHandler.RGB(ksbRed.Value, ksbGreen.Value, ksbBlue.Value);
            SetHSV(ColourHandler.RGBtoHSV(RGB));
            SetRGBLabels(RGB);
            this.Invalidate();
        }

        private void ColorChooser2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
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