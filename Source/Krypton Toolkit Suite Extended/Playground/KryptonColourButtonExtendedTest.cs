using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class KryptonColourButtonExtendedTest : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonColourButtonExtended kryptonColourButtonExtended1;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cpbResult;
        private ExtendedColourControls.KryptonColourButtonExtended kryptonColourButtonExtended2;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cpbResult = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonColourButtonExtended1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonColourButtonExtended();
            this.kryptonColourButtonExtended2 = new ExtendedColourControls.KryptonColourButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonColourButtonExtended2);
            this.kryptonPanel1.Controls.Add(this.cpbResult);
            this.kryptonPanel1.Controls.Add(this.kryptonColourButtonExtended1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(475, 164);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cpbResult
            // 
            this.cpbResult.BackColor = System.Drawing.Color.White;
            this.cpbResult.Location = new System.Drawing.Point(316, 12);
            this.cpbResult.Name = "cpbResult";
            this.cpbResult.Size = new System.Drawing.Size(131, 131);
            this.cpbResult.TabIndex = 1;
            this.cpbResult.TabStop = false;
            // 
            // kryptonColourButtonExtended1
            // 
            this.kryptonColourButtonExtended1.Location = new System.Drawing.Point(12, 28);
            this.kryptonColourButtonExtended1.Name = "kryptonColourButtonExtended1";
            this.kryptonColourButtonExtended1.Size = new System.Drawing.Size(275, 25);
            this.kryptonColourButtonExtended1.TabIndex = 1;
            this.kryptonColourButtonExtended1.Values.Text = "kryptonColourButtonExtended1";
            this.kryptonColourButtonExtended1.SelectedColourChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.KryptonColourButtonExtended1_SelectedColourChanged);
            // 
            // kryptonColourButtonExtended2
            // 
            this.kryptonColourButtonExtended2.Location = new System.Drawing.Point(12, 78);
            this.kryptonColourButtonExtended2.Name = "kryptonColourButtonExtended2";
            this.kryptonColourButtonExtended2.Size = new System.Drawing.Size(275, 25);
            this.kryptonColourButtonExtended2.TabIndex = 1;
            this.kryptonColourButtonExtended2.Values.Text = "kryptonColourButtonExtended2";
            // 
            // KryptonColourButtonExtendedTest
            // 
            this.ClientSize = new System.Drawing.Size(475, 164);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "KryptonColourButtonExtendedTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbResult)).EndInit();
            this.ResumeLayout(false);

        }

        public KryptonColourButtonExtendedTest()
        {
            InitializeComponent();
        }

        private void KryptonColourButtonExtended1_SelectedColourChanged(object sender, ColorEventArgs e)
        {
            cpbResult.BackColor = kryptonColourButtonExtended1.SelectedColour;
        }
    }
}