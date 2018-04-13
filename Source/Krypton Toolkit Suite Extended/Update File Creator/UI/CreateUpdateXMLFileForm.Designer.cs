namespace UpdateFileCreator.UI
{
    partial class CreateUpdateXMLFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateXMLFileForm));
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnViewUpdateXMLFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.knavUpdateData = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpBasicInformation = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.ktxtUpdatePackageFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ktxtUpdateXMLFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnGetFileDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowseForUpdatePackageFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowseForUpdateXMLFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.klblWordCounter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnBasicInformationNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knavUpdateData)).BeginInit();
            this.knavUpdateData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpBasicInformation)).BeginInit();
            this.kpBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kbtnViewUpdateXMLFile);
            this.kpnlBackground.Controls.Add(this.knavUpdateData);
            this.kpnlBackground.Controls.Add(this.ktxtUpdatePackageFilePath);
            this.kpnlBackground.Controls.Add(this.ktxtUpdateXMLFilePath);
            this.kpnlBackground.Controls.Add(this.kbtnGetFileDetails);
            this.kpnlBackground.Controls.Add(this.kbtnBrowseForUpdatePackageFile);
            this.kpnlBackground.Controls.Add(this.kbtnBrowseForUpdateXMLFile);
            this.kpnlBackground.Controls.Add(this.kbtnCreate);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.kryptonLabel2);
            this.kpnlBackground.Controls.Add(this.kryptonLabel1);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(1848, 888);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kbtnViewUpdateXMLFile
            // 
            this.kbtnViewUpdateXMLFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnViewUpdateXMLFile.AutoSize = true;
            this.kbtnViewUpdateXMLFile.Enabled = false;
            this.kbtnViewUpdateXMLFile.Location = new System.Drawing.Point(1179, 846);
            this.kbtnViewUpdateXMLFile.Name = "kbtnViewUpdateXMLFile";
            this.kbtnViewUpdateXMLFile.Size = new System.Drawing.Size(183, 30);
            this.kbtnViewUpdateXMLFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnViewUpdateXMLFile.TabIndex = 11;
            this.kbtnViewUpdateXMLFile.Values.Text = "&View Update XML File";
            // 
            // knavUpdateData
            // 
            this.knavUpdateData.Location = new System.Drawing.Point(12, 82);
            this.knavUpdateData.Name = "knavUpdateData";
            this.knavUpdateData.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kpBasicInformation,
            this.kryptonPage2});
            this.knavUpdateData.SelectedIndex = 0;
            this.knavUpdateData.Size = new System.Drawing.Size(1824, 758);
            this.knavUpdateData.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knavUpdateData.TabIndex = 10;
            this.knavUpdateData.Text = "kryptonNavigator1";
            // 
            // kpBasicInformation
            // 
            this.kpBasicInformation.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpBasicInformation.Controls.Add(this.kbtnBasicInformationNext);
            this.kpBasicInformation.Controls.Add(this.klblWordCounter);
            this.kpBasicInformation.Controls.Add(this.kryptonRichTextBox1);
            this.kpBasicInformation.Controls.Add(this.kryptonLabel5);
            this.kpBasicInformation.Controls.Add(this.kryptonTextBox2);
            this.kpBasicInformation.Controls.Add(this.kryptonLabel4);
            this.kpBasicInformation.Controls.Add(this.kryptonTextBox1);
            this.kpBasicInformation.Controls.Add(this.kryptonLabel3);
            this.kpBasicInformation.Flags = 65534;
            this.kpBasicInformation.LastVisibleSet = true;
            this.kpBasicInformation.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpBasicInformation.Name = "kpBasicInformation";
            this.kpBasicInformation.Size = new System.Drawing.Size(1822, 731);
            this.kpBasicInformation.Text = "Basic Package Information";
            this.kpBasicInformation.ToolTipTitle = "Page ToolTip";
            this.kpBasicInformation.UniqueName = "4BEB977043CD49A506B26C3AFB72ECD8";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "0994CAA52FE74112C08AB8A07D655E32";
            // 
            // ktxtUpdatePackageFilePath
            // 
            this.ktxtUpdatePackageFilePath.Location = new System.Drawing.Point(231, 47);
            this.ktxtUpdatePackageFilePath.Name = "ktxtUpdatePackageFilePath";
            this.ktxtUpdatePackageFilePath.Size = new System.Drawing.Size(1567, 29);
            this.ktxtUpdatePackageFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtUpdatePackageFilePath.TabIndex = 9;
            this.ktxtUpdatePackageFilePath.Text = ".\\Update.exe";
            // 
            // ktxtUpdateXMLFilePath
            // 
            this.ktxtUpdateXMLFilePath.Location = new System.Drawing.Point(263, 12);
            this.ktxtUpdateXMLFilePath.Name = "ktxtUpdateXMLFilePath";
            this.ktxtUpdateXMLFilePath.Size = new System.Drawing.Size(1535, 29);
            this.ktxtUpdateXMLFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtUpdateXMLFilePath.TabIndex = 8;
            this.ktxtUpdateXMLFilePath.Text = ".\\Update.xml";
            // 
            // kbtnGetFileDetails
            // 
            this.kbtnGetFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnGetFileDetails.AutoSize = true;
            this.kbtnGetFileDetails.Enabled = false;
            this.kbtnGetFileDetails.Location = new System.Drawing.Point(1368, 846);
            this.kbtnGetFileDetails.Name = "kbtnGetFileDetails";
            this.kbtnGetFileDetails.Size = new System.Drawing.Size(183, 30);
            this.kbtnGetFileDetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetFileDetails.TabIndex = 6;
            this.kbtnGetFileDetails.Values.Text = "&Get Update File Details";
            // 
            // kbtnBrowseForUpdatePackageFile
            // 
            this.kbtnBrowseForUpdatePackageFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowseForUpdatePackageFile.AutoSize = true;
            this.kbtnBrowseForUpdatePackageFile.Location = new System.Drawing.Point(1804, 48);
            this.kbtnBrowseForUpdatePackageFile.Name = "kbtnBrowseForUpdatePackageFile";
            this.kbtnBrowseForUpdatePackageFile.Size = new System.Drawing.Size(32, 30);
            this.kbtnBrowseForUpdatePackageFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseForUpdatePackageFile.TabIndex = 5;
            this.kbtnBrowseForUpdatePackageFile.Values.Text = "...";
            this.kbtnBrowseForUpdatePackageFile.Click += new System.EventHandler(this.kbtnBrowseForUpdatePackageFile_Click);
            // 
            // kbtnBrowseForUpdateXMLFile
            // 
            this.kbtnBrowseForUpdateXMLFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowseForUpdateXMLFile.AutoSize = true;
            this.kbtnBrowseForUpdateXMLFile.Location = new System.Drawing.Point(1804, 12);
            this.kbtnBrowseForUpdateXMLFile.Name = "kbtnBrowseForUpdateXMLFile";
            this.kbtnBrowseForUpdateXMLFile.Size = new System.Drawing.Size(32, 30);
            this.kbtnBrowseForUpdateXMLFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseForUpdateXMLFile.TabIndex = 4;
            this.kbtnBrowseForUpdateXMLFile.Values.Text = "...";
            this.kbtnBrowseForUpdateXMLFile.Click += new System.EventHandler(this.kbtnBrowseForUpdateXMLFile_Click);
            // 
            // kbtnCreate
            // 
            this.kbtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCreate.AutoSize = true;
            this.kbtnCreate.Enabled = false;
            this.kbtnCreate.Location = new System.Drawing.Point(1557, 846);
            this.kbtnCreate.Name = "kbtnCreate";
            this.kbtnCreate.Size = new System.Drawing.Size(183, 30);
            this.kbtnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCreate.TabIndex = 3;
            this.kbtnCreate.Values.Text = "Create Update X&ML File";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(1746, 846);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 2;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 44);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(213, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Update Package File Path:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(245, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Update XML Update File Path:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 19);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(146, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Application Name:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(176, 18);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(710, 29);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 1;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(1096, 18);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(710, 29);
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.TabIndex = 3;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(892, 19);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(198, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Application Identification:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(24, 71);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(152, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Update Description";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(24, 107);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(1782, 527);
            this.kryptonRichTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRichTextBox1.TabIndex = 5;
            this.kryptonRichTextBox1.Text = "kryptonRichTextBox1";
            // 
            // klblWordCounter
            // 
            this.klblWordCounter.Location = new System.Drawing.Point(835, 652);
            this.klblWordCounter.Name = "klblWordCounter";
            this.klblWordCounter.Size = new System.Drawing.Size(125, 26);
            this.klblWordCounter.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblWordCounter.TabIndex = 6;
            this.klblWordCounter.Values.Text = "{0} of {1} Words";
            // 
            // kbtnBasicInformationNext
            // 
            this.kbtnBasicInformationNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBasicInformationNext.AutoSize = true;
            this.kbtnBasicInformationNext.Location = new System.Drawing.Point(1717, 676);
            this.kbtnBasicInformationNext.Name = "kbtnBasicInformationNext";
            this.kbtnBasicInformationNext.Size = new System.Drawing.Size(89, 30);
            this.kbtnBasicInformationNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBasicInformationNext.TabIndex = 7;
            this.kbtnBasicInformationNext.Values.Text = "&Next";
            // 
            // CreateUpdateXMLFileForm
            // 
            this.AcceptButton = this.kbtnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(1848, 888);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUpdateXMLFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUpdateXMLFileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUpdateXMLFileForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knavUpdateData)).EndInit();
            this.knavUpdateData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpBasicInformation)).EndInit();
            this.kpBasicInformation.ResumeLayout(false);
            this.kpBasicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCreate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnBrowseForUpdatePackageFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnBrowseForUpdateXMLFile;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtUpdatePackageFilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtUpdateXMLFilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnGetFileDetails;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator knavUpdateData;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpBasicInformation;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnViewUpdateXMLFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnBasicInformationNext;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblWordCounter;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
    }
}