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
using System.Net;
using System.Windows.Forms;

namespace Common.Drawing
{
    public class GraphicsUtilities
    {
        #region Constructor
        public GraphicsUtilities()
        {

        }
        #endregion

        #region Metods
        /// <summary>Extracts the binary icon.</summary>
        /// <param name="binaryFilePath">The binary file path.</param>
        /// <returns></returns>
        public static Image ExtractBinaryIcon(string binaryFilePath) => Icon.ExtractAssociatedIcon(binaryFilePath).ToBitmap();

        public static void GrabFavIcon(PictureBox container, string url)
        {
            container.ImageLocation = url + "/favicon.ico";

            container.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        #endregion
    }
}