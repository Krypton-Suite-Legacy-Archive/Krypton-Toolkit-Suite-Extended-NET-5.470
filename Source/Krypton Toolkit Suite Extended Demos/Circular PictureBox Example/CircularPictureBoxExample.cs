using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPictureBoxExample
{
    public class CircularPictureBoxExample : KryptonForm
    {
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox circularPictureBox1;
        private Utilities.Components.ControlContainer controlContainer1;

        private void InitializeComponent()
        {
            this.controlContainer1 = new Utilities.Components.ControlContainer();
            this.circularPictureBox1 = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlContainer1
            // 
            this.controlContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlContainer1.InstructionsText = "To view the properties of a control, just click on the desired control.";
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.SelectedControl = null;
            this.controlContainer1.ShowInstructionsPane = true;
            this.controlContainer1.Size = new System.Drawing.Size(1108, 722);
            this.controlContainer1.TabIndex = 0;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.circularPictureBox1.Location = new System.Drawing.Point(384, 145);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(413, 390);
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // CircularPictureBoxExample
            // 
            this.BracketType = ComponentFactory.Krypton.Toolkit.BracketType.CURVEDBRACKET;
            this.ClientSize = new System.Drawing.Size(1108, 722);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.controlContainer1);
            this.Name = "CircularPictureBoxExample";
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        public CircularPictureBoxExample()
        {
            InitializeComponent();
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            controlContainer1.PropertyGrid.SelectedObject = circularPictureBox1;
        }
    }
}