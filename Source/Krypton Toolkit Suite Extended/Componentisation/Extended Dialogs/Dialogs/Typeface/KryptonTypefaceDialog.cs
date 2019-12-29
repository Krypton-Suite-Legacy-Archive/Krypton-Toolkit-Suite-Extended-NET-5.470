#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs.Dialogs.Typeface
{
    public class KryptonTypefaceDialog : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnCancel;
        private KryptonPanel kryptonPanel2;
        private KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceList kryptonTypefaceList1;
        private KryptonButton kryptonButton1;
        private KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceExample kryptonTypefaceExample1;
        private KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceSizeList kryptonTypefaceSizeList1;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTypefaceList1 = new KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonTypefaceSizeList1 = new KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceSizeList();
            this.kryptonTypefaceExample1 = new KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonTypefaceExample();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 525);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(980, 57);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(716, 6);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(123, 39);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "&Cancel";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.Location = new System.Drawing.Point(845, 6);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(123, 39);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonTypefaceExample1);
            this.kryptonPanel2.Controls.Add(this.kryptonTypefaceSizeList1);
            this.kryptonPanel2.Controls.Add(this.kryptonTypefaceList1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(980, 525);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // kryptonTypefaceList1
            // 
            this.kryptonTypefaceList1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonTypefaceList1.Location = new System.Drawing.Point(12, 12);
            this.kryptonTypefaceList1.Name = "kryptonTypefaceList1";
            this.kryptonTypefaceList1.SelectedFontFamily = null;
            this.kryptonTypefaceList1.Size = new System.Drawing.Size(339, 487);
            this.kryptonTypefaceList1.TabIndex = 0;
            this.kryptonTypefaceList1.Typeface = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 3);
            this.panel1.TabIndex = 6;
            // 
            // kryptonTypefaceSizeList1
            // 
            this.kryptonTypefaceSizeList1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonTypefaceSizeList1.Location = new System.Drawing.Point(357, 12);
            this.kryptonTypefaceSizeList1.Name = "kryptonTypefaceSizeList1";
            this.kryptonTypefaceSizeList1.Size = new System.Drawing.Size(74, 487);
            this.kryptonTypefaceSizeList1.TabIndex = 1;
            // 
            // kryptonTypefaceExample1
            // 
            this.kryptonTypefaceExample1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonTypefaceExample1.HeaderText = "Sample Typeface";
            this.kryptonTypefaceExample1.Location = new System.Drawing.Point(437, 218);
            this.kryptonTypefaceExample1.Name = "kryptonTypefaceExample1";
            this.kryptonTypefaceExample1.SampleText = "AaBbCc123#+*-";
            this.kryptonTypefaceExample1.Size = new System.Drawing.Size(530, 281);
            this.kryptonTypefaceExample1.TabIndex = 2;
            this.kryptonTypefaceExample1.Typeface = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // KryptonTypefaceDialog
            // 
            this.ClientSize = new System.Drawing.Size(980, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "KryptonTypefaceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}