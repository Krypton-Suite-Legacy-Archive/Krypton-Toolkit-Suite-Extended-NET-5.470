using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteExplorer.UX.Colour
{
    public class ColourMixerBasic : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnGenerate;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel klblRedValue;
        private KryptonLabel klblGreenValue;
        private KryptonLabel klblBlueValue;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonNumericUpDown knumAlpaValue;
        private KryptonLabel kryptonLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel cwSelectedColour;
        private KryptonButton kbtnSetColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxColourPreview;
        private KryptonComboBox kryptonComboBox1;
        private KryptonLabel kryptonLabel2;
        private KryptonButton kbtnOk;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnGenerate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblRedValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumAlpaValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cwSelectedColour = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbxColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kbtnSetColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnGenerate);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 451);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(855, 65);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.AutoSize = true;
            this.kbtnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerate.Location = new System.Drawing.Point(12, 15);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(197, 30);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 61;
            this.kbtnGenerate.Values.Text = "Gener&ate Random Colour";
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(807, 15);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 60;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 2);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnSetColour);
            this.kryptonPanel2.Controls.Add(this.cbxColourPreview);
            this.kryptonPanel2.Controls.Add(this.kryptonComboBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.klblRedValue);
            this.kryptonPanel2.Controls.Add(this.klblGreenValue);
            this.kryptonPanel2.Controls.Add(this.klblBlueValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.knumAlpaValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cwSelectedColour);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(855, 449);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // klblRedValue
            // 
            this.klblRedValue.Location = new System.Drawing.Point(288, 390);
            this.klblRedValue.Name = "klblRedValue";
            this.klblRedValue.Size = new System.Drawing.Size(6, 2);
            this.klblRedValue.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.TabIndex = 32;
            this.klblRedValue.Values.Text = "";
            // 
            // klblGreenValue
            // 
            this.klblGreenValue.Location = new System.Drawing.Point(476, 390);
            this.klblGreenValue.Name = "klblGreenValue";
            this.klblGreenValue.Size = new System.Drawing.Size(6, 2);
            this.klblGreenValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.TabIndex = 31;
            this.klblGreenValue.Values.Text = "";
            // 
            // klblBlueValue
            // 
            this.klblBlueValue.Location = new System.Drawing.Point(666, 390);
            this.klblBlueValue.Name = "klblBlueValue";
            this.klblBlueValue.Size = new System.Drawing.Size(6, 2);
            this.klblBlueValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.TabIndex = 30;
            this.klblBlueValue.Values.Text = "";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(223, 390);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 29;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(390, 390);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 28;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(596, 387);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 27;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // knumAlpaValue
            // 
            this.knumAlpaValue.DecimalPlaces = 99;
            this.knumAlpaValue.Location = new System.Drawing.Point(97, 390);
            this.knumAlpaValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpaValue.Name = "knumAlpaValue";
            this.knumAlpaValue.Size = new System.Drawing.Size(120, 32);
            this.knumAlpaValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpaValue.TabIndex = 26;
            this.knumAlpaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 387);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // cwSelectedColour
            // 
            this.cwSelectedColour.BackColor = System.Drawing.Color.Transparent;
            this.cwSelectedColour.Location = new System.Drawing.Point(12, 12);
            this.cwSelectedColour.Name = "cwSelectedColour";
            this.cwSelectedColour.Size = new System.Drawing.Size(352, 362);
            this.cwSelectedColour.TabIndex = 24;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(370, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(218, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 33;
            this.kryptonLabel2.Values.Text = "Generate colour for:";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 435;
            this.kryptonComboBox1.Location = new System.Drawing.Point(404, 52);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(435, 27);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 34;
            // 
            // cbxColourPreview
            // 
            this.cbxColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxColourPreview.Location = new System.Drawing.Point(486, 86);
            this.cbxColourPreview.Name = "cbxColourPreview";
            this.cbxColourPreview.Size = new System.Drawing.Size(232, 230);
            this.cbxColourPreview.TabIndex = 35;
            this.cbxColourPreview.TabStop = false;
            // 
            // kbtnSetColour
            // 
            this.kbtnSetColour.AutoSize = true;
            this.kbtnSetColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnSetColour.Enabled = false;
            this.kbtnSetColour.Location = new System.Drawing.Point(562, 344);
            this.kbtnSetColour.Name = "kbtnSetColour";
            this.kbtnSetColour.Size = new System.Drawing.Size(88, 30);
            this.kbtnSetColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSetColour.TabIndex = 61;
            this.kbtnSetColour.Values.Text = "&Set Colour";
            // 
            // ColourMixerBasic
            // 
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ColourMixerBasic";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).EndInit();
            this.ResumeLayout(false);

        }
    }
}