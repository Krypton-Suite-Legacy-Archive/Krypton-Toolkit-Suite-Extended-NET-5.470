#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.ComponentModel;

namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    internal class SendRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        //private readonly Response _result;

        public SendRequestCompletedEventArgs(Exception error, bool cancelled, object userState) : base(error, cancelled, userState)
        {
        }
    }
}