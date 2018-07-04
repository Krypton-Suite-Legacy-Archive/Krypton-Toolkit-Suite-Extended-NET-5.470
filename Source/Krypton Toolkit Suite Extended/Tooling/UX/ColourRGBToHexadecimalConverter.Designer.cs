namespace Tooling.UX
{
    partial class ColourRGBToHexadecimalConverter
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
            this.kchkEnableAlphaChannel = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.numAlpha = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.klblAlpha = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numBlue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.numGreen = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblHexOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.kchkAutoUpdate = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.numRed = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kbtnConvert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tmrUpdateValues = new System.Windows.Forms.Timer(this.components);
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkEnableAlphaChannel);
            this.kryptonPanel1.Controls.Add(this.numAlpha);
            this.kryptonPanel1.Controls.Add(this.klblAlpha);
            this.kryptonPanel1.Controls.Add(this.numBlue);
            this.kryptonPanel1.Controls.Add(this.numGreen);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.klblHexOutput);
            this.kryptonPanel1.Controls.Add(this.pnlPreview);
            this.kryptonPanel1.Controls.Add(this.kchkAutoUpdate);
            this.kryptonPanel1.Controls.Add(this.numRed);
            this.kryptonPanel1.Controls.Add(this.kbtnConvert);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(803, 202);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kchkEnableAlphaChannel
            // 
            this.kchkEnableAlphaChannel.Location = new System.Drawing.Point(477, 144);
            this.kchkEnableAlphaChannel.Name = "kchkEnableAlphaChannel";
            this.kchkEnableAlphaChannel.Size = new System.Drawing.Size(183, 26);
            this.kchkEnableAlphaChannel.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkEnableAlphaChannel.TabIndex = 6;
            this.kchkEnableAlphaChannel.Values.Text = "&Enable Alpha Channel";
            this.kchkEnableAlphaChannel.CheckedChanged += new System.EventHandler(this.kchkEnableAlphaChannel_CheckedChanged);
            // 
            // numAlpha
            // 
            this.numAlpha.DecimalPlaces = 1;
            this.numAlpha.Enabled = false;
            this.numAlpha.Location = new System.Drawing.Point(605, 35);
            this.numAlpha.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(80, 28);
            this.numAlpha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAlpha.TabIndex = 3;
            this.numAlpha.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // klblAlpha
            // 
            this.klblAlpha.Enabled = false;
            this.klblAlpha.Location = new System.Drawing.Point(537, 37);
            this.klblAlpha.Name = "klblAlpha";
            this.klblAlpha.Size = new System.Drawing.Size(62, 26);
            this.klblAlpha.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAlpha.TabIndex = 11;
            this.klblAlpha.Values.Text = "Alpha:";
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(433, 35);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(80, 28);
            this.numBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBlue.TabIndex = 2;
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(268, 35);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(80, 28);
            this.numGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGreen.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(200, 37);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Green:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(377, 37);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // klblHexOutput
            // 
            this.klblHexOutput.Location = new System.Drawing.Point(43, 92);
            this.klblHexOutput.Name = "klblHexOutput";
            this.klblHexOutput.Size = new System.Drawing.Size(139, 37);
            this.klblHexOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.klblHexOutput.TabIndex = 5;
            this.klblHexOutput.Values.Text = "Hex Value:";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.Transparent;
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPreview.Location = new System.Drawing.Point(691, 35);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(101, 89);
            this.pnlPreview.TabIndex = 7;
            this.pnlPreview.MouseEnter += new System.EventHandler(this.pnlPreview_MouseEnter);
            // 
            // kchkAutoUpdate
            // 
            this.kchkAutoUpdate.Checked = true;
            this.kchkAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kchkAutoUpdate.Location = new System.Drawing.Point(237, 144);
            this.kchkAutoUpdate.Name = "kchkAutoUpdate";
            this.kchkAutoUpdate.Size = new System.Drawing.Size(234, 26);
            this.kchkAutoUpdate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkAutoUpdate.TabIndex = 4;
            this.kchkAutoUpdate.Values.Text = "Automatically Update &Values";
            this.kchkAutoUpdate.CheckedChanged += new System.EventHandler(this.kchkAutoUpdate_CheckedChanged);
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(95, 35);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(80, 28);
            this.numRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRed.TabIndex = 0;
            // 
            // kbtnConvert
            // 
            this.kbtnConvert.Location = new System.Drawing.Point(43, 144);
            this.kbtnConvert.Name = "kbtnConvert";
            this.kbtnConvert.Size = new System.Drawing.Size(188, 25);
            this.kbtnConvert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnConvert.TabIndex = 5;
            this.kbtnConvert.Values.Text = "&Convert RGB To Hex";
            this.kbtnConvert.Click += new System.EventHandler(this.kbtnConvert_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(43, 37);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Red:";
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
            // ColourRGBToHexadecimalConverter
            // 
            this.AcceptButton = this.kbtnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 202);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourRGBToHexadecimalConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB to Hexadecimal Converter";
            this.Load += new System.EventHandler(this.ColourRGBToHexadecimalConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numBlue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numGreen;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblHexOutput;
        private System.Windows.Forms.Panel pnlPreview;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkAutoUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numRed;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnConvert;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kPal;
        private System.Windows.Forms.Timer tmrUpdateValues;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numAlpha;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblAlpha;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkEnableAlphaChannel;
        private System.Windows.Forms.ToolTip ttInformation;
    }
}