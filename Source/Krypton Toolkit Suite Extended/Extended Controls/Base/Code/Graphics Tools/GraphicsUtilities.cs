using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.GraphicsTools
{
    public class GraphicsUtilities
    {
        /// <summary>
        /// Draws the control to bitmap.
        /// (https://www.youtube.com/watch?v=x-tMlZ3LTw8)
        /// </summary>
        /// <param name="targetControl">The target control.</param>
        /// <returns></returns>
        public static Bitmap DrawControlToBitmap(Control targetControl)
        {
            Bitmap tempBitmap = new Bitmap(targetControl.Width, targetControl.Height);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(tempBitmap);

            Rectangle rect = targetControl.RectangleToScreen(targetControl.ClientRectangle);

            graphics.CopyFromScreen(rect.Location, Point.Empty, targetControl.Size);

            return tempBitmap;
        }
    }
}