#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    /// <summary>
    /// Adapted from CrashReporter .NET.
    /// </summary>
    internal class AnonymousData
    {
        public Exception Exception { get; set; }

        public string ToEMail { get; set; }

        public Guid? ApplicationID { get; set; }
    }
}