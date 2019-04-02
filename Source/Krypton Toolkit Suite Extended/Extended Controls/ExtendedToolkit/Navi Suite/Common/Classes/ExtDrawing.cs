#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion


using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.Classes
{
    public class ExtDrawing
    {
        /// <summary>
        /// Draws a vertical gradient on a Graphics canvas
        /// </summary>
        /// <param name="g">The graphics canvas</param>
        /// <param name="bounds">The bounds of the gradient</param>
        /// <param name="colors">The colors of the gradient</param>
        /// <param name="positions">The position of the colors inside the gradient</param>
        public static void DrawVertGradient(Graphics g, Rectangle bounds, Color[] colors, float[] positions)
        {
            ColorBlend blend = new ColorBlend();

            blend.Colors = colors;
            blend.Positions = positions;

            // To prevent out of memory exceptions when the width or height is 0
            if (bounds.Height == 0)
                bounds.Height = 1;
            if (bounds.Width == 0)
                bounds.Width = 1;

            // Make the linear brush and assign the custom blend to it
            using (LinearGradientBrush brush = new LinearGradientBrush(new Point(bounds.Left, bounds.Bottom), new Point(bounds.Left, bounds.Top), Color.White, Color.Black))
            {
                brush.InterpolationColors = blend;
                g.FillRectangle(brush, bounds);
            }
        }

        /// <summary>
        /// Draws a horizontal gradient on a Graphics canvas
        /// </summary>
        /// <param name="g">The graphics canvas</param>
        /// <param name="bounds">The bounds of the gradient</param>
        /// <param name="colors">The colors of the gradient</param>
        /// <param name="positions">The position of the colors inside the gradient</param>
        public static void DrawHorGradient(Graphics g, Rectangle bounds, Color[] colors, float[] positions)
        {
            ColorBlend blend = new ColorBlend();

            blend.Colors = colors;
            blend.Positions = positions;

            // To prevent out of memory exceptions when the width or height is 0
            if (bounds.Height == 0)
                bounds.Height = 1;
            if (bounds.Width == 0)
                bounds.Width = 1;

            // Make the linear brush and assign the custom blend to it
            using (LinearGradientBrush brush = new LinearGradientBrush(new Point(bounds.Left, bounds.Bottom), new Point(bounds.Right, bounds.Bottom), Color.White, Color.Black))
            {
                brush.InterpolationColors = blend;
                g.FillRectangle(brush, bounds);
            }
        }

        /// <summary>
        /// Draws a radial gradient on a Graphics canvas
        /// </summary>      
        public static void DrawRadialGradient(Graphics g, GraphicsPath path, Rectangle bounds, Color centerColor, Color[] colors)
        {
            PathGradientBrush pathGradient = new PathGradientBrush(path);
            pathGradient.CenterColor = centerColor;
            pathGradient.SurroundColors = colors;
            using (Bitmap b = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppPArgb))
            {
                using (Graphics bitmapG = Graphics.FromImage(b))
                {
                    bitmapG.FillPath(pathGradient, path);
                }
                g.DrawImageUnscaled(b, new Point(bounds.X, bounds.Y));
            }
        }
    }
}