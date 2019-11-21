using ComponentFactory.Krypton.Toolkit;
using Core.Classes;
using ExtendedControls.Base.Code.IO;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using PaletteExplorer.Classes;
using PaletteExplorer.UX.Colour;
using System;
using System.IO;
using System.Windows.Forms;

namespace PaletteExplorer.UX.Debugging
{
    public class ColourDebugConsole : KryptonForm
    {
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kpnlContent;
        private KryptonListBox klstPaletteColours;
        private KryptonLabel klblAlphaValue;
        private KryptonLabel klblRedValue;
        private KryptonLabel klblGreenValue;
        private KryptonLabel klblBlueValue;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel cwSelectedColour;
        private KryptonLabel klblHexValue;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxColourPreview;
        private KryptonButton kbtnImport;
        private KryptonButton kbtnClose;
        private KryptonLabel kryptonLabel2;
        private KryptonTextBox ktxtHexValue;
        private KryptonButton kbtnSetAsBaseColour;
        private KryptonTrackBar ktrkAlphaValue;
        private ToolTip ttInfo;
        private System.ComponentModel.IContainer components;
        private KryptonPanel kpnlControls;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourDebugConsole));
            this.kpnlControls = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktrkAlphaValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.kbtnSetAsBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ktxtHexValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klblHexValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblAlphaValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblRedValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klstPaletteColours = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cbxColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cwSelectedColour = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).BeginInit();
            this.kpnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            this.kpnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlControls
            // 
            this.kpnlControls.Controls.Add(this.kbtnImport);
            this.kpnlControls.Controls.Add(this.kbtnClose);
            this.kpnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlControls.Location = new System.Drawing.Point(0, 827);
            this.kpnlControls.Name = "kpnlControls";
            this.kpnlControls.Size = new System.Drawing.Size(1115, 66);
            this.kpnlControls.TabIndex = 0;
            // 
            // kbtnImport
            // 
            this.kbtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnImport.AutoSize = true;
            this.kbtnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnImport.Location = new System.Drawing.Point(12, 17);
            this.kbtnImport.Name = "kbtnImport";
            this.kbtnImport.Size = new System.Drawing.Size(129, 30);
            this.kbtnImport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImport.TabIndex = 66;
            this.kbtnImport.Values.Text = "Import from &File";
            this.kbtnImport.Click += new System.EventHandler(this.KbtnImport_Click);
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1035, 17);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(68, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 65;
            this.kbtnClose.Values.Image = global::PaletteExplorer.Properties.Resources.Exit_16_x_16;
            this.kbtnClose.Values.Text = "&Close";
            this.kbtnClose.Click += new System.EventHandler(this.KbtnClose_Click);
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 824);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(1115, 3);
            this.pnlSplitter.TabIndex = 1;
            // 
            // kpnlContent
            // 
            this.kpnlContent.Controls.Add(this.ktrkAlphaValue);
            this.kpnlContent.Controls.Add(this.kbtnSetAsBaseColour);
            this.kpnlContent.Controls.Add(this.kryptonLabel2);
            this.kpnlContent.Controls.Add(this.ktxtHexValue);
            this.kpnlContent.Controls.Add(this.klblHexValue);
            this.kpnlContent.Controls.Add(this.cbxColourPreview);
            this.kpnlContent.Controls.Add(this.cwSelectedColour);
            this.kpnlContent.Controls.Add(this.klblAlphaValue);
            this.kpnlContent.Controls.Add(this.klblRedValue);
            this.kpnlContent.Controls.Add(this.klblGreenValue);
            this.kpnlContent.Controls.Add(this.klblBlueValue);
            this.kpnlContent.Controls.Add(this.kryptonLabel10);
            this.kpnlContent.Controls.Add(this.kryptonLabel9);
            this.kpnlContent.Controls.Add(this.kryptonLabel8);
            this.kpnlContent.Controls.Add(this.kryptonLabel1);
            this.kpnlContent.Controls.Add(this.klstPaletteColours);
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(1115, 824);
            this.kpnlContent.TabIndex = 2;
            // 
            // ktrkAlphaValue
            // 
            this.ktrkAlphaValue.DrawBackground = true;
            this.ktrkAlphaValue.Location = new System.Drawing.Point(517, 12);
            this.ktrkAlphaValue.Maximum = 255;
            this.ktrkAlphaValue.Name = "ktrkAlphaValue";
            this.ktrkAlphaValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ktrkAlphaValue.Size = new System.Drawing.Size(41, 688);
            this.ktrkAlphaValue.TabIndex = 68;
            this.ktrkAlphaValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkAlphaValue.TrackBarSize = ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.ktrkAlphaValue.Value = 255;
            this.ktrkAlphaValue.ValueChanged += new System.EventHandler(this.KtrkAlphaValue_ValueChanged);
            // 
            // kbtnSetAsBaseColour
            // 
            this.kbtnSetAsBaseColour.AutoSize = true;
            this.kbtnSetAsBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnSetAsBaseColour.Enabled = false;
            this.kbtnSetAsBaseColour.Location = new System.Drawing.Point(775, 670);
            this.kbtnSetAsBaseColour.Name = "kbtnSetAsBaseColour";
            this.kbtnSetAsBaseColour.Size = new System.Drawing.Size(146, 30);
            this.kbtnSetAsBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSetAsBaseColour.TabIndex = 67;
            this.kbtnSetAsBaseColour.Values.Text = "&Set as Base Colour";
            this.kbtnSetAsBaseColour.Click += new System.EventHandler(this.KbtnSetAsBaseColour_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(78, 737);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(26, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 46;
            this.kryptonLabel2.Values.Text = "#";
            // 
            // ktxtHexValue
            // 
            this.ktxtHexValue.Hint = "FFFFFF";
            this.ktxtHexValue.Location = new System.Drawing.Point(110, 741);
            this.ktxtHexValue.MaxLength = 6;
            this.ktxtHexValue.Name = "ktxtHexValue";
            this.ktxtHexValue.Size = new System.Drawing.Size(158, 29);
            this.ktxtHexValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtHexValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtHexValue.TabIndex = 45;
            this.ktxtHexValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtHexValue.TextChanged += new System.EventHandler(this.KtxtHexValue_TextChanged);
            // 
            // klblHexValue
            // 
            this.klblHexValue.Location = new System.Drawing.Point(12, 737);
            this.klblHexValue.Name = "klblHexValue";
            this.klblHexValue.Size = new System.Drawing.Size(60, 33);
            this.klblHexValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHexValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHexValue.TabIndex = 44;
            this.klblHexValue.Values.Text = "Hex:";
            // 
            // klblAlphaValue
            // 
            this.klblAlphaValue.Location = new System.Drawing.Point(416, 740);
            this.klblAlphaValue.Name = "klblAlphaValue";
            this.klblAlphaValue.Size = new System.Drawing.Size(6, 2);
            this.klblAlphaValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAlphaValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAlphaValue.TabIndex = 41;
            this.klblAlphaValue.Values.Text = "";
            // 
            // klblRedValue
            // 
            this.klblRedValue.Location = new System.Drawing.Point(607, 740);
            this.klblRedValue.Name = "klblRedValue";
            this.klblRedValue.Size = new System.Drawing.Size(6, 2);
            this.klblRedValue.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.klblRedValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRedValue.TabIndex = 40;
            this.klblRedValue.Values.Text = "";
            // 
            // klblGreenValue
            // 
            this.klblGreenValue.Location = new System.Drawing.Point(795, 740);
            this.klblGreenValue.Name = "klblGreenValue";
            this.klblGreenValue.Size = new System.Drawing.Size(6, 2);
            this.klblGreenValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.klblGreenValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblGreenValue.TabIndex = 39;
            this.klblGreenValue.Values.Text = "";
            // 
            // klblBlueValue
            // 
            this.klblBlueValue.Location = new System.Drawing.Point(985, 740);
            this.klblBlueValue.Name = "klblBlueValue";
            this.klblBlueValue.Size = new System.Drawing.Size(6, 2);
            this.klblBlueValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.klblBlueValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBlueValue.TabIndex = 38;
            this.klblBlueValue.Values.Text = "";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(542, 740);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 37;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(709, 740);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 36;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(915, 737);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 35;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(331, 737);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 33;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // klstPaletteColours
            // 
            this.klstPaletteColours.Location = new System.Drawing.Point(12, 12);
            this.klstPaletteColours.Name = "klstPaletteColours";
            this.klstPaletteColours.Size = new System.Drawing.Size(483, 688);
            this.klstPaletteColours.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstPaletteColours.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstPaletteColours.TabIndex = 3;
            this.klstPaletteColours.SelectedIndexChanged += new System.EventHandler(this.KlstPaletteColours_SelectedIndexChanged);
            // 
            // cbxColourPreview
            // 
            this.cbxColourPreview.BackColor = System.Drawing.Color.White;
            this.cbxColourPreview.Location = new System.Drawing.Point(726, 399);
            this.cbxColourPreview.Name = "cbxColourPreview";
            this.cbxColourPreview.Size = new System.Drawing.Size(232, 230);
            this.cbxColourPreview.TabIndex = 43;
            this.cbxColourPreview.TabStop = false;
            // 
            // cwSelectedColour
            // 
            this.cwSelectedColour.BackColor = System.Drawing.Color.Transparent;
            this.cwSelectedColour.Location = new System.Drawing.Point(670, 12);
            this.cwSelectedColour.Name = "cwSelectedColour";
            this.cwSelectedColour.Size = new System.Drawing.Size(352, 362);
            this.cwSelectedColour.TabIndex = 42;
            this.cwSelectedColour.ColourChanged += new System.EventHandler(this.CwSelectedColour_ColourChanged);
            // 
            // ColourDebugConsole
            // 
            this.ClientSize = new System.Drawing.Size(1115, 893);
            this.Controls.Add(this.kpnlContent);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColourDebugConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette Debug Console - [{0}]";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).EndInit();
            this.kpnlControls.ResumeLayout(false);
            this.kpnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            this.kpnlContent.ResumeLayout(false);
            this.kpnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourPreview)).EndInit();
            this.ResumeLayout(false);

        }

        public ColourDebugConsole()
        {
            InitializeComponent();
        }

        private void KlstPaletteColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI(klstPaletteColours.GetItemText(klstPaletteColours.SelectedItem));
        }

        private void UpdateUI(string v)
        {
            cwSelectedColour.Colour = TranslationMethods.RGBStringToColour(v);

            cbxColourPreview.BackColor = TranslationMethods.RGBStringToColour(v);

            ktxtHexValue.Text = ColourHelpers.ColourToHexadecimal(cbxColourPreview.BackColor);

            klblAlphaValue.Text = cbxColourPreview.BackColor.A.ToString();

            klblRedValue.Text = cbxColourPreview.BackColor.R.ToString();

            klblGreenValue.Text = cbxColourPreview.BackColor.G.ToString();

            klblBlueValue.Text = cbxColourPreview.BackColor.B.ToString();
        }

        private void KbtnImport_Click(object sender, EventArgs e)
        {
            ImportFile();
        }

        private void ImportFile()
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a Colour Configuration File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Colour Configuration Files", ".ccf"));

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Palette Colour Configuration Files", ".kpccf"));

            cofd.Filters.Add(new CommonFileDialogFilter("Normal Text Files", ".txt"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FileUtilities.ImportContentFromFile(Path.GetFullPath(cofd.FileName), klstPaletteColours);
            }
        }

        private void KbtnClose_Click(object sender, EventArgs e)
        {

        }

        private void CwSelectedColour_ColourChanged(object sender, EventArgs e)
        {
            kbtnSetAsBaseColour.Enabled = true;
        }

        private void KtxtHexValue_TextChanged(object sender, EventArgs e)
        {
            if (!TranslationMethods.IsHexadecimal(ktxtHexValue.Text) && !string.IsNullOrWhiteSpace(ktxtHexValue.Text))
            {
                ktxtHexValue.Clear();

                ExtendedKryptonMessageBox.Show("A invalid character has been entered, please try again.", "Invalid Content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ktxtHexValue.Text.Length == 3 || ktxtHexValue.Text.Length == 6)
            {
                UpdateColour(ktxtHexValue.Text);
            }
        }

        private void UpdateColour(string text)
        {
            cwSelectedColour.Colour = ColourHelpers.ColourFromHexadecimal(text);

            cbxColourPreview.BackColor = ColourHelpers.ColourFromHexadecimal(text);
        }

        private void KtrkAlphaValue_ValueChanged(object sender, EventArgs e)
        {
            ColourHelpers.SetColourAlphaValue(cbxColourPreview.BackColor, ktrkAlphaValue.Value);

            ttInfo.SetToolTip(ktrkAlphaValue, $"Alpha Value: { ktrkAlphaValue.Value }");
        }

        private void KbtnSetAsBaseColour_Click(object sender, EventArgs e)
        {
            ColourMixerAdvanced colourMixer = new ColourMixerAdvanced(cbxColourPreview.BackColor);

            colourMixer.Show();

            kbtnSetAsBaseColour.Enabled = false;
        }
    }
}