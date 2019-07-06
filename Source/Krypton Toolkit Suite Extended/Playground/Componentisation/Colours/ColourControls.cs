using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Componentisation.Colours
{
    public class ColourControls : KryptonForm
    {
        private ExtendedColourControls.RedValueNumericBox redNumericBox1;
        private ExtendedColourControls.ColourWheel colourWheel1;

        private void InitializeComponent()
        {
            this.redNumericBox1 = new ExtendedColourControls.RedValueNumericBox();
            this.colourWheel1 = new ExtendedColourControls.ColourWheel();
            this.SuspendLayout();
            // 
            // redNumericBox1
            // 
            this.redNumericBox1.DecimalPlaces = 99;
            this.redNumericBox1.Location = new System.Drawing.Point(198, 52);
            this.redNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumericBox1.Name = "redNumericBox1";
            this.redNumericBox1.Size = new System.Drawing.Size(120, 26);
            this.redNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.redNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.redNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.redNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.redNumericBox1.TabIndex = 0;
            // 
            // colourWheel1
            // 
            this.colourWheel1.BackColor = System.Drawing.Color.Transparent;
            this.colourWheel1.Location = new System.Drawing.Point(12, 12);
            this.colourWheel1.Name = "colourWheel1";
            this.colourWheel1.Size = new System.Drawing.Size(121, 115);
            this.colourWheel1.TabIndex = 1;
            // 
            // ColourControls
            // 
            this.ClientSize = new System.Drawing.Size(1429, 725);
            this.Controls.Add(this.colourWheel1);
            this.Controls.Add(this.redNumericBox1);
            this.Name = "ColourControls";
            this.ResumeLayout(false);

        }
    }
}