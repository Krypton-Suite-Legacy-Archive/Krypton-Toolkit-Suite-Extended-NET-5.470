#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace Core.Classes
{
    public class TranslationMethods
    {
        #region Constructors
        public TranslationMethods()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Parses the boolean.
        /// </summary>
        /// <param name="booleanInput">The boolean input.</param>
        /// <returns></returns>
        public bool ParseBoolean(string booleanInput)
        {
            return bool.Parse(booleanInput.ToLower());
        }

        /// <summary>
        /// Parses the date time.
        /// </summary>
        /// <param name="dateTimeInput">The date time input.</param>
        /// <returns></returns>
        public DateTime ParseDateTime(string dateTimeInput)
        {
            return DateTime.Parse(dateTimeInput);
        }

        /// <summary>
        /// Parses the long.
        /// </summary>
        /// <param name="longInput">The long input.</param>
        /// <returns></returns>
        public long ParseLong(string longInput)
        {
            return long.Parse(longInput);
        }

        /// <summary>
        /// Parses the integer.
        /// </summary>
        /// <param name="integerInput">The integer input.</param>
        /// <returns></returns>
        public int ParseInteger(string integerInput)
        {
            return int.Parse(integerInput);
        }

        /// <summary>
        /// Parses the version.
        /// </summary>
        /// <param name="versionInput">The version input.</param>
        /// <returns></returns>
        public Version ParseVersion(string versionInput)
        {
            return Version.Parse(versionInput);
        }
        #endregion
    }
}