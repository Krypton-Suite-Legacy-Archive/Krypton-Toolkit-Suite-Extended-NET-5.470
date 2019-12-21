#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using KryptonExtendedToolkit.Base.Code;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class UACExample : KryptonForm
    {
        private KryptonButton kbtnBrowse;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox ktbFilePath;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kuacElevateSelectedFile;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UACExample));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktbFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kuacElevateSelectedFile = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kuacElevateSelectedFile);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.ktbFilePath);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(745, 85);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnBrowse.Location = new System.Drawing.Point(697, 12);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(36, 26);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.TabIndex = 19;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.KbtnBrowse_Click);
            // 
            // ktbFilePath
            // 
            this.ktbFilePath.Hint = "File path...";
            this.ktbFilePath.Location = new System.Drawing.Point(101, 12);
            this.ktbFilePath.Name = "ktbFilePath";
            this.ktbFilePath.Size = new System.Drawing.Size(590, 27);
            this.ktbFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbFilePath.TabIndex = 18;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "File Path:";
            // 
            // kuacElevateSelectedFile
            // 
            this.kuacElevateSelectedFile.AutoSize = true;
            this.kuacElevateSelectedFile.Location = new System.Drawing.Point(547, 45);
            this.kuacElevateSelectedFile.Name = "kuacElevateSelectedFile";
            this.kuacElevateSelectedFile.Size = new System.Drawing.Size(186, 30);
            this.kuacElevateSelectedFile.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacElevateSelectedFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacElevateSelectedFile.TabIndex = 20;
            this.kuacElevateSelectedFile.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton1.Values.Image")));
            this.kuacElevateSelectedFile.Values.Text = "Elevate Selected File...";
            this.kuacElevateSelectedFile.Click += new System.EventHandler(this.KuacElevateSelectedFile_Click);
            // 
            // UACExample
            // 
            this.ClientSize = new System.Drawing.Size(745, 85);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UACExample";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public UACExample()
        {
            InitializeComponent();
        }

        private void KuacElevateSelectedFile_Click(object sender, EventArgs e)
        {
            UtilityMethods.ElevateProcessWithAdministrativeRights(ktbFilePath.Text);

            kuacElevateSelectedFile.Enabled = false;
        }

        private void KbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Open a executable to elevate:";

            cofd.Filters.Add(new CommonFileDialogFilter("Windows Executable Binaries", ".exe"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktbFilePath.Text = Path.GetFullPath(cofd.FileName);

                kuacElevateSelectedFile.Enabled = true;
            }
        }
    }
}