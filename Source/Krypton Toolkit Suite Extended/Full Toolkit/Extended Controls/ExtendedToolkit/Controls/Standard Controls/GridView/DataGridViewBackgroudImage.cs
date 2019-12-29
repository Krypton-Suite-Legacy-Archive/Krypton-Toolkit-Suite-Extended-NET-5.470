#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    [ToolboxBitmap(typeof(DataGridView)), ToolboxItem(false)]
    public class DataGridViewBackgroudImage : DataGridView
    {
        // Fields
        private Image m_Image;

        // Methods
        public DataGridViewBackgroudImage()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            if (this.m_Image != null)
            {
                base.PaintBackground(graphics, clipBounds, gridBounds);
                graphics.DrawImage(this.m_Image, gridBounds);
            }
            else
            {
                base.PaintBackground(graphics, clipBounds, gridBounds);
            }
        }

        // Properties
        [Category("Appearance"), Description("Set Background Image")]
        public Image BackImage
        {
            get
            {
                return this.m_Image;
            }
            set
            {
                this.m_Image = value;
            }
        }
    }


}