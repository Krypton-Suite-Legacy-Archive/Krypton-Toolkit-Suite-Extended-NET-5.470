#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.UAC;
using System;
using System.IO;
using System.Windows.Forms;

namespace Playground
{
    public class UACAdvancedExample : KryptonForm
    {
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton1;
        private KryptonRadioButton kryptonRadioButton1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UACAdvancedExample));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonUACElevatedButton1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonRadioButton1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonUACElevatedButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonRadioButton1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(919, 257);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonUACElevatedButton1
            // 
            this.kryptonUACElevatedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonUACElevatedButton1.Location = new System.Drawing.Point(735, 204);
            this.kryptonUACElevatedButton1.Name = "kryptonUACElevatedButton1";
            this.kryptonUACElevatedButton1.Size = new System.Drawing.Size(172, 41);
            this.kryptonUACElevatedButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonUACElevatedButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonUACElevatedButton1.TabIndex = 2;
            this.kryptonUACElevatedButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton1.Values.Image")));
            this.kryptonUACElevatedButton1.Values.Text = "Elevate &Now";
            this.kryptonUACElevatedButton1.Click += new System.EventHandler(this.KryptonUACElevatedButton1_Click);
            // 
            // kryptonRadioButton1
            // 
            this.kryptonRadioButton1.Location = new System.Drawing.Point(12, 12);
            this.kryptonRadioButton1.Name = "kryptonRadioButton1";
            this.kryptonRadioButton1.Size = new System.Drawing.Size(179, 26);
            this.kryptonRadioButton1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonRadioButton1.TabIndex = 1;
            this.kryptonRadioButton1.Values.Text = "kryptonRadioButton1";
            // 
            // UACAdvancedExample
            // 
            this.ClientSize = new System.Drawing.Size(919, 257);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "UACAdvancedExample";
            this.Load += new System.EventHandler(this.UACAdvancedExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public UACAdvancedExample()
        {
            InitializeComponent();
        }

        private void UACAdvancedExample_Load(object sender, EventArgs e)
        {

        }

        private void KryptonUACElevatedButton1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetFullPath(Application.ExecutablePath);

            UACHandler.ElevateProcessWithAdministrativeRights(appPath);
        }
    }
}