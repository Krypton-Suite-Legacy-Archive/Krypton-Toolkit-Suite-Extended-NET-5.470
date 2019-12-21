#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs.Dialogs.Colour.Palettes
{
    public class CustomPaletteColours : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnOk;
        private KryptonTextBox ktbHexadecimal;
        private KryptonButton kbtnUtiliseAsBaseColour;
        private KryptonButton kbtnSaveColour;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonListBox klstCustomColourSelector;
        private System.Windows.Forms.PictureBox pbxColourPreview;
        private KryptonComboBox kcmbNormalTextSystemColours;
        private KryptonLabel kryptonLabel22;
        private KryptonComboBox kcmbNormalTextColour;
        private KryptonLabel kryptonLabel21;
        private KryptonButton kbtnGenerateNormalTextBlueValue;
        private KryptonNumericUpDown knumBlueChannelValue;
        private KryptonLabel kryptonLabel4;
        private KryptonButton kbtnGenerateNormalTextGreenValue;
        private KryptonNumericUpDown knumGreenChannelValue;
        private KryptonLabel kryptonLabel3;
        private KryptonButton kbtnGenerateNormalTextRedValue;
        private KryptonNumericUpDown knumRedChannelValue;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPaletteColours));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbHexadecimal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnUtiliseAsBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSaveColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klstCustomColourSelector = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.pbxColourPreview = new System.Windows.Forms.PictureBox();
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
            this.kryptonPanel1.Controls.Add(this.kbtnUtiliseAsBaseColour);
            this.kryptonPanel1.Controls.Add(this.kbtnSaveColour);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.ktbHexadecimal);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 341);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1027, 50);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(983, 8);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 101;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // ktbHexadecimal
            // 
            this.ktbHexadecimal.Hint = "#000000";
            this.ktbHexadecimal.Location = new System.Drawing.Point(534, 9);
            this.ktbHexadecimal.MaxLength = 7;
            this.ktbHexadecimal.Name = "ktbHexadecimal";
            this.ktbHexadecimal.Size = new System.Drawing.Size(176, 29);
            this.ktbHexadecimal.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbHexadecimal.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbHexadecimal.TabIndex = 85;
            this.ktbHexadecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(356, 11);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(172, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 84;
            this.kryptonLabel1.Values.Text = "Hexadecimal Colour:";
            // 
            // kbtnUtiliseAsBaseColour
            // 
            this.kbtnUtiliseAsBaseColour.AutoSize = true;
            this.kbtnUtiliseAsBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnUtiliseAsBaseColour.Location = new System.Drawing.Point(183, 8);
            this.kbtnUtiliseAsBaseColour.Name = "kbtnUtiliseAsBaseColour";
            this.kbtnUtiliseAsBaseColour.Size = new System.Drawing.Size(167, 30);
            this.kbtnUtiliseAsBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUtiliseAsBaseColour.TabIndex = 103;
            this.kbtnUtiliseAsBaseColour.Values.Text = "Utilise as Base &Colour";
            // 
            // kbtnSaveColour
            // 
            this.kbtnSaveColour.AutoSize = true;
            this.kbtnSaveColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnSaveColour.Enabled = false;
            this.kbtnSaveColour.Location = new System.Drawing.Point(12, 8);
            this.kbtnSaveColour.Name = "kbtnSaveColour";
            this.kbtnSaveColour.Size = new System.Drawing.Size(165, 30);
            this.kbtnSaveColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveColour.TabIndex = 102;
            this.kbtnSaveColour.Values.Text = "Save &Selected Colour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 3);
            this.panel1.TabIndex = 3;
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
            this.kryptonPanel2.Size = new System.Drawing.Size(1027, 338);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // klstCustomColourSelector
            // 
            this.klstCustomColourSelector.HorizontalScrollbar = true;
            this.klstCustomColourSelector.Location = new System.Drawing.Point(12, 12);
            this.klstCustomColourSelector.Name = "klstCustomColourSelector";
            this.klstCustomColourSelector.Size = new System.Drawing.Size(335, 257);
            this.klstCustomColourSelector.Sorted = true;
            this.klstCustomColourSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstCustomColourSelector.TabIndex = 156;
            // 
            // pbxColourPreview
            // 
            this.pbxColourPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxColourPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxColourPreview.Location = new System.Drawing.Point(353, 12);
            this.pbxColourPreview.Name = "pbxColourPreview";
            this.pbxColourPreview.Size = new System.Drawing.Size(650, 180);
            this.pbxColourPreview.TabIndex = 155;
            this.pbxColourPreview.TabStop = false;
            // 
            // kcmbNormalTextSystemColours
            // 
            this.kcmbNormalTextSystemColours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbNormalTextSystemColours.DropDownWidth = 173;
            this.kcmbNormalTextSystemColours.IntegralHeight = false;
            this.kcmbNormalTextSystemColours.Location = new System.Drawing.Point(830, 215);
            this.kcmbNormalTextSystemColours.Name = "kcmbNormalTextSystemColours";
            this.kcmbNormalTextSystemColours.Size = new System.Drawing.Size(173, 27);
            this.kcmbNormalTextSystemColours.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbNormalTextSystemColours.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbNormalTextSystemColours.TabIndex = 154;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(688, 216);
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
            this.kcmbNormalTextColour.IntegralHeight = false;
            this.kcmbNormalTextColour.Location = new System.Drawing.Point(509, 215);
            this.kcmbNormalTextColour.Name = "kcmbNormalTextColour";
            this.kcmbNormalTextColour.Size = new System.Drawing.Size(173, 27);
            this.kcmbNormalTextColour.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbNormalTextColour.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbNormalTextColour.TabIndex = 152;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(353, 216);
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
            this.kbtnGenerateNormalTextBlueValue.Location = new System.Drawing.Point(843, 282);
            this.kbtnGenerateNormalTextBlueValue.Name = "kbtnGenerateNormalTextBlueValue";
            this.kbtnGenerateNormalTextBlueValue.Size = new System.Drawing.Size(114, 30);
            this.kbtnGenerateNormalTextBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextBlueValue.TabIndex = 150;
            this.kbtnGenerateNormalTextBlueValue.Values.Text = "Generate &Blue";
            // 
            // knumBlueChannelValue
            // 
            this.knumBlueChannelValue.Location = new System.Drawing.Point(717, 282);
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
            this.knumBlueChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBlueChannelValue.TabIndex = 149;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(649, 284);
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
            this.kbtnGenerateNormalTextGreenValue.Location = new System.Drawing.Point(517, 284);
            this.kbtnGenerateNormalTextGreenValue.Name = "kbtnGenerateNormalTextGreenValue";
            this.kbtnGenerateNormalTextGreenValue.Size = new System.Drawing.Size(126, 30);
            this.kbtnGenerateNormalTextGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextGreenValue.TabIndex = 147;
            this.kbtnGenerateNormalTextGreenValue.Values.Text = "Generate &Green";
            // 
            // knumGreenChannelValue
            // 
            this.knumGreenChannelValue.Location = new System.Drawing.Point(391, 284);
            this.knumGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreenChannelValue.Name = "knumGreenChannelValue";
            this.knumGreenChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumGreenChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreenChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumGreenChannelValue.TabIndex = 146;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(323, 284);
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
            this.kbtnGenerateNormalTextRedValue.Location = new System.Drawing.Point(206, 284);
            this.kbtnGenerateNormalTextRedValue.Name = "kbtnGenerateNormalTextRedValue";
            this.kbtnGenerateNormalTextRedValue.Size = new System.Drawing.Size(111, 30);
            this.kbtnGenerateNormalTextRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateNormalTextRedValue.TabIndex = 144;
            this.kbtnGenerateNormalTextRedValue.Values.Text = "Generate &Red";
            // 
            // knumRedChannelValue
            // 
            this.knumRedChannelValue.Location = new System.Drawing.Point(80, 283);
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
            this.knumRedChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumRedChannelValue.TabIndex = 143;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 284);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 142;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // CustomPaletteColours
            // 
            this.ClientSize = new System.Drawing.Size(1027, 391);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomPaletteColours";
            this.ShowInTaskbar = false;
            this.Text = "Define Custom Palette Colours";
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
    }
}