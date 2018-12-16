namespace PaletteCreator.UX
{
    partial class ColourMixer
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
            this.ktbBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.kbtnUseAsBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateAlphaChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.ktbRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.knumBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktbAlphaChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.knumAlphaChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxBaseColour = new System.Windows.Forms.PictureBox();
            this.ttInformation = new System.Windows.Forms.ToolTip(this.components);
            this.tmrUpdateUI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ktbBlueChannelValue);
            this.kryptonPanel1.Controls.Add(this.kbtnUseAsBaseColour);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateAlphaChannelValue);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateBlueChannelValue);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateGreenChannelValue);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateRedChannelValue);
            this.kryptonPanel1.Controls.Add(this.ktbGreenChannelValue);
            this.kryptonPanel1.Controls.Add(this.ktbRedChannelValue);
            this.kryptonPanel1.Controls.Add(this.knumBlueChannelValue);
            this.kryptonPanel1.Controls.Add(this.knumGreenChannelValue);
            this.kryptonPanel1.Controls.Add(this.knumRedChannelValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.ktbAlphaChannelValue);
            this.kryptonPanel1.Controls.Add(this.knumAlphaChannelValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.pbxBaseColour);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1250, 787);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ktbBlueChannelValue
            // 
            this.ktbBlueChannelValue.DrawBackground = true;
            this.ktbBlueChannelValue.Location = new System.Drawing.Point(968, 670);
            this.ktbBlueChannelValue.Maximum = 255;
            this.ktbBlueChannelValue.Name = "ktbBlueChannelValue";
            this.ktbBlueChannelValue.Size = new System.Drawing.Size(270, 21);
            this.ktbBlueChannelValue.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.ktbBlueChannelValue.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.ktbBlueChannelValue.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.ktbBlueChannelValue.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.ktbBlueChannelValue.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.ktbBlueChannelValue.TabIndex = 34;
            this.ktbBlueChannelValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktbBlueChannelValue.ValueChanged += new System.EventHandler(this.ktbBlueChannelValue_ValueChanged);
            // 
            // kbtnUseAsBaseColour
            // 
            this.kbtnUseAsBaseColour.AutoSize = true;
            this.kbtnUseAsBaseColour.Location = new System.Drawing.Point(1046, 742);
            this.kbtnUseAsBaseColour.Name = "kbtnUseAsBaseColour";
            this.kbtnUseAsBaseColour.Size = new System.Drawing.Size(167, 30);
            this.kbtnUseAsBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUseAsBaseColour.TabIndex = 33;
            this.kbtnUseAsBaseColour.Values.Text = "&Use as Base Colour";
            this.kbtnUseAsBaseColour.Click += new System.EventHandler(this.kbtnUseAsBaseColour_Click);
            // 
            // kbtnGenerateAlphaChannelValue
            // 
            this.kbtnGenerateAlphaChannelValue.AutoSize = true;
            this.kbtnGenerateAlphaChannelValue.Location = new System.Drawing.Point(98, 697);
            this.kbtnGenerateAlphaChannelValue.Name = "kbtnGenerateAlphaChannelValue";
            this.kbtnGenerateAlphaChannelValue.Size = new System.Drawing.Size(167, 30);
            this.kbtnGenerateAlphaChannelValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateAlphaChannelValue.TabIndex = 32;
            this.kbtnGenerateAlphaChannelValue.Values.Text = "Generate &Alpha";
            this.kbtnGenerateAlphaChannelValue.Click += new System.EventHandler(this.kbtnGenerateAlphaChannelValue_Click);
            // 
            // kbtnGenerateBlueChannelValue
            // 
            this.kbtnGenerateBlueChannelValue.AutoSize = true;
            this.kbtnGenerateBlueChannelValue.Location = new System.Drawing.Point(1046, 697);
            this.kbtnGenerateBlueChannelValue.Name = "kbtnGenerateBlueChannelValue";
            this.kbtnGenerateBlueChannelValue.Size = new System.Drawing.Size(167, 30);
            this.kbtnGenerateBlueChannelValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBlueChannelValue.TabIndex = 31;
            this.kbtnGenerateBlueChannelValue.Values.Text = "Generate &Blue";
            this.kbtnGenerateBlueChannelValue.Click += new System.EventHandler(this.kbtnGenerateBlueChannelValue_Click);
            // 
            // kbtnGenerateGreenChannelValue
            // 
            this.kbtnGenerateGreenChannelValue.AutoSize = true;
            this.kbtnGenerateGreenChannelValue.Location = new System.Drawing.Point(729, 697);
            this.kbtnGenerateGreenChannelValue.Name = "kbtnGenerateGreenChannelValue";
            this.kbtnGenerateGreenChannelValue.Size = new System.Drawing.Size(167, 30);
            this.kbtnGenerateGreenChannelValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateGreenChannelValue.TabIndex = 30;
            this.kbtnGenerateGreenChannelValue.Values.Text = "Generate &Green";
            this.kbtnGenerateGreenChannelValue.Click += new System.EventHandler(this.kbtnGenerateGreenChannelValue_Click);
            // 
            // kbtnGenerateRedChannelValue
            // 
            this.kbtnGenerateRedChannelValue.AutoSize = true;
            this.kbtnGenerateRedChannelValue.Location = new System.Drawing.Point(422, 697);
            this.kbtnGenerateRedChannelValue.Name = "kbtnGenerateRedChannelValue";
            this.kbtnGenerateRedChannelValue.Size = new System.Drawing.Size(167, 30);
            this.kbtnGenerateRedChannelValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateRedChannelValue.TabIndex = 29;
            this.kbtnGenerateRedChannelValue.Values.Text = "Generate &Red";
            this.kbtnGenerateRedChannelValue.Click += new System.EventHandler(this.kbtnGenerateRedChannelValue_Click);
            // 
            // ktbGreenChannelValue
            // 
            this.ktbGreenChannelValue.DrawBackground = true;
            this.ktbGreenChannelValue.Location = new System.Drawing.Point(644, 670);
            this.ktbGreenChannelValue.Maximum = 255;
            this.ktbGreenChannelValue.Name = "ktbGreenChannelValue";
            this.ktbGreenChannelValue.Size = new System.Drawing.Size(318, 21);
            this.ktbGreenChannelValue.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.ktbGreenChannelValue.TabIndex = 22;
            this.ktbGreenChannelValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktbGreenChannelValue.ValueChanged += new System.EventHandler(this.ktbGreenChannelValue_ValueChanged);
            // 
            // ktbRedChannelValue
            // 
            this.ktbRedChannelValue.DrawBackground = true;
            this.ktbRedChannelValue.Location = new System.Drawing.Point(336, 670);
            this.ktbRedChannelValue.Maximum = 255;
            this.ktbRedChannelValue.Name = "ktbRedChannelValue";
            this.ktbRedChannelValue.Size = new System.Drawing.Size(302, 21);
            this.ktbRedChannelValue.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.ktbRedChannelValue.TabIndex = 21;
            this.ktbRedChannelValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktbRedChannelValue.ValueChanged += new System.EventHandler(this.ktbRedChannelValue_ValueChanged);
            // 
            // knumBlueChannelValue
            // 
            this.knumBlueChannelValue.Location = new System.Drawing.Point(1024, 621);
            this.knumBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlueChannelValue.Name = "knumBlueChannelValue";
            this.knumBlueChannelValue.Size = new System.Drawing.Size(214, 28);
            this.knumBlueChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBlueChannelValue.TabIndex = 20;
            this.knumBlueChannelValue.ValueChanged += new System.EventHandler(this.knumBlueChannelValue_ValueChanged);
            // 
            // knumGreenChannelValue
            // 
            this.knumGreenChannelValue.Location = new System.Drawing.Point(712, 623);
            this.knumGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreenChannelValue.Name = "knumGreenChannelValue";
            this.knumGreenChannelValue.Size = new System.Drawing.Size(250, 28);
            this.knumGreenChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreenChannelValue.TabIndex = 19;
            this.knumGreenChannelValue.ValueChanged += new System.EventHandler(this.knumGreenChannelValue_ValueChanged);
            // 
            // knumRedChannelValue
            // 
            this.knumRedChannelValue.Location = new System.Drawing.Point(388, 621);
            this.knumRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRedChannelValue.Name = "knumRedChannelValue";
            this.knumRedChannelValue.Size = new System.Drawing.Size(250, 28);
            this.knumRedChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumRedChannelValue.TabIndex = 18;
            this.knumRedChannelValue.ValueChanged += new System.EventHandler(this.knumRedChannelValue_ValueChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(968, 623);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(644, 623);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(336, 623);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // ktbAlphaChannelValue
            // 
            this.ktbAlphaChannelValue.DrawBackground = true;
            this.ktbAlphaChannelValue.Location = new System.Drawing.Point(13, 670);
            this.ktbAlphaChannelValue.Maximum = 255;
            this.ktbAlphaChannelValue.Name = "ktbAlphaChannelValue";
            this.ktbAlphaChannelValue.Size = new System.Drawing.Size(317, 21);
            this.ktbAlphaChannelValue.TabIndex = 4;
            this.ktbAlphaChannelValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktbAlphaChannelValue.Value = 255;
            this.ktbAlphaChannelValue.ValueChanged += new System.EventHandler(this.ktbAlphaChannelValue_ValueChanged);
            // 
            // knumAlphaChannelValue
            // 
            this.knumAlphaChannelValue.Location = new System.Drawing.Point(80, 623);
            this.knumAlphaChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlphaChannelValue.Name = "knumAlphaChannelValue";
            this.knumAlphaChannelValue.Size = new System.Drawing.Size(250, 28);
            this.knumAlphaChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlphaChannelValue.TabIndex = 3;
            this.knumAlphaChannelValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlphaChannelValue.ValueChanged += new System.EventHandler(this.knumAlphaChannelValue_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 623);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // pbxBaseColour
            // 
            this.pbxBaseColour.BackColor = System.Drawing.Color.Transparent;
            this.pbxBaseColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBaseColour.Location = new System.Drawing.Point(311, 12);
            this.pbxBaseColour.Name = "pbxBaseColour";
            this.pbxBaseColour.Size = new System.Drawing.Size(660, 584);
            this.pbxBaseColour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBaseColour.TabIndex = 1;
            this.pbxBaseColour.TabStop = false;
            this.pbxBaseColour.MouseEnter += new System.EventHandler(this.pbxBaseColour_MouseEnter);
            // 
            // tmrUpdateUI
            // 
            this.tmrUpdateUI.Enabled = true;
            this.tmrUpdateUI.Interval = 250;
            this.tmrUpdateUI.Tick += new System.EventHandler(this.tmrUpdateUI_Tick);
            // 
            // ColourMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 787);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourMixer";
            this.Text = "Colour Mixer";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseColour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar ktbAlphaChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumAlphaChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pbxBaseColour;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumBlueChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumGreenChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown knumRedChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar ktbRedChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar ktbGreenChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateAlphaChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateBlueChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateGreenChannelValue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGenerateRedChannelValue;
        private System.Windows.Forms.ToolTip ttInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnUseAsBaseColour;
        private System.Windows.Forms.Timer tmrUpdateUI;
        private ComponentFactory.Krypton.Toolkit.KryptonTrackBar ktbBlueChannelValue;
    }
}