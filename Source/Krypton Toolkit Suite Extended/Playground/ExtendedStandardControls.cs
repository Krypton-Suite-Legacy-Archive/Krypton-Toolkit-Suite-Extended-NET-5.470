using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class ExtendedStandardControls : KryptonForm
    {
        private ExtendedStandardControls.KryptonCheckBoxExtended kryptonCheckBoxExtended1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBoxExtended1 = new ExtendedStandardControls.KryptonCheckBoxExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonCheckBoxExtended1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1527, 744);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonCheckBoxExtended1
            // 
            this.kryptonCheckBoxExtended1.Image = null;
            this.kryptonCheckBoxExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonCheckBoxExtended1.LongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.LongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBoxExtended1.Name = "kryptonCheckBoxExtended1";
            this.kryptonCheckBoxExtended1.ShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.ShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBoxExtended1.Size = new System.Drawing.Size(233, 23);
            this.kryptonCheckBoxExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBoxExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBoxExtended1.TabIndex = 1;
            this.kryptonCheckBoxExtended1.Values.Text = "kryptonCheckBoxExtended1";
            // 
            // ExtendedStandardControls
            // 
            this.ClientSize = new System.Drawing.Size(1527, 744);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ExtendedStandardControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}