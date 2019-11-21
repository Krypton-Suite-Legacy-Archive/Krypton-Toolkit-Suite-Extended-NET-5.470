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
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.Colours.ColourWheel
{
    internal class ImagesUtil
    {
        public static ImageList GetToolbarImageList(Type type, string resourceName, Size imageSize, Color transparentColour)
        {
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(type, resourceName);
            ImageList imageList = new ImageList();
            imageList.ImageSize = imageSize;
            imageList.TransparentColor = transparentColour;
            imageList.Images.AddStrip(bitmap);
            imageList.ColorDepth = ColorDepth.Depth24Bit;
            return imageList;
        }
    }

    internal class SelectorImages
    {
        public enum eIndexes
        {
            RIGHT,
            LEFT,
            UP,
            DOWN,
            DOGHNUT,
        }

        private static ImageList m_imageList = null;
        public static ImageList ImageList()
        {
            Type t = typeof(SelectorImages);
            if (m_imageList == null)
                m_imageList = ImagesUtil.GetToolbarImageList(t, "Resources.colorbarIndicators.bmp", new Size(12, 12), Color.Magenta);
            return m_imageList;
        }
        public static Image Image(eIndexes index)
        {
            return ImageList().Images[(int)index];
        }
    }

    internal class PopupContainerImages
    {
        public enum eIndexes
        {
            CLOSE,
            CHECK,
        }

        private static ImageList m_imageList = null;
        public static ImageList ImageList()
        {
            Type t = typeof(SelectorImages);
            if (m_imageList == null)
                m_imageList = ImagesUtil.GetToolbarImageList(t, "Resources.popupcontainerbuttons.bmp", new Size(16, 16), Color.Magenta);
            return m_imageList;
        }
        public static Image Image(eIndexes index)
        {
            return ImageList().Images[(int)index];
        }
    }
}