#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.UI.Dialogues;
using System;
using System.IO;
using System.Windows.Forms;

namespace Playground
{
    public class KryptonFileInformationExample : KryptonForm
    {
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox ktbFilePath;
        private KryptonButton kbtnFileInformation;
        private KryptonButton kbtnBrowse;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileInformationExample));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnFileInformation = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnFileInformation);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.ktbFilePath);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(741, 81);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnFileInformation
            // 
            this.kbtnFileInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnFileInformation.Enabled = false;
            this.kbtnFileInformation.Location = new System.Drawing.Point(528, 44);
            this.kbtnFileInformation.Name = "kbtnFileInformation";
            this.kbtnFileInformation.Size = new System.Drawing.Size(195, 29);
            this.kbtnFileInformation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnFileInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnFileInformation.TabIndex = 17;
            this.kbtnFileInformation.Values.Text = "Get File &Information";
            this.kbtnFileInformation.Click += new System.EventHandler(this.KbtnFileInformation_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowse.Location = new System.Drawing.Point(687, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(36, 26);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 16;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.KbtnBrowse_Click);
            // 
            // ktbFilePath
            // 
            this.ktbFilePath.Hint = "File path...";
            this.ktbFilePath.Location = new System.Drawing.Point(101, 12);
            this.ktbFilePath.Name = "ktbFilePath";
            this.ktbFilePath.Size = new System.Drawing.Size(580, 27);
            this.ktbFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbFilePath.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "File Path:";
            // 
            // KryptonFileInformationExample
            // 
            this.ClientSize = new System.Drawing.Size(741, 81);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonFileInformationExample";
            this.Text = "Get File Information";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public KryptonFileInformationExample()
        {
            InitializeComponent();
        }

        private void KbtnFileInformation_Click(object sender, EventArgs e)
        {
            KryptonFileInformationDialog informationDialog = new KryptonFileInformationDialog(ktbFilePath.Text);

            informationDialog.Show();
        }

        private void KbtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ktbFilePath.Text = Path.GetFullPath(ofd.FileName);
            }

            kbtnFileInformation.Enabled = true;
        }
    }
}