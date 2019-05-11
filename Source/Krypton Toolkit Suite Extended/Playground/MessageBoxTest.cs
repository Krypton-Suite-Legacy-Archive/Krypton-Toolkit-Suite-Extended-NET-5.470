#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using System;
using System.Drawing;

namespace Playground
{
    public class MessageBoxTest : KryptonForm
    {
        private KryptonButton kbtnTopMostTrue;
        private KryptonButton kbtnTopMostFalse;

        private void InitializeComponent()
        {
            this.kbtnTopMostTrue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnTopMostFalse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kbtnTopMostTrue
            // 
            this.kbtnTopMostTrue.Location = new System.Drawing.Point(129, 117);
            this.kbtnTopMostTrue.Name = "kbtnTopMostTrue";
            this.kbtnTopMostTrue.Size = new System.Drawing.Size(138, 25);
            this.kbtnTopMostTrue.TabIndex = 0;
            this.kbtnTopMostTrue.Values.Text = "TopMost = True Test";
            this.kbtnTopMostTrue.Click += new System.EventHandler(this.kbtnTopMostTrue_Click);
            // 
            // kbtnTopMostFalse
            // 
            this.kbtnTopMostFalse.Location = new System.Drawing.Point(129, 159);
            this.kbtnTopMostFalse.Name = "kbtnTopMostFalse";
            this.kbtnTopMostFalse.Size = new System.Drawing.Size(138, 25);
            this.kbtnTopMostFalse.TabIndex = 1;
            this.kbtnTopMostFalse.Values.Text = "TopMost = False Test";
            this.kbtnTopMostFalse.Click += new System.EventHandler(this.kbtnTopMostFalse_Click);
            // 
            // MessageBoxTest
            // 
            this.ClientSize = new System.Drawing.Size(1037, 681);
            this.Controls.Add(this.kbtnTopMostFalse);
            this.Controls.Add(this.kbtnTopMostTrue);
            this.Name = "MessageBoxTest";
            this.Load += new System.EventHandler(this.MessageBoxTest_Load);
            this.ResumeLayout(false);

        }

        public MessageBoxTest()
        {
            InitializeComponent();
        }

        private void MessageBoxTest_Load(object sender, EventArgs e)
        {

        }

        private void kbtnTopMostTrue_Click(object sender, EventArgs e)
        {
            ExtendedKryptonMessageBox.Show("TopMost = True", null, new Font("Segoe UI", 9f), true);
        }

        private void kbtnTopMostFalse_Click(object sender, EventArgs e)
        {
            ExtendedKryptonMessageBox.Show("TopMost = False", null, new Font("Segoe UI", 9f), false);
        }
    }
}