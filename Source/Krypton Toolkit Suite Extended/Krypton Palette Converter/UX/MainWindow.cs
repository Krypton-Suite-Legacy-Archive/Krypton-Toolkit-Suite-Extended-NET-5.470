using ComponentFactory.Krypton.Toolkit;
using Core;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
        private KryptonLabel kryptonLabel3;
        private KryptonButton kbtnUpgrade;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
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
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krtbNewFile = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kptxNewPaletteFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kbtnBrowseNewPaletteFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.krtbOriginalFile = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kptxtOriginalPaletteFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
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
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbVersions = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kbtnUpgrade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpSS)).BeginInit();
            this.kpSS.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbVersions)).BeginInit();
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
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
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
            this.krtbOriginalFile.StateCommon.Content.Color1 = System.Drawing.SystemColors.Control;
            this.krtbOriginalFile.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbOriginalFile.TabIndex = 16;
            this.krtbOriginalFile.Text = "";
            popupPositionValues9.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues9.PlacementTarget = null;
            this.krtbOriginalFile.ToolTipValues.ToolTipPosition = popupPositionValues9;
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
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslStatus.Text = "Ready";
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
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 616);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(132, 24);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 22;
            popupPositionValues4.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues4.PlacementTarget = null;
            this.kryptonLabel3.ToolTipValues.ToolTipPosition = popupPositionValues4;
            this.kryptonLabel3.Values.Text = "Convert Version:";
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpSS)).EndInit();
            this.kpSS.ResumeLayout(false);
            this.kpSS.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbVersions)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        Version _applicationVersiomn = Assembly.GetEntryAssembly().GetName().Version;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateTitle();

            TextExtra = $"(Version: { _applicationVersiomn.ToString() })";
        }

        private void kbtnBrowseForOriginalPaletteFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Browse for Palette File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Palette Files", ".xml"));

            cofd.InitialDirectory = Path.GetFullPath(Environment.SpecialFolder.MyDocuments.ToString());

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtOriginalPaletteFilePath.Text = Path.GetFullPath(cofd.FileName);

                UpdateTitle(kptxtOriginalPaletteFilePath.Text);

                ParseFile(kptxtOriginalPaletteFilePath.Text, krtbOriginalFile);
            }

            kptxNewPaletteFilePath.Text = Path.GetFileNameWithoutExtension(cofd.FileName) + "_New.xml";
        }

        private void kbtnBrowseNewPaletteFile_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {

        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region Methods
        private void UpdateTitle(string text = "")
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
                    // StreamReader reader = new StreamReader(themeFilePath);

                    // Load into KryptonRichTextBox
                    output.LoadFile(themeFilePath);
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }
        #endregion
    }
}