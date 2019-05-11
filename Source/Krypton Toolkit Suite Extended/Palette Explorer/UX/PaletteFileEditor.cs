#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Enumerations;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using System;
using System.Windows.Forms;

namespace PaletteExplorer.UX
{
    public class PaletteFileEditor : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private ScintillaNET.Scintilla scEdit;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslCurrentStatus;
        private KryptonButton kbtnOpen;
        private KryptonButton kbtnSaveFile;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnCreate;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonSliderBar ksbZoomLevel;
        private System.Windows.Forms.ToolStripStatusLabel tsslCurrentZoomLevel;
        private System.Windows.Forms.Panel pnlSplitter;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.scEdit = new ScintillaNET.Scintilla();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSaveFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ksbZoomLevel = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonSliderBar();
            this.tsslCurrentZoomLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.scEdit);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(870, 729);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // scEdit
            // 
            this.scEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scEdit.Lexer = ScintillaNET.Lexer.Xml;
            this.scEdit.Location = new System.Drawing.Point(12, 12);
            this.scEdit.Name = "scEdit";
            this.scEdit.Size = new System.Drawing.Size(846, 697);
            this.scEdit.TabIndex = 0;
            this.scEdit.Technology = ScintillaNET.Technology.DirectWrite;
            this.scEdit.TextChanged += new System.EventHandler(this.scEdit_TextChanged);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnCreate);
            this.kryptonPanel2.Controls.Add(this.kbtnOpen);
            this.kryptonPanel2.Controls.Add(this.kbtnSaveFile);
            this.kryptonPanel2.Controls.Add(this.kbtnOk);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Controls.Add(this.statusStrip1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 732);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(870, 71);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnCreate.Location = new System.Drawing.Point(258, 8);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(155, 29);
            this.kbtnCreate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.TabIndex = 19;
            this.kbtnCreate.Values.Text = "C&reate New File...";
            this.kbtnCreate.Click += new System.EventHandler(this.kbtnCreate_Click);
            // 
            // kbtnOpen
            // 
            this.kbtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnOpen.Location = new System.Drawing.Point(12, 8);
            this.kbtnOpen.Name = "kbtnOpen";
            this.kbtnOpen.Size = new System.Drawing.Size(117, 29);
            this.kbtnOpen.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOpen.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOpen.TabIndex = 18;
            this.kbtnOpen.Values.Text = "&Open";
            this.kbtnOpen.Click += new System.EventHandler(this.kbtnOpen_Click);
            // 
            // kbtnSaveFile
            // 
            this.kbtnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnSaveFile.Enabled = false;
            this.kbtnSaveFile.Location = new System.Drawing.Point(135, 8);
            this.kbtnSaveFile.Name = "kbtnSaveFile";
            this.kbtnSaveFile.Size = new System.Drawing.Size(117, 29);
            this.kbtnSaveFile.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveFile.TabIndex = 17;
            this.kbtnSaveFile.Values.Text = "S&ave File...";
            this.kbtnSaveFile.Click += new System.EventHandler(this.kbtnSaveFile_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(618, 8);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(117, 29);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 16;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(741, 8);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 15;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCurrentStatus,
            this.ksbZoomLevel,
            this.tsslCurrentZoomLevel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 48);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(870, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslCurrentStatus
            // 
            this.tslCurrentStatus.Name = "tslCurrentStatus";
            this.tslCurrentStatus.Size = new System.Drawing.Size(715, 18);
            this.tslCurrentStatus.Spring = true;
            this.tslCurrentStatus.Text = "Ready";
            this.tslCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ksbZoomLevel
            // 
            this.ksbZoomLevel.BackColor = System.Drawing.Color.Transparent;
            this.ksbZoomLevel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksbZoomLevel.Name = "ksbZoomLevel";
            this.ksbZoomLevel.Size = new System.Drawing.Size(140, 21);
            this.ksbZoomLevel.Steps = 2;
            this.ksbZoomLevel.Text = "kryptonSliderBar1";
            this.ksbZoomLevel.TrackerSize = new System.Drawing.Size(140, 21);
            this.ksbZoomLevel.ValueChanged += new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonSliderBar.ValueChangedEventHandler(this.ksbZoomLevel_ValueChanged);
            // 
            // tsslCurrentZoomLevel
            // 
            this.tsslCurrentZoomLevel.Name = "tsslCurrentZoomLevel";
            this.tsslCurrentZoomLevel.Size = new System.Drawing.Size(0, 18);
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 729);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(870, 3);
            this.pnlSplitter.TabIndex = 2;
            // 
            // PaletteFileEditor
            // 
            this.ClientSize = new System.Drawing.Size(870, 803);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "PaletteFileEditor";
            this.Load += new System.EventHandler(this.PaletteFileEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string _paletteFileName, _cleanFileContent;
        private Timer _updateUI;
        private KryptonPalette _palette = new KryptonPalette();
        #endregion

        #region Properties
        public string CleanFileContent { get => _cleanFileContent; set => _cleanFileContent = value; }

        public string PaletteFileName { get => _paletteFileName; set => _paletteFileName = value; }
        #endregion

        #region Constructors
        public PaletteFileEditor()
        {
            InitializeComponent();

            _updateUI = new Timer();

            _updateUI.Interval = 250;

            _updateUI.Enabled = true;

            _updateUI.Tick += UpdateUI_Tick;
        }

        public PaletteFileEditor(string paletteFilePath)
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCreate_Click(object sender, EventArgs e)
        {
            DialogResult result = ExtendedKryptonMessageBox.Show("Do you want to create a new palette file?", "Create New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            UpdateStatus(PaletteFileEditorStatusIndicator.CREATENEWFILE);

            if (result == DialogResult.Yes)
            {
                CreateNewFile();

                UpdateStatus(PaletteFileEditorStatusIndicator.READY);
            }
        }

        private void kbtnOpen_Click(object sender, EventArgs e)
        {

        }

        private void kbtnSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void ksbZoomLevel_ValueChanged(ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonToolbarSlider sender, ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToolbarItems.KryptonToolbarSlider.SliderEventArgs e)
        {
            ChangeZoomLevel(ksbZoomLevel.Value);
        }

        private void scEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaletteFileEditor_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Methods
        private void CreateNewFile()
        {
            CleanFileContent = Properties.Resources.NewPaletteFile;

            scEdit.Text = CleanFileContent;
        }

        private void UpdateTitle(string messageText, bool edited = false)
        {
            Text = ReturnTitle(messageText, edited);
        }

        private string ReturnTitle(string messageText)
        {
            string tempString = Text;

            return $"{ tempString } - [{ messageText }]";
        }

        private string ReturnTitle(string messageText, bool edited)
        {
            string tempString = Text;

            if (edited)
            {
                return $"{ tempString } - [{ messageText }] *";
            }
            else
            {
                return ReturnTitle(messageText);
            }
        }

        private void UpdateStatus(PaletteFileEditorStatusIndicator indicator, string text = "", int zoomLevel = 0)
        {
            switch (indicator)
            {
                case PaletteFileEditorStatusIndicator.CREATENEWFILE:
                    tslCurrentStatus.Text = "Creating a new palette file...";
                    break;
                case PaletteFileEditorStatusIndicator.CHANGEZOOMLEVEL:
                    tslCurrentStatus.Text = $"Changing editor zoom level to: { zoomLevel.ToString() }%";
                    break;
                case PaletteFileEditorStatusIndicator.READY:
                    tslCurrentStatus.Text = "Ready";
                    break;
                case PaletteFileEditorStatusIndicator.OPENFILE:
                    tslCurrentStatus.Text = $"Opening file: [{ text }]";
                    break;
                case PaletteFileEditorStatusIndicator.SAVEFILE:
                    tslCurrentStatus.Text = $"Saving file: [{ text }]";
                    break;
            }
        }

        private void ChangeZoomLevel(int zoomLevel)
        {
            tsslCurrentZoomLevel.Text = $"{ zoomLevel.ToString() }%";

            scEdit.Zoom = zoomLevel;

            UpdateStatus(PaletteFileEditorStatusIndicator.CHANGEZOOMLEVEL, "", zoomLevel);
        }
        #endregion
    }
}