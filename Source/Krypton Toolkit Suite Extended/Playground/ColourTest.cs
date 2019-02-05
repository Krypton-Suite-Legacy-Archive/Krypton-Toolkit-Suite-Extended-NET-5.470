using ComponentFactory.Krypton.Toolkit;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public partial class ColourWheelColourPickerDialog : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private Core.Controls.Colours.ColourEditorManager colourEditorManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Core.Controls.Colours.ColourWheel cwTest;

        private void InitializeComponent()
        {
            this.cwTest = new Core.Controls.Colours.ColourWheel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.colourEditorManager1 = new Core.Controls.Colours.ColourEditorManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cwTest
            // 
            this.cwTest.Location = new System.Drawing.Point(12, 12);
            this.cwTest.Name = "cwTest";
            this.cwTest.Size = new System.Drawing.Size(324, 309);
            this.cwTest.TabIndex = 0;
            this.cwTest.ColourChanged += new System.EventHandler(this.cwTest_ColourChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.cwTest);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(566, 577);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ColourTest
            // 
            this.ClientSize = new System.Drawing.Size(566, 577);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ColourTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void cwTest_ColourChanged(object sender, System.EventArgs e)
        {
            pictureBox1.BackColor = cwTest.Colour;
        }

        public ColourWheelColourPickerDialog()
        {
            InitializeComponent();
        }
    }
}