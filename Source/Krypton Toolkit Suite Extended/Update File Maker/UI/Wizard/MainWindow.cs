using ComponentFactory.Krypton.Toolkit;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace UpdateFileMaker.UI.Wizard
{
    public class MainWindow : KryptonForm
    {
        #region Designer Code
        private ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard kwUpdate;

        private void InitializeComponent()
        {
            this.kwUpdate = new ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard();
            this.wizardPage2 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.wizardPage1 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.wizardPage4 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizardPage3 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kwUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).BeginInit();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).BeginInit();
            this.SuspendLayout();
            // 
            // kwUpdate
            // 
            this.kwUpdate.Controls.Add(this.wizardPage2);
            this.kwUpdate.Controls.Add(this.wizardPage1);
            this.kwUpdate.Controls.Add(this.wizardPage4);
            this.kwUpdate.Controls.Add(this.wizardPage3);
            this.kwUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kwUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwUpdate.Location = new System.Drawing.Point(0, 0);
            this.kwUpdate.Name = "kwUpdate";
            this.kwUpdate.Pages.AddRange(new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4});
            this.kwUpdate.Size = new System.Drawing.Size(1004, 628);
            this.kwUpdate.TabIndex = 0;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.kryptonLabel3);
            this.wizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage2.IsFinishPage = false;
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(1004, 580);
            this.wizardPage2.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(117, 124);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(151, 26);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Application Name:";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.kryptonLabel2);
            this.wizardPage1.Controls.Add(this.kryptonLabel1);
            this.wizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage1.IsFinishPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(1004, 580);
            this.wizardPage1.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(80, 178);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(228, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "To begin, click \'Next\'";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(46, 127);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(596, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Welcome to the aplication file update file maker wizard...";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage4.IsFinishPage = false;
            this.wizardPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(1215, 772);
            this.wizardPage4.TabIndex = 5;
            // 
            // wizardPage3
            // 
            this.wizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage3.IsFinishPage = false;
            this.wizardPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(1215, 772);
            this.wizardPage3.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1004, 628);
            this.Controls.Add(this.kwUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update File Maker";
            this.kwUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).EndInit();
            this.ResumeLayout(false);

        }

        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage1;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage2;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage3;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage4;
        private KryptonLabel kryptonLabel3;
        #endregion

        #region Variables
        private Version _applicationVersion = Assembly.GetExecutingAssembly().GetName().Version;
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            TextExtra = $"(Alpha - Version: { _applicationVersion.ToString() })";
        }
        #endregion
    }
}