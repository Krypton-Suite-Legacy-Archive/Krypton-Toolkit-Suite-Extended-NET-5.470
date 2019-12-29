#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Colours;
using ExtendedControls.Base.Code.Colours.ColourDialog;
using ExtendedControls.Base.Enumerations;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public class AdobeColourDialog : KryptonForm
    {
        #region Designer Code
        private Controls.Colours.Controls.AdobeVerticalColourSlider avcsColours;
        private KryptonPanel kryptonPanel1;
        private KryptonRadioButton krbtnB;
        private KryptonRadioButton krbtnBlue;
        private KryptonRadioButton krbtnAlpha;
        private KryptonRadioButton krbtnLuminosity;
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
        private KryptonNumericUpDown knumB;
        private KryptonNumericUpDown knumAlpha;
        private KryptonNumericUpDown knumLuminosity;
        private KryptonNumericUpDown knumBlue;
        private KryptonNumericUpDown knumGreen;
        private KryptonNumericUpDown knumRed;
        private KryptonNumericUpDown knumBrightness;
        private KryptonNumericUpDown knumSaturation;
        private KryptonNumericUpDown knumHue;
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
        private KryptonNumericUpDown knumCyan;
        private KryptonNumericUpDown knumKey;
        private KryptonNumericUpDown knumYellow;
        private KryptonNumericUpDown knumMagenta;
        private Controls.Colours.Controls.ColourComparer cc1;
        private KryptonLabel kryptonLabel14;
        private Controls.KryptonPromptTextBox kptxtHexValue;
        private KryptonButton kbtnGradients;
        private Controls.Colours.Controls.Adobe2DColourBox adcbColours;

        private void InitializeComponent()
        {
            ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB hsb1 = new ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB();
            ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB hsb2 = new ExtendedControls.Base.Code.Colours.ColourDialog.AdobeColours.HSB();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdobeColourDialog));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kptxtHexValue = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cc1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourComparer();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumCyan = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumKey = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumYellow = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumMagenta = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumB = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumAlpha = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumLuminosity = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBlue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumGreen = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumRed = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBrightness = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumSaturation = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumHue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.pnlBlankBox = new System.Windows.Forms.Panel();
            this.pnlSecondaryColour = new System.Windows.Forms.Panel();
            this.pnlPrimaryColour = new System.Windows.Forms.Panel();
            this.krbtnB = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnBlue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnAlpha = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnLuminosity = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnBrightness = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnGreen = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnSaturation = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.krbtnRed = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krbtnHue = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kcbWebColours = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.avcsColours = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.AdobeVerticalColourSlider();
            this.adcbColours = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.Adobe2DColourBox();
            this.kbtnGradients = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.pnlBlankBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnGradients);
            this.kryptonPanel1.Controls.Add(this.kptxtHexValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel1.Controls.Add(this.cc1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel1.Controls.Add(this.knumCyan);
            this.kryptonPanel1.Controls.Add(this.knumKey);
            this.kryptonPanel1.Controls.Add(this.knumYellow);
            this.kryptonPanel1.Controls.Add(this.knumMagenta);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.knumB);
            this.kryptonPanel1.Controls.Add(this.knumAlpha);
            this.kryptonPanel1.Controls.Add(this.knumLuminosity);
            this.kryptonPanel1.Controls.Add(this.knumBlue);
            this.kryptonPanel1.Controls.Add(this.knumGreen);
            this.kryptonPanel1.Controls.Add(this.knumRed);
            this.kryptonPanel1.Controls.Add(this.knumBrightness);
            this.kryptonPanel1.Controls.Add(this.knumSaturation);
            this.kryptonPanel1.Controls.Add(this.knumHue);
            this.kryptonPanel1.Controls.Add(this.pnlBlankBox);
            this.kryptonPanel1.Controls.Add(this.krbtnB);
            this.kryptonPanel1.Controls.Add(this.krbtnBlue);
            this.kryptonPanel1.Controls.Add(this.krbtnAlpha);
            this.kryptonPanel1.Controls.Add(this.krbtnLuminosity);
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
            // kptxtHexValue
            // 
            this.kptxtHexValue.DrawPrompt = true;
            this.kptxtHexValue.FocusSelect = true;
            this.kptxtHexValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtHexValue.Location = new System.Drawing.Point(324, 380);
            this.kptxtHexValue.MaxLength = 7;
            this.kptxtHexValue.Name = "kptxtHexValue";
            this.kptxtHexValue.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtHexValue.PromptText = "000000";
            this.kptxtHexValue.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtHexValue.Size = new System.Drawing.Size(106, 27);
            this.kptxtHexValue.TabIndex = 76;
            this.kptxtHexValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // cc1
            // 
            this.cc1.BackColor = System.Drawing.Color.Transparent;
            this.cc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cc1.Location = new System.Drawing.Point(324, 57);
            this.cc1.Name = "cc1";
            this.cc1.PrimaryColour = System.Drawing.Color.White;
            this.cc1.SecondaryColour = System.Drawing.Color.Silver;
            this.cc1.ShowHexadecimalValues = false;
            this.cc1.Size = new System.Drawing.Size(73, 71);
            this.cc1.TabIndex = 73;
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
            // knumCyan
            // 
            this.knumCyan.Location = new System.Drawing.Point(516, 282);
            this.knumCyan.Name = "knumCyan";
            this.knumCyan.Size = new System.Drawing.Size(62, 26);
            this.knumCyan.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.knumCyan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumCyan.TabIndex = 66;
            this.knumCyan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumKey
            // 
            this.knumKey.Location = new System.Drawing.Point(516, 380);
            this.knumKey.Name = "knumKey";
            this.knumKey.Size = new System.Drawing.Size(62, 26);
            this.knumKey.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumKey.TabIndex = 65;
            this.knumKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumYellow
            // 
            this.knumYellow.Location = new System.Drawing.Point(516, 348);
            this.knumYellow.Name = "knumYellow";
            this.knumYellow.Size = new System.Drawing.Size(62, 26);
            this.knumYellow.StateCommon.Back.Color1 = System.Drawing.Color.Yellow;
            this.knumYellow.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumYellow.TabIndex = 64;
            this.knumYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumMagenta
            // 
            this.knumMagenta.Location = new System.Drawing.Point(516, 316);
            this.knumMagenta.Name = "knumMagenta";
            this.knumMagenta.Size = new System.Drawing.Size(62, 26);
            this.knumMagenta.StateCommon.Back.Color1 = System.Drawing.Color.Magenta;
            this.knumMagenta.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumMagenta.TabIndex = 63;
            this.knumMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(470, 380);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(24, 24);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 62;
            this.kryptonLabel9.Values.Text = "K:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(470, 348);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(23, 24);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 61;
            this.kryptonLabel8.Values.Text = "Y:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(470, 316);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(29, 24);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 60;
            this.kryptonLabel7.Values.Text = "M:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(470, 284);
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
            // knumB
            // 
            this.knumB.Location = new System.Drawing.Point(516, 241);
            this.knumB.Name = "knumB";
            this.knumB.Size = new System.Drawing.Size(62, 26);
            this.knumB.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumB.TabIndex = 55;
            this.knumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumAlpha
            // 
            this.knumAlpha.Location = new System.Drawing.Point(516, 209);
            this.knumAlpha.Name = "knumAlpha";
            this.knumAlpha.Size = new System.Drawing.Size(62, 26);
            this.knumAlpha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpha.TabIndex = 54;
            this.knumAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumLuminosity
            // 
            this.knumLuminosity.Location = new System.Drawing.Point(516, 177);
            this.knumLuminosity.Name = "knumLuminosity";
            this.knumLuminosity.Size = new System.Drawing.Size(62, 26);
            this.knumLuminosity.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumLuminosity.TabIndex = 53;
            this.knumLuminosity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(368, 348);
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(62, 26);
            this.knumBlue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBlue.TabIndex = 52;
            this.knumBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(368, 316);
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(62, 26);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.knumGreen.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreen.TabIndex = 51;
            this.knumGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(368, 284);
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(62, 26);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumRed.TabIndex = 50;
            this.knumRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBrightness
            // 
            this.knumBrightness.Location = new System.Drawing.Point(368, 241);
            this.knumBrightness.Name = "knumBrightness";
            this.knumBrightness.Size = new System.Drawing.Size(62, 26);
            this.knumBrightness.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBrightness.TabIndex = 49;
            this.knumBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumSaturation
            // 
            this.knumSaturation.Location = new System.Drawing.Point(368, 209);
            this.knumSaturation.Name = "knumSaturation";
            this.knumSaturation.Size = new System.Drawing.Size(62, 26);
            this.knumSaturation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumSaturation.TabIndex = 48;
            this.knumSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumHue
            // 
            this.knumHue.Location = new System.Drawing.Point(368, 177);
            this.knumHue.Name = "knumHue";
            this.knumHue.Size = new System.Drawing.Size(62, 26);
            this.knumHue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumHue.TabIndex = 47;
            this.knumHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // krbtnB
            // 
            this.krbtnB.Location = new System.Drawing.Point(470, 239);
            this.krbtnB.Name = "krbtnB";
            this.krbtnB.Size = new System.Drawing.Size(36, 24);
            this.krbtnB.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnB.TabIndex = 44;
            this.krbtnB.Values.Text = "B:";
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
            // krbtnAlpha
            // 
            this.krbtnAlpha.Location = new System.Drawing.Point(470, 209);
            this.krbtnAlpha.Name = "krbtnAlpha";
            this.krbtnAlpha.Size = new System.Drawing.Size(37, 24);
            this.krbtnAlpha.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnAlpha.TabIndex = 45;
            this.krbtnAlpha.Values.Text = "A:";
            // 
            // krbtnLuminosity
            // 
            this.krbtnLuminosity.Location = new System.Drawing.Point(470, 179);
            this.krbtnLuminosity.Name = "krbtnLuminosity";
            this.krbtnLuminosity.Size = new System.Drawing.Size(34, 24);
            this.krbtnLuminosity.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krbtnLuminosity.TabIndex = 43;
            this.krbtnLuminosity.Values.Text = "L:";
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
            // avcsColours
            // 
            this.avcsColours.BackColor = System.Drawing.Color.Transparent;
            this.avcsColours.BaseColourComponent = ExtendedControls.Base.Enumerations.ColourComponent.HUE;
            hsb1.B = 1D;
            hsb1.H = 0D;
            hsb1.S = 1D;
            this.avcsColours.HSB = hsb1;
            this.avcsColours.Location = new System.Drawing.Point(278, 26);
            this.avcsColours.Name = "avcsColours";
            this.avcsColours.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.avcsColours.Size = new System.Drawing.Size(40, 260);
            this.avcsColours.TabIndex = 1;
            this.avcsColours.WebSafeColoursOnly = false;
            // 
            // adcbColours
            // 
            this.adcbColours.BaseColourComponent = ExtendedControls.Base.Enumerations.ColourComponent.HUE;
            hsb2.B = 1D;
            hsb2.H = 0D;
            hsb2.S = 1D;
            this.adcbColours.HSB = hsb2;
            this.adcbColours.Location = new System.Drawing.Point(12, 26);
            this.adcbColours.Name = "adcbColours";
            this.adcbColours.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adcbColours.Size = new System.Drawing.Size(260, 260);
            this.adcbColours.TabIndex = 0;
            this.adcbColours.WebSafeColoursOnly = false;
            // 
            // kbtnGradients
            // 
            this.kbtnGradients.Location = new System.Drawing.Point(489, 74);
            this.kbtnGradients.Name = "kbtnGradients";
            this.kbtnGradients.Size = new System.Drawing.Size(138, 25);
            this.kbtnGradients.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGradients.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGradients.TabIndex = 77;
            this.kbtnGradients.Values.Text = "Gr&adients";
            this.kbtnGradients.Visible = false;
            // 
            // AdobeColourDialog
            // 
            this.ClientSize = new System.Drawing.Size(639, 428);
            this.Controls.Add(this.avcsColours);
            this.Controls.Add(this.adcbColours);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdobeColourDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select a Colour";
            this.Load += new System.EventHandler(this.AdobeColourDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.pnlBlankBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Constants
        private const int MINIMUM_VALUE = 0, MAXIMUM_VALUE = 255;
        #endregion

        #region Variables
        private Color _rgb;
        private AdobeColours.HSB _hsl;
        private AdobeColours.CMYK _cmyk;
        #endregion

        #region Properties
        public Color PrimaryColour
        {
            get => _rgb;

            set
            {
                _rgb = value;

                _hsl = AdobeColours.RGB_to_HSB(_rgb);

                UpdateValues();
            }
        }

        public ColourComponent DrawStyle
        {
            get
            {
                if (krbtnHue.Checked)
                {
                    return ColourComponent.HUE;
                }
                else if (krbtnSaturation.Checked)
                {
                    return ColourComponent.SATURATION;
                }
                else if (krbtnBrightness.Checked)
                {
                    return ColourComponent.BRIGHTESS;
                }
                else if (krbtnRed.Checked)
                {
                    return ColourComponent.RED;
                }
                else if (krbtnGreen.Checked)
                {
                    return ColourComponent.GREEN;
                }
                else if (krbtnBlue.Checked)
                {
                    return ColourComponent.BLUE;
                }
                else
                {
                    return ColourComponent.HUE;
                }
            }

            set
            {
                switch (value)
                {
                    case ColourComponent.HUE:
                        krbtnHue.Checked = true;
                        break;
                    case ColourComponent.SATURATION:
                        krbtnSaturation.Checked = true;
                        break;
                    case ColourComponent.BRIGHTESS:
                        krbtnBrightness.Checked = true;
                        break;
                    case ColourComponent.RED:
                        krbtnRed.Checked = true;
                        break;
                    case ColourComponent.GREEN:
                        krbtnGreen.Checked = true;
                        break;
                    case ColourComponent.BLUE:
                        krbtnBlue.Checked = true; ;
                        break;
                }
            }
        }
        #endregion

        #region Constructor
        public AdobeColourDialog(Color startingColour)
        {
            PrimaryColour = startingColour;

            _hsl = AdobeColours.RGB_to_HSB(_rgb);

            _cmyk = AdobeColours.RGB_to_CMYK(_rgb);

            UpdateValues();

            adcbColours.HSB = _hsl;

            avcsColours.HSB = _hsl;

            cc1.PrimaryColour = startingColour;

            cc1.SecondaryColour = startingColour;

            krbtnHue.Checked = true;

            #region Values
            SetNumericUpDownValueBoundaries(knumHue, MINIMUM_VALUE, 360);

            SetNumericUpDownValueBoundaries(knumSaturation, MINIMUM_VALUE, 100);

            SetNumericUpDownValueBoundaries(knumBrightness, MINIMUM_VALUE, 100);

            SetNumericUpDownValueBoundaries(knumRed, MINIMUM_VALUE, MAXIMUM_VALUE);

            SetNumericUpDownValueBoundaries(knumGreen, MINIMUM_VALUE, MAXIMUM_VALUE);

            SetNumericUpDownValueBoundaries(knumBlue, MINIMUM_VALUE, MAXIMUM_VALUE);
            #endregion

            knumCyan.StateCommon.Content.Color1 = ColourExtensions.GetContrast(knumCyan.StateCommon.Back.Color1);

            knumMagenta.StateCommon.Content.Color1 = ColourExtensions.GetContrast(knumMagenta.StateCommon.Back.Color1);

            knumYellow.StateCommon.Content.Color1 = ColourExtensions.GetContrast(knumYellow.StateCommon.Back.Color1);
        }
        #endregion

        #region Methods
        private void SetNumericUpDownValueBoundaries(KryptonNumericUpDown target, int minimum, int maximum)
        {
            target.Minimum = minimum;

            target.Maximum = maximum;
        }

        private void AdobeColourDialog_Load(object sender, System.EventArgs e)
        {

        }

        private void UpdateValues()
        {

        }
        #endregion
    }
}