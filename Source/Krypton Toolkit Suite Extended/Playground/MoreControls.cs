using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;

namespace Playground
{
    public class MoreControls : KryptonForm
    {
        private System.ComponentModel.IContainer components;
        private KryptonDomainUpDown kryptonDomainUpDown1;
        private KryptonButton kryptonButton1;
        private KryptonButton kryptonButton2;
        private KryptonManager kryptonManager1;
        private KryptonPanel kryptonPanel1;

        public MoreControls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDomainUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1450, 777);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(1057, 211);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(158, 25);
            this.kryptonButton2.TabIndex = 80;
            this.kryptonButton2.Values.Text = "Colour Chooser 2";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1057, 180);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(158, 25);
            this.kryptonButton1.TabIndex = 79;
            this.kryptonButton1.Values.Text = "Colour Chooser 1";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonDomainUpDown1
            // 
            this.kryptonDomainUpDown1.Location = new System.Drawing.Point(1057, 152);
            this.kryptonDomainUpDown1.Name = "kryptonDomainUpDown1";
            this.kryptonDomainUpDown1.Size = new System.Drawing.Size(158, 22);
            this.kryptonDomainUpDown1.TabIndex = 70;
            this.kryptonDomainUpDown1.Text = "kryptonDomainUpDown1";
            // 
            // MoreControls
            // 
            this.ClientSize = new System.Drawing.Size(1450, 777);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MoreControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            KryptonColourChooser1 kcc1 = new KryptonColourChooser1();

            kcc1.Show();
        }

        private void kryptonButton2_Click(object sender, System.EventArgs e)
        {
            KryptonColourChooser2 kcc2 = new KryptonColourChooser2();

            kcc2.Show();
        }
    }
}