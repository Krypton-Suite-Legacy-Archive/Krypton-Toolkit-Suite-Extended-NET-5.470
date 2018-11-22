namespace Tooling.UX
{
    partial class CustomColours
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomColours));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxColourPreview = new System.Windows.Forms.PictureBox();
            this.kbtnSaveColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmbNormalTextSystemColours = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbNormalTextColour = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnGenerateNormalTextBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.knumBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnGenerateNormalTextGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.knumGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnGenerateNormalTextRedValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.knumRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klstCustomColourSelector = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbNormalTextSystemColours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbNormalTextColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnSaveColour);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 328);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1286, 49);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(1242, 7);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 77;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 2);
            this.panel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.klstCustomColourSelector);
            this.kryptonPanel2.Controls.Add(this.pbxColourPreview);
            this.kryptonPanel2.Controls.Add(this.kcmbNormalTextSystemColours);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel22);
            this.kryptonPanel2.Controls.Add(this.kcmbNormalTextColour);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel21);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateNormalTextBlueValue);
            this.kryptonPanel2.Controls.Add(this.knumBlueChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateNormalTextGreenValue);
            this.kryptonPanel2.Controls.Add(this.knumGreenChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateNormalTextRedValue);
            this.kryptonPanel2.Controls.Add(this.knumRedChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1286, 326);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // pbxColourPreview
            // 
            this.pbxColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxColourPreview.Location = new System.Drawing.Point(347, 12);
            this.pbxColourPreview.Name = "pbxColourPreview";
            this.pbxColourPreview.Size = new System.Drawing.Size(586, 298);
            this.pbxColourPreview.TabIndex = 155;
            this.pbxColourPreview.TabStop = false;
            this.pbxColourPreview.MouseEnter += new System.EventHandler(this.pbxColourPreview_MouseEnter);
            // 
            // kbtnSaveColour
            // 
            this.kbtnSaveColour.AutoSize = true;
            this.kbtnSaveColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnSaveColour.Enabled = false;
            this.kbtnSaveColour.Location = new System.Drawing.Point(12, 7);
            this.kbtnSaveColour.Name = "kbtnSaveColour";
            this.kbtnSaveColour.Size = new System.Drawing.Size(165, 30);
            this.kbtnSaveColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveColour.TabIndex = 78;
            this.kbtnSaveColour.Values.Text = "Save &Selected Colour";
            this.kbtnSaveColour.Click += new System.EventHandler(this.kbtnSaveColour_Click);
            // 
            // kcmbNormalTextSystemColours
            // 
            this.kcmbNormalTextSystemColours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbNormalTextSystemColours.DropDownWidth = 173;
            this.kcmbNormalTextSystemColours.Location = new System.Drawing.Point(168, 242);
            this.kcmbNormalTextSystemColours.Name = "kcmbNormalTextSystemColours";
            this.kcmbNormalTextSystemColours.Size = new System.Drawing.Size(173, 27);
            this.kcmbNormalTextSystemColours.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbNormalTextSystemColours.TabIndex = 154;
            this.kcmbNormalTextSystemColours.SelectedIndexChanged += new System.EventHandler(this.kcmbNormalTextSystemColours_SelectedIndexChanged);
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(12, 243);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(136, 26);
            this.kryptonLabel22.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel22.TabIndex = 153;
            this.kryptonLabel22.Values.Text = "System Colours:";
            // 
            // kcmbNormalTextColour
            // 
            this.kcmbNormalTextColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbNormalTextColour.DropDownWidth = 173;
            this.kcmbNormalTextColour.Location = new System.Drawing.Point(168, 188);
            this.kcmbNormalTextColour.Name = "kcmbNormalTextColour";
            this.kcmbNormalTextColour.Size = new System.Drawing.Size(173, 27);
            this.kcmbNormalTextColour.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbNormalTextColour.TabIndex = 152;
            this.kcmbNormalTextColour.SelectedIndexChanged += new System.EventHandler(this.kcmbNormalTextColour_SelectedIndexChanged);
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(12, 189);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(150, 26);
            this.kryptonLabel21.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel21.TabIndex = 151;
            this.kryptonLabel21.Values.Text = "Standard Colours:";
            // 
            // kbtnGenerateNormalTextBlueValue
            // 
            this.kbtnGenerateNormalTextBlueValue.AutoSize = true;
            this.kbtnGenerateNormalTextBlueValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateNormalTextBlueValue.Location = new System.Drawing.Point(227, 120);
            this.kbtnGenerateNormalTextBlueValue.Name = "kbtnGenerateNormalTextBlueValue";
            this.kbtnGenerateNormalTextBlueValue.Size = new System.Drawing.Size(114, 30);
            this.kbtnGenerateNormalTextBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextBlueValue.TabIndex = 150;
            this.kbtnGenerateNormalTextBlueValue.Values.Text = "Generate &Blue";
            this.kbtnGenerateNormalTextBlueValue.Click += new System.EventHandler(this.kbtnGenerateNormalTextBlueValue_Click);
            // 
            // knumBlueChannelValue
            // 
            this.knumBlueChannelValue.Location = new System.Drawing.Point(80, 120);
            this.knumBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlueChannelValue.Name = "knumBlueChannelValue";
            this.knumBlueChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumBlueChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBlueChannelValue.TabIndex = 149;
            this.knumBlueChannelValue.ValueChanged += new System.EventHandler(this.knumBlueChannelValue_ValueChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 122);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 148;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kbtnGenerateNormalTextGreenValue
            // 
            this.kbtnGenerateNormalTextGreenValue.AutoSize = true;
            this.kbtnGenerateNormalTextGreenValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateNormalTextGreenValue.Location = new System.Drawing.Point(215, 67);
            this.kbtnGenerateNormalTextGreenValue.Name = "kbtnGenerateNormalTextGreenValue";
            this.kbtnGenerateNormalTextGreenValue.Size = new System.Drawing.Size(126, 30);
            this.kbtnGenerateNormalTextGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextGreenValue.TabIndex = 147;
            this.kbtnGenerateNormalTextGreenValue.Values.Text = "Generate &Green";
            this.kbtnGenerateNormalTextGreenValue.Click += new System.EventHandler(this.kbtnGenerateNormalTextGreenValue_Click);
            // 
            // knumGreenChannelValue
            // 
            this.knumGreenChannelValue.Location = new System.Drawing.Point(80, 67);
            this.knumGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreenChannelValue.Name = "knumGreenChannelValue";
            this.knumGreenChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumGreenChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreenChannelValue.TabIndex = 146;
            this.knumGreenChannelValue.ValueChanged += new System.EventHandler(this.knumGreenChannelValue_ValueChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 67);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 145;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kbtnGenerateNormalTextRedValue
            // 
            this.kbtnGenerateNormalTextRedValue.AutoSize = true;
            this.kbtnGenerateNormalTextRedValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateNormalTextRedValue.Location = new System.Drawing.Point(230, 12);
            this.kbtnGenerateNormalTextRedValue.Name = "kbtnGenerateNormalTextRedValue";
            this.kbtnGenerateNormalTextRedValue.Size = new System.Drawing.Size(111, 30);
            this.kbtnGenerateNormalTextRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextRedValue.TabIndex = 144;
            this.kbtnGenerateNormalTextRedValue.Values.Text = "Generate &Red";
            this.kbtnGenerateNormalTextRedValue.Click += new System.EventHandler(this.kbtnGenerateNormalTextRedValue_Click);
            // 
            // knumRedChannelValue
            // 
            this.knumRedChannelValue.Location = new System.Drawing.Point(80, 11);
            this.knumRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRedChannelValue.Name = "knumRedChannelValue";
            this.knumRedChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumRedChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumRedChannelValue.TabIndex = 143;
            this.knumRedChannelValue.ValueChanged += new System.EventHandler(this.knumRedChannelValue_ValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 142;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // klstCustomColourSelector
            // 
            this.klstCustomColourSelector.Items.AddRange(new object[] {
            "Border Colour",
            "Alternative Normal Text Colour",
            "Normal Text Colour",
            "Disabled Text Colour",
            "Focused Text Colour",
            "Pressed Text Colour",
            "Link Normal Text Colour",
            "Link Hover Text Colour",
            "Link Visited Text Colour",
            "Disabled Control Colour",
            "Custom Colour One",
            "Custom Colour Two",
            "Custom Colour Three",
            "Custom Colour Four",
            "Custom Colour Five",
            "Menu Text Colour",
            "Custom Text Colour One",
            "Custom Text Colour Two",
            "Custom TextColour Three",
            "Custom Text Colour Four",
            "Custom Text Colour Five",
            "Status Text Colour"});
            this.klstCustomColourSelector.Location = new System.Drawing.Point(939, 12);
            this.klstCustomColourSelector.Name = "klstCustomColourSelector";
            this.klstCustomColourSelector.Size = new System.Drawing.Size(335, 298);
            this.klstCustomColourSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstCustomColourSelector.TabIndex = 156;
            // 
            // CustomColours
            // 
            this.AcceptButton = this.kbtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 377);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomColours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define Custom Colours";
            this.Load += new System.EventHandler(this.CustomColours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbNormalTextSystemColours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbNormalTextColour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSaveColour;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateNormalTextBlueValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumBlueChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateNormalTextGreenValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumGreenChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateNormalTextRedValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumRedChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbNormalTextSystemColours;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbNormalTextColour;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private System.Windows.Forms.PictureBox pbxColourPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox klstCustomColourSelector;
    }
}