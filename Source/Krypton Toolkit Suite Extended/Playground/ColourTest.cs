#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public partial class ColourTest : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private Core.Controls.Colours.ColourEditorManager colourEditorManager1;
        private KryptonButton kbtnTest;
        private System.Windows.Forms.PictureBox pictureBox1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colourEditorManager1 = new Core.Controls.Colours.ColourEditorManager();
            this.kbtnTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnTest);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(566, 77);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kbtnTest
            // 
            this.kbtnTest.AutoSize = true;
            this.kbtnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnTest.Location = new System.Drawing.Point(150, 23);
            this.kbtnTest.Name = "kbtnTest";
            this.kbtnTest.Size = new System.Drawing.Size(42, 30);
            this.kbtnTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTest.TabIndex = 24;
            this.kbtnTest.Values.Text = "Test";
            this.kbtnTest.Click += new System.EventHandler(this.kbtnTest_Click);
            // 
            // ColourWheelColourPickerDialog
            // 
            this.ClientSize = new System.Drawing.Size(566, 77);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ColourWheelColourPickerDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void cwTest_ColourChanged(object sender, System.EventArgs e)
        {

        }

        public ColourTest()
        {
            InitializeComponent();
        }

        private void kbtnTest_Click(object sender, System.EventArgs e)
        {
            ColourWheelColourPickerDialog colourWheelColourPickerDialog = new ColourWheelColourPickerDialog();

            if (colourWheelColourPickerDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colourWheelColourPickerDialog.SelectedColour;
            }
        }
    }
}