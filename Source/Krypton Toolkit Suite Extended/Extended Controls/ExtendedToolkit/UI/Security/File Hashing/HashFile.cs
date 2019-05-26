#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Security.FileHashing
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ComponentFactory.Krypton.Toolkit.KryptonForm" />
    public class HashFile : KryptonForm
    {
        #region Designer Code
        private KryptonLabel klblResult;
        private KryptonLabel kryptonLabel2;
        private KryptonComboBox kcbxHashAlgorithimType;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnBrowse;
        private Controls.KryptonPromptTextBox kptxtApplicationExecutable;
        private KryptonLabel kryptonLabel3;
        private KryptonButton kbtnGenerateFileHash;
        private System.Windows.Forms.ContextMenuStrip ctxResult;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private KryptonButton kbtnCancel;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnSaveHash;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tspbHashProgess;
        private System.Windows.Forms.ToolStripStatusLabel tslHashProgressValue;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgwMD5;
        private BackgroundWorker bgwSHA1;
        private BackgroundWorker bgwSHA256;
        private BackgroundWorker bgwSHA384;
        private BackgroundWorker bgwSHA512;
        private BackgroundWorker bgwRIPEMD160;
        private KryptonButton kbtnVarify;
        private KryptonCheckBox kcbShowLength;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashFile));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcbShowLength = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnGenerateFileHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblResult = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ctxResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbxHashAlgorithimType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kptxtApplicationExecutable = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnVarify = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSaveHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbHashProgess = new System.Windows.Forms.ToolStripProgressBar();
            this.tslHashProgressValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgwMD5 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA1 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA384 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA512 = new System.ComponentModel.BackgroundWorker();
            this.bgwRIPEMD160 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.ctxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kcbShowLength);
            this.kryptonPanel1.Controls.Add(this.kbtnGenerateFileHash);
            this.kryptonPanel1.Controls.Add(this.klblResult);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kcbxHashAlgorithimType);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.kptxtApplicationExecutable);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(853, 427);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kcbShowLength
            // 
            this.kcbShowLength.Location = new System.Drawing.Point(572, 109);
            this.kcbShowLength.Name = "kcbShowLength";
            this.kcbShowLength.Size = new System.Drawing.Size(119, 26);
            this.kcbShowLength.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbShowLength.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbShowLength.TabIndex = 9;
            this.kcbShowLength.Values.Text = "Show &Length";
            // 
            // kbtnGenerateFileHash
            // 
            this.kbtnGenerateFileHash.Enabled = false;
            this.kbtnGenerateFileHash.Location = new System.Drawing.Point(410, 109);
            this.kbtnGenerateFileHash.Name = "kbtnGenerateFileHash";
            this.kbtnGenerateFileHash.Size = new System.Drawing.Size(156, 27);
            this.kbtnGenerateFileHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateFileHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateFileHash.TabIndex = 8;
            this.kbtnGenerateFileHash.Values.Text = "&Generate";
            this.kbtnGenerateFileHash.Click += new System.EventHandler(this.KbtnGenerateFileHash_Click);
            // 
            // klblResult
            // 
            this.klblResult.AutoSize = false;
            this.klblResult.ContextMenuStrip = this.ctxResult;
            this.klblResult.Location = new System.Drawing.Point(24, 217);
            this.klblResult.Name = "klblResult";
            this.klblResult.Size = new System.Drawing.Size(811, 73);
            this.klblResult.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblResult.StateCommon.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblResult.StateCommon.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblResult.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblResult.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblResult.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblResult.TabIndex = 7;
            this.klblResult.Values.Text = "";
            // 
            // ctxResult
            // 
            this.ctxResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.ctxResult.Name = "ctxResult";
            this.ctxResult.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(24, 170);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Result:";
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
            this.kcbxHashAlgorithimType.Location = new System.Drawing.Point(181, 109);
            this.kcbxHashAlgorithimType.Name = "kcbxHashAlgorithimType";
            this.kcbxHashAlgorithimType.Size = new System.Drawing.Size(223, 27);
            this.kcbxHashAlgorithimType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxHashAlgorithimType.TabIndex = 5;
            this.kcbxHashAlgorithimType.SelectedIndexChanged += new System.EventHandler(this.KcbxHashAlgorithimType_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 110);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Hash Algorithim:";
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(800, 44);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(35, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 3;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.KbtnBrowse_Click);
            // 
            // kptxtApplicationExecutable
            // 
            this.kptxtApplicationExecutable.DrawPrompt = true;
            this.kptxtApplicationExecutable.FocusSelect = true;
            this.kptxtApplicationExecutable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtApplicationExecutable.Location = new System.Drawing.Point(181, 44);
            this.kptxtApplicationExecutable.Name = "kptxtApplicationExecutable";
            this.kptxtApplicationExecutable.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtApplicationExecutable.PromptText = "Executable Path";
            this.kptxtApplicationExecutable.PromptTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtApplicationExecutable.Size = new System.Drawing.Size(613, 29);
            this.kptxtApplicationExecutable.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 45);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(153, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Application Binary:";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(718, 17);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 9;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnVarify);
            this.kryptonPanel2.Controls.Add(this.kbtnSaveHash);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Controls.Add(this.ss);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 343);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(853, 84);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kbtnVarify
            // 
            this.kbtnVarify.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnVarify.Location = new System.Drawing.Point(12, 17);
            this.kbtnVarify.Name = "kbtnVarify";
            this.kbtnVarify.Size = new System.Drawing.Size(139, 29);
            this.kbtnVarify.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnVarify.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnVarify.TabIndex = 11;
            this.kbtnVarify.Values.Text = "V&arify Hash";
            this.kbtnVarify.Click += new System.EventHandler(this.KbtnVarify_Click);
            // 
            // kbtnSaveHash
            // 
            this.kbtnSaveHash.Enabled = false;
            this.kbtnSaveHash.Location = new System.Drawing.Point(595, 17);
            this.kbtnSaveHash.Name = "kbtnSaveHash";
            this.kbtnSaveHash.Size = new System.Drawing.Size(117, 29);
            this.kbtnSaveHash.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveHash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveHash.TabIndex = 10;
            this.kbtnSaveHash.Values.Text = "S&ave";
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tspbHashProgess,
            this.tslHashProgressValue});
            this.ss.Location = new System.Drawing.Point(0, 62);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(853, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(838, 17);
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
            this.tslHashProgressValue.Size = new System.Drawing.Size(31, 17);
            this.tslHashProgressValue.Text = "{0}%";
            this.tslHashProgressValue.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 3);
            this.panel1.TabIndex = 3;
            // 
            // bgwMD5
            // 
            this.bgwMD5.WorkerReportsProgress = true;
            this.bgwMD5.WorkerSupportsCancellation = true;
            this.bgwMD5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwMD5_DoWork);
            this.bgwMD5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwMD5_ProgressChanged);
            this.bgwMD5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwMD5_RunWorkerCompleted);
            // 
            // bgwSHA1
            // 
            this.bgwSHA1.WorkerReportsProgress = true;
            this.bgwSHA1.WorkerSupportsCancellation = true;
            this.bgwSHA1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSHA1_DoWork);
            this.bgwSHA1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSHA1_ProgressChanged);
            this.bgwSHA1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSHA1_RunWorkerCompleted);
            // 
            // bgwSHA256
            // 
            this.bgwSHA256.WorkerReportsProgress = true;
            this.bgwSHA256.WorkerSupportsCancellation = true;
            this.bgwSHA256.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSHA256_DoWork);
            this.bgwSHA256.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSHA256_ProgressChanged);
            this.bgwSHA256.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSHA256_RunWorkerCompleted);
            // 
            // bgwSHA384
            // 
            this.bgwSHA384.WorkerReportsProgress = true;
            this.bgwSHA384.WorkerSupportsCancellation = true;
            this.bgwSHA384.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSHA384_DoWork);
            this.bgwSHA384.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSHA384_ProgressChanged);
            this.bgwSHA384.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSHA384_RunWorkerCompleted);
            // 
            // bgwSHA512
            // 
            this.bgwSHA512.WorkerReportsProgress = true;
            this.bgwSHA512.WorkerSupportsCancellation = true;
            this.bgwSHA512.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSHA512_DoWork);
            this.bgwSHA512.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSHA512_ProgressChanged);
            this.bgwSHA512.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSHA512_RunWorkerCompleted);
            // 
            // bgwRIPEMD160
            // 
            this.bgwRIPEMD160.WorkerReportsProgress = true;
            this.bgwRIPEMD160.WorkerSupportsCancellation = true;
            this.bgwRIPEMD160.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRIPEMD160_DoWork);
            this.bgwRIPEMD160.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRIPEMD160_ProgressChanged);
            this.bgwRIPEMD160.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRIPEMD160_RunWorkerCompleted);
            // 
            // HashFile
            // 
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(853, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HashFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash File";
            this.Load += new System.EventHandler(this.HashFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ctxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public HashFile()
        {
            InitializeComponent();
        }
        #endregion

        private void HashFile_Load(object sender, EventArgs e)
        {

        }

        #region Background Workers
        private void bgwMD5_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm md5 = MD5.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        md5.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwMD5.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    md5.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeMD5HashString(md5.Hash);
                }
            }
        }

        private void bgwMD5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwMD5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);

            //bgwMD5.IsBusy;
        }

        private void bgwSHA1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm sha1 = SHA1.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha1.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA1.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    sha1.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeSHA1HashString(sha1.Hash);
                }
            }
        }

        private void bgwSHA1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwSHA1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
        }

        private void bgwSHA256_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm sha256 = SHA256.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha256.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA256.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    sha256.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeSHA256HashString(sha256.Hash);
                }
            }
        }

        private void bgwSHA256_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwSHA256_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
        }

        private void bgwSHA384_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm sha384 = SHA384.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha384.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA384.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    sha384.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeSHA384HashString(sha384.Hash);
                }
            }
        }

        private void bgwSHA384_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwSHA384_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
        }

        private void bgwSHA512_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm sha512 = SHA512.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        sha512.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwSHA512.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    sha512.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeSHA512HashString(sha512.Hash);
                }
            }
        }

        private void bgwSHA512_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwSHA512_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
        }

        private void bgwRIPEMD160_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;

            int bytesRead;

            long sizeOfFile, totalBytesToRead = 0;

            using (Stream fileStream = File.OpenRead(filePath))
            {
                sizeOfFile = fileStream.Length;

                using (HashAlgorithm ripemd160 = RIPEMD160.Create())
                {
                    do
                    {
                        buffer = new byte[4096];

                        bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                        totalBytesToRead += bytesRead;

                        ripemd160.TransformBlock(buffer, 0, bytesRead, null, 0);

                        bgwRIPEMD160.ReportProgress((int)((double)totalBytesToRead / sizeOfFile * 100));
                    } while (bytesRead != 0);

                    ripemd160.TransformFinalBlock(buffer, 0, 0);

                    e.Result = MakeRIPEMD160HashString(ripemd160.Hash);
                }
            }
        }

        private void bgwRIPEMD160_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbHashProgess.Visible = true;

            tspbHashProgess.Value = e.ProgressPercentage;

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.Normal, e.ProgressPercentage);

            tslHashProgressValue.Text = $"{ tspbHashProgess.Value.ToString() }%";
        }

        private void bgwRIPEMD160_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tspbHashProgess.Value = 0;

            tspbHashProgess.Visible = false;

            tslHashProgressValue.Text = "";

            klblResult.Text = e.Result.ToString();

            if (kcbShowLength.Checked)
            {
                GetHashLength();
            }

            WindowsAPICodePackModel.UpdateTaskbarProgressbarValue(TaskbarProgressBarState.NoProgress, 0);
        }
        #endregion

        #region Hash Concatenation        
        /// <summary>
        /// Makes the MD5 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        private static string MakeMD5HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder md5 = new StringBuilder(32);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    md5.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    md5.Append(b.ToString("X2").ToLower());
                }
            }

            return md5.ToString();
        }

        /// <summary>
        /// Makes the SHA-1 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        public static string MakeSHA1HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder sha1 = new StringBuilder(40);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    sha1.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    sha1.Append(b.ToString("X2").ToLower());
                }
            }

            return sha1.ToString();
        }

        /// <summary>
        /// Makes the SHA-256 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        public static string MakeSHA256HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder sha256 = new StringBuilder(64);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    sha256.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    sha256.Append(b.ToString("X2").ToLower());
                }
            }

            return sha256.ToString();
        }

        /// <summary>
        /// Makes the SHA-384 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        public static string MakeSHA384HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder sha384 = new StringBuilder(96);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    sha384.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    sha384.Append(b.ToString("X2").ToLower());
                }
            }

            return sha384.ToString();
        }

        /// <summary>
        /// Makes the SHA-512 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        public static string MakeSHA512HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder sha512 = new StringBuilder(128);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    sha512.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    sha512.Append(b.ToString("X2").ToLower());
                }
            }

            return sha512.ToString();
        }

        /// <summary>
        /// Makes the RIPEMD-160 hash string.
        /// </summary>
        /// <param name="hashBytes">The hash bytes.</param>
        /// <param name="toUpper">if set to <c>true</c> [to upper].</param>
        /// <returns></returns>
        public static string MakeRIPEMD160HashString(byte[] hashBytes, bool toUpper = false)
        {
            StringBuilder ripemd160 = new StringBuilder(40);

            foreach (byte b in hashBytes)
            {
                if (toUpper)
                {
                    ripemd160.Append(b.ToString("X2").ToUpper());
                }
                else
                {
                    ripemd160.Append(b.ToString("X2").ToLower());
                }
            }

            return ripemd160.ToString();
        }
        #endregion
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(klblResult.Text);
        }

        private void KbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a file to get the hash:";

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtApplicationExecutable.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void KbtnGenerateFileHash_Click(object sender, EventArgs e)
        {
            if (kcbxHashAlgorithimType.Text == "MD5")
            {
                bgwMD5.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-1")
            {
                bgwSHA1.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-256")
            {
                bgwSHA256.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-384")
            {
                bgwSHA384.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "SHA-512")
            {
                bgwSHA512.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
            else if (kcbxHashAlgorithimType.Text == "RIPEMD-160")
            {
                bgwRIPEMD160.RunWorkerAsync(kptxtApplicationExecutable.Text);
            }
        }

        private void KcbxHashAlgorithimType_SelectedIndexChanged(object sender, EventArgs e)
        {
            kbtnGenerateFileHash.Enabled = true;
        }

        private void GetHashLength()
        {
            MessageBox.Show($"Length of hash: { klblResult.Text.Length.ToString() }");
        }

        private void KbtnVarify_Click(object sender, EventArgs e)
        {
            VarifyFileHash varifyFileHash = new VarifyFileHash(kptxtApplicationExecutable.Text, kcbxHashAlgorithimType.Text, klblResult.Text);

            varifyFileHash.Show();
        }
    }
}