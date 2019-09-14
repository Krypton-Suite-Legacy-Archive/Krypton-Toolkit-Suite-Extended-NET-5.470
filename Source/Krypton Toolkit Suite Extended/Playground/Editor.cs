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

namespace Playground
{
    public class Editor : KryptonForm
    {
        private KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonSplitButton kryptonSplitButton1;
        #region Designer Code

        private void InitializeComponent()
        {
            this.kryptonSplitButton1 = new KryptonToolkitSuiteExtendedCore.Components.Controls.KryptonSplitButton();
            this.SuspendLayout();
            // 
            // kryptonSplitButton1
            // 
            this.kryptonSplitButton1.AutoSize = true;
            this.kryptonSplitButton1.CornerRadius = 25;
            this.kryptonSplitButton1.Location = new System.Drawing.Point(420, 215);
            this.kryptonSplitButton1.Name = "kryptonSplitButton1";
            this.kryptonSplitButton1.ShowSplitOption = true;
            this.kryptonSplitButton1.Size = new System.Drawing.Size(272, 38);
            this.kryptonSplitButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSplitButton1.StateCommon.Border.Rounding = 25;
            this.kryptonSplitButton1.TabIndex = 0;
            this.kryptonSplitButton1.Values.Text = "kryptonSplitButton1";
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(1410, 690);
            this.Controls.Add(this.kryptonSplitButton1);
            this.Name = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public Editor()
        {
            InitializeComponent();
        }
    }
}