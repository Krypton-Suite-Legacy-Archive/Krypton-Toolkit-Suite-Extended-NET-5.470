#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Core.Classes.Other
{
    /// <summary>
    /// Provides base functions for drawing a <see cref="ToolStrip"/> on a window titlebar.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.ToolStripSystemRenderer" />
    public class ToolStripNonClientRenderer : ToolStripSystemRenderer
    {
        /// <summary>
        /// Determines whether [is supported os].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is supported os]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSupportedOS()
        {
            // Windows 7 and higher
            return (Environment.OSVersion.Version.Major >= 6 && Environment.Version.Minor >= 1);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBackground" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.IsDropDown)
            {
                base.OnRenderToolStripBackground(e);
            }
            else
            {
                e.Graphics.Clear(Color.Transparent);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderToolStripBorder" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip.IsDropDown)
            {
                base.OnRenderToolStripBorder(e);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderItemText" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemTextRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.ToolStrip.IsDropDown)
            {
                base.OnRenderItemText(e);
            }
            else
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddString(e.Text, e.TextFont.FontFamily, (int)e.TextFont.Style, e.TextFont.Size + 2, e.TextRectangle.Location, new StringFormat());

                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                    e.Graphics.FillPath(Brushes.Black, path);
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderOverflowButtonBackground" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemRenderEventArgs" /> that contains the event data.</param>
        protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.Clear(Color.FromArgb(20, Color.Navy));
            }

            Rectangle rect = Rectangle.Empty;

            if (e.Item.RightToLeft == RightToLeft.Yes)
            {
                rect = new Rectangle(0, e.Item.Height - 8, 9, 5);
            }
            else
            {
                rect = new Rectangle(e.Item.Width - 12, e.Item.Height - 16, 9, 5);
            }

            base.DrawArrow(new ToolStripArrowRenderEventArgs(e.Graphics, e.Item, rect, SystemColors.ControlText, ArrowDirection.Down));

            e.Graphics.DrawLine(SystemPens.ControlText, (int)(rect.Right - 7), (int)(rect.Y - 2), (int)(rect.Right - 3), (int)(rect.Y - 2));
        }
    }
}