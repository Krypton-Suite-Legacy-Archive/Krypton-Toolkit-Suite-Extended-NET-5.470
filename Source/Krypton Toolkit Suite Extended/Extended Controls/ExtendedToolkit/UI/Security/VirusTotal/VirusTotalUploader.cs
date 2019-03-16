using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using ExtendedControls.Base.Code.Security;
using ExtendedControls.Base.Code.Settings;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Security.VirusTotal
{
    public class VirusTotalUploader : KryptonForm
    {
        private KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Panel panel1;
        private Controls.KryptonPromptTextBox kptxtFilePath;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnBrowse;
        private KryptonButton kbtnOptions;
        private KryptonButton kbtnSubmit;
        private KryptonButton kbtnCancel;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues10 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kptxtFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.kptxtFilePath);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(847, 61);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(797, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(38, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 11;
            popupPositionValues6.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues6.PlacementTarget = null;
            this.kbtnBrowse.ToolTipValues.ToolTipPosition = popupPositionValues6;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // kptxtFilePath
            // 
            this.kptxtFilePath.DrawPrompt = true;
            this.kptxtFilePath.FocusSelect = true;
            this.kptxtFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFilePath.Location = new System.Drawing.Point(101, 12);
            this.kptxtFilePath.Name = "kptxtFilePath";
            this.kptxtFilePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtFilePath.PromptText = "Enter a file path...";
            this.kptxtFilePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFilePath.Size = new System.Drawing.Size(690, 29);
            this.kptxtFilePath.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            popupPositionValues7.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues7.PlacementTarget = null;
            this.kryptonLabel1.ToolTipValues.ToolTipPosition = popupPositionValues7;
            this.kryptonLabel1.Values.Text = "File Path:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnOptions);
            this.kryptonPanel2.Controls.Add(this.kbtnSubmit);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 62);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(847, 46);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kbtnOptions
            // 
            this.kbtnOptions.Location = new System.Drawing.Point(12, 5);
            this.kbtnOptions.Name = "kbtnOptions";
            this.kbtnOptions.Size = new System.Drawing.Size(117, 29);
            this.kbtnOptions.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOptions.TabIndex = 13;
            popupPositionValues8.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues8.PlacementTarget = null;
            this.kbtnOptions.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.kbtnOptions.Values.Text = "&Options";
            this.kbtnOptions.Click += new System.EventHandler(this.kbtnOptions_Click);
            // 
            // kbtnSubmit
            // 
            this.kbtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnSubmit.Enabled = false;
            this.kbtnSubmit.Location = new System.Drawing.Point(549, 5);
            this.kbtnSubmit.Name = "kbtnSubmit";
            this.kbtnSubmit.Size = new System.Drawing.Size(163, 29);
            this.kbtnSubmit.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSubmit.TabIndex = 12;
            popupPositionValues9.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues9.PlacementTarget = null;
            this.kbtnSubmit.ToolTipValues.ToolTipPosition = popupPositionValues9;
            this.kbtnSubmit.Values.Text = "Upload && &Analyse";
            this.kbtnSubmit.Click += new System.EventHandler(this.kbtnSubmit_ClickAsync);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(718, 5);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 11;
            popupPositionValues10.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues10.PlacementTarget = null;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues10;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 47);
            this.panel1.TabIndex = 1;
            // 
            // VirusTotalUploader
            // 
            this.ClientSize = new System.Drawing.Size(847, 108);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "VirusTotalUploader";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public VirusTotalUploader()
        {
            InitializeComponent();
        }

        private async void kbtnSubmit_ClickAsync(object sender, EventArgs e)
        {
            await RunScan(kptxtFilePath.Text);
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Filters.Add(new CommonFileDialogFilter("All Valid Files", "*.*"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kptxtFilePath.Text = Path.GetFullPath(cofd.FileName);

                kbtnSubmit.Enabled = true;
            }
        }

        private void kbtnOptions_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private static async Task RunScan(string filePath)
        {
            try
            {
                VirusTotalUploader virusTotalUploader = new VirusTotalUploader();

                VirusTotalAPI virusTotal = new VirusTotalAPI(SettingsManager.GetVirusTotalAPIKey());

                virusTotal.UseTLS = SettingsManager.GetVirusTotalUseTLS();

                byte[] file = File.ReadAllBytes(filePath);

                FileReport report = await virusTotal.GetFileReportAsync(file);

                bool hasBeenSeenBefore = report.ResponseCode == FileReportResponseCode.Present;

                ExtendedKryptonMessageBox.Show($"The file: '{ Path.GetFileName(filePath) }' has been scanned before.", "Scanning File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (hasBeenSeenBefore)
                {
                    virusTotalUploader.ShowResults(report);
                }
                else
                {
                    ScanResult scanResult = await virusTotal.ScanFileAsync(file, filePath + ".vtr");

                    virusTotalUploader.ShowResults(scanResult);
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        private void ShowResults(ScanResult scanResult)
        {
            ReportViewer reportViewer = new ReportViewer(kptxtFilePath.Text);

            reportViewer.ReportBox.Items.Add($"Scan ID: { scanResult.ScanId }");

            reportViewer.ReportBox.Items.Add($"Message: { scanResult.VerboseMsg }");

            reportViewer.Show();
        }

        private void ShowResults(FileReport report)
        {
            ReportViewer reportViewer = new ReportViewer(kptxtFilePath.Text);

            reportViewer.ReportBox.Items.Add($"Scan ID: { report.ScanId }");

            reportViewer.ReportBox.Items.Add($"Message: { report.VerboseMsg }");

            if (report.ResponseCode == FileReportResponseCode.Present)
            {
                foreach (KeyValuePair<string, ScanEngine> scan in report.Scans)
                {
                    reportViewer.ReportBox.Items.Add(string.Format("{0,-25} Detected: {1}", scan.Key, scan.Value.Detected));
                }
            }

            reportViewer.Show();
        }
    }
}