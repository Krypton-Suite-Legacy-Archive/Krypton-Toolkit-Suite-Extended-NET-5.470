#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.ExtendedToolkit.UI.Windows
{
    public class KryptonFileCopy : KryptonForm
    {
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnCancelCopy;
        private KryptonLabel klblTotalFiles;
        private Controls.KryptonControls.KryptonProgressBar kryptonProgressBar2;
        private KryptonLabel klblCurrentFile;
        private Controls.KryptonControls.KryptonProgressBar kryptonProgressBar1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancelCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblTotalFiles = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonProgressBar1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar();
            this.klblCurrentFile = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonProgressBar2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCancelCopy);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 196);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(749, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnCancelCopy
            // 
            this.kbtnCancelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancelCopy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancelCopy.Location = new System.Drawing.Point(620, 9);
            this.kbtnCancelCopy.Name = "kbtnCancelCopy";
            this.kbtnCancelCopy.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancelCopy.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancelCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancelCopy.TabIndex = 15;
            this.kbtnCancelCopy.Values.Text = "&Cancel Copy";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 195);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(749, 1);
            this.pnlSplitter.TabIndex = 4;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonProgressBar2);
            this.kryptonPanel2.Controls.Add(this.klblCurrentFile);
            this.kryptonPanel2.Controls.Add(this.kryptonProgressBar1);
            this.kryptonPanel2.Controls.Add(this.klblTotalFiles);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(749, 195);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // klblTotalFiles
            // 
            this.klblTotalFiles.Location = new System.Drawing.Point(12, 12);
            this.klblTotalFiles.Name = "klblTotalFiles";
            this.klblTotalFiles.Size = new System.Drawing.Size(109, 24);
            this.klblTotalFiles.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTotalFiles.TabIndex = 4;
            this.klblTotalFiles.Values.Text = "Total Files: {0}";
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonProgressBar1.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(135)))));
            this.kryptonProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonProgressBar1.ForeColour = System.Drawing.Color.Empty;
            this.kryptonProgressBar1.Location = new System.Drawing.Point(12, 42);
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(725, 32);
            this.kryptonProgressBar1.StartColour = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(135)))));
            this.kryptonProgressBar1.TabIndex = 5;
            // 
            // klblCurrentFile
            // 
            this.klblCurrentFile.Location = new System.Drawing.Point(12, 108);
            this.klblCurrentFile.Name = "klblCurrentFile";
            this.klblCurrentFile.Size = new System.Drawing.Size(119, 24);
            this.klblCurrentFile.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentFile.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentFile.TabIndex = 6;
            this.klblCurrentFile.Values.Text = "Current File: {0}";
            // 
            // kryptonProgressBar2
            // 
            this.kryptonProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonProgressBar2.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(135)))));
            this.kryptonProgressBar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonProgressBar2.ForeColour = System.Drawing.Color.Empty;
            this.kryptonProgressBar2.Location = new System.Drawing.Point(12, 138);
            this.kryptonProgressBar2.Name = "kryptonProgressBar2";
            this.kryptonProgressBar2.Size = new System.Drawing.Size(725, 32);
            this.kryptonProgressBar2.StartColour = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(135)))));
            this.kryptonProgressBar2.TabIndex = 7;
            // 
            // KryptonFileCopy
            // 
            this.ClientSize = new System.Drawing.Size(749, 246);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "KryptonFileCopy";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}