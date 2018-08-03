namespace Tooling.UX.SysInfo
{
    partial class SystemInformationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemInformationWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.krtbSystemInformation = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.krtbCPUInformation = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.krtbVideoInformation = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.krtbLocalDrivesInformation = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonPage5 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.klstMoreInformation = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kbtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kcmbClass = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateInRealTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrRealTimeUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            this.kryptonPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).BeginInit();
            this.kryptonPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbClass)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 798);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnClose
            // 
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.Location = new System.Drawing.Point(697, 756);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 1;
            this.kbtnClose.Values.Text = "C&lose";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Location = new System.Drawing.Point(12, 12);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2,
            this.kryptonPage3,
            this.kryptonPage4,
            this.kryptonPage5});
            this.kryptonNavigator1.SelectedIndex = 4;
            this.kryptonNavigator1.Size = new System.Drawing.Size(776, 732);
            this.kryptonNavigator1.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.krtbSystemInformation);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(774, 699);
            this.kryptonPage1.Text = "System";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "52A80FE93F9648674DAA3B958E5EEAE3";
            // 
            // krtbSystemInformation
            // 
            this.krtbSystemInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbSystemInformation.Location = new System.Drawing.Point(0, 0);
            this.krtbSystemInformation.Name = "krtbSystemInformation";
            this.krtbSystemInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbSystemInformation.Size = new System.Drawing.Size(774, 699);
            this.krtbSystemInformation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbSystemInformation.TabIndex = 1;
            this.krtbSystemInformation.Text = "";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.krtbCPUInformation);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(774, 699);
            this.kryptonPage2.Text = "CPU";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "AF3BD15EEE494D712799EDA8503D850E";
            // 
            // krtbCPUInformation
            // 
            this.krtbCPUInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbCPUInformation.Location = new System.Drawing.Point(0, 0);
            this.krtbCPUInformation.Name = "krtbCPUInformation";
            this.krtbCPUInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbCPUInformation.Size = new System.Drawing.Size(774, 699);
            this.krtbCPUInformation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbCPUInformation.TabIndex = 1;
            this.krtbCPUInformation.Text = "";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Controls.Add(this.krtbVideoInformation);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(774, 699);
            this.kryptonPage3.Text = "Video";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "2502D0D0948B48EAA1A4DF94B9393C51";
            // 
            // krtbVideoInformation
            // 
            this.krtbVideoInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbVideoInformation.Location = new System.Drawing.Point(0, 0);
            this.krtbVideoInformation.Name = "krtbVideoInformation";
            this.krtbVideoInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbVideoInformation.Size = new System.Drawing.Size(774, 699);
            this.krtbVideoInformation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbVideoInformation.TabIndex = 1;
            this.krtbVideoInformation.Text = "";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Controls.Add(this.krtbLocalDrivesInformation);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(774, 699);
            this.kryptonPage4.Text = "Local Drives";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "0E6E7473C4AF4658239BBFE1BE865410";
            // 
            // krtbLocalDrivesInformation
            // 
            this.krtbLocalDrivesInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.krtbLocalDrivesInformation.Location = new System.Drawing.Point(0, 0);
            this.krtbLocalDrivesInformation.Name = "krtbLocalDrivesInformation";
            this.krtbLocalDrivesInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtbLocalDrivesInformation.Size = new System.Drawing.Size(774, 699);
            this.krtbLocalDrivesInformation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbLocalDrivesInformation.TabIndex = 1;
            this.krtbLocalDrivesInformation.Text = "";
            // 
            // kryptonPage5
            // 
            this.kryptonPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage5.Controls.Add(this.klstMoreInformation);
            this.kryptonPage5.Controls.Add(this.kbtnSave);
            this.kryptonPage5.Controls.Add(this.kcmbClass);
            this.kryptonPage5.Controls.Add(this.kryptonLabel1);
            this.kryptonPage5.Flags = 65534;
            this.kryptonPage5.LastVisibleSet = true;
            this.kryptonPage5.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage5.Name = "kryptonPage5";
            this.kryptonPage5.Size = new System.Drawing.Size(774, 699);
            this.kryptonPage5.Text = "More";
            this.kryptonPage5.ToolTipTitle = "Page ToolTip";
            this.kryptonPage5.UniqueName = "D7CDD629AF9D4B7AB886B5D66381737C";
            // 
            // klstMoreInformation
            // 
            this.klstMoreInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.klstMoreInformation.Location = new System.Drawing.Point(0, 49);
            this.klstMoreInformation.Name = "klstMoreInformation";
            this.klstMoreInformation.ScrollAlwaysVisible = true;
            this.klstMoreInformation.Size = new System.Drawing.Size(774, 650);
            this.klstMoreInformation.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstMoreInformation.TabIndex = 5;
            // 
            // kbtnSave
            // 
            this.kbtnSave.AutoSize = true;
            this.kbtnSave.Enabled = false;
            this.kbtnSave.Location = new System.Drawing.Point(346, 15);
            this.kbtnSave.Name = "kbtnSave";
            this.kbtnSave.Size = new System.Drawing.Size(90, 28);
            this.kbtnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSave.TabIndex = 4;
            this.kbtnSave.Values.Text = "&Save";
            // 
            // kcmbClass
            // 
            this.kcmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbClass.DropDownWidth = 121;
            this.kcmbClass.Location = new System.Drawing.Point(120, 16);
            this.kcmbClass.Name = "kcmbClass";
            this.kcmbClass.Size = new System.Drawing.Size(219, 25);
            this.kcmbClass.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbClass.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(100, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Select Class:";
            // 
            // ctxMenu
            // 
            this.ctxMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInRealTimeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.copyInformationToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(181, 54);
            // 
            // updateInRealTimeToolStripMenuItem
            // 
            this.updateInRealTimeToolStripMenuItem.CheckOnClick = true;
            this.updateInRealTimeToolStripMenuItem.Name = "updateInRealTimeToolStripMenuItem";
            this.updateInRealTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateInRealTimeToolStripMenuItem.Text = "Update in &Real Time";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // copyInformationToolStripMenuItem
            // 
            this.copyInformationToolStripMenuItem.Name = "copyInformationToolStripMenuItem";
            this.copyInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyInformationToolStripMenuItem.Text = "&Copy Information";
            // 
            // tmrRealTimeUpdater
            // 
            this.tmrRealTimeUpdater.Interval = 250;
            // 
            // SystemInformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 798);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemInformationWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.SystemInformationWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            this.kryptonPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).EndInit();
            this.kryptonPage5.ResumeLayout(false);
            this.kryptonPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbClass)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnClose;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage5;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbSystemInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbCPUInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbVideoInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbLocalDrivesInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kcmbClass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox klstMoreInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem updateInRealTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyInformationToolStripMenuItem;
        private System.Windows.Forms.Timer tmrRealTimeUpdater;
    }
}