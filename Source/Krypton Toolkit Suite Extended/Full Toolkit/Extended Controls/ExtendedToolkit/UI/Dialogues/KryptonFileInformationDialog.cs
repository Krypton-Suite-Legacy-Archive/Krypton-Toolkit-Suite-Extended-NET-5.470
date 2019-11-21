#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using ExtendedControls.Base.Code.IO;
using ExtendedControls.Base.Code.Security;
using ExtendedControls.Base.Code.Windows;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ToolkitSettings.Classes.Global;

namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    /// <summary>
    /// Displays the properties of a file or directory.
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public class KryptonFileInformationDialog : KryptonForm
    {
        #region Designer Code
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private KryptonGroupBox kryptonGroupBox2;
        private KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.PictureBox pbxFileIcon;
        private KryptonTextBox ktbFileName;
        private KryptonLabel klblAccessed;
        private KryptonLabel klblModified;
        private KryptonLabel klblCreated;
        private System.Windows.Forms.Panel panel3;
        private KryptonLabel klblSizeOnDisk;
        private KryptonLabel klblFileSize;
        private KryptonLabel klblFileLocation;
        private System.Windows.Forms.Panel panel2;
        private KryptonLabel klblFileType;
        private System.Windows.Forms.Panel panel1;
        private KryptonComboBox kcmbHashType1;
        private KryptonLabel klblTotalFiles;
        private KryptonLabel klblRealFileHash;
        private KryptonButton kbtnValidate;
        private KryptonTextBox ktxtValidate;
        private KryptonComboBox kcmbValidatedHashType;
        private KryptonLabel kryptonLabel9;
        private KryptonButton kbtnCalculateFileHash;
        private System.ComponentModel.BackgroundWorker bgwMD5;
        private System.ComponentModel.BackgroundWorker bgwSHA1;
        private System.ComponentModel.BackgroundWorker bgwSHA256;
        private System.ComponentModel.BackgroundWorker bgwSHA384;
        private System.ComponentModel.BackgroundWorker bgwSHA512;
        private System.ComponentModel.BackgroundWorker bgwRIPEMD160;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpFileAttributes;
        private KryptonGroupBox kryptonGroupBox3;
        private KryptonCheckBox kcbCompressed;
        private KryptonCheckBox kcbDevice;
        private KryptonCheckBox kcbDirectory;
        private KryptonCheckBox kcbEncrypted;
        private KryptonCheckBox kcbArchive;
        private KryptonCheckBox kcbTemporary;
        private KryptonCheckBox kcbSystem;
        private KryptonCheckBox kcbSparseFile;
        private KryptonCheckBox kcbReparsePoint;
        private KryptonCheckBox kcbReadOnly;
        private KryptonCheckBox kcbOffline;
        private KryptonCheckBox kcbIntegrityStream;
        private KryptonCheckBox kcbNormal;
        private KryptonCheckBox kcbNoScrubData;
        private KryptonCheckBox kcbNotContextIndexed;
        private KryptonCheckBox kcbHidden;
        private KryptonButton kbtnClearAllFileAttributes;
        private KryptonButton kryptonButton1;
        private ContextMenuStrip ctxHashMenu;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private KryptonButton kbtnGetFileAttributes;
        private KryptonButton kbtnImportHash;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileInformationDialog));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.klblAccessed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblModified = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCreated = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.klblSizeOnDisk = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileSize = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFileLocation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.klblFileType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ktbFileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pbxFileIcon = new System.Windows.Forms.PictureBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnImportHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnValidate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtValidate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ctxHashMenu = new System.Windows.Forms.ContextMenuStrip();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kcmbValidatedHashType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnCalculateFileHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblRealFileHash = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcmbHashType1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.klblTotalFiles = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpFileAttributes = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kbtnGetFileAttributes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnClearAllFileAttributes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kcbTemporary = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbSystem = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbSparseFile = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbReparsePoint = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbReadOnly = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbOffline = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbIntegrityStream = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbNormal = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbNoScrubData = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbNotContextIndexed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbHidden = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbCompressed = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbDevice = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbDirectory = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbEncrypted = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kcbArchive = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.bgwMD5 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA1 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA384 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA512 = new System.ComponentModel.BackgroundWorker();
            this.bgwRIPEMD160 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.ctxHashMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbValidatedHashType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbHashType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpFileAttributes)).BeginInit();
            this.kpFileAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 694);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(716, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(511, 9);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(70, 29);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnOk.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnOk.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnOk.TabIndex = 15;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(587, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.TabIndex = 14;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 693);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(716, 1);
            this.pnlSplitter.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(716, 693);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.NextPrevious;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Location = new System.Drawing.Point(12, 12);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2,
            this.kpFileAttributes});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(692, 675);
            this.kryptonNavigator1.StateCommon.Tab.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.klblAccessed);
            this.kryptonPage1.Controls.Add(this.klblModified);
            this.kryptonPage1.Controls.Add(this.klblCreated);
            this.kryptonPage1.Controls.Add(this.panel3);
            this.kryptonPage1.Controls.Add(this.klblSizeOnDisk);
            this.kryptonPage1.Controls.Add(this.klblFileSize);
            this.kryptonPage1.Controls.Add(this.klblFileLocation);
            this.kryptonPage1.Controls.Add(this.panel2);
            this.kryptonPage1.Controls.Add(this.klblFileType);
            this.kryptonPage1.Controls.Add(this.panel1);
            this.kryptonPage1.Controls.Add(this.ktbFileName);
            this.kryptonPage1.Controls.Add(this.pbxFileIcon);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(690, 644);
            this.kryptonPage1.Text = "General";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "c8e6d019e3df414d87a48f82aaa4b1e9";
            // 
            // klblAccessed
            // 
            this.klblAccessed.Location = new System.Drawing.Point(20, 461);
            this.klblAccessed.Name = "klblAccessed";
            this.klblAccessed.Size = new System.Drawing.Size(99, 24);
            this.klblAccessed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAccessed.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblAccessed.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblAccessed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblAccessed.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblAccessed.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblAccessed.TabIndex = 10;
            this.klblAccessed.Values.Text = "Accessed: {0}";
            // 
            // klblModified
            // 
            this.klblModified.Location = new System.Drawing.Point(20, 410);
            this.klblModified.Name = "klblModified";
            this.klblModified.Size = new System.Drawing.Size(98, 24);
            this.klblModified.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblModified.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblModified.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblModified.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblModified.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblModified.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblModified.TabIndex = 9;
            this.klblModified.Values.Text = "Modified: {0}";
            // 
            // klblCreated
            // 
            this.klblCreated.Location = new System.Drawing.Point(20, 359);
            this.klblCreated.Name = "klblCreated";
            this.klblCreated.Size = new System.Drawing.Size(90, 24);
            this.klblCreated.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCreated.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblCreated.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblCreated.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCreated.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblCreated.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblCreated.TabIndex = 8;
            this.klblCreated.Values.Text = "Created: {0}";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(20, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 1);
            this.panel3.TabIndex = 5;
            // 
            // klblSizeOnDisk
            // 
            this.klblSizeOnDisk.Location = new System.Drawing.Point(20, 284);
            this.klblSizeOnDisk.Name = "klblSizeOnDisk";
            this.klblSizeOnDisk.Size = new System.Drawing.Size(117, 24);
            this.klblSizeOnDisk.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSizeOnDisk.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblSizeOnDisk.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblSizeOnDisk.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSizeOnDisk.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblSizeOnDisk.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblSizeOnDisk.TabIndex = 7;
            this.klblSizeOnDisk.Values.Text = "Size on disk: {0}";
            // 
            // klblFileSize
            // 
            this.klblFileSize.Location = new System.Drawing.Point(20, 233);
            this.klblFileSize.Name = "klblFileSize";
            this.klblFileSize.Size = new System.Drawing.Size(64, 24);
            this.klblFileSize.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileSize.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileSize.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileSize.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileSize.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileSize.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileSize.TabIndex = 6;
            this.klblFileSize.Values.Text = "Size: {0}";
            // 
            // klblFileLocation
            // 
            this.klblFileLocation.Location = new System.Drawing.Point(20, 182);
            this.klblFileLocation.Name = "klblFileLocation";
            this.klblFileLocation.Size = new System.Drawing.Size(95, 24);
            this.klblFileLocation.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileLocation.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileLocation.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileLocation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileLocation.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileLocation.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileLocation.TabIndex = 5;
            this.klblFileLocation.Values.Text = "Location: {0}";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(20, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 1);
            this.panel2.TabIndex = 4;
            // 
            // klblFileType
            // 
            this.klblFileType.Location = new System.Drawing.Point(20, 107);
            this.klblFileType.Name = "klblFileType";
            this.klblFileType.Size = new System.Drawing.Size(112, 24);
            this.klblFileType.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileType.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileType.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileType.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFileType.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblFileType.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblFileType.TabIndex = 3;
            this.klblFileType.Values.Text = "Type of file: {0}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 1);
            this.panel1.TabIndex = 2;
            // 
            // ktbFileName
            // 
            this.ktbFileName.Hint = "Filename.*.*";
            this.ktbFileName.Location = new System.Drawing.Point(91, 31);
            this.ktbFileName.Name = "ktbFileName";
            this.ktbFileName.Size = new System.Drawing.Size(580, 27);
            this.ktbFileName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbFileName.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbFileName.TabIndex = 1;
            // 
            // pbxFileIcon
            // 
            this.pbxFileIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxFileIcon.Location = new System.Drawing.Point(20, 14);
            this.pbxFileIcon.Name = "pbxFileIcon";
            this.pbxFileIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFileIcon.TabIndex = 0;
            this.pbxFileIcon.TabStop = false;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPage2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(690, 644);
            this.kryptonPage2.Text = "Checksums";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "fa8152ff43634150b3dc299a9631bdfc";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(20, 274);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnImportHash);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnValidate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ktxtValidate);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kcmbValidatedHashType);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(651, 221);
            this.kryptonGroupBox2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox2.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "Validate Checksum";
            // 
            // kbtnImportHash
            // 
            this.kbtnImportHash.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnImportHash.Location = new System.Drawing.Point(328, 156);
            this.kbtnImportHash.Name = "kbtnImportHash";
            this.kbtnImportHash.Size = new System.Drawing.Size(139, 29);
            this.kbtnImportHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImportHash.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnImportHash.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnImportHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImportHash.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnImportHash.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnImportHash.TabIndex = 15;
            this.kbtnImportHash.Values.Text = "&Import Hash";
            this.kbtnImportHash.Click += new System.EventHandler(this.KbtnImportHash_Click);
            // 
            // kbtnValidate
            // 
            this.kbtnValidate.Enabled = false;
            this.kbtnValidate.Location = new System.Drawing.Point(473, 156);
            this.kbtnValidate.Name = "kbtnValidate";
            this.kbtnValidate.Size = new System.Drawing.Size(156, 29);
            this.kbtnValidate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidate.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnValidate.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnValidate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidate.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnValidate.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnValidate.TabIndex = 10;
            this.kbtnValidate.Values.Text = "&Validate";
            this.kbtnValidate.Click += new System.EventHandler(this.KbtnValidate_Click);
            // 
            // ktxtValidate
            // 
            this.ktxtValidate.ContextMenuStrip = this.ctxHashMenu;
            this.ktxtValidate.Location = new System.Drawing.Point(15, 81);
            this.ktxtValidate.Name = "ktxtValidate";
            this.ktxtValidate.Size = new System.Drawing.Size(614, 35);
            this.ktxtValidate.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtValidate.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtValidate.TabIndex = 9;
            this.ktxtValidate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtValidate.TextChanged += new System.EventHandler(this.KtxtValidate_TextChanged);
            // 
            // ctxHashMenu
            // 
            this.ctxHashMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxHashMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.copyToolStripMenuItem,
            this.toolStripMenuItem2,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.selectAllToolStripMenuItem});
            this.ctxHashMenu.Name = "ctxHashMenu";
            this.ctxHashMenu.Size = new System.Drawing.Size(123, 110);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // kcmbValidatedHashType
            // 
            this.kcmbValidatedHashType.DropDownWidth = 220;
            this.kcmbValidatedHashType.IntegralHeight = false;
            this.kcmbValidatedHashType.Location = new System.Drawing.Point(109, 29);
            this.kcmbValidatedHashType.Name = "kcmbValidatedHashType";
            this.kcmbValidatedHashType.Size = new System.Drawing.Size(132, 25);
            this.kcmbValidatedHashType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbValidatedHashType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.StateCommon.Item.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmbValidatedHashType.StateCommon.Item.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcmbValidatedHashType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbValidatedHashType.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmbValidatedHashType.StateCommon.Item.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcmbValidatedHashType.TabIndex = 8;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(15, 29);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(88, 24);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel9.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel9.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel9.TabIndex = 7;
            this.kryptonLabel9.Values.Text = "Hash Type:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 14);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCalculateFileHash);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblRealFileHash);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcmbHashType1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblTotalFiles);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(651, 221);
            this.kryptonGroupBox1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Calculate Checksum";
            // 
            // kbtnCalculateFileHash
            // 
            this.kbtnCalculateFileHash.Enabled = false;
            this.kbtnCalculateFileHash.Location = new System.Drawing.Point(473, 151);
            this.kbtnCalculateFileHash.Name = "kbtnCalculateFileHash";
            this.kbtnCalculateFileHash.Size = new System.Drawing.Size(156, 29);
            this.kbtnCalculateFileHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCalculateFileHash.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCalculateFileHash.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCalculateFileHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCalculateFileHash.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCalculateFileHash.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCalculateFileHash.TabIndex = 9;
            this.kbtnCalculateFileHash.Values.Text = "Calculat&e";
            this.kbtnCalculateFileHash.Click += new System.EventHandler(this.KbtnCalculateFileHash_Click);
            // 
            // klblRealFileHash
            // 
            this.klblRealFileHash.AutoSize = false;
            this.klblRealFileHash.Location = new System.Drawing.Point(15, 84);
            this.klblRealFileHash.Name = "klblRealFileHash";
            this.klblRealFileHash.Size = new System.Drawing.Size(614, 52);
            this.klblRealFileHash.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRealFileHash.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblRealFileHash.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblRealFileHash.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRealFileHash.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblRealFileHash.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblRealFileHash.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblRealFileHash.TabIndex = 7;
            this.klblRealFileHash.Values.Text = "";
            // 
            // kcmbHashType1
            // 
            this.kcmbHashType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbHashType1.DropDownWidth = 220;
            this.kcmbHashType1.IntegralHeight = false;
            this.kcmbHashType1.Location = new System.Drawing.Point(109, 19);
            this.kcmbHashType1.Name = "kcmbHashType1";
            this.kcmbHashType1.Size = new System.Drawing.Size(132, 25);
            this.kcmbHashType1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbHashType1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.StateCommon.Item.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmbHashType1.StateCommon.Item.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcmbHashType1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbHashType1.StateCommon.Item.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcmbHashType1.StateCommon.Item.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcmbHashType1.TabIndex = 6;
            this.kcmbHashType1.SelectedIndexChanged += new System.EventHandler(this.KcmbHashType1_SelectedIndexChanged);
            // 
            // klblTotalFiles
            // 
            this.klblTotalFiles.Location = new System.Drawing.Point(15, 19);
            this.klblTotalFiles.Name = "klblTotalFiles";
            this.klblTotalFiles.Size = new System.Drawing.Size(88, 24);
            this.klblTotalFiles.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblTotalFiles.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblTotalFiles.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblTotalFiles.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblTotalFiles.TabIndex = 5;
            this.klblTotalFiles.Values.Text = "Hash Type:";
            // 
            // kpFileAttributes
            // 
            this.kpFileAttributes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpFileAttributes.Controls.Add(this.kbtnGetFileAttributes);
            this.kpFileAttributes.Controls.Add(this.kryptonButton1);
            this.kpFileAttributes.Controls.Add(this.kbtnClearAllFileAttributes);
            this.kpFileAttributes.Controls.Add(this.kryptonGroupBox3);
            this.kpFileAttributes.Flags = 65534;
            this.kpFileAttributes.LastVisibleSet = true;
            this.kpFileAttributes.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpFileAttributes.Name = "kpFileAttributes";
            this.kpFileAttributes.Size = new System.Drawing.Size(690, 644);
            this.kpFileAttributes.Text = "File Attributes";
            this.kpFileAttributes.ToolTipTitle = "Page ToolTip";
            this.kpFileAttributes.UniqueName = "50a26aabd19c4b24a5d601dc8c8dcced";
            this.kpFileAttributes.Visible = false;
            // 
            // kbtnGetFileAttributes
            // 
            this.kbtnGetFileAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnGetFileAttributes.Location = new System.Drawing.Point(65, 274);
            this.kbtnGetFileAttributes.Name = "kbtnGetFileAttributes";
            this.kbtnGetFileAttributes.Size = new System.Drawing.Size(198, 29);
            this.kbtnGetFileAttributes.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetFileAttributes.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGetFileAttributes.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGetFileAttributes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetFileAttributes.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGetFileAttributes.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGetFileAttributes.TabIndex = 17;
            this.kbtnGetFileAttributes.Values.Text = "G&et File Attributes";
            this.kbtnGetFileAttributes.Click += new System.EventHandler(this.KbtnGetFileAttributes_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(269, 274);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(198, 29);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "&Set File Attributes";
            // 
            // kbtnClearAllFileAttributes
            // 
            this.kbtnClearAllFileAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClearAllFileAttributes.Location = new System.Drawing.Point(473, 274);
            this.kbtnClearAllFileAttributes.Name = "kbtnClearAllFileAttributes";
            this.kbtnClearAllFileAttributes.Size = new System.Drawing.Size(198, 29);
            this.kbtnClearAllFileAttributes.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClearAllFileAttributes.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnClearAllFileAttributes.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnClearAllFileAttributes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClearAllFileAttributes.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnClearAllFileAttributes.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnClearAllFileAttributes.TabIndex = 15;
            this.kbtnClearAllFileAttributes.Values.Text = "Cle&ar All File Attributes";
            this.kbtnClearAllFileAttributes.Click += new System.EventHandler(this.KbtnClearAllFileAttributes_Click);
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(20, 14);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbTemporary);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbSystem);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbSparseFile);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbReparsePoint);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbReadOnly);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbOffline);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbIntegrityStream);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbNormal);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbNoScrubData);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbNotContextIndexed);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbHidden);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbCompressed);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbDevice);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbDirectory);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbEncrypted);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kcbArchive);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(651, 243);
            this.kryptonGroupBox3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox3.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox3.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonGroupBox3.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonGroupBox3.TabIndex = 2;
            this.kryptonGroupBox3.Values.Heading = "Validate Checksum";
            // 
            // kcbTemporary
            // 
            this.kcbTemporary.Location = new System.Drawing.Point(232, 161);
            this.kcbTemporary.Name = "kcbTemporary";
            this.kcbTemporary.Size = new System.Drawing.Size(103, 26);
            this.kcbTemporary.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTemporary.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbTemporary.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbTemporary.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTemporary.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbTemporary.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbTemporary.TabIndex = 15;
            this.kcbTemporary.ToolTipValues.Description = resources.GetString("resource.Description");
            this.kcbTemporary.ToolTipValues.Heading = "Archived";
            this.kcbTemporary.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbTemporary.Values.Text = "Te&mporary";
            // 
            // kcbSystem
            // 
            this.kcbSystem.Location = new System.Drawing.Point(133, 161);
            this.kcbSystem.Name = "kcbSystem";
            this.kcbSystem.Size = new System.Drawing.Size(77, 26);
            this.kcbSystem.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSystem.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbSystem.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbSystem.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSystem.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbSystem.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbSystem.TabIndex = 14;
            this.kcbSystem.ToolTipValues.Description = resources.GetString("resource.Description1");
            this.kcbSystem.ToolTipValues.Heading = "Archived";
            this.kcbSystem.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbSystem.Values.Text = "S&ystem";
            // 
            // kcbSparseFile
            // 
            this.kcbSparseFile.Location = new System.Drawing.Point(15, 161);
            this.kcbSparseFile.Name = "kcbSparseFile";
            this.kcbSparseFile.Size = new System.Drawing.Size(102, 26);
            this.kcbSparseFile.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSparseFile.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbSparseFile.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbSparseFile.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbSparseFile.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbSparseFile.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbSparseFile.TabIndex = 13;
            this.kcbSparseFile.ToolTipValues.Description = resources.GetString("resource.Description2");
            this.kcbSparseFile.ToolTipValues.Heading = "Archived";
            this.kcbSparseFile.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbSparseFile.Values.Text = "Spar&se File";
            // 
            // kcbReparsePoint
            // 
            this.kcbReparsePoint.Location = new System.Drawing.Point(476, 114);
            this.kcbReparsePoint.Name = "kcbReparsePoint";
            this.kcbReparsePoint.Size = new System.Drawing.Size(125, 26);
            this.kcbReparsePoint.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbReparsePoint.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbReparsePoint.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbReparsePoint.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbReparsePoint.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbReparsePoint.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbReparsePoint.TabIndex = 12;
            this.kcbReparsePoint.ToolTipValues.Description = resources.GetString("resource.Description3");
            this.kcbReparsePoint.ToolTipValues.Heading = "Archived";
            this.kcbReparsePoint.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbReparsePoint.Values.Text = "Re&parse Point";
            // 
            // kcbReadOnly
            // 
            this.kcbReadOnly.Location = new System.Drawing.Point(348, 114);
            this.kcbReadOnly.Name = "kcbReadOnly";
            this.kcbReadOnly.Size = new System.Drawing.Size(100, 26);
            this.kcbReadOnly.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbReadOnly.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbReadOnly.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbReadOnly.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbReadOnly.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbReadOnly.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbReadOnly.TabIndex = 11;
            this.kcbReadOnly.ToolTipValues.Description = resources.GetString("resource.Description4");
            this.kcbReadOnly.ToolTipValues.Heading = "Archived";
            this.kcbReadOnly.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbReadOnly.Values.Text = "&Read Only";
            // 
            // kcbOffline
            // 
            this.kcbOffline.Location = new System.Drawing.Point(232, 114);
            this.kcbOffline.Name = "kcbOffline";
            this.kcbOffline.Size = new System.Drawing.Size(73, 26);
            this.kcbOffline.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbOffline.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbOffline.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbOffline.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbOffline.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbOffline.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbOffline.TabIndex = 10;
            this.kcbOffline.ToolTipValues.Description = resources.GetString("resource.Description5");
            this.kcbOffline.ToolTipValues.Heading = "Archived";
            this.kcbOffline.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbOffline.Values.Text = "O&ffline";
            // 
            // kcbIntegrityStream
            // 
            this.kcbIntegrityStream.Location = new System.Drawing.Point(133, 67);
            this.kcbIntegrityStream.Name = "kcbIntegrityStream";
            this.kcbIntegrityStream.Size = new System.Drawing.Size(142, 26);
            this.kcbIntegrityStream.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbIntegrityStream.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbIntegrityStream.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbIntegrityStream.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbIntegrityStream.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbIntegrityStream.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbIntegrityStream.TabIndex = 9;
            this.kcbIntegrityStream.Values.Text = "I&ntegrity Stream";
            // 
            // kcbNormal
            // 
            this.kcbNormal.Location = new System.Drawing.Point(287, 67);
            this.kcbNormal.Name = "kcbNormal";
            this.kcbNormal.Size = new System.Drawing.Size(79, 26);
            this.kcbNormal.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNormal.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNormal.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNormal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNormal.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNormal.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNormal.TabIndex = 8;
            this.kcbNormal.Values.Text = "No&rmal";
            // 
            // kcbNoScrubData
            // 
            this.kcbNoScrubData.Location = new System.Drawing.Point(399, 67);
            this.kcbNoScrubData.Name = "kcbNoScrubData";
            this.kcbNoScrubData.Size = new System.Drawing.Size(131, 26);
            this.kcbNoScrubData.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNoScrubData.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNoScrubData.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNoScrubData.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNoScrubData.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNoScrubData.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNoScrubData.TabIndex = 7;
            this.kcbNoScrubData.Values.Text = "No &Scrub Data";
            // 
            // kcbNotContextIndexed
            // 
            this.kcbNotContextIndexed.Location = new System.Drawing.Point(15, 114);
            this.kcbNotContextIndexed.Name = "kcbNotContextIndexed";
            this.kcbNotContextIndexed.Size = new System.Drawing.Size(176, 26);
            this.kcbNotContextIndexed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNotContextIndexed.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNotContextIndexed.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNotContextIndexed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbNotContextIndexed.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbNotContextIndexed.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbNotContextIndexed.TabIndex = 6;
            this.kcbNotContextIndexed.Values.Text = "Not Co&ntext Indexed";
            // 
            // kcbHidden
            // 
            this.kcbHidden.Location = new System.Drawing.Point(15, 67);
            this.kcbHidden.Name = "kcbHidden";
            this.kcbHidden.Size = new System.Drawing.Size(78, 26);
            this.kcbHidden.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbHidden.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbHidden.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbHidden.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbHidden.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbHidden.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbHidden.TabIndex = 5;
            this.kcbHidden.ToolTipValues.Description = resources.GetString("resource.Description6");
            this.kcbHidden.ToolTipValues.Heading = "Archived";
            this.kcbHidden.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbHidden.Values.Text = "&Hidden";
            // 
            // kcbCompressed
            // 
            this.kcbCompressed.Location = new System.Drawing.Point(133, 19);
            this.kcbCompressed.Name = "kcbCompressed";
            this.kcbCompressed.Size = new System.Drawing.Size(115, 26);
            this.kcbCompressed.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCompressed.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbCompressed.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbCompressed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbCompressed.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbCompressed.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbCompressed.TabIndex = 4;
            this.kcbCompressed.Values.Text = "C&ompressed";
            // 
            // kcbDevice
            // 
            this.kcbDevice.Location = new System.Drawing.Point(287, 19);
            this.kcbDevice.Name = "kcbDevice";
            this.kcbDevice.Size = new System.Drawing.Size(73, 26);
            this.kcbDevice.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbDevice.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbDevice.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbDevice.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbDevice.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbDevice.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbDevice.TabIndex = 3;
            this.kcbDevice.Values.Text = "D&evice";
            // 
            // kcbDirectory
            // 
            this.kcbDirectory.Location = new System.Drawing.Point(399, 19);
            this.kcbDirectory.Name = "kcbDirectory";
            this.kcbDirectory.Size = new System.Drawing.Size(91, 26);
            this.kcbDirectory.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbDirectory.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbDirectory.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbDirectory.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbDirectory.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbDirectory.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbDirectory.TabIndex = 2;
            this.kcbDirectory.Values.Text = "D&irectory";
            // 
            // kcbEncrypted
            // 
            this.kcbEncrypted.Location = new System.Drawing.Point(529, 19);
            this.kcbEncrypted.Name = "kcbEncrypted";
            this.kcbEncrypted.Size = new System.Drawing.Size(97, 26);
            this.kcbEncrypted.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbEncrypted.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbEncrypted.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbEncrypted.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbEncrypted.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbEncrypted.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbEncrypted.TabIndex = 1;
            this.kcbEncrypted.Values.Text = "&Encrypted";
            // 
            // kcbArchive
            // 
            this.kcbArchive.Location = new System.Drawing.Point(15, 19);
            this.kcbArchive.Name = "kcbArchive";
            this.kcbArchive.Size = new System.Drawing.Size(79, 26);
            this.kcbArchive.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbArchive.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbArchive.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbArchive.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbArchive.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kcbArchive.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kcbArchive.TabIndex = 0;
            this.kcbArchive.ToolTipValues.Description = resources.GetString("resource.Description7");
            this.kcbArchive.ToolTipValues.Heading = "Archived";
            this.kcbArchive.ToolTipValues.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kcbArchive.Values.Text = "&Archive";
            // 
            // bgwMD5
            // 
            this.bgwMD5.WorkerReportsProgress = true;
            this.bgwMD5.WorkerSupportsCancellation = true;
            this.bgwMD5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwMD5_DoWork);
            this.bgwMD5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwMD5_ProgressChanged);
            this.bgwMD5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwMD5_RunWorkerCompleted);
            // 
            // bgwSHA1
            // 
            this.bgwSHA1.WorkerReportsProgress = true;
            this.bgwSHA1.WorkerSupportsCancellation = true;
            this.bgwSHA1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwSHA1_DoWork);
            this.bgwSHA1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwSHA1_ProgressChanged);
            this.bgwSHA1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwSHA1_RunWorkerCompleted);
            // 
            // bgwSHA256
            // 
            this.bgwSHA256.WorkerReportsProgress = true;
            this.bgwSHA256.WorkerSupportsCancellation = true;
            this.bgwSHA256.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwSHA256_DoWork);
            this.bgwSHA256.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwSHA256_ProgressChanged);
            this.bgwSHA256.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwSHA256_RunWorkerCompleted);
            // 
            // bgwSHA384
            // 
            this.bgwSHA384.WorkerReportsProgress = true;
            this.bgwSHA384.WorkerSupportsCancellation = true;
            this.bgwSHA384.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwSHA384_DoWork);
            this.bgwSHA384.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwSHA384_ProgressChanged);
            this.bgwSHA384.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwSHA384_RunWorkerCompleted);
            // 
            // bgwSHA512
            // 
            this.bgwSHA512.WorkerReportsProgress = true;
            this.bgwSHA512.WorkerSupportsCancellation = true;
            this.bgwSHA512.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwSHA512_DoWork);
            this.bgwSHA512.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwSHA512_ProgressChanged);
            this.bgwSHA512.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwSHA512_RunWorkerCompleted);
            // 
            // bgwRIPEMD160
            // 
            this.bgwRIPEMD160.WorkerReportsProgress = true;
            this.bgwRIPEMD160.WorkerSupportsCancellation = true;
            this.bgwRIPEMD160.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwRIPEMD160_DoWork);
            this.bgwRIPEMD160.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwRIPEMD160_ProgressChanged);
            this.bgwRIPEMD160.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwRIPEMD160_RunWorkerCompleted);
            // 
            // KryptonFileInformationDialog
            // 
            this.ClientSize = new System.Drawing.Size(716, 744);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonFileInformationDialog";
            this.Text = "{0} Properties";
            this.Load += new System.EventHandler(this.KryptonFileInformationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ctxHashMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbValidatedHashType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbHashType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpFileAttributes)).EndInit();
            this.kpFileAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string _filePath = null;
        private Timer _fileAttributesTimer = new Timer();
        private GlobalStringSettingsManager _globalStringSettingsManager = new GlobalStringSettingsManager();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get => _filePath; set => _filePath = value; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonFileInformationDialog"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public KryptonFileInformationDialog(string filePath)
        {
            InitializeComponent();

            FilePath = filePath;

            //_fileAttributesTimer.Enabled = true;

            //_fileAttributesTimer.Interval = 500;

            //_fileAttributesTimer.Tick += FileAttributesTimer_Tick;
        }

        #region Hashing Stuff
        private void BgwMD5_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm md5 = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        md5.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwMD5.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    md5.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(md5.Hash, 32);
                }
            }
        }

        private void BgwMD5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwMD5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwMD5.Dispose();
        }

        private void BgwSHA1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm sha1 = SHA1.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha1.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA1.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    sha1.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(sha1.Hash, 40);
                }
            }
        }

        private void BgwSHA1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwSHA1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwSHA1.Dispose();
        }

        private void BgwSHA256_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm sha256 = SHA256.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha256.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA256.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    sha256.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(sha256.Hash, 40);
                }
            }
        }

        private void BgwSHA256_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwSHA256_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwSHA256.Dispose();
        }

        private void BgwSHA384_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm sha384 = SHA384.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha384.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA384.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    sha384.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(sha384.Hash, 96);
                }
            }
        }

        private void BgwSHA384_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwSHA384_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwSHA384.Dispose();
        }

        private void BgwSHA512_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm sha512 = SHA512.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha512.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA512.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    sha512.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(sha512.Hash, 128);
                }
            }
        }

        private void BgwSHA512_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwSHA512_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwSHA512.Dispose();
        }

        private void BgwRIPEMD160_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long fileLength, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                fileLength = fileStream.Length;

                using (HashAlgorithm ripemd160 = RIPEMD160.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        ripemd160.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwRIPEMD160.ReportProgress((int)((double)totalBytesToRead / fileLength * 100));
                    } while (bytesRead != 0);

                    ripemd160.TransformFinalBlock(buffer, 0, 0);

                    e.Result = HashingHelper.BuildFileHash(ripemd160.Hash, 40);
                }
            }
        }

        private void BgwRIPEMD160_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);
        }

        private void BgwRIPEMD160_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            klblRealFileHash.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwRIPEMD160.Dispose();
        }
        #endregion

        private void FileAttributesTimer_Tick(object sender, EventArgs e)
        {
            FileAttributeHandler.GetSelectedFileAttributes(ktbFileName.Text, kcbArchive, kcbCompressed, kcbDevice, kcbDirectory, kcbEncrypted, kcbHidden, kcbIntegrityStream, kcbNormal, kcbNoScrubData, kcbNotContextIndexed, kcbOffline, kcbReadOnly, kcbReparsePoint, kcbSparseFile, kcbSystem, kcbTemporary);

            _fileAttributesTimer.Stop();
        }

        private void KryptonFileInformationDialog_Load(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void KbtnValidate_Click(object sender, EventArgs e)
        {
            HashingHelper.ValidateFileHash(klblRealFileHash, ktxtValidate);
        }

        private void LoadWindow()
        {
            HashingHelper.PropagateHashInput(kcmbHashType1);

            HashingHelper.PropagateHashInput(kcmbValidatedHashType);

            UpdateWindowTitle(FilePath);

            ktbFileName.Text = Path.GetFileName(FilePath);

            GetFileInformation(FilePath);

            UpdateWindowIcon(FilePath);
        }

        /// <summary>
        /// Updates the window icon.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        private void UpdateWindowIcon(string filePath)
        {
            Icon = GetFileIcon(filePath);

            pbxFileIcon.Image = GetFileIconImage(filePath);
        }

        /// <summary>
        /// Gets the file icon image.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private Image GetFileIconImage(string filePath)
        {
            return Icon.ExtractAssociatedIcon(filePath).ToBitmap();
        }

        /// <summary>
        /// Gets the file icon.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private Icon GetFileIcon(string filePath)
        {
            return Icon.ExtractAssociatedIcon(filePath);
        }

        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        private void GetFileInformation(string filePath)
        {
            try
            {
                if (filePath == string.Empty) throw new ArgumentNullException();

                FileInfo fileInfo = new FileInfo(filePath);

                klblFileType.Text = $"Type of file: *{ Path.GetExtension(filePath) }";

                klblFileLocation.Text = $"Location: { Path.GetFullPath(filePath) }";

                klblFileSize.Text = $"Size: { FileUtilities.GetReadableFileSize(fileInfo.Length) } ({ fileInfo.Length.ToString() } bytes)";

                klblSizeOnDisk.Text = $"Size on disk: { FileUtilities.GetReadableFileSize(FileUtilities.GetFileSizeOnDisk(filePath)) }";

                klblCreated.Text = $"Created: { GetDateTimeAsString(fileInfo.CreationTime) }";

                klblAccessed.Text = $"Accessed: { GetDateTimeAsString(fileInfo.LastAccessTime) }";

                klblModified.Text = $"Modified: { GetDateTimeAsString(fileInfo.LastWriteTime) }";
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        /// <summary>
        /// Updates the window title.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="showExtension">if set to <c>true</c> [show extension].</param>
        private void UpdateWindowTitle(string filePath, bool showExtension = false)
        {
            if (showExtension)
            {
                Text = $"{ Path.GetFileName(filePath) } Properties";
            }
            else
            {
                Text = $"{ Path.GetFileNameWithoutExtension(filePath) } Properties";
            }
        }

        /// <summary>
        /// Constructs the m d5 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <returns></returns>
        private static string ConstructMD5HashString(byte[] hashBytes)
        {
            StringBuilder hashBuilder = new StringBuilder(32);

            foreach (byte b in hashBytes)
            {
                hashBuilder.Append(b.ToString("X2").ToLower());
            }

            return hashBuilder.ToString();
        }

        /// <summary>
        /// Gets the date time as string.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        private static string GetDateTimeAsString(DateTime dateTime)
        {
            return $"{ dateTime.DayOfWeek.ToString() }, { dateTime.ToLongDateString() }, { dateTime.ToLongTimeString() }";
        }

        private void KbtnCalculateFileHash_Click(object sender, EventArgs e)
        {
            if (kcmbHashType1.Text == "MD5")
            {
                bgwMD5.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-1")
            {
                bgwSHA1.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-256")
            {
                bgwSHA256.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-384")
            {
                bgwSHA384.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "SHA-512")
            {
                bgwSHA512.RunWorkerAsync(ktbFileName.Text);
            }
            else if (kcmbHashType1.Text == "RIPEMD-160")
            {
                bgwRIPEMD160.RunWorkerAsync(ktbFileName.Text);
            }

            kbtnCalculateFileHash.Enabled = false;
        }

        private void KtxtValidate_TextChanged(object sender, EventArgs e)
        {
            HashingHelper.UpdateHashType(kcmbValidatedHashType, ktxtValidate.Text.Length);
        }

        private void KbtnClearAllFileAttributes_Click(object sender, EventArgs e)
        {
            DialogResult result = ExtendedKryptonMessageBox.Show($"Are you sure that you want to clear the attributes for file: '{ ktbFileName.Text }'?", "Clear File Attributes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FileAttributeHandler.ClearAllAttributes(ktbFileName.Text);
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ktxtValidate.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ktxtValidate.Text);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ktxtValidate.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ktxtValidate.SelectAll();
        }

        private void KbtnGetFileAttributes_Click(object sender, EventArgs e)
        {
            _fileAttributesTimer.Start();
        }

        private void KcmbHashType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kbtnCalculateFileHash.Enabled = true;
        }

        private void KbtnImportHash_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Import a hash file:";

            cofd.Filters.Add(new CommonFileDialogFilter("MD5 Files", ".md5"));

            cofd.Filters.Add(new CommonFileDialogFilter("SHA-1 Files", ".sha1"));

            cofd.Filters.Add(new CommonFileDialogFilter("SHA-256 Files", ".sha256"));

            cofd.Filters.Add(new CommonFileDialogFilter("SHA-384 Files", ".sha384"));

            cofd.Filters.Add(new CommonFileDialogFilter("SHA-512 Files", ".sha512"));

            cofd.Filters.Add(CommonFileDialogStandardFilters.TextFiles);

            cofd.Filters.Add(new CommonFileDialogFilter("All Files", ".*"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string path = Path.GetFullPath(cofd.FileName);

                StreamReader reader = new StreamReader(path);

                ktxtValidate.Text = reader.ReadToEnd();
            }
        }
    }
}