#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace Persistence.VersionFramework.Classes
{
    public class AssemblyInformation
    {
        #region Variables
        private string _name, _version, _fullName;
        #endregion

        #region Properties
        public string Name { get { return _name; } set { _name = value; } }

        public string Version { get { return _version; } set { _version = value; } }

        public string FullName { get { return _fullName; } set { _fullName = value; } }
        #endregion
    }
}