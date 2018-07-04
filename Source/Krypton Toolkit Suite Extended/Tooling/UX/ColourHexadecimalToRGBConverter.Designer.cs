namespace Tooling.UX
{
    partial class ColourHexadecimalToRGBConverter
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtHexColourValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klblRGBOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.kchkAutoUpdate = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnConvert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tmrUpdateValues = new System.Windows.Forms.Timer(this.components);
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkAutoUpdate);
            this.kryptonPanel1.Controls.Add(this.klblRGBOutput);
            this.kryptonPanel1.Controls.Add(this.kbtnConvert);
            this.kryptonPanel1.Controls.Add(this.pnlPreview);
            this.kryptonPanel1.Controls.Add(this.ktxtHexColourValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(750, 202);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(43, 37);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(235, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Hexadecimal Colour Value: #";
            // 
            // ktxtHexColourValue
            // 
            this.ktxtHexColourValue.Location = new System.Drawing.Point(285, 36);
            this.ktxtHexColourValue.MaxLength = 6;
            this.ktxtHexColourValue.Name = "ktxtHexColourValue";
            this.ktxtHexColourValue.Size = new System.Drawing.Size(100, 29);
            this.ktxtHexColourValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtHexColourValue.TabIndex = 2;
            this.ktxtHexColourValue.Text = "000000";
            this.ktxtHexColourValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtHexColourValue.TextChanged += new System.EventHandler(this.ktxtHexColourValue_TextChanged);
            // 
            // klblRGBOutput
            // 
            this.klblRGBOutput.Location = new System.Drawing.Point(43, 104);
            this.klblRGBOutput.Name = "klblRGBOutput";
            this.klblRGBOutput.Size = new System.Drawing.Size(143, 37);
            this.klblRGBOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.klblRGBOutput.TabIndex = 8;
            this.klblRGBOutput.Values.Text = "RGB Value:";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.Transparent;
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPreview.Location = new System.Drawing.Point(634, 37);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(101, 89);
            this.pnlPreview.TabIndex = 9;
            this.pnlPreview.MouseEnter += new System.EventHandler(this.pnlPreview_MouseEnter);
            // 
            // kchkAutoUpdate
            // 
            this.kchkAutoUpdate.Checked = true;
            this.kchkAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kchkAutoUpdate.Location = new System.Drawing.Point(237, 157);
            this.kchkAutoUpdate.Name = "kchkAutoUpdate";
            this.kchkAutoUpdate.Size = new System.Drawing.Size(234, 26);
            this.kchkAutoUpdate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkAutoUpdate.TabIndex = 6;
            this.kchkAutoUpdate.Values.Text = "Automatically Update &Values";
            this.kchkAutoUpdate.CheckedChanged += new System.EventHandler(this.kchkAutoUpdate_CheckedChanged);
            // 
            // kbtnConvert
            // 
            this.kbtnConvert.Location = new System.Drawing.Point(43, 157);
            this.kbtnConvert.Name = "kbtnConvert";
            this.kbtnConvert.Size = new System.Drawing.Size(188, 25);
            this.kbtnConvert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnConvert.TabIndex = 7;
            this.kbtnConvert.Values.Text = "&Convert Hex to RGB";
            this.kbtnConvert.Click += new System.EventHandler(this.kbtnConvert_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kPal;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // tmrUpdateValues
            // 
            this.tmrUpdateValues.Interval = 150;
            this.tmrUpdateValues.Tick += new System.EventHandler(this.tmrUpdateValues_Tick);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // ColourHexadecimalToRGBConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 202);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourHexadecimalToRGBConverter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexadecimal to RGB Converter";
            this.Load += new System.EventHandler(this.ColourHexadecimalToRGBConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtHexColourValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblRGBOutput;
        private System.Windows.Forms.Panel pnlPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkAutoUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnConvert;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kPal;
        private System.Windows.Forms.Timer tmrUpdateValues;
        private System.Windows.Forms.ToolTip ttInformation;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}