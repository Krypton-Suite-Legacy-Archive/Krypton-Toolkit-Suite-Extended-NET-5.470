#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion


using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs.Dialogs.About
{
    public class KryptonAboutWindow : KryptonForm
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private KryptonLabel klblProductName;
        private KryptonLabel klblVersion;
        private KryptonLabel klblCopyright;
        private KryptonLabel klblCompanyName;
        private KryptonRichTextBox kryptonRichTextBox1;
        private KryptonButton kryptonButton1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonAboutWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.klblProductName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCopyright = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(587, 416);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.klblProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.klblVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.klblCopyright, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.klblCompanyName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonRichTextBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton1, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 392);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(179, 386);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // klblProductName
            // 
            this.klblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblProductName.Location = new System.Drawing.Point(188, 3);
            this.klblProductName.Name = "klblProductName";
            this.klblProductName.Size = new System.Drawing.Size(372, 43);
            this.klblProductName.TabIndex = 14;
            this.klblProductName.Values.Text = "kryptonLabel1";
            // 
            // klblVersion
            // 
            this.klblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblVersion.Location = new System.Drawing.Point(188, 52);
            this.klblVersion.Name = "klblVersion";
            this.klblVersion.Size = new System.Drawing.Size(372, 43);
            this.klblVersion.TabIndex = 15;
            this.klblVersion.Values.Text = "kryptonLabel1";
            // 
            // klblCopyright
            // 
            this.klblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblCopyright.Location = new System.Drawing.Point(188, 101);
            this.klblCopyright.Name = "klblCopyright";
            this.klblCopyright.Size = new System.Drawing.Size(372, 43);
            this.klblCopyright.TabIndex = 16;
            this.klblCopyright.Values.Text = "kryptonLabel1";
            // 
            // klblCompanyName
            // 
            this.klblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblCompanyName.Location = new System.Drawing.Point(188, 150);
            this.klblCompanyName.Name = "klblCompanyName";
            this.klblCompanyName.Size = new System.Drawing.Size(372, 43);
            this.klblCompanyName.TabIndex = 17;
            this.klblCompanyName.Values.Text = "kryptonLabel2";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(188, 199);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ReadOnly = true;
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(372, 141);
            this.kryptonRichTextBox1.TabIndex = 18;
            this.kryptonRichTextBox1.Text = "kryptonRichTextBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(470, 364);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 19;
            this.kryptonButton1.Values.Text = "&Ok";
            // 
            // KryptonAboutWindow
            // 
            this.ClientSize = new System.Drawing.Size(587, 416);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KryptonAboutWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}