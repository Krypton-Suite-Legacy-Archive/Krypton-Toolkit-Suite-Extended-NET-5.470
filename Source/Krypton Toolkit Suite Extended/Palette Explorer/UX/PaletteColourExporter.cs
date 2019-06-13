using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteExplorer.UX
{
    public class PaletteColourExporter : KryptonForm
    {
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnClose;
        private KryptonLabel lblColourOutput;
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnExport;
        private KryptonButton kbtnBrowse;
        private KryptonTextBox kryptonTextBox1;
        private KryptonLabel kryptonLabel2;
        private KryptonComboBox kryptonComboBox1;
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
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
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(684, 127);
            this.kryptonPanel1.TabIndex = 7;
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
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 484;
            this.kryptonComboBox1.Location = new System.Drawing.Point(187, 13);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(484, 27);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 1;
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(187, 73);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(455, 29);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonTextBox1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public PaletteColourExporter()
        {
            InitializeComponent();
        }

        private void PaletteColourExporter_Load(object sender, EventArgs e)
        {

        }
    }
}