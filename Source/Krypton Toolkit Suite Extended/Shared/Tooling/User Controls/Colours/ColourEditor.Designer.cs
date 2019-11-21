namespace Core.UserControls.Colours
{
    partial class ColourEditor
    {
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
            this.rgbHeaderLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.rColourBar = new Core.Controls.Colours.RGBAColourSlider();
            this.gLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gColourBar = new Core.Controls.Colours.RGBAColourSlider();
            this.gNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.bLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bColourBar = new Core.Controls.Colours.RGBAColourSlider();
            this.bNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.hexLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hexTextBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lColourBar = new Core.Controls.Colours.LightnessColourSlider();
            this.lLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.sNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.sColourBar = new Core.Controls.Colours.SaturationColourSlider();
            this.sLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hColourBar = new Core.Controls.Colours.HueColourSlider();
            this.hNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.hLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.hslLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.aNumericUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.aColourBar = new Core.Controls.Colours.RGBAColourSlider();
            this.aLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbHeaderLabel
            // 
            this.rgbHeaderLabel.AutoSize = true;
            this.rgbHeaderLabel.Location = new System.Drawing.Point(-3, 0);
            this.rgbHeaderLabel.Name = "rgbHeaderLabel";
            this.rgbHeaderLabel.Size = new System.Drawing.Size(33, 13);
            this.rgbHeaderLabel.TabIndex = 0;
            this.rgbHeaderLabel.Text = "RGB:";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(3, 13);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(18, 13);
            this.rLabel.TabIndex = 1;
            this.rLabel.Text = "R:";
            // 
            // rNumericUpDown
            // 
            this.rNumericUpDown.Location = new System.Drawing.Point(105, 11);
            this.rNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rNumericUpDown.Name = "rNumericUpDown";
            this.rNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.rNumericUpDown.TabIndex = 2;
            this.rNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // rColourBar
            // 
            this.rColourBar.Location = new System.Drawing.Point(27, 13);
            this.rColourBar.Name = "rColourBar";
            this.rColourBar.Size = new System.Drawing.Size(72, 20);
            this.rColourBar.TabIndex = 3;
            this.rColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(3, 39);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(18, 13);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "G:";
            // 
            // gColourBar
            // 
            this.gColourBar.Channel = Core.Enumerations.RGBAChannel.GREEN;
            this.gColourBar.Location = new System.Drawing.Point(27, 39);
            this.gColourBar.Name = "gColourBar";
            this.gColourBar.Size = new System.Drawing.Size(72, 20);
            this.gColourBar.TabIndex = 6;
            this.gColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // gNumericUpDown
            // 
            this.gNumericUpDown.Location = new System.Drawing.Point(105, 37);
            this.gNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gNumericUpDown.Name = "gNumericUpDown";
            this.gNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.gNumericUpDown.TabIndex = 5;
            this.gNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(3, 65);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(17, 13);
            this.bLabel.TabIndex = 7;
            this.bLabel.Text = "B:";
            // 
            // bColourBar
            // 
            this.bColourBar.Channel = Core.Enumerations.RGBAChannel.BLUE;
            this.bColourBar.Location = new System.Drawing.Point(27, 65);
            this.bColourBar.Name = "bColourBar";
            this.bColourBar.Size = new System.Drawing.Size(72, 20);
            this.bColourBar.TabIndex = 9;
            this.bColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // bNumericUpDown
            // 
            this.bNumericUpDown.Location = new System.Drawing.Point(105, 65);
            this.bNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bNumericUpDown.Name = "bNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.bNumericUpDown.TabIndex = 8;
            this.bNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(3, 94);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(29, 13);
            this.hexLabel.TabIndex = 10;
            this.hexLabel.Text = "Hex:";
            // 
            // hexTextBox
            // 
            //this.hexTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hexTextBox.Location = new System.Drawing.Point(105, 91);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(58, 21);
            this.hexTextBox.TabIndex = 11;
            //this.hexTextBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.hexTextBox_DrawItem);
            this.hexTextBox.DropDown += new System.EventHandler(this.hexTextBox_DropDown);
            this.hexTextBox.SelectedIndexChanged += new System.EventHandler(this.hexTextBox_SelectedIndexChanged);
            this.hexTextBox.TextChanged += new System.EventHandler(this.ValueChangedHandler);
            this.hexTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hexTextBox_KeyDown);
            // 
            // lNumericUpDown
            // 
            this.lNumericUpDown.Location = new System.Drawing.Point(105, 190);
            this.lNumericUpDown.Name = "lNumericUpDown";
            this.lNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.lNumericUpDown.TabIndex = 20;
            this.lNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // lColourBar
            // 
            this.lColourBar.Location = new System.Drawing.Point(27, 190);
            this.lColourBar.Name = "lColourBar";
            this.lColourBar.Size = new System.Drawing.Size(72, 20);
            this.lColourBar.TabIndex = 21;
            this.lColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // lLabel
            // 
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(3, 192);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(16, 13);
            this.lLabel.TabIndex = 19;
            this.lLabel.Text = "L:";
            // 
            // sNumericUpDown
            // 
            this.sNumericUpDown.Location = new System.Drawing.Point(105, 164);
            this.sNumericUpDown.Name = "sNumericUpDown";
            this.sNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.sNumericUpDown.TabIndex = 17;
            this.sNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // sColourBar
            // 
            this.sColourBar.Location = new System.Drawing.Point(27, 164);
            this.sColourBar.Name = "sColourBar";
            this.sColourBar.Size = new System.Drawing.Size(72, 20);
            this.sColourBar.TabIndex = 18;
            this.sColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(4, 166);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(17, 13);
            this.sLabel.TabIndex = 16;
            this.sLabel.Text = "S:";
            // 
            // hColourBar
            // 
            this.hColourBar.Location = new System.Drawing.Point(27, 138);
            this.hColourBar.Name = "hColourBar";
            this.hColourBar.Size = new System.Drawing.Size(72, 20);
            this.hColourBar.TabIndex = 15;
            this.hColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hNumericUpDown
            // 
            this.hNumericUpDown.Location = new System.Drawing.Point(105, 138);
            this.hNumericUpDown.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.hNumericUpDown.Name = "hNumericUpDown";
            this.hNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.hNumericUpDown.TabIndex = 14;
            this.hNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(3, 140);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(18, 13);
            this.hLabel.TabIndex = 13;
            this.hLabel.Text = "H:";
            // 
            // hslLabel
            // 
            this.hslLabel.AutoSize = true;
            this.hslLabel.Location = new System.Drawing.Point(3, 117);
            this.hslLabel.Name = "hslLabel";
            this.hslLabel.Size = new System.Drawing.Size(31, 13);
            this.hslLabel.TabIndex = 12;
            this.hslLabel.Text = "HSL:";
            // 
            // aNumericUpDown
            // 
            this.aNumericUpDown.Location = new System.Drawing.Point(105, 216);
            this.aNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.aNumericUpDown.Name = "aNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.aNumericUpDown.TabIndex = 23;
            this.aNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // aColourBar
            // 
            this.aColourBar.Channel = Core.Enumerations.RGBAChannel.ALPHA;
            this.aColourBar.Location = new System.Drawing.Point(27, 216);
            this.aColourBar.Name = "aColourBar";
            this.aColourBar.Size = new System.Drawing.Size(72, 20);
            this.aColourBar.TabIndex = 24;
            this.aColourBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(3, 218);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(37, 13);
            this.aLabel.TabIndex = 22;
            this.aLabel.Text = "Alpha:";
            //
            // kpnlBackground
            //
            this.kpnlBackdrop.Controls.Add(this.rgbHeaderLabel);
            this.kpnlBackdrop.Controls.Add(this.rLabel);
            this.kpnlBackdrop.Controls.Add(this.rNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.rColourBar);
            this.kpnlBackdrop.Controls.Add(this.gLabel);
            this.kpnlBackdrop.Controls.Add(this.gColourBar);
            this.kpnlBackdrop.Controls.Add(this.gNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.bLabel);
            this.kpnlBackdrop.Controls.Add(this.bColourBar);
            this.kpnlBackdrop.Controls.Add(this.bNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.hexLabel);
            this.kpnlBackdrop.Controls.Add(this.hexTextBox);
            this.kpnlBackdrop.Controls.Add(this.lNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.lColourBar);
            this.kpnlBackdrop.Controls.Add(this.lLabel);
            this.kpnlBackdrop.Controls.Add(this.sNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.sColourBar);
            this.kpnlBackdrop.Controls.Add(this.sLabel);
            this.kpnlBackdrop.Controls.Add(this.hColourBar);
            this.kpnlBackdrop.Controls.Add(this.hNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.hLabel);
            this.kpnlBackdrop.Controls.Add(this.hslLabel);
            this.kpnlBackdrop.Controls.Add(this.aNumericUpDown);
            this.kpnlBackdrop.Controls.Add(this.aColourBar);
            this.kpnlBackdrop.Controls.Add(this.aLabel);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(173, 246);
            this.kpnlBackdrop.TabIndex = 2;
            // 
            // ColorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.aNumericUpDown);
            this.Controls.Add(this.aColourBar);
            this.Controls.Add(this.hslLabel);
            this.Controls.Add(this.lNumericUpDown);
            this.Controls.Add(this.lColourBar);
            this.Controls.Add(this.lLabel);
            this.Controls.Add(this.sNumericUpDown);
            this.Controls.Add(this.sColourBar);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.hColourBar);
            this.Controls.Add(this.hNumericUpDown);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.bNumericUpDown);
            this.Controls.Add(this.bColourBar);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gNumericUpDown);
            this.Controls.Add(this.gColourBar);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rColourBar);
            this.Controls.Add(this.rNumericUpDown);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.rgbHeaderLabel);
            this.Name = "ColourEditor";
            this.Size = new System.Drawing.Size(173, 246);
            ((System.ComponentModel.ISupportInitialize)(this.rNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel rgbHeaderLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel rLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown rNumericUpDown;
        private Core.Controls.Colours.RGBAColourSlider rColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel gLabel;
        private Core.Controls.Colours.RGBAColourSlider gColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown gNumericUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel bLabel;
        private Core.Controls.Colours.RGBAColourSlider bColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown bNumericUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel hexLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox hexTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown lNumericUpDown;
        private Core.Controls.Colours.LightnessColourSlider lColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown sNumericUpDown;
        private Core.Controls.Colours.SaturationColourSlider sColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel sLabel;
        private Core.Controls.Colours.HueColourSlider hColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown hNumericUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel hLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel hslLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown aNumericUpDown;
        private Core.Controls.Colours.RGBAColourSlider aColourBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel aLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
    }
}