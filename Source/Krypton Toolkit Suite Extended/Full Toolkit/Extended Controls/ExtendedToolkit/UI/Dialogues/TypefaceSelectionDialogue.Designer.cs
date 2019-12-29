namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    partial class TypefaceSelectionDialogue
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkUnderline = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kchkStrikeout = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.knumTypefaceSize = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.klbTypefaceStyles = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kgbTextPreview = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.klblTextPreview = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbSelectedTypeface = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTextPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTextPreview.Panel)).BeginInit();
            this.kgbTextPreview.Panel.SuspendLayout();
            this.kgbTextPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelectedTypeface)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 412);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 51);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(690, 9);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 61;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.Location = new System.Drawing.Point(728, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 60;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kchkUnderline);
            this.kryptonPanel2.Controls.Add(this.kchkStrikeout);
            this.kryptonPanel2.Controls.Add(this.knumTypefaceSize);
            this.kryptonPanel2.Controls.Add(this.klbTypefaceStyles);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kgbTextPreview);
            this.kryptonPanel2.Controls.Add(this.kcmbSelectedTypeface);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel11);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(800, 410);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kchkUnderline
            // 
            this.kchkUnderline.Location = new System.Drawing.Point(386, 312);
            this.kchkUnderline.Name = "kchkUnderline";
            this.kchkUnderline.Size = new System.Drawing.Size(95, 26);
            this.kchkUnderline.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkUnderline.TabIndex = 68;
            this.kchkUnderline.Values.Text = "U&nderline";
            // 
            // kchkStrikeout
            // 
            this.kchkStrikeout.Location = new System.Drawing.Point(290, 312);
            this.kchkStrikeout.Name = "kchkStrikeout";
            this.kchkStrikeout.Size = new System.Drawing.Size(90, 26);
            this.kchkStrikeout.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkStrikeout.TabIndex = 67;
            this.kchkStrikeout.Values.Text = "&Strikeout";
            // 
            // knumTypefaceSize
            // 
            this.knumTypefaceSize.Location = new System.Drawing.Point(13, 362);
            this.knumTypefaceSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.knumTypefaceSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knumTypefaceSize.Name = "knumTypefaceSize";
            this.knumTypefaceSize.Size = new System.Drawing.Size(120, 28);
            this.knumTypefaceSize.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumTypefaceSize.TabIndex = 66;
            this.knumTypefaceSize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.knumTypefaceSize.ValueChanged += new System.EventHandler(this.knumTypefaceSize_ValueChanged);
            // 
            // klbTypefaceStyles
            // 
            this.klbTypefaceStyles.HorizontalScrollbar = true;
            this.klbTypefaceStyles.Location = new System.Drawing.Point(13, 129);
            this.klbTypefaceStyles.Name = "klbTypefaceStyles";
            this.klbTypefaceStyles.ScrollAlwaysVisible = true;
            this.klbTypefaceStyles.Size = new System.Drawing.Size(251, 194);
            this.klbTypefaceStyles.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbTypefaceStyles.TabIndex = 65;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(288, 355);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(61, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 62;
            this.kryptonLabel2.Values.Text = "Script:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(288, 280);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(68, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 63;
            this.kryptonLabel3.Values.Text = "Effects:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 329);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(47, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 64;
            this.kryptonLabel4.Values.Text = "Size:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 96);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(129, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 64;
            this.kryptonLabel1.Values.Text = "Typeface Style:";
            // 
            // kgbTextPreview
            // 
            this.kgbTextPreview.Location = new System.Drawing.Point(288, 12);
            this.kgbTextPreview.Name = "kgbTextPreview";
            // 
            // kgbTextPreview.Panel
            // 
            this.kgbTextPreview.Panel.Controls.Add(this.klblTextPreview);
            this.kgbTextPreview.Size = new System.Drawing.Size(500, 252);
            this.kgbTextPreview.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgbTextPreview.TabIndex = 63;
            this.kgbTextPreview.Values.Heading = "Text Preview Sample";
            // 
            // klblTextPreview
            // 
            this.klblTextPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblTextPreview.Location = new System.Drawing.Point(0, 0);
            this.klblTextPreview.Name = "klblTextPreview";
            this.klblTextPreview.Size = new System.Drawing.Size(496, 222);
            this.klblTextPreview.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblTextPreview.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblTextPreview.TabIndex = 0;
            this.klblTextPreview.Values.Text = "ABC";
            // 
            // kcmbSelectedTypeface
            // 
            this.kcmbSelectedTypeface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbSelectedTypeface.DropDownWidth = 173;
            this.kcmbSelectedTypeface.Items.AddRange(new object[] {
            "Base Colour",
            "Darkest Colour",
            "Medium Colour",
            "Light Colour",
            "Lightest Colour"});
            this.kcmbSelectedTypeface.Location = new System.Drawing.Point(12, 44);
            this.kcmbSelectedTypeface.Name = "kcmbSelectedTypeface";
            this.kcmbSelectedTypeface.Size = new System.Drawing.Size(252, 27);
            this.kcmbSelectedTypeface.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbSelectedTypeface.TabIndex = 62;
            this.kcmbSelectedTypeface.TextChanged += new System.EventHandler(this.kcmbSelectedTypeface_TextChanged);
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(86, 26);
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 61;
            this.kryptonLabel11.Values.Text = "Typeface:";
            // 
            // TypefaceSelectionDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TypefaceSelectionDialogue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typeface Selection";
            this.Load += new System.EventHandler(this.TypefaceSelectionDialogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTextPreview.Panel)).EndInit();
            this.kgbTextPreview.Panel.ResumeLayout(false);
            this.kgbTextPreview.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgbTextPreview)).EndInit();
            this.kgbTextPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbSelectedTypeface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnOk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbTextPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblTextPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbSelectedTypeface;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumTypefaceSize;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox klbTypefaceStyles;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkUnderline;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkStrikeout;
    }
}