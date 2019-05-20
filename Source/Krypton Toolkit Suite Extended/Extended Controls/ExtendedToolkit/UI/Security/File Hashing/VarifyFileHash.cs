#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Security;
using ExtendedControls.Base.Code.Windows;
using ExtendedControls.ExtendedToolkit.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Security.FileHashing
{
    public class VarifyFileHash : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.StatusStrip ss;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel3;
        private KryptonButton kbtnBrowse;
        private KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private KryptonLabel kryptonLabel4;
        private KryptonButton kbtnGenerateFileHash;
        private KryptonLabel kryptonLabel2;
        private KryptonComboBox kcbxHashAlgorithimType;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnCancel;
        private System.ComponentModel.BackgroundWorker bgwMD5;
        private System.ComponentModel.BackgroundWorker bgwSHA1;
        private System.ComponentModel.BackgroundWorker bgwSHA256;
        private System.ComponentModel.BackgroundWorker bgwSHA384;
        private System.ComponentModel.BackgroundWorker bgwSHA512;
        private System.ComponentModel.BackgroundWorker bgwRIPEMD160;
        private KryptonButton kbtnVarify;
        private System.Windows.Forms.ContextMenuStrip ctxResult;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripProgressBar tspbHashProgess;
        private System.Windows.Forms.ToolStripStatusLabel tslHashProgressValue;
        private KryptonButton kbtnComputeHash;
        private KryptonLabel klblActualResult;
        private KryptonTextBox ktxtImportedResult;
        private KryptonTextBox ktxtApplicationExecutable;
        private KryptonButton kbtnImportHash;
        private ContextMenuStrip ctxActualResult;
        private ToolStripMenuItem copyHashToClipboardToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exportHashToFileToolStripMenuItem;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarifyFileHash));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbHashProgess = new System.Windows.Forms.ToolStripProgressBar();
            this.tslHashProgressValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnImportHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnComputeHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnVarify = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtApplicationExecutable = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtImportedResult = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ctxResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.klblActualResult = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ctxActualResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyHashToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportHashToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnGenerateFileHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbxHashAlgorithimType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.bgwMD5 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA1 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA384 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA512 = new System.ComponentModel.BackgroundWorker();
            this.bgwRIPEMD160 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.ctxResult.SuspendLayout();
            this.ctxActualResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ss);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 441);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1335, 22);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tspbHashProgess,
            this.tslHashProgressValue});
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1335, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1320, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbHashProgess
            // 
            this.tspbHashProgess.Name = "tspbHashProgess";
            this.tspbHashProgess.Size = new System.Drawing.Size(100, 16);
            this.tspbHashProgess.Visible = false;
            // 
            // tslHashProgressValue
            // 
            this.tslHashProgressValue.Name = "tslHashProgressValue";
            this.tslHashProgressValue.Size = new System.Drawing.Size(0, 17);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnImportHash);
            this.kryptonPanel2.Controls.Add(this.kbtnComputeHash);
            this.kryptonPanel2.Controls.Add(this.kbtnVarify);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 357);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1335, 84);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kbtnImportHash
            // 
            this.kbtnImportHash.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnImportHash.Location = new System.Drawing.Point(912, 28);
            this.kbtnImportHash.Name = "kbtnImportHash";
            this.kbtnImportHash.Size = new System.Drawing.Size(139, 29);
            this.kbtnImportHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImportHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnImportHash.TabIndex = 14;
            this.kbtnImportHash.Values.Text = "&Import Hash";
            this.kbtnImportHash.Click += new System.EventHandler(this.KbtnImportHash_Click);
            // 
            // kbtnComputeHash
            // 
            this.kbtnComputeHash.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnComputeHash.Location = new System.Drawing.Point(12, 28);
            this.kbtnComputeHash.Name = "kbtnComputeHash";
            this.kbtnComputeHash.Size = new System.Drawing.Size(139, 29);
            this.kbtnComputeHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnComputeHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnComputeHash.TabIndex = 13;
            this.kbtnComputeHash.Values.Text = "&Compute Hash";
            this.kbtnComputeHash.Click += new System.EventHandler(this.KbtnComputeHash_Click);
            // 
            // kbtnVarify
            // 
            this.kbtnVarify.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnVarify.Enabled = false;
            this.kbtnVarify.Location = new System.Drawing.Point(1057, 28);
            this.kbtnVarify.Name = "kbtnVarify";
            this.kbtnVarify.Size = new System.Drawing.Size(139, 29);
            this.kbtnVarify.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnVarify.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnVarify.TabIndex = 12;
            this.kbtnVarify.Values.Text = "V&arify Hash";
            this.kbtnVarify.Click += new System.EventHandler(this.KbtnVarify_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(1202, 28);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 10;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.KbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 3);
            this.panel1.TabIndex = 4;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.ktxtApplicationExecutable);
            this.kryptonPanel3.Controls.Add(this.ktxtImportedResult);
            this.kryptonPanel3.Controls.Add(this.klblActualResult);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel3.Controls.Add(this.kbtnGenerateFileHash);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel3.Controls.Add(this.kcbxHashAlgorithimType);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1335, 354);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // ktxtApplicationExecutable
            // 
            this.ktxtApplicationExecutable.Hint = "File Path";
            this.ktxtApplicationExecutable.Location = new System.Drawing.Point(245, 12);
            this.ktxtApplicationExecutable.Name = "ktxtApplicationExecutable";
            this.ktxtApplicationExecutable.Size = new System.Drawing.Size(1033, 29);
            this.ktxtApplicationExecutable.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtApplicationExecutable.TabIndex = 18;
            // 
            // ktxtImportedResult
            // 
            this.ktxtImportedResult.ContextMenuStrip = this.ctxResult;
            this.ktxtImportedResult.Location = new System.Drawing.Point(13, 307);
            this.ktxtImportedResult.Name = "ktxtImportedResult";
            this.ktxtImportedResult.Size = new System.Drawing.Size(1306, 33);
            this.ktxtImportedResult.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtImportedResult.TabIndex = 17;
            this.ktxtImportedResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ktxtImportedResult.TextChanged += new System.EventHandler(this.KtxtActualResult_TextChanged);
            // 
            // ctxResult
            // 
            this.ctxResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCut,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiPaste,
            this.toolStripSeparator3,
            this.tsmiSelectAll});
            this.ctxResult.Name = "ctxResult";
            this.ctxResult.Size = new System.Drawing.Size(123, 110);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(122, 22);
            this.tsmiCut.Text = "C&ut";
            this.tsmiCut.Click += new System.EventHandler(this.TsmiCut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(122, 22);
            this.tsmiPaste.Text = "&Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.TsmiPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(122, 22);
            this.tsmiSelectAll.Text = "Select &All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // klblActualResult
            // 
            this.klblActualResult.AutoSize = false;
            this.klblActualResult.ContextMenuStrip = this.ctxActualResult;
            this.klblActualResult.Location = new System.Drawing.Point(12, 161);
            this.klblActualResult.Name = "klblActualResult";
            this.klblActualResult.Size = new System.Drawing.Size(1307, 107);
            this.klblActualResult.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblActualResult.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblActualResult.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblActualResult.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblActualResult.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblActualResult.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblActualResult.TabIndex = 16;
            this.klblActualResult.Values.Text = "";
            // 
            // ctxActualResult
            // 
            this.ctxActualResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxActualResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyHashToClipboardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exportHashToFileToolStripMenuItem});
            this.ctxActualResult.Name = "ctxActualResult";
            this.ctxActualResult.Size = new System.Drawing.Size(211, 54);
            // 
            // copyHashToClipboardToolStripMenuItem
            // 
            this.copyHashToClipboardToolStripMenuItem.Name = "copyHashToClipboardToolStripMenuItem";
            this.copyHashToClipboardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.copyHashToClipboardToolStripMenuItem.Text = "&Copy Hash to Clipboard...";
            this.copyHashToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyHashToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // exportHashToFileToolStripMenuItem
            // 
            this.exportHashToFileToolStripMenuItem.Name = "exportHashToFileToolStripMenuItem";
            this.exportHashToFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exportHashToFileToolStripMenuItem.Text = "E&xport Hash to File...";
            this.exportHashToFileToolStripMenuItem.Click += new System.EventHandler(this.ExportHashToFileToolStripMenuItem_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 274);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(196, 26);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Imported/Copied Result:";
            // 
            // kbtnGenerateFileHash
            // 
            this.kbtnGenerateFileHash.Enabled = false;
            this.kbtnGenerateFileHash.Location = new System.Drawing.Point(398, 67);
            this.kbtnGenerateFileHash.Name = "kbtnGenerateFileHash";
            this.kbtnGenerateFileHash.Size = new System.Drawing.Size(156, 27);
            this.kbtnGenerateFileHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateFileHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateFileHash.TabIndex = 12;
            this.kbtnGenerateFileHash.Values.Text = "&Generate";
            this.kbtnGenerateFileHash.Click += new System.EventHandler(this.KbtnGenerateFileHash_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 128);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(114, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Actual Result:";
            // 
            // kcbxHashAlgorithimType
            // 
            this.kcbxHashAlgorithimType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbxHashAlgorithimType.DropDownWidth = 223;
            this.kcbxHashAlgorithimType.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512",
            "RIPEMD-160"});
            this.kcbxHashAlgorithimType.Location = new System.Drawing.Point(169, 67);
            this.kcbxHashAlgorithimType.Name = "kcbxHashAlgorithimType";
            this.kcbxHashAlgorithimType.Size = new System.Drawing.Size(223, 27);
            this.kcbxHashAlgorithimType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.TabIndex = 10;
            this.kcbxHashAlgorithimType.SelectedIndexChanged += new System.EventHandler(this.KcbxHashAlgorithimType_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 68);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Hash Algorithim:";
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(1284, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(35, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 6;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.KbtnBrowse_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(227, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Application Binary/Hash File:";
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
            // VarifyFileHash
            // 
            this.ClientSize = new System.Drawing.Size(1335, 463);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VarifyFileHash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varify File Hash";
            this.Load += new System.EventHandler(this.VarifyFileHash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ctxResult.ResumeLayout(false);
            this.ctxActualResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        bool _busy;
        private string _readableExtensionList = "MD5 Files (*.md5)|RIPEMD-160 Files (*.ripemd160)|SHA-1 Files (*.sha1)|SHA-256 Files (*.sha256)|SHA-384 Files (*.sha384)|SHA-512 Files (*.sha512)|All Files (*.*)", _extensionList = ".md5,.ripemd160,.sha1,.sha256,.sha384,.sha512,.*";
        #endregion

        #region Properties
        private bool Busy { get => _busy; set => _busy = value; }

        private string ReadableExtensionList { get => _readableExtensionList; }

        private string ExtensionList { get => _extensionList; }
        #endregion

        #region Constructor
        public VarifyFileHash()
        {
            InitializeComponent();

            SetBusy(false);
        }

        public VarifyFileHash(string filePath, string hashType, string hash)
        {
            InitializeComponent();

            ktxtApplicationExecutable.Text = filePath;

            kcbxHashAlgorithimType.Text = hashType;

            klblActualResult.Text = hash;

            SetBusy(false);
        }
        #endregion

        private void VarifyFileHash_Load(object sender, EventArgs e)
        {

        }

        private void KbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Select a file:";

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtApplicationExecutable.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void KbtnGenerateFileHash_Click(object sender, EventArgs e)
        {
            if (kcbxHashAlgorithimType.Text == "MD5")
            {
                bgwMD5.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-1")
            {
                bgwSHA1.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-256")
            {
                bgwSHA256.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-384")
            {
                bgwSHA384.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-512")
            {
                bgwSHA512.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "RIPEMD-160")
            {
                bgwRIPEMD160.RunWorkerAsync(ktxtApplicationExecutable.Text);
            }

            kbtnGenerateFileHash.Enabled = false;
        }

        private void KbtnComputeHash_Click(object sender, EventArgs e)
        {
            HashFile hashFile = new HashFile();

            hashFile.Show();

            Hide();
        }

        private void KbtnVarify_Click(object sender, EventArgs e)
        {
            HashingHelper.ValidateFileHash(klblActualResult, ktxtImportedResult);
        }

        private void KbtnCancel_Click(object sender, EventArgs e)
        {
            if (bgwMD5.IsBusy || bgwRIPEMD160.IsBusy || bgwSHA1.IsBusy || bgwSHA256.IsBusy || bgwSHA384.IsBusy || bgwSHA512.IsBusy)
            {
                DialogResult result = KryptonMessageBoxExtended.Show("One or more tasks are running, cancel the tasks now?", "Running Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bgwMD5.CancelAsync();

                    bgwRIPEMD160.CancelAsync();

                    bgwSHA1.CancelAsync();

                    bgwSHA256.CancelAsync();

                    bgwSHA384.CancelAsync();

                    bgwSHA512.CancelAsync();

                    Hide();
                }
            }
            else
            {
                Hide();
            }
        }

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileHash"></param>
        /// <param name="importedHash"></param>
        /// <returns></returns>
        private bool CompareHash(string fileHash, string importedHash)
        {
            return fileHash.Contains(importedHash);
        }

        private bool IsBusy()
        {
            return GetBusy();
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the value of Busy to value.
        /// </summary>
        /// <param name="value">The value of Busy.</param>
        private void SetBusy(bool value)
        {
            Busy = value;
        }

        /// <summary>
        /// Returns the value of Busy.
        /// </summary>
        /// <returns>The value of Busy.</returns>
        private bool GetBusy()
        {
            return Busy;
        }
        #endregion

        private void KtxtActualResult_TextChanged(object sender, EventArgs e)
        {
            if (ktxtImportedResult.Text != string.Empty)
            {
                kbtnVarify.Enabled = true;
            }
            else
            {
                kbtnVarify.Enabled = false;
            }
        }

        private void TsmiCut_Click(object sender, EventArgs e)
        {
            ktxtImportedResult.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ktxtImportedResult.Copy();
        }

        private void TsmiPaste_Click(object sender, EventArgs e)
        {
            ktxtImportedResult.Paste();
        }

        private void TsmiSelectAll_Click(object sender, EventArgs e)
        {
            ktxtImportedResult.SelectAll();
        }

        #region Hashing Work
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
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwMD5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

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
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwSHA1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

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

                    e.Result = HashingHelper.BuildFileHash(sha256.Hash, 64);
                }
            }
        }

        private void BgwSHA256_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwSHA256_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
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
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwSHA384_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

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
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwSHA512_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

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
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void BgwRIPEMD160_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblActualResult.Text = e.Result.ToString();

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            bgwRIPEMD160.Dispose();
        }
        #endregion

        private void KcbxHashAlgorithimType_SelectedIndexChanged(object sender, EventArgs e)
        {
            kbtnGenerateFileHash.Enabled = true;
        }

        private void KbtnImportHash_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cifofd = new CommonOpenFileDialog();

            cifofd.Title = "Import a hash file:";

            cifofd.Filters.Add(new CommonFileDialogFilter(ReadableExtensionList, ExtensionList));

            if (cifofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                StreamReader reader = new StreamReader(cifofd.FileName);

                ktxtImportedResult.Text = reader.ReadToEnd();
            }
        }

        private void ExportHashToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonSaveFileDialog chsfd = new CommonSaveFileDialog();

            chsfd.Title = "Save hash to file:";

            chsfd.Filters.Add(new CommonFileDialogFilter(ReadableExtensionList, ExtensionList));

            chsfd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();

            if (chsfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                StreamWriter writer = new StreamWriter(chsfd.FileName);

                writer.WriteLine(klblActualResult.Text);

                writer.Flush();

                writer.Close();

                writer.Dispose();
            }
        }

        private void CopyHashToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(klblActualResult.Text);
        }
    }
}