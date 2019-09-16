using ComponentFactory.Krypton.Toolkit;
using KryptonFileCopier.Classes;
using KryptonFileCopier.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KryptonFileCopier.UX
{
    public class CopyFilesDialog : KryptonForm, ICopyFilesDialog
    {
        #region Designer Code
        private ExtendedStandardControls.KryptonButtonExtended kbtneCancel;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.ProgressBar pbCurrentFile;
        private ExtendedStandardControls.KryptonLabelExtended kllblCurrentFile;
        private System.Windows.Forms.ProgressBar pbTotalFiles;
        private ExtendedStandardControls.KryptonLabelExtended klblTotalFiles;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtneCancel = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblTotalFiles = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbTotalFiles = new System.Windows.Forms.ProgressBar();
            this.kllblCurrentFile = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbCurrentFile = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtneCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 146);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(649, 53);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtneCancel
            // 
            this.kbtneCancel.Image = null;
            this.kbtneCancel.Location = new System.Drawing.Point(279, 15);
            this.kbtneCancel.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.Name = "kbtneCancel";
            this.kbtneCancel.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtneCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneCancel.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneCancel.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneCancel.TabIndex = 0;
            this.kbtneCancel.Values.Text = "C&ancel";
            this.kbtneCancel.Click += new System.EventHandler(this.kbtneCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 2);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.pbCurrentFile);
            this.kryptonPanel2.Controls.Add(this.kllblCurrentFile);
            this.kryptonPanel2.Controls.Add(this.pbTotalFiles);
            this.kryptonPanel2.Controls.Add(this.klblTotalFiles);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(649, 144);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // klblTotalFiles
            // 
            this.klblTotalFiles.Image = null;
            this.klblTotalFiles.Location = new System.Drawing.Point(12, 12);
            this.klblTotalFiles.LongTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.Name = "klblTotalFiles";
            this.klblTotalFiles.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.Size = new System.Drawing.Size(90, 26);
            this.klblTotalFiles.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFiles.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFiles.StateDisabled.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFiles.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFiles.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblTotalFiles.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblTotalFiles.TabIndex = 3;
            this.klblTotalFiles.Values.Text = "Total Files";
            // 
            // pbTotalFiles
            // 
            this.pbTotalFiles.Location = new System.Drawing.Point(12, 44);
            this.pbTotalFiles.Name = "pbTotalFiles";
            this.pbTotalFiles.Size = new System.Drawing.Size(625, 23);
            this.pbTotalFiles.TabIndex = 7;
            // 
            // kllblCurrentFile
            // 
            this.kllblCurrentFile.Image = null;
            this.kllblCurrentFile.Location = new System.Drawing.Point(12, 73);
            this.kllblCurrentFile.LongTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.Name = "kllblCurrentFile";
            this.kllblCurrentFile.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.Size = new System.Drawing.Size(102, 26);
            this.kllblCurrentFile.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kllblCurrentFile.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kllblCurrentFile.StateDisabled.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kllblCurrentFile.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kllblCurrentFile.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblCurrentFile.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kllblCurrentFile.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kllblCurrentFile.TabIndex = 8;
            this.kllblCurrentFile.Values.Text = "Current File";
            // 
            // pbCurrentFile
            // 
            this.pbCurrentFile.Location = new System.Drawing.Point(12, 105);
            this.pbCurrentFile.Name = "pbCurrentFile";
            this.pbCurrentFile.Size = new System.Drawing.Size(625, 23);
            this.pbCurrentFile.TabIndex = 9;
            // 
            // CopyFilesDialog
            // 
            this.ClientSize = new System.Drawing.Size(649, 199);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyFilesDialog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CopyFilesDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void Update(int totalFiles, int copiedFiles, long totalBytes, long copiedBytes, string currentFilename)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Constructor
        public CopyFilesDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region Interface Implementation 
        public event CopyFiles.DEL_cancelCopy EN_cancelCopy;

        public ISynchronizeInvoke SynchronizationObject { get; set; }
        #endregion

        #region Methods
        public void update(Int32 totalFiles, Int32 copiedFiles, Int64 totalBytes, Int64 copiedBytes, String currentFilename)
        {
            pbTotalFiles.Maximum = totalFiles;

            pbTotalFiles.Value = copiedFiles;

            pbCurrentFile.Maximum = 100;

            if (totalBytes != 0)
            {
                pbCurrentFile.Value = Convert.ToInt32((100f / (totalBytes / 1024f)) * (copiedBytes / 1024f));
            }

            klblTotalFiles.Text = "Total files (" + copiedFiles + "/" + totalFiles + ")";

            kllblCurrentFile.Text = currentFilename;
        }

        private void RaiseCancel()
        {
            if (EN_cancelCopy != null)
            {
                EN_cancelCopy();
            }
        }
        #endregion

        private void kbtneCancel_Click(object sender, EventArgs e)
        {
            RaiseCancel();
        }

        private void CopyFilesDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            RaiseCancel();
        }
    }
}