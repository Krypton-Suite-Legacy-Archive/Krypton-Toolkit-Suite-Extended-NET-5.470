#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

namespace Playground
{
    public class KryptonWizardExample : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard kryptonWizard1;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage4;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage3;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage2;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage1;

        private void InitializeComponent()
        {
            this.kryptonWizard1 = new ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard();
            this.wizardPage1 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizardPage2 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizardPage3 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizardPage4 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonWizard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonWizard1
            // 
            this.kryptonWizard1.Controls.Add(this.wizardPage3);
            this.kryptonWizard1.Controls.Add(this.wizardPage4);
            this.kryptonWizard1.Controls.Add(this.wizardPage2);
            this.kryptonWizard1.Controls.Add(this.wizardPage1);
            this.kryptonWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonWizard1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonWizard1.Location = new System.Drawing.Point(0, 0);
            this.kryptonWizard1.Name = "kryptonWizard1";
            this.kryptonWizard1.Pages.AddRange(new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4});
            this.kryptonWizard1.Size = new System.Drawing.Size(1138, 785);
            this.kryptonWizard1.TabIndex = 0;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage1.IsFinishPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(444, 224);
            this.wizardPage1.TabIndex = 2;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage2.IsFinishPage = false;
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(444, 224);
            this.wizardPage2.TabIndex = 3;
            // 
            // wizardPage3
            // 
            this.wizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage3.IsFinishPage = false;
            this.wizardPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(1138, 737);
            this.wizardPage3.TabIndex = 4;
            // 
            // wizardPage4
            // 
            this.wizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage4.IsFinishPage = false;
            this.wizardPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(1138, 737);
            this.wizardPage4.TabIndex = 5;
            // 
            // KryptonWizardExample
            // 
            this.ClientSize = new System.Drawing.Size(1138, 785);
            this.Controls.Add(this.kryptonWizard1);
            this.Name = "KryptonWizardExample";
            this.kryptonWizard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).EndInit();
            this.ResumeLayout(false);

        }
    }
}