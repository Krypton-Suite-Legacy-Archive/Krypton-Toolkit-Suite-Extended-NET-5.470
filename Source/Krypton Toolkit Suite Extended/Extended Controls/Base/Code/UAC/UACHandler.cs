#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using KryptonExtendedToolkit.ExtendedToolkit.Controls;
using KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.UAC
{
    public class UACHandler
    {
        #region Constructor
        public UACHandler()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Elevates the application to use administrative privileges. To be used with <see cref="KryptonUACElevatedButton"/> or <see cref="ToolStripMenuItemUACSheld"/> button click.
        /// </summary>
        /// <param name="processName">The process name that you wish to elevate.</param>
        public static void ElevateProcessWithAdministrativeRights(string processName)
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            bool hasAdministrativeRights = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!hasAdministrativeRights)
            {
                // Relaunch the application with administrative rights
                ProcessStartInfo processStartInfo = new ProcessStartInfo();

                processStartInfo.Verb = "runas";

                processStartInfo.FileName = processName;

                try
                {
                    Process.Start(processStartInfo);
                }
                catch (Win32Exception wexc)
                {
                    ExtendedKryptonMessageBox.Show("Error: " + wexc.Message, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
        }

        /// <summary>
        /// Checks to see if the current process has launched with administrative rights.
        /// </summary>
        /// <remarks>
        /// Use this method in your 'Load' event.
        /// </remarks>
        /// <returns>True if the current process has launched with administrative rights, false if not.</returns>
        public static bool GetHasElevateProcessWithAdministrativeRights()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

            bool hasAdministrativeRights = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (hasAdministrativeRights)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}