using Common;
using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using KryptonPaletteUpgradeTool.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace KryptonPaletteUpgradeTool.UX
{
    public class MainWindow : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kryptonPanel3;
        private KryptonPanel kpSS;
        private System.Windows.Forms.StatusStrip ss;
        private KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private KryptonLabel klblPaletteStyle;
        private KryptonButton kbtnBrowseForOriginalPaletteFile;
        private KryptonRichTextBox krtbNewFile;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kptxNewPaletteFilePath;
        private KryptonButton kbtnBrowseNewPaletteFile;
        private KryptonLabel kryptonLabel1;
        private KryptonRichTextBox krtbOriginalFile;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kptxtOriginalPaletteFilePath;
        private KryptonLabel klblStatus;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private KryptonComboBox kcmbVersions;
        private KryptonLabel klblVersion;
        private KryptonButton kbtnUpgrade;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues5 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues10 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues11 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues12 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues13 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues14 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnUpgrade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmbVersions = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krtbNewFile = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kbtnBrowseNewPaletteFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krtbOriginalFile = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kbtnBrowseForOriginalPaletteFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblPaletteStyle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kpSS = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kptxNewPaletteFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kptxtOriginalPaletteFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpSS)).BeginInit();
            this.kpSS.SuspendLayout();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1461, 100);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(107, 0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(1354, 100);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.kryptonLabel2.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.kryptonLabel2.Values.Text = "Krypton Palette File Upgrade Tool";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::KryptonPaletteUpgradeTool.Properties.Resources.PU_Icon_64_x_64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnUpgrade);
            this.kryptonPanel2.Controls.Add(this.kcmbVersions);
            this.kryptonPanel2.Controls.Add(this.klblVersion);
            this.kryptonPanel2.Controls.Add(this.kbtnExport);
            this.kryptonPanel2.Controls.Add(this.krtbNewFile);
            this.kryptonPanel2.Controls.Add(this.kptxNewPaletteFilePath);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseNewPaletteFile);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.krtbOriginalFile);
            this.kryptonPanel2.Controls.Add(this.kptxtOriginalPaletteFilePath);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseForOriginalPaletteFile);
            this.kryptonPanel2.Controls.Add(this.klblPaletteStyle);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 100);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1461, 660);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kbtnUpgrade
            // 
            this.kbtnUpgrade.Enabled = false;
            this.kbtnUpgrade.Location = new System.Drawing.Point(1209, 612);
            this.kbtnUpgrade.Name = "kbtnUpgrade";
            this.kbtnUpgrade.Size = new System.Drawing.Size(117, 29);
            this.kbtnUpgrade.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUpgrade.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUpgrade.TabIndex = 24;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.kbtnUpgrade.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnUpgrade.Values.Text = "&Upgrade";
            this.kbtnUpgrade.Click += new System.EventHandler(this.kbtnUpgrade_Click);
            // 
            // kcmbVersions
            // 
            this.kcmbVersions.AutoCompleteCustomSource.AddRange(new string[] {
            "2 to 6",
            "6 to 18"});
            this.kcmbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbVersions.DropDownWidth = 172;
            this.kcmbVersions.Items.AddRange(new object[] {
            "2 to 6",
            "6 to 18"});
            this.kcmbVersions.Location = new System.Drawing.Point(150, 615);
            this.kcmbVersions.Name = "kcmbVersions";
            this.kcmbVersions.Size = new System.Drawing.Size(172, 27);
            this.kcmbVersions.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbVersions.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbVersions.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbVersions.TabIndex = 23;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.kcmbVersions.ToolTipValues.ToolTipPosition = popupPositionValues3;
            // 
            // klblVersion
            // 
            this.klblVersion.Location = new System.Drawing.Point(12, 616);
            this.klblVersion.Name = "klblVersion";
            this.klblVersion.Size = new System.Drawing.Size(132, 24);
            this.klblVersion.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblVersion.TabIndex = 22;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.klblVersion.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.klblVersion.Values.Text = "Convert Version:";
            // 
            // kbtnExport
            // 
            this.kbtnExport.Enabled = false;
            this.kbtnExport.Location = new System.Drawing.Point(1332, 612);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(117, 29);
            this.kbtnExport.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.TabIndex = 21;
            popupPositionValues5.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues5.PlacementTarget = null;
            this.kbtnExport.ToolTipValues.ToolTipPosition = popupPositionValues5;
            this.kbtnExport.Values.Text = "E&xport";
            this.kbtnExport.Click += new System.EventHandler(this.kbtnExport_Click);
            // 
            // krtbNewFile
            // 
            this.krtbNewFile.Location = new System.Drawing.Point(12, 347);
            this.krtbNewFile.Name = "krtbNewFile";
            this.krtbNewFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbNewFile.Size = new System.Drawing.Size(1437, 250);
            this.krtbNewFile.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbNewFile.TabIndex = 20;
            this.krtbNewFile.Text = "";
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.krtbNewFile.ToolTipValues.ToolTipPosition = popupPositionValues6;
            // 
            // kbtnBrowseNewPaletteFile
            // 
            this.kbtnBrowseNewPaletteFile.Location = new System.Drawing.Point(1418, 314);
            this.kbtnBrowseNewPaletteFile.Name = "kbtnBrowseNewPaletteFile";
            this.kbtnBrowseNewPaletteFile.Size = new System.Drawing.Size(31, 27);
            this.kbtnBrowseNewPaletteFile.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseNewPaletteFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseNewPaletteFile.TabIndex = 18;
            popupPositionValues7.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues7.PlacementTarget = null;
            this.kbtnBrowseNewPaletteFile.ToolTipValues.ToolTipPosition = popupPositionValues7;
            this.kbtnBrowseNewPaletteFile.Values.Text = ".&..";
            this.kbtnBrowseNewPaletteFile.Click += new System.EventHandler(this.kbtnBrowseNewPaletteFile_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 314);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(200, 24);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            popupPositionValues8.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues8.PlacementTarget = null;
            this.kryptonLabel1.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.kryptonLabel1.Values.Text = "New Palette File Location:";
            // 
            // krtbOriginalFile
            // 
            this.krtbOriginalFile.Location = new System.Drawing.Point(12, 48);
            this.krtbOriginalFile.Name = "krtbOriginalFile";
            this.krtbOriginalFile.ReadOnly = true;
            this.krtbOriginalFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbOriginalFile.Size = new System.Drawing.Size(1437, 250);
            this.krtbOriginalFile.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.krtbOriginalFile.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.krtbOriginalFile.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbOriginalFile.TabIndex = 16;
            this.krtbOriginalFile.Text = "";
            popupPositionValues9.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues9.PlacementTarget = null;
            this.krtbOriginalFile.ToolTipValues.ToolTipPosition = popupPositionValues9;
            // 
            // kbtnBrowseForOriginalPaletteFile
            // 
            this.kbtnBrowseForOriginalPaletteFile.Location = new System.Drawing.Point(1418, 18);
            this.kbtnBrowseForOriginalPaletteFile.Name = "kbtnBrowseForOriginalPaletteFile";
            this.kbtnBrowseForOriginalPaletteFile.Size = new System.Drawing.Size(31, 27);
            this.kbtnBrowseForOriginalPaletteFile.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseForOriginalPaletteFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseForOriginalPaletteFile.TabIndex = 13;
            popupPositionValues10.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues10.PlacementTarget = null;
            this.kbtnBrowseForOriginalPaletteFile.ToolTipValues.ToolTipPosition = popupPositionValues10;
            this.kbtnBrowseForOriginalPaletteFile.Values.Text = ".&..";
            this.kbtnBrowseForOriginalPaletteFile.Click += new System.EventHandler(this.kbtnBrowseForOriginalPaletteFile_Click);
            // 
            // klblPaletteStyle
            // 
            this.klblPaletteStyle.Location = new System.Drawing.Point(12, 18);
            this.klblPaletteStyle.Name = "klblPaletteStyle";
            this.klblPaletteStyle.Size = new System.Drawing.Size(225, 24);
            this.klblPaletteStyle.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblPaletteStyle.TabIndex = 5;
            popupPositionValues11.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues11.PlacementTarget = null;
            this.klblPaletteStyle.ToolTipValues.ToolTipPosition = popupPositionValues11;
            this.klblPaletteStyle.Values.Text = "Original Palette File Location:";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kbtnOk);
            this.kryptonPanel3.Controls.Add(this.klblStatus);
            this.kryptonPanel3.Controls.Add(this.kbtnCancel);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 763);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1461, 51);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(1209, 11);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(117, 29);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 14;
            popupPositionValues12.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues12.PlacementTarget = null;
            this.kbtnOk.ToolTipValues.ToolTipPosition = popupPositionValues12;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // klblStatus
            // 
            this.klblStatus.Location = new System.Drawing.Point(12, 11);
            this.klblStatus.Name = "klblStatus";
            this.klblStatus.Size = new System.Drawing.Size(6, 2);
            this.klblStatus.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblStatus.TabIndex = 13;
            popupPositionValues13.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues13.PlacementTarget = null;
            this.klblStatus.ToolTipValues.ToolTipPosition = popupPositionValues13;
            this.klblStatus.Values.Text = "";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(1332, 11);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 12;
            popupPositionValues14.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues14.PlacementTarget = null;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues14;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kpSS
            // 
            this.kpSS.Controls.Add(this.ss);
            this.kpSS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpSS.Location = new System.Drawing.Point(0, 814);
            this.kpSS.Name = "kpSS";
            this.kpSS.Size = new System.Drawing.Size(1461, 22);
            this.kpSS.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1461, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(1446, 17);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "Ready";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 760);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 3);
            this.panel1.TabIndex = 1;
            // 
            // kptxNewPaletteFilePath
            // 
            this.kptxNewPaletteFilePath.DrawPrompt = true;
            this.kptxNewPaletteFilePath.FocusSelect = true;
            this.kptxNewPaletteFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxNewPaletteFilePath.Location = new System.Drawing.Point(243, 314);
            this.kptxNewPaletteFilePath.Name = "kptxNewPaletteFilePath";
            this.kptxNewPaletteFilePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxNewPaletteFilePath.PromptText = "Enter new paette file path here...";
            this.kptxNewPaletteFilePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxNewPaletteFilePath.Size = new System.Drawing.Size(1169, 27);
            this.kptxNewPaletteFilePath.TabIndex = 19;
            // 
            // kptxtOriginalPaletteFilePath
            // 
            this.kptxtOriginalPaletteFilePath.DrawPrompt = true;
            this.kptxtOriginalPaletteFilePath.FocusSelect = true;
            this.kptxtOriginalPaletteFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtOriginalPaletteFilePath.Location = new System.Drawing.Point(243, 18);
            this.kptxtOriginalPaletteFilePath.Name = "kptxtOriginalPaletteFilePath";
            this.kptxtOriginalPaletteFilePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtOriginalPaletteFilePath.PromptText = "Enter original palette file path here...";
            this.kptxtOriginalPaletteFilePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtOriginalPaletteFilePath.Size = new System.Drawing.Size(1169, 27);
            this.kptxtOriginalPaletteFilePath.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1461, 836);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kpSS);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Palette File Upgrade Tool - [{0}]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpSS)).EndInit();
            this.kpSS.ResumeLayout(false);
            this.kpSS.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _modified = false;
        private Version _applicationVersiomn = Assembly.GetEntryAssembly().GetName().Version;
        private Timer _uiUpdateTimer, _detectModification;
        private const int MINIMUM_VERSION_NUMBER = 2, MAXIMUM_VERSION_NUMBER = 17;
        private int _inputVersionNumber;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether [detect modification].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [detect modification]; otherwise, <c>false</c>.
        /// </value>
        public bool DetectModification { get => _modified; set => _modified = value; }

        public int InputVersionNumber { get => _inputVersionNumber; set => _inputVersionNumber = value; }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            _uiUpdateTimer = new Timer();

            _uiUpdateTimer.Interval = 2000;

            _uiUpdateTimer.Enabled = true;

            _uiUpdateTimer.Tick += UIUpdateTimer_Tick;

            _detectModification = new Timer();

            _detectModification.Interval = 250;

            _detectModification.Enabled = true;

            _detectModification.Tick += DetectModification_Tick;
        }
        #endregion

        #region Event Handlers        
        /// <summary>
        /// Handles the Load event of the MainWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateTitle();

            TextExtra = $"(Version: { _applicationVersiomn.ToString() })";

            EnableUpgradeUI(false);

            UpdateStatus(Status.READY);
        }

        /// <summary>
        /// Handles the Click event of the kbtnBrowseForOriginalPaletteFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnBrowseForOriginalPaletteFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Browse for Palette File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Palette Files", ".xml"));

            cofd.InitialDirectory = Path.GetFullPath(Environment.SpecialFolder.MyDocuments.ToString());

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtOriginalPaletteFilePath.Text = Path.GetFullPath(cofd.FileName);

                UpdateTitle(false, kptxtOriginalPaletteFilePath.Text);

                ParseFile(kptxtOriginalPaletteFilePath.Text, krtbOriginalFile);
            }
            else
            {
                return;
            }

            kptxNewPaletteFilePath.Text = Path.GetDirectoryName(cofd.FileName) + "\\" + Path.GetFileNameWithoutExtension(cofd.FileName) + "_New.xml";

            UpdateStatus(Status.OPENFILE, Path.GetFullPath(cofd.FileName));

            EnableUpgradeUI(true);

            _uiUpdateTimer.Start();
        }

        /// <summary>
        /// Handles the Click event of the kbtnBrowseNewPaletteFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnBrowseNewPaletteFile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the kbtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the kbtnExport control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnExport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the kbtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the FormClosing event of the MainWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _detectModification.Tick -= DetectModification_Tick;

            _uiUpdateTimer.Tick -= UIUpdateTimer_Tick;
        }

        /// <summary>
        /// Handles the Click event of the kbtnUpgrade control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnUpgrade_Click(object sender, EventArgs e)
        {
            if (kcmbVersions.Text == string.Empty)
            {
                ExtendedKryptonMessageBox.Show("No upgrade version has been selected.\nPlease select a version to upgrade to\nand try again.", "No Version Has Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Information, messageboxTypeface: new Font("Segoe UI", 12f));
            }
            else if (kcmbVersions.Text == "2 to 6")
            {
                UpgradePalette(VersionType.VERSION2TO6);
            }
            else if (kcmbVersions.Text == "6 to 18")
            {
                UpgradePalette(VersionType.VERSION6TO18);
            }
        }

        /// <summary>
        /// Handles the Tick event of the UIUpdateTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UIUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus(Status.READY);

            _uiUpdateTimer.Stop();
        }

        /// <summary>
        /// Handles the Tick event of the DetectModification control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DetectModification_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods                
        /// <summary>
        /// Updates the title.
        /// </summary>
        /// <param name="modified">if set to <c>true</c> [modified].</param>
        /// <param name="text">The text.</param>
        private void UpdateTitle(bool modified = false, string text = "")
        {
            if (text != "")
            {
                Text = $"Krypton Palette File Upgrade Tool - [{ text }]";
            }
            else
            {
                Text = "Krypton Palette File Upgrade Tool";
            }
        }

        /// <summary>
        /// Parses the specified file.
        /// </summary>
        /// <param name="themeFilePath">The theme file path.</param>
        /// <param name="output">The output.</param>
        private void ParseFile(string themeFilePath, KryptonRichTextBox output)
        {
            try
            {
                // Do some checking first
                if (!File.Exists(themeFilePath))
                {
                    ExtendedKryptonMessageBox.Show($"Cannot locate: '{ Path.GetFullPath(themeFilePath) }'!\nPlease verify that the file is there before proceeding.", "Cannot Find File", MessageBoxButtons.OK, MessageBoxIcon.Error, messageboxTypeface: new Font("Segoe UI", 12f));
                }
                else
                {
                    // Read from file
                    StreamReader reader = new StreamReader(themeFilePath);

                    // Load into KryptonRichTextBox
                    //output.LoadFile(themeFilePath);
                    output.WordWrap = true;
                    output.Text = reader.ReadToEnd();

                    // Tidy up after ourselves
                    reader.Close();

                    reader.Dispose();
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        /// <summary>
        /// Upgrades the palette.
        /// </summary>
        /// <param name="versionType">Type of the version.</param>
        private void UpgradePalette(VersionType versionType)
        {
            switch (versionType)
            {
                case VersionType.CONVERSIONINPROGRESS:
                    klblStatus.Text = "Converting file; please wait...";

                    UpdateStatusTextColour(StatusTextColour.AMBER);
                    break;
                case VersionType.VERSION2TO6:
                    break;
                case VersionType.VERSION6TO18:
                    try
                    {
                        SetDetectModification(true);

                        XslCompiledTransform xslCompiledTransform1 = new XslCompiledTransform(), xslCompiledTransform2 = new XslCompiledTransform();

                        xslCompiledTransform1.Load(new XmlTextReader(Resources.Version2To6));

                        xslCompiledTransform2.Load(new XmlTextReader(Resources.Version6To18));

                        StreamReader reader = new StreamReader(krtbOriginalFile.Text);

                        string end = reader.ReadToEnd();

                        reader.Close();

                        if (GetInputVersionNumber() < 6)
                        {
                            end = TransformXML(xslCompiledTransform1, end);
                        }
                        else
                        {
                            end = TransformXML(xslCompiledTransform2, end);
                        }

                        StreamWriter writer = new StreamWriter(krtbNewFile.Text);

                        writer.WriteLine("<?xml version=\"1.0\"?>");

                        writer.Write(end);

                        writer.Flush();

                        writer.Close();

                        object[] text = new object[] { "Input file: ", krtbOriginalFile.Text, "\nOutput file: ", krtbNewFile.Text, "\n\nUpgrade from version '", _inputVersionNumber, "' to version '", 18.ToString(), "' has succeeded." };

                        ExtendedKryptonMessageBox.Show(string.Concat(text), "Upgrade Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc2)
                    {
                        ExceptionHandler.CaptureException(exc2);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="text">The text.</param>
        private void UpdateStatus(ToolStripLabel statusLabel, string text)
        {
            tsslStatus.Text = text;
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <param name="extraText">The extra text.</param>
        private void UpdateStatus(Status status, string extraText = "")
        {
            switch (status)
            {
                case Status.READY:
                    UpdateStatus(tsslStatus, "Ready");
                    break;
                case Status.OPENFILE:
                    UpdateStatus(tsslStatus, $"Opening file: '{ extraText }'");
                    break;
                case Status.CONVERTINGINPROGRESS:
                    UpdateStatus(tsslStatus, $"Conversion of palette file: '{ extraText }' is in progress...");
                    break;
                case Status.CONVERSIONSUCCEDED:
                    UpdateStatus(tsslStatus, $"Conversion of palette file: '{ extraText }' was successful!");
                    break;
                case Status.CONVERSIONFAILED:
                    UpdateStatus(tsslStatus, $"Conversion of palette file: '{ extraText }' failed!");
                    break;
                case Status.FILENOTFOUND:
                    UpdateStatus(tsslStatus, $"Cannot find file: '{ extraText }'");
                    break;
                case Status.OVERWRITE:
                    UpdateStatus(tsslStatus, $"Overwriting file: '{ extraText }'");
                    break;
                case Status.OVERWRITESUCCEDED:
                    UpdateStatus(tsslStatus, $"File overwrite: '{ extraText }' was successful!");
                    break;
                case Status.OVERWRITEFAILED:
                    UpdateStatus(tsslStatus, $"File overwrite: '{ extraText }' failed!");
                    break;
                case Status.SAVEFILE:
                    UpdateStatus(tsslStatus, $"Saving file: '{ extraText }'");
                    break;
                case Status.SAVEFILESUCCEDED:
                    UpdateStatus(tsslStatus, $"The file: '{ extraText }' was saved!");
                    break;
                case Status.SAVEFILEFAILED:
                    UpdateStatus(tsslStatus, $"The file: '{ extraText }' failed to save!");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates the status text colour.
        /// </summary>
        /// <param name="colour">The colour.</param>
        private void UpdateStatusTextColour(StatusTextColour colour)
        {
            switch (colour)
            {
                case StatusTextColour.NONE:
                    klblStatus.StateCommon.LongText.Color1 = Color.Empty;

                    klblStatus.StateCommon.ShortText.Color1 = Color.Empty;
                    break;
                case StatusTextColour.GREEN:
                    klblStatus.StateCommon.LongText.Color1 = Color.Green;

                    klblStatus.StateCommon.ShortText.Color1 = Color.Green;
                    break;
                case StatusTextColour.RED:
                    klblStatus.StateCommon.LongText.Color1 = Color.Red;

                    klblStatus.StateCommon.ShortText.Color1 = Color.Red;
                    break;
                case StatusTextColour.AMBER:
                    klblStatus.StateCommon.LongText.Color1 = ColorTranslator.FromHtml("#FFBF00");

                    klblStatus.StateCommon.ShortText.Color1 = ColorTranslator.FromHtml("#FFBF00");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Transforms the XML.
        /// </summary>
        /// <param name="transform">The transform.</param>
        /// <param name="xmlContent">Content of the XML.</param>
        /// <returns></returns>
        private string TransformXML(XslCompiledTransform transform, string xmlContent)
        {
            StringReader reader = new StringReader(xmlContent);

            StringWriter writer = new StringWriter();

            XmlTextReader xmlTextReader = new XmlTextReader(reader);

            XmlTextWriter xmlTextWriter = new XmlTextWriter(writer) { Formatting = Formatting.Indented, Indentation = 4 };

            transform.Transform(xmlTextReader, xmlTextWriter);

            return writer.ToString();
        }

        /// <summary>
        /// Enables the upgrade UI.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private void EnableUpgradeUI(bool enabled)
        {
            klblVersion.Enabled = enabled;

            kcmbVersions.Enabled = enabled;

            kbtnUpgrade.Enabled = enabled;
        }
        #endregion

        #region Enumerations
        private enum VersionType
        {
            CONVERSIONINPROGRESS = 0,
            VERSION2TO6 = 1,
            VERSION6TO18 = 2
        }

        private enum Status
        {
            READY,
            OPENFILE,
            CONVERTINGINPROGRESS,
            CONVERSIONSUCCEDED,
            CONVERSIONFAILED,
            FILENOTFOUND,
            OVERWRITE,
            OVERWRITESUCCEDED,
            OVERWRITEFAILED,
            SAVEFILE,
            SAVEFILESUCCEDED,
            SAVEFILEFAILED
        }

        private enum StatusTextColour
        {
            NONE = 0,
            GREEN = 1,
            RED = 2,
            AMBER = 3
        }
        #endregion

        #region Setters and Getters        
        /// <summary>
        /// Sets the detect modification.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        private void SetDetectModification(bool value)
        {
            DetectModification = value;
        }

        /// <summary>
        /// Gets the detect modification.
        /// </summary>
        /// <returns></returns>
        private bool GetDetectModification()
        {
            return DetectModification;
        }

        /// <summary>
        /// Sets the InputVersionNumber to the value of value.
        /// </summary>
        /// <param name="value">The desired value of InputVersionNumber.</param>
        private void SetInputVersionNumber(int value)
        {
            InputVersionNumber = value;
        }

        /// <summary>
        /// Returns the value of the InputVersionNumber.
        /// </summary>
        /// <returns>The value of the InputVersionNumber.</returns>
        private int GetInputVersionNumber()
        {
            return InputVersionNumber;
        }
        #endregion
    }
}