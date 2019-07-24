using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonPaletteColourMixerBasic : KryptonForm
    {
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnOptions;
        private KryptonColorButton kcbBaseColour;
        private KryptonButton kbtnDefineOtherColours;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnUtiliseAsBaseColour;
        private KryptonButton kbtnGenerateColour;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel1;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox1;
        private ExtendedColourControls.KryptonAlphaValueNumericBox alphaValueNumericBox1;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel1;
        private ExtendedColourControls.Controls.Labels.KryptonRedValueLabel kryptonRedValueLabel1;
        private ExtendedColourControls.Controls.Labels.KryptonGreenValueLabel kryptonGreenValueLabel1;
        private ExtendedColourControls.Controls.Labels.KryptonBlueValueLabel kryptonBlueValueLabel1;
        private ExtendedColourControls.KryptonAlphaTrackBar kryptonAlphaTrackBar1;
        private ExtendedColourControls.KryptonRedTrackBar kryptonRedTrackBar1;
        private ExtendedColourControls.KryptonGreenTrackBar kryptonGreenTrackBar1;
        private ExtendedColourControls.KryptonBlueTrackBar kryptonBlueTrackBar1;
        private KryptonButton kbtnGenerate;

        private void InitializeComponent()
        {
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcbBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kbtnDefineOtherColours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUtiliseAsBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.alphaValueNumericBox1 = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.kryptonAlphaValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.circularPictureBox1 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.kryptonRedValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonRedValueLabel();
            this.kryptonGreenValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonGreenValueLabel();
            this.kryptonBlueValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonBlueValueLabel();
            this.kryptonAlphaTrackBar1 = new ExtendedColourControls.KryptonAlphaTrackBar();
            this.kryptonRedTrackBar1 = new ExtendedColourControls.KryptonRedTrackBar();
            this.kryptonGreenTrackBar1 = new ExtendedColourControls.KryptonGreenTrackBar();
            this.kryptonBlueTrackBar1 = new ExtendedColourControls.KryptonBlueTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnOptions);
            this.kryptonPanel2.Controls.Add(this.kcbBaseColour);
            this.kryptonPanel2.Controls.Add(this.kbtnDefineOtherColours);
            this.kryptonPanel2.Controls.Add(this.kbtnOk);
            this.kryptonPanel2.Controls.Add(this.kbtnUtiliseAsBaseColour);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateColour);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerate);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 273);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1208, 45);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kbtnOptions
            // 
            this.kbtnOptions.AutoSize = true;
            this.kbtnOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOptions.Location = new System.Drawing.Point(711, 6);
            this.kbtnOptions.Name = "kbtnOptions";
            this.kbtnOptions.Size = new System.Drawing.Size(69, 30);
            this.kbtnOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOptions.TabIndex = 77;
            this.kbtnOptions.Values.Text = "&Options";
            // 
            // kcbBaseColour
            // 
            this.kcbBaseColour.AutoSize = true;
            this.kcbBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kcbBaseColour.Location = new System.Drawing.Point(506, 6);
            this.kcbBaseColour.Name = "kcbBaseColour";
            this.kcbBaseColour.Size = new System.Drawing.Size(199, 30);
            this.kcbBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbBaseColour.TabIndex = 76;
            this.kcbBaseColour.Values.Text = "&Choose a Base Colour";
            // 
            // kbtnDefineOtherColours
            // 
            this.kbtnDefineOtherColours.AutoSize = true;
            this.kbtnDefineOtherColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnDefineOtherColours.Location = new System.Drawing.Point(335, 6);
            this.kbtnDefineOtherColours.Name = "kbtnDefineOtherColours";
            this.kbtnDefineOtherColours.Size = new System.Drawing.Size(165, 30);
            this.kbtnDefineOtherColours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDefineOtherColours.TabIndex = 63;
            this.kbtnDefineOtherColours.Values.Text = "Define Other &Colours";
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(1160, 6);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 60;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kbtnUtiliseAsBaseColour
            // 
            this.kbtnUtiliseAsBaseColour.AutoSize = true;
            this.kbtnUtiliseAsBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnUtiliseAsBaseColour.Location = new System.Drawing.Point(12, 6);
            this.kbtnUtiliseAsBaseColour.Name = "kbtnUtiliseAsBaseColour";
            this.kbtnUtiliseAsBaseColour.Size = new System.Drawing.Size(167, 30);
            this.kbtnUtiliseAsBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUtiliseAsBaseColour.TabIndex = 15;
            this.kbtnUtiliseAsBaseColour.Values.Text = "Utilise as Base &Colour";
            // 
            // kbtnGenerateColour
            // 
            this.kbtnGenerateColour.AutoSize = true;
            this.kbtnGenerateColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateColour.Location = new System.Drawing.Point(506, 6);
            this.kbtnGenerateColour.Name = "kbtnGenerateColour";
            this.kbtnGenerateColour.Size = new System.Drawing.Size(197, 30);
            this.kbtnGenerateColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateColour.TabIndex = 29;
            this.kbtnGenerateColour.Values.Text = "Generate Random &Colour";
            this.kbtnGenerateColour.Visible = false;
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.AutoSize = true;
            this.kbtnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerate.Location = new System.Drawing.Point(185, 6);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(144, 30);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 16;
            this.kbtnGenerate.Values.Text = "Gener&ate a Colour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 2);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonAlphaTrackBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonRedTrackBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonGreenTrackBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonBlueTrackBar1);
            this.kryptonPanel1.Controls.Add(this.alphaValueNumericBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonAlphaValueLabel1);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonBlueValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonGreenValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonRedValueLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1208, 271);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // alphaValueNumericBox1
            // 
            this.alphaValueNumericBox1.Location = new System.Drawing.Point(292, 12);
            this.alphaValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaValueNumericBox1.Name = "alphaValueNumericBox1";
            this.alphaValueNumericBox1.Size = new System.Drawing.Size(79, 26);
            this.alphaValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.alphaValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.alphaValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.alphaValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.alphaValueNumericBox1.TabIndex = 5;
            // 
            // kryptonAlphaValueLabel1
            // 
            this.kryptonAlphaValueLabel1.AlphaValue = 255;
            this.kryptonAlphaValueLabel1.Location = new System.Drawing.Point(224, 12);
            this.kryptonAlphaValueLabel1.Name = "kryptonAlphaValueLabel1";
            this.kryptonAlphaValueLabel1.Size = new System.Drawing.Size(62, 26);
            this.kryptonAlphaValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.TabIndex = 6;
            this.kryptonAlphaValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel1.Values.Text = "Alpha:";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(206, 195);
            this.circularPictureBox1.TabIndex = 5;
            this.circularPictureBox1.TabStop = false;
            // 
            // kryptonRedValueLabel1
            // 
            this.kryptonRedValueLabel1.Location = new System.Drawing.Point(240, 44);
            this.kryptonRedValueLabel1.Name = "kryptonRedValueLabel1";
            this.kryptonRedValueLabel1.RedValue = 255;
            this.kryptonRedValueLabel1.Size = new System.Drawing.Size(46, 26);
            this.kryptonRedValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.TabIndex = 5;
            this.kryptonRedValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.Values.Text = "Red:";
            // 
            // kryptonGreenValueLabel1
            // 
            this.kryptonGreenValueLabel1.Location = new System.Drawing.Point(224, 90);
            this.kryptonGreenValueLabel1.Name = "kryptonGreenValueLabel1";
            this.kryptonGreenValueLabel1.RedValue = 255;
            this.kryptonGreenValueLabel1.Size = new System.Drawing.Size(213, 26);
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.TabIndex = 6;
            this.kryptonGreenValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.Values.Text = "kryptonGreenValueLabel1";
            // 
            // kryptonBlueValueLabel1
            // 
            this.kryptonBlueValueLabel1.Location = new System.Drawing.Point(224, 138);
            this.kryptonBlueValueLabel1.Name = "kryptonBlueValueLabel1";
            this.kryptonBlueValueLabel1.RedValue = 255;
            this.kryptonBlueValueLabel1.Size = new System.Drawing.Size(201, 26);
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.TabIndex = 7;
            this.kryptonBlueValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.Values.Text = "kryptonBlueValueLabel1";
            // 
            // kryptonAlphaTrackBar1
            // 
            this.kryptonAlphaTrackBar1.DrawBackground = true;
            this.kryptonAlphaTrackBar1.Location = new System.Drawing.Point(377, 17);
            this.kryptonAlphaTrackBar1.Maximum = 255;
            this.kryptonAlphaTrackBar1.Name = "kryptonAlphaTrackBar1";
            this.kryptonAlphaTrackBar1.Size = new System.Drawing.Size(603, 21);
            this.kryptonAlphaTrackBar1.TabIndex = 8;
            this.kryptonAlphaTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonRedTrackBar1
            // 
            this.kryptonRedTrackBar1.DrawBackground = true;
            this.kryptonRedTrackBar1.Location = new System.Drawing.Point(431, 49);
            this.kryptonRedTrackBar1.Maximum = 255;
            this.kryptonRedTrackBar1.Name = "kryptonRedTrackBar1";
            this.kryptonRedTrackBar1.Size = new System.Drawing.Size(603, 21);
            this.kryptonRedTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar1.TabIndex = 9;
            this.kryptonRedTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonGreenTrackBar1
            // 
            this.kryptonGreenTrackBar1.DrawBackground = true;
            this.kryptonGreenTrackBar1.Location = new System.Drawing.Point(431, 95);
            this.kryptonGreenTrackBar1.Maximum = 255;
            this.kryptonGreenTrackBar1.Name = "kryptonGreenTrackBar1";
            this.kryptonGreenTrackBar1.Size = new System.Drawing.Size(603, 21);
            this.kryptonGreenTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar1.TabIndex = 10;
            this.kryptonGreenTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // kryptonBlueTrackBar1
            // 
            this.kryptonBlueTrackBar1.DrawBackground = true;
            this.kryptonBlueTrackBar1.Location = new System.Drawing.Point(431, 138);
            this.kryptonBlueTrackBar1.Maximum = 255;
            this.kryptonBlueTrackBar1.Name = "kryptonBlueTrackBar1";
            this.kryptonBlueTrackBar1.Size = new System.Drawing.Size(603, 21);
            this.kryptonBlueTrackBar1.StateCommon.Tick.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar1.TabIndex = 11;
            this.kryptonBlueTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // KryptonPaletteColourMixerBasic
            // 
            this.ClientSize = new System.Drawing.Size(1208, 318);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonPaletteColourMixerBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}