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

namespace Playground
{
    public class TimeSpanExample : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.TimeSpanExtended.KryptonTimeSpanPicker kryptonTimeSpanPicker1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTimeSpanPicker1 = new ExtendedControls.ExtendedToolkit.Controls.TimeSpanExtended.KryptonTimeSpanPicker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonTimeSpanPicker1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonTimeSpanPicker1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(700, 542);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonTimeSpanPicker1
            // 
            this.kryptonTimeSpanPicker1.DropDownWidth = 336;
            this.kryptonTimeSpanPicker1.Location = new System.Drawing.Point(31, 34);
            this.kryptonTimeSpanPicker1.Name = "kryptonTimeSpanPicker1";
            this.kryptonTimeSpanPicker1.Size = new System.Drawing.Size(336, 21);
            this.kryptonTimeSpanPicker1.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonTimeSpanPicker1.TabIndex = 1;
            // 
            // TimeSpanExample
            // 
            this.ClientSize = new System.Drawing.Size(700, 542);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "TimeSpanExample";
            this.Load += new System.EventHandler(this.TimeSpanExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonTimeSpanPicker1)).EndInit();
            this.ResumeLayout(false);

        }

        private void TimeSpanExample_Load(object sender, EventArgs e)
        {

        }
    }
}