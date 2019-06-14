using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using PaletteExplorer.Classes;
using PaletteExplorer.Enumerations;
using System;
using System.IO;

namespace PaletteExplorer.UX
{
    public class PaletteColourExporter : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnClose;
        private KryptonLabel lblColourOutput;
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnExport;
        private KryptonButton kbtnBrowse;
        private KryptonTextBox ktxtConfigurationPath;
        private KryptonLabel kryptonLabel2;
        private KryptonComboBox kcmbConfigurationType;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtConfigurationPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbConfigurationType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbConfigurationType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnExport);
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 130);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(684, 54);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // kbtnExport
            // 
            this.kbtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnExport.AutoSize = true;
            this.kbtnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExport.Enabled = false;
            this.kbtnExport.Location = new System.Drawing.Point(557, 12);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(58, 30);
            this.kbtnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.TabIndex = 65;
            this.kbtnExport.Values.Text = "E&xport";
            this.kbtnExport.Click += new System.EventHandler(this.KbtnExport_Click);
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(621, 12);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 64;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(12, 13);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(6, 2);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 63;
            this.lblColourOutput.Values.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 3);
            this.panel1.TabIndex = 6;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.ktxtConfigurationPath);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kcmbConfigurationType);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(684, 127);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowse.AutoSize = true;
            this.kbtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnBrowse.Location = new System.Drawing.Point(648, 72);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(23, 30);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 65;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.KbtnBrowse_Click);
            // 
            // ktxtConfigurationPath
            // 
            this.ktxtConfigurationPath.Location = new System.Drawing.Point(187, 73);
            this.ktxtConfigurationPath.Name = "ktxtConfigurationPath";
            this.ktxtConfigurationPath.Size = new System.Drawing.Size(455, 29);
            this.ktxtConfigurationPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtConfigurationPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtConfigurationPath.TabIndex = 3;
            this.ktxtConfigurationPath.TextChanged += new System.EventHandler(this.KtxtConfigurationPath_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 73);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(164, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Configuration Path:";
            // 
            // kcmbConfigurationType
            // 
            this.kcmbConfigurationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbConfigurationType.DropDownWidth = 484;
            this.kcmbConfigurationType.Location = new System.Drawing.Point(187, 13);
            this.kcmbConfigurationType.Name = "kcmbConfigurationType";
            this.kcmbConfigurationType.Size = new System.Drawing.Size(484, 27);
            this.kcmbConfigurationType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbConfigurationType.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbConfigurationType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbConfigurationType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbConfigurationType.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(167, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Configuration Type:";
            // 
            // PaletteColourExporter
            // 
            this.ClientSize = new System.Drawing.Size(684, 184);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Name = "PaletteColourExporter";
            this.Load += new System.EventHandler(this.PaletteColourExporter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbConfigurationType)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string[] _configurationTypes = { "All Colours", "Basic Colours", "Custom Colours", "Custom Text Colours", "Link Text Colours", "Miscellaneous Colours", "Standard Control Text Colours", "Text Colours" };
        #endregion

        public PaletteColourExporter()
        {
            InitializeComponent();
        }

        private void PaletteColourExporter_Load(object sender, EventArgs e)
        {
            foreach (string item in _configurationTypes)
            {
                kcmbConfigurationType.Items.Add(item);
            }
        }

        private void KbtnExport_Click(object sender, EventArgs e)
        {
            if (kcmbConfigurationType.Text == "All Colours")
            {
                ColourConfigurationFileManager.SaveColourConfigurationFile(ColourSettingsType.ALLCOLOURSETTINGS, ktxtConfigurationPath.Text);
            }
            else if (kcmbConfigurationType.Text == "Basic Colours")
            {
                ColourConfigurationFileManager.SaveColourConfigurationFile(ColourSettingsType.BASICCOLOURSETTINGS, ktxtConfigurationPath.Text);
            }
            else if (kcmbConfigurationType.Text == "Custom Colours")
            {
                ColourConfigurationFileManager.SaveColourConfigurationFile(ColourSettingsType.CUSTOMCOLOURSETTINGS, ktxtConfigurationPath.Text);
            }
            else if (kcmbConfigurationType.Text == "Custom Text Colours")
            {
                ColourConfigurationFileManager.SaveColourConfigurationFile(ColourSettingsType.CUSTOMTEXTCOLOURSETTINGS, ktxtConfigurationPath.Text);
            }
        }

        private void KbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.Title = "Select Where to Save Your Configuation Files:";

            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtConfigurationPath.Text = Path.GetFullPath(dialog.FileName);
            }
        }

        private void KtxtConfigurationPath_TextChanged(object sender, EventArgs e)
        {
            if (ktxtConfigurationPath.Text.Length > 0)
            {
                kbtnExport.Enabled = true;
            }
            else
            {
                kbtnExport.Enabled = false;
            }
        }
    }
}