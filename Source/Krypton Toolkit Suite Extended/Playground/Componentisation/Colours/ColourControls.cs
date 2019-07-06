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
        private ExtendedColourControls.AlphaValueNumericBox alphaValueNumericBox1;
        private ExtendedColourControls.BlueValueNumericBox blueValueNumericBox1;
        private ExtendedColourControls.GreenValueNumericBox greenValueNumericBox1;
        private ExtendedColourControls.RedValueNumericBox redValueNumericBox1;
        private ExtendedColourControls.ColourWheel colourWheel1;

        private void InitializeComponent()
        {
            this.redValueNumericBox1 = new ExtendedColourControls.RedValueNumericBox();
            this.greenValueNumericBox1 = new ExtendedColourControls.GreenValueNumericBox();
            this.blueValueNumericBox1 = new ExtendedColourControls.BlueValueNumericBox();
            this.alphaValueNumericBox1 = new ExtendedColourControls.AlphaValueNumericBox();
            this.colourWheel1 = new ExtendedColourControls.ColourWheel();
            this.SuspendLayout();
            // 
            // redValueNumericBox1
            // 
            this.redValueNumericBox1.DecimalPlaces = 99;
            this.redValueNumericBox1.Location = new System.Drawing.Point(202, 70);
            this.redValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redValueNumericBox1.Name = "redValueNumericBox1";
            this.redValueNumericBox1.Size = new System.Drawing.Size(120, 26);
            this.redValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.redValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.redValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.redValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.redValueNumericBox1.TabIndex = 5;
            // 
            // greenValueNumericBox1
            // 
            this.greenValueNumericBox1.DecimalPlaces = 99;
            this.greenValueNumericBox1.Location = new System.Drawing.Point(202, 101);
            this.greenValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenValueNumericBox1.Name = "greenValueNumericBox1";
            this.greenValueNumericBox1.Size = new System.Drawing.Size(120, 26);
            this.greenValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.greenValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.greenValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.greenValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.greenValueNumericBox1.TabIndex = 4;
            // 
            // blueValueNumericBox1
            // 
            this.blueValueNumericBox1.DecimalPlaces = 99;
            this.blueValueNumericBox1.Location = new System.Drawing.Point(202, 133);
            this.blueValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueValueNumericBox1.Name = "blueValueNumericBox1";
            this.blueValueNumericBox1.Size = new System.Drawing.Size(120, 26);
            this.blueValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.blueValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.blueValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.blueValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.blueValueNumericBox1.TabIndex = 3;
            // 
            // alphaValueNumericBox1
            // 
            this.alphaValueNumericBox1.DecimalPlaces = 99;
            this.alphaValueNumericBox1.Location = new System.Drawing.Point(202, 38);
            this.alphaValueNumericBox1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alphaValueNumericBox1.Name = "alphaValueNumericBox1";
            this.alphaValueNumericBox1.Size = new System.Drawing.Size(120, 26);
            this.alphaValueNumericBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.alphaValueNumericBox1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.alphaValueNumericBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.alphaValueNumericBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.alphaValueNumericBox1.TabIndex = 2;
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
            this.Controls.Add(this.redValueNumericBox1);
            this.Controls.Add(this.greenValueNumericBox1);
            this.Controls.Add(this.blueValueNumericBox1);
            this.Controls.Add(this.alphaValueNumericBox1);
            this.Controls.Add(this.colourWheel1);
            this.Name = "ColourControls";
            this.ResumeLayout(false);

        }
    }
}