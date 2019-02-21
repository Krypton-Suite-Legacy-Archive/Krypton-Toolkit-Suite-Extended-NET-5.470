using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Security.FileHashing
{
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
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgwMD5;
        private BackgroundWorker bgwSHA1;
        private BackgroundWorker bgwSHA256;
        private BackgroundWorker bgwSHA384;
        private BackgroundWorker bgwSHA512;
        private BackgroundWorker bgwRIPEMD160;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kptxtApplicationExecutable = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbxHashAlgorithimType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblResult = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnGenerateFileHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ctxResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnSaveHash = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwMD5 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA1 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA256 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA384 = new System.ComponentModel.BackgroundWorker();
            this.bgwSHA512 = new System.ComponentModel.BackgroundWorker();
            this.bgwRIPEMD160 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).BeginInit();
            this.ctxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
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
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(800, 44);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(35, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 3;
            this.kbtnBrowse.Values.Text = "...";
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
            this.kryptonPanel2.Controls.Add(this.kbtnSaveHash);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Controls.Add(this.ss);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 343);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(853, 84);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.ss.Location = new System.Drawing.Point(0, 62);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(853, 22);
            this.ss.TabIndex = 0;
            this.ss.Text = "statusStrip1";
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(705, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "{0}%";
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
            this.MaximizeBox = false;
            this.Name = "HashFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HashFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxHashAlgorithimType)).EndInit();
            this.ctxResult.ResumeLayout(false);
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

        private void bgwMD5_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwMD5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwMD5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bgwSHA1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwSHA1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwSHA1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bgwSHA256_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwSHA256_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwSHA256_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bgwSHA384_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwSHA384_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwSHA384_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bgwSHA512_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwSHA512_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwSHA512_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bgwRIPEMD160_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwRIPEMD160_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgwRIPEMD160_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}