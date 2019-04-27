using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace ExtendedFileDialogs.UI.Palette
{
    public class OpenKryptonPaletteFile : KryptonForm
    {
        #region Design Code
        private KryptonPanel kryptonPanel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnOpen;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnBrowse;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kptxtKryptonPaletteFilePath;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kptxtKryptonPaletteFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOpen);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 53);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(906, 55);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel2.Controls.Add(this.kptxtKryptonPaletteFilePath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(906, 52);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 1);
            this.panel1.TabIndex = 2;
            // 
            // kbtnOpen
            // 
            this.kbtnOpen.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.kbtnOpen.Enabled = false;
            this.kbtnOpen.Location = new System.Drawing.Point(708, 15);
            this.kbtnOpen.Name = "kbtnOpen";
            this.kbtnOpen.Size = new System.Drawing.Size(90, 28);
            this.kbtnOpen.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOpen.TabIndex = 3;
            this.kbtnOpen.Values.Text = "O&pen";
            this.kbtnOpen.Click += new System.EventHandler(this.kbtnOpen_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(804, 15);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 28);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 2;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kptxtKryptonPaletteFilePath
            // 
            this.kptxtKryptonPaletteFilePath.DrawPrompt = true;
            this.kptxtKryptonPaletteFilePath.FocusSelect = true;
            this.kptxtKryptonPaletteFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtKryptonPaletteFilePath.Location = new System.Drawing.Point(106, 12);
            this.kptxtKryptonPaletteFilePath.MaxLength = 256;
            this.kptxtKryptonPaletteFilePath.Name = "kptxtKryptonPaletteFilePath";
            this.kptxtKryptonPaletteFilePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtKryptonPaletteFilePath.PromptText = "Enter filename...";
            this.kptxtKryptonPaletteFilePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtKryptonPaletteFilePath.Size = new System.Drawing.Size(752, 27);
            this.kptxtKryptonPaletteFilePath.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 24);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "File Name:";
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.DialogResult = System.Windows.Forms.DialogResult.No;
            this.kbtnBrowse.Location = new System.Drawing.Point(864, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(31, 27);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 11;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // OpenKryptonPaletteFile
            // 
            this.ClientSize = new System.Drawing.Size(906, 108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenKryptonPaletteFile";
            this.Load += new System.EventHandler(this.OpenKryptonPaletteFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string _paletteFileName;
        private KryptonPalette _kryptonPalette = new KryptonPalette();
        #endregion

        #region Properties
        public string PaletteFileName { get => _paletteFileName; set => _paletteFileName = value; }
        #endregion

        #region Constructors
        public OpenKryptonPaletteFile()
        {
            InitializeComponent();
        }
        #endregion

        private void OpenKryptonPaletteFile_Load(object sender, EventArgs e)
        {

        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a Krypton Palette File:";

            cofd.Filters.Add(new CommonFileDialogFilter("Krypton Palette Files", "*.xml"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtKryptonPaletteFilePath.Text = Path.GetFullPath(cofd.FileName);

                PaletteFileName = Path.GetFullPath(cofd.FileName);
            }

            kbtnOpen.Enabled = true;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void kbtnOpen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }
    }
}