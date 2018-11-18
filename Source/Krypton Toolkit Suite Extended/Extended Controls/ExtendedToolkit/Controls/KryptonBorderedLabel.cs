using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class KryptonBorderedLabel : KryptonLabel
    {
        public KryptonBorderedLabel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();

            BackColor = Color.Transparent;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            //default Paint
            base.OnPaint(e);
            //get Forecolor
            ForeColor = KryptonManager.CurrentGlobalPalette.GetBorderColor1(PaletteBorderStyle.InputControlCustom1, PaletteState.Normal);
            //get Graphics
            Graphics screenGraphics = e.Graphics;
            //Set Rectangle to draw 
            Rectangle rect = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            //Draw the border
            screenGraphics.DrawRectangle(new Pen(ForeColor), rect);


        }

    }
}