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
        private ExtendedStandardControls.Controls.KryptonTreeViewExtended kryptonTreeViewExtended2;
        private ExtendedStandardControls.Controls.KryptonTreeViewExtended kryptonTreeViewExtended1;
        #region Designer Code

        private void InitializeComponent()
        {
            this.kryptonTreeViewExtended2 = new ExtendedStandardControls.Controls.KryptonTreeViewExtended();
            this.SuspendLayout();
            // 
            // kryptonTreeViewExtended2
            // 
            this.kryptonTreeViewExtended2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTreeViewExtended2.LongTextTypeface = null;
            this.kryptonTreeViewExtended2.Name = "kryptonTreeViewExtended2";
            this.kryptonTreeViewExtended2.ShortTextTypeface = null;
            this.kryptonTreeViewExtended2.Size = new System.Drawing.Size(120, 96);
            this.kryptonTreeViewExtended2.StateCommonBackgroundColour = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.StateCommonNodeShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonTreeViewExtended2.TabIndex = 0;
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(1410, 690);
            this.Controls.Add(this.kryptonTreeViewExtended2);
            this.Name = "Editor";
            this.ResumeLayout(false);

        }
        #endregion

        public Editor()
        {
            InitializeComponent();
        }
    }
}