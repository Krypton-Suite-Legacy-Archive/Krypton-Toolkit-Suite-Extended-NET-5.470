using ComponentFactory.Krypton.Toolkit;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public class AdobeColourDialog : KryptonForm
    {
        #region Designer Code
        private Controls.Colours.Controls.AdobeVerticalColourSlider adobeVerticalColourSlider1;
        private KryptonPanel kryptonPanel1;
        private KryptonRadioButton kryptonRadioButton7;
        private KryptonRadioButton krbtnBlue;
        private KryptonRadioButton kryptonRadioButton8;
        private KryptonRadioButton kryptonRadioButton9;
        private KryptonRadioButton krbtnBrightness;
        private KryptonRadioButton krbtnGreen;
        private KryptonRadioButton krbtnSaturation;
        private KryptonRadioButton krbtnRed;
        private KryptonLabel kryptonLabel2;
        private KryptonRadioButton krbtnHue;
        private KryptonCheckBox kcbWebColours;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel pnlBlankBox;
        private System.Windows.Forms.Panel pnlSecondaryColour;
        private System.Windows.Forms.Panel pnlPrimaryColour;
        private KryptonNumericUpDown kryptonNumericUpDown7;
        private KryptonNumericUpDown kryptonNumericUpDown8;
        private KryptonNumericUpDown kryptonNumericUpDown9;
        private KryptonNumericUpDown kryptonNumericUpDown4;
        private KryptonNumericUpDown kryptonNumericUpDown5;
        private KryptonNumericUpDown kryptonNumericUpDown6;
        private KryptonNumericUpDown kryptonNumericUpDown3;
        private KryptonNumericUpDown kryptonNumericUpDown2;
        private KryptonNumericUpDown kryptonNumericUpDown1;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel6;
        private KryptonButton kryptonButton2;
        private KryptonButton kryptonButton1;
        private KryptonLabel kryptonLabel13;
        private KryptonLabel kryptonLabel12;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel11;
        private KryptonNumericUpDown kryptonNumericUpDown13;
        private KryptonNumericUpDown kryptonNumericUpDown10;
        private KryptonNumericUpDown kryptonNumericUpDown11;
        private KryptonNumericUpDown kryptonNumericUpDown12;
        private Controls.Colours.Controls.ColourComparer colourComparer1;
        private Controls.KryptonPromptTextBox kryptonPromptTextBox1;
        private KryptonLabel kryptonLabel14;
        private Controls.Colours.Controls.Adobe2DColourBox adobe2DColourBox1;

        private void InitializeComponent()
        {
            ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB hsb1 = new ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB();
            ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB hsb2 = new ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdobeColourDialog));
            this.adobe2DColourBox1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.Adobe2DColourBox();
            this.adobeVerticalColourSlider1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.AdobeVerticalColourSlider();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.colourComparer1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourComparer();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonNumericUpDown13 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown10 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown11 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown12 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonNumericUpDown7 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown8 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown9 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown4 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown5 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown6 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown3 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown2 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.pnlBlankBox = new System.Windows.Forms.Panel();
            this.pnlSecondaryColour = new System.Windows.Forms.Panel();
            this.pnlPrimaryColour = new System.Windows.Forms.Panel();
            this.kryptonRadioButton7 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnBlue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton8 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton9 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnBrightness = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnGreen = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnSaturation = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnRed = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krbtnHue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kcbWebColours = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPromptTextBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.pnlBlankBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adobe2DColourBox1
            // 
            this.adobe2DColourBox1.BaseColourComponent = ExtendedControls.Base.Enumerations.ColourComponent.HUE;
            hsb1.B = 1D;
            hsb1.H = 0D;
            hsb1.S = 1D;
            this.adobe2DColourBox1.HSB = hsb1;
            this.adobe2DColourBox1.Location = new System.Drawing.Point(12, 26);
            this.adobe2DColourBox1.Name = "adobe2DColourBox1";
            this.adobe2DColourBox1.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adobe2DColourBox1.Size = new System.Drawing.Size(260, 260);
            this.adobe2DColourBox1.TabIndex = 0;
            this.adobe2DColourBox1.WebSafeColoursOnly = false;
            // 
            // adobeVerticalColourSlider1
            // 
            this.adobeVerticalColourSlider1.BackColor = System.Drawing.Color.Transparent;
            this.adobeVerticalColourSlider1.BaseColourComponent = ExtendedControls.Base.Enumerations.ColourComponent.HUE;
            hsb2.B = 1D;
            hsb2.H = 0D;
            hsb2.S = 1D;
            this.adobeVerticalColourSlider1.HSB = hsb2;
            this.adobeVerticalColourSlider1.Location = new System.Drawing.Point(278, 26);
            this.adobeVerticalColourSlider1.Name = "adobeVerticalColourSlider1";
            this.adobeVerticalColourSlider1.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adobeVerticalColourSlider1.Size = new System.Drawing.Size(40, 260);
            this.adobeVerticalColourSlider1.TabIndex = 1;
            this.adobeVerticalColourSlider1.WebSafeColoursOnly = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel1.Controls.Add(this.kryptonPromptTextBox1);
            this.kryptonPanel1.Controls.Add(this.colourComparer1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown13);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown10);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown11);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown12);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown7);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown8);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown9);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown4);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown5);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown6);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown3);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown2);
            this.kryptonPanel1.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonPanel1.Controls.Add(this.pnlBlankBox);
            this.kryptonPanel1.Controls.Add(this.kryptonRadioButton7);
            this.kryptonPanel1.Controls.Add(this.krbtnBlue);
            this.kryptonPanel1.Controls.Add(this.kryptonRadioButton8);
            this.kryptonPanel1.Controls.Add(this.kryptonRadioButton9);
            this.kryptonPanel1.Controls.Add(this.krbtnBrightness);
            this.kryptonPanel1.Controls.Add(this.krbtnGreen);
            this.kryptonPanel1.Controls.Add(this.krbtnSaturation);
            this.kryptonPanel1.Controls.Add(this.krbtnRed);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.krbtnHue);
            this.kryptonPanel1.Controls.Add(this.kcbWebColours);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(639, 428);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // colourComparer1
            // 
            this.colourComparer1.BackColor = System.Drawing.Color.Transparent;
            this.colourComparer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colourComparer1.Location = new System.Drawing.Point(324, 57);
            this.colourComparer1.Name = "colourComparer1";
            this.colourComparer1.PrimaryColour = System.Drawing.Color.White;
            this.colourComparer1.SecondaryColour = System.Drawing.Color.Silver;
            this.colourComparer1.ShowHexadecimalValues = false;
            this.colourComparer1.Size = new System.Drawing.Size(73, 71);
            this.colourComparer1.TabIndex = 73;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(489, 43);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(138, 25);
            this.kryptonButton2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 72;
            this.kryptonButton2.Values.Text = "&Cancel";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(489, 12);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(138, 25);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 71;
            this.kryptonButton1.Values.Text = "O&k";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(584, 380);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel13.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 70;
            this.kryptonLabel13.Values.Text = "%";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(584, 348);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel12.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 69;
            this.kryptonLabel12.Values.Text = "%";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(584, 316);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 68;
            this.kryptonLabel10.Values.Text = "%";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(584, 284);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel11.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 67;
            this.kryptonLabel11.Values.Text = "%";
            // 
            // kryptonNumericUpDown13
            // 
            this.kryptonNumericUpDown13.Location = new System.Drawing.Point(516, 282);
            this.kryptonNumericUpDown13.Name = "kryptonNumericUpDown13";
            this.kryptonNumericUpDown13.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown13.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown13.TabIndex = 66;
            this.kryptonNumericUpDown13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown10
            // 
            this.kryptonNumericUpDown10.Location = new System.Drawing.Point(516, 380);
            this.kryptonNumericUpDown10.Name = "kryptonNumericUpDown10";
            this.kryptonNumericUpDown10.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown10.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown10.TabIndex = 65;
            this.kryptonNumericUpDown10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown11
            // 
            this.kryptonNumericUpDown11.Location = new System.Drawing.Point(516, 348);
            this.kryptonNumericUpDown11.Name = "kryptonNumericUpDown11";
            this.kryptonNumericUpDown11.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown11.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown11.TabIndex = 64;
            this.kryptonNumericUpDown11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown12
            // 
            this.kryptonNumericUpDown12.Location = new System.Drawing.Point(516, 316);
            this.kryptonNumericUpDown12.Name = "kryptonNumericUpDown12";
            this.kryptonNumericUpDown12.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown12.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown12.TabIndex = 63;
            this.kryptonNumericUpDown12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(472, 380);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 62;
            this.kryptonLabel9.Values.Text = "K:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(472, 348);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(23, 24);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 61;
            this.kryptonLabel8.Values.Text = "Y:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(472, 316);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(29, 24);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 60;
            this.kryptonLabel7.Values.Text = "M:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(472, 284);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 59;
            this.kryptonLabel6.Values.Text = "C:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(436, 241);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 58;
            this.kryptonLabel5.Values.Text = "%";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(436, 209);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 57;
            this.kryptonLabel4.Values.Text = "%";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(436, 179);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(17, 24);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 56;
            this.kryptonLabel3.Values.Text = "°";
            // 
            // kryptonNumericUpDown7
            // 
            this.kryptonNumericUpDown7.Location = new System.Drawing.Point(516, 241);
            this.kryptonNumericUpDown7.Name = "kryptonNumericUpDown7";
            this.kryptonNumericUpDown7.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown7.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown7.TabIndex = 55;
            this.kryptonNumericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown8
            // 
            this.kryptonNumericUpDown8.Location = new System.Drawing.Point(516, 209);
            this.kryptonNumericUpDown8.Name = "kryptonNumericUpDown8";
            this.kryptonNumericUpDown8.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown8.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown8.TabIndex = 54;
            this.kryptonNumericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown9
            // 
            this.kryptonNumericUpDown9.Location = new System.Drawing.Point(516, 177);
            this.kryptonNumericUpDown9.Name = "kryptonNumericUpDown9";
            this.kryptonNumericUpDown9.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown9.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown9.TabIndex = 53;
            this.kryptonNumericUpDown9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown4
            // 
            this.kryptonNumericUpDown4.Location = new System.Drawing.Point(368, 348);
            this.kryptonNumericUpDown4.Name = "kryptonNumericUpDown4";
            this.kryptonNumericUpDown4.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown4.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonNumericUpDown4.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonNumericUpDown4.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown4.TabIndex = 52;
            this.kryptonNumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown5
            // 
            this.kryptonNumericUpDown5.Location = new System.Drawing.Point(368, 316);
            this.kryptonNumericUpDown5.Name = "kryptonNumericUpDown5";
            this.kryptonNumericUpDown5.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown5.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonNumericUpDown5.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonNumericUpDown5.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown5.TabIndex = 51;
            this.kryptonNumericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown6
            // 
            this.kryptonNumericUpDown6.Location = new System.Drawing.Point(368, 284);
            this.kryptonNumericUpDown6.Name = "kryptonNumericUpDown6";
            this.kryptonNumericUpDown6.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown6.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonNumericUpDown6.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonNumericUpDown6.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown6.TabIndex = 50;
            this.kryptonNumericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown3
            // 
            this.kryptonNumericUpDown3.Location = new System.Drawing.Point(368, 241);
            this.kryptonNumericUpDown3.Name = "kryptonNumericUpDown3";
            this.kryptonNumericUpDown3.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown3.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown3.TabIndex = 49;
            this.kryptonNumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown2
            // 
            this.kryptonNumericUpDown2.Location = new System.Drawing.Point(368, 209);
            this.kryptonNumericUpDown2.Name = "kryptonNumericUpDown2";
            this.kryptonNumericUpDown2.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown2.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown2.TabIndex = 48;
            this.kryptonNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(368, 177);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(62, 26);
            this.kryptonNumericUpDown1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNumericUpDown1.TabIndex = 47;
            this.kryptonNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBlankBox
            // 
            this.pnlBlankBox.BackColor = System.Drawing.Color.Black;
            this.pnlBlankBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlankBox.Controls.Add(this.pnlSecondaryColour);
            this.pnlBlankBox.Controls.Add(this.pnlPrimaryColour);
            this.pnlBlankBox.Location = new System.Drawing.Point(324, 57);
            this.pnlBlankBox.Name = "pnlBlankBox";
            this.pnlBlankBox.Size = new System.Drawing.Size(63, 71);
            this.pnlBlankBox.TabIndex = 46;
            // 
            // pnlSecondaryColour
            // 
            this.pnlSecondaryColour.BackColor = System.Drawing.Color.Silver;
            this.pnlSecondaryColour.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSecondaryColour.Location = new System.Drawing.Point(0, 32);
            this.pnlSecondaryColour.Name = "pnlSecondaryColour";
            this.pnlSecondaryColour.Size = new System.Drawing.Size(59, 35);
            this.pnlSecondaryColour.TabIndex = 1;
            // 
            // pnlPrimaryColour
            // 
            this.pnlPrimaryColour.BackColor = System.Drawing.Color.White;
            this.pnlPrimaryColour.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrimaryColour.Location = new System.Drawing.Point(0, 0);
            this.pnlPrimaryColour.Name = "pnlPrimaryColour";
            this.pnlPrimaryColour.Size = new System.Drawing.Size(59, 35);
            this.pnlPrimaryColour.TabIndex = 0;
            // 
            // kryptonRadioButton7
            // 
            this.kryptonRadioButton7.Location = new System.Drawing.Point(472, 239);
            this.kryptonRadioButton7.Name = "kryptonRadioButton7";
            this.kryptonRadioButton7.Size = new System.Drawing.Size(36, 24);
            this.kryptonRadioButton7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton7.TabIndex = 44;
            this.kryptonRadioButton7.Values.Text = "B:";
            // 
            // krbtnBlue
            // 
            this.krbtnBlue.Location = new System.Drawing.Point(324, 348);
            this.krbtnBlue.Name = "krbtnBlue";
            this.krbtnBlue.Size = new System.Drawing.Size(36, 24);
            this.krbtnBlue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnBlue.TabIndex = 44;
            this.krbtnBlue.Values.Text = "B:";
            // 
            // kryptonRadioButton8
            // 
            this.kryptonRadioButton8.Location = new System.Drawing.Point(472, 209);
            this.kryptonRadioButton8.Name = "kryptonRadioButton8";
            this.kryptonRadioButton8.Size = new System.Drawing.Size(37, 24);
            this.kryptonRadioButton8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton8.TabIndex = 45;
            this.kryptonRadioButton8.Values.Text = "A:";
            // 
            // kryptonRadioButton9
            // 
            this.kryptonRadioButton9.Location = new System.Drawing.Point(472, 179);
            this.kryptonRadioButton9.Name = "kryptonRadioButton9";
            this.kryptonRadioButton9.Size = new System.Drawing.Size(34, 24);
            this.kryptonRadioButton9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton9.TabIndex = 43;
            this.kryptonRadioButton9.Values.Text = "L:";
            // 
            // krbtnBrightness
            // 
            this.krbtnBrightness.Location = new System.Drawing.Point(326, 241);
            this.krbtnBrightness.Name = "krbtnBrightness";
            this.krbtnBrightness.Size = new System.Drawing.Size(36, 24);
            this.krbtnBrightness.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnBrightness.TabIndex = 41;
            this.krbtnBrightness.Values.Text = "B:";
            // 
            // krbtnGreen
            // 
            this.krbtnGreen.Location = new System.Drawing.Point(324, 316);
            this.krbtnGreen.Name = "krbtnGreen";
            this.krbtnGreen.Size = new System.Drawing.Size(37, 24);
            this.krbtnGreen.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnGreen.TabIndex = 45;
            this.krbtnGreen.Values.Text = "G:";
            // 
            // krbtnSaturation
            // 
            this.krbtnSaturation.Location = new System.Drawing.Point(326, 209);
            this.krbtnSaturation.Name = "krbtnSaturation";
            this.krbtnSaturation.Size = new System.Drawing.Size(35, 24);
            this.krbtnSaturation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnSaturation.TabIndex = 42;
            this.krbtnSaturation.Values.Text = "S:";
            // 
            // krbtnRed
            // 
            this.krbtnRed.Location = new System.Drawing.Point(324, 284);
            this.krbtnRed.Name = "krbtnRed";
            this.krbtnRed.Size = new System.Drawing.Size(36, 24);
            this.krbtnRed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnRed.TabIndex = 43;
            this.krbtnRed.Values.Text = "R:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(324, 134);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(63, 24);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.TabIndex = 41;
            this.kryptonLabel2.Values.Text = "Current";
            // 
            // krbtnHue
            // 
            this.krbtnHue.Location = new System.Drawing.Point(326, 179);
            this.krbtnHue.Name = "krbtnHue";
            this.krbtnHue.Size = new System.Drawing.Size(38, 24);
            this.krbtnHue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnHue.TabIndex = 40;
            this.krbtnHue.Values.Text = "H:";
            // 
            // kcbWebColours
            // 
            this.kcbWebColours.Location = new System.Drawing.Point(13, 293);
            this.kcbWebColours.Name = "kcbWebColours";
            this.kcbWebColours.Size = new System.Drawing.Size(148, 24);
            this.kcbWebColours.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbWebColours.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbWebColours.TabIndex = 39;
            this.kcbWebColours.Values.Text = "Only &Web Colours";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(334, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(42, 24);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "New";
            // 
            // kryptonPromptTextBox1
            // 
            this.kryptonPromptTextBox1.DrawPrompt = true;
            this.kryptonPromptTextBox1.FocusSelect = true;
            this.kryptonPromptTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Location = new System.Drawing.Point(326, 380);
            this.kryptonPromptTextBox1.Name = "kryptonPromptTextBox1";
            this.kryptonPromptTextBox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kryptonPromptTextBox1.PromptText = "000000";
            this.kryptonPromptTextBox1.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Size = new System.Drawing.Size(100, 27);
            this.kryptonPromptTextBox1.TabIndex = 74;
            this.kryptonPromptTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(176, 380);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(144, 24);
            this.kryptonLabel14.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 75;
            this.kryptonLabel14.Values.Text = "Hexadecimal Value:";
            // 
            // AdobeColourDialog
            // 
            this.ClientSize = new System.Drawing.Size(639, 428);
            this.Controls.Add(this.adobeVerticalColourSlider1);
            this.Controls.Add(this.adobe2DColourBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdobeColourDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.pnlBlankBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}