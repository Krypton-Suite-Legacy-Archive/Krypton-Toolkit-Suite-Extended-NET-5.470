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

namespace Persistence.Interfaces
{
    public interface IAboutStripped
    {
        string ApplicationName { get; set; }

        Icon ApplicationIcon { get; set; }

        Bitmap ApplicationIconImage { get; set; }

        string AuthourName { get; set; }

        Version ApplicationVersion { get; set; }

        string InstallLocation { get; set; }
    }
}