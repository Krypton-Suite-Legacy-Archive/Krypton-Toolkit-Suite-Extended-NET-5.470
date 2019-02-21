using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class WizardTest : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage2;
        private ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage wizardPage1;
        private ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard wizard1;

        private void InitializeComponent()
        {
            this.wizard1 = new ExtendedControls.ExtendedToolkit.Wizard.Controls.KryptonWizard();
            this.wizardPage1 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizardPage2 = new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage();
            this.wizard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.Controls.Add(this.wizardPage2);
            this.wizard1.Controls.Add(this.wizardPage1);
            this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizard1.Location = new System.Drawing.Point(0, 0);
            this.wizard1.Name = "wizard1";
            this.wizard1.Pages.AddRange(new ExtendedControls.ExtendedToolkit.Wizard.Classes.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2});
            this.wizard1.Size = new System.Drawing.Size(991, 699);
            this.wizard1.TabIndex = 0;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage1.IsFinishPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(991, 651);
            this.wizardPage1.TabIndex = 2;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardPage2.IsFinishPage = false;
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(991, 651);
            this.wizardPage2.TabIndex = 3;
            // 
            // WizardTest
            // 
            this.ClientSize = new System.Drawing.Size(991, 699);
            this.Controls.Add(this.wizard1);
            this.Name = "WizardTest";
            this.wizard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardPage2)).EndInit();
            this.ResumeLayout(false);

        }

        public WizardTest()
        {
            InitializeComponent();
        }
    }
}