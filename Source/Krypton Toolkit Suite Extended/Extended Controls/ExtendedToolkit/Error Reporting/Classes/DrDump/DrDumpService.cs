#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    /// <summary>
    /// Adapted from CrashReporter .NET.
    /// </summary>
    internal class DrDumpService
    {
        #region Delegates & Events
        public delegate void SendRequestCompletedEventHandler(object sender, SendRequestCompletedEventArgs e);

        public event SendRequestCompletedEventHandler SendRequestCompleted;
        #endregion

        #region Variables
        //private SendRequestState _sendRequestState;
        #endregion
    }
}