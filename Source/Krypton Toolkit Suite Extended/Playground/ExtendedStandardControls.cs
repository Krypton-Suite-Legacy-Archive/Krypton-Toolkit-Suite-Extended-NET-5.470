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
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButtonExtended1 = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButtonExtended1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1395, 750);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButtonExtended1
            // 
            this.kryptonButtonExtended1.BackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.BackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.Image = null;
            this.kryptonButtonExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonButtonExtended1.LongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.LongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.Name = "kryptonButtonExtended1";
            this.kryptonButtonExtended1.ShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.ShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonExtended1.Size = new System.Drawing.Size(204, 51);
            this.kryptonButtonExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButtonExtended1.TabIndex = 1;
            this.kryptonButtonExtended1.Values.Text = "kryptonButtonExtended1";
            // 
            // ExtendedStandardControls
            // 
            this.ClientSize = new System.Drawing.Size(1395, 750);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ExtendedStandardControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
}