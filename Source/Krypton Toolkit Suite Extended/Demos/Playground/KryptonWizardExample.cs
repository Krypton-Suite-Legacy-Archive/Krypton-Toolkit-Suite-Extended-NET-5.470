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
        private KryptonTextBox kryptonTextBox1;
        private KryptonTextBox kryptonTextBox2;
        private KryptonTextBox kryptonTextBox3;
        private KryptonTextBox kryptonTextBox4;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage1;

        public KryptonWizardExample()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.kryptonWizard1 = new ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard();
            this.wizardPage1 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.wizardPage4 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonTextBox4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.wizardPage3 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.wizardPage2 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWizard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).BeginInit();
            this.wizardPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).BeginInit();
            this.wizardPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).BeginInit();
            this.wizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonWizard1
            // 
            this.kryptonWizard1.Controls.Add(this.wizardPage1);
            this.kryptonWizard1.Controls.Add(this.wizardPage4);
            this.kryptonWizard1.Controls.Add(this.wizardPage3);
            this.kryptonWizard1.Controls.Add(this.wizardPage2);
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
            this.wizardPage1.Controls.Add(this.kryptonTextBox1);
            this.wizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage1.IsFinishPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(1138, 737);
            this.wizardPage1.TabIndex = 2;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(237, 230);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox1.TabIndex = 0;
            this.kryptonTextBox1.Text = "Page - 1";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Controls.Add(this.kryptonTextBox4);
            this.wizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage4.IsFinishPage = false;
            this.wizardPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(1138, 737);
            this.wizardPage4.TabIndex = 5;
            // 
            // kryptonTextBox4
            // 
            this.kryptonTextBox4.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox4.Name = "kryptonTextBox4";
            this.kryptonTextBox4.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox4.TabIndex = 0;
            this.kryptonTextBox4.Text = "Page - 4";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.kryptonTextBox3);
            this.wizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage3.IsFinishPage = false;
            this.wizardPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(1138, 737);
            this.wizardPage3.TabIndex = 4;
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox3.TabIndex = 0;
            this.kryptonTextBox3.Text = "Page - 3";
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.kryptonTextBox2);
            this.wizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage2.IsFinishPage = false;
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(444, 224);
            this.wizardPage2.TabIndex = 3;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox2.TabIndex = 0;
            this.kryptonTextBox2.Text = "Page - 2";
            // 
            // KryptonWizardExample
            // 
            this.ClientSize = new System.Drawing.Size(1138, 785);
            this.Controls.Add(this.kryptonWizard1);
            this.Name = "KryptonWizardExample";
            this.kryptonWizard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage4)).EndInit();
            this.wizardPage4.ResumeLayout(false);
            this.wizardPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage3)).EndInit();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}