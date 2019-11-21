#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KryptonExtendedToolkit.Base.Code
{
    /// <summary>
    /// A wrapper for exception handling.
    /// </summary>
    public class ExceptionHandler
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionHandler"/> class.
        /// </summary>
        public ExceptionHandler()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Shows the exception.
        /// </summary>
        /// <param name="exceptionMessage">The exception message.</param>
        /// <param name="useKryptonMessageBox">if set to <c>true</c> [use krypton message box].</param>
        /// <param name="useExtendedKryptonMessageBox">if set to <c>true</c> [use extended krypton message box].</param>
        /// <param name="useWin32MessageBox">if set to <c>true</c> [use win32 message box].</param>
        /// <param name="useConsole">if set to <c>true</c> [use console].</param>
        /// <param name="useToolStripLabel">if set to <c>true</c> [use tool strip label].</param>
        /// <param name="toolStripLabel">The tool strip label.</param>
        /// <param name="args">The arguments.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="options">The options.</param>
        public void ShowException(string exceptionMessage, bool useKryptonMessageBox = false, bool useExtendedKryptonMessageBox = false, bool useWin32MessageBox = false, bool useConsole = false, bool useToolStripLabel = false, ToolStripLabel toolStripLabel = null, object args = null, string caption = "Exception Caught", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button3, MessageBoxIcon icon = MessageBoxIcon.Exclamation, MessageBoxOptions options = MessageBoxOptions.DefaultDesktopOnly)
        {
            if (useKryptonMessageBox)
            {
                KryptonMessageBox.Show(exceptionMessage, caption, buttons, icon, defaultButton, options);
            }
            else if (useExtendedKryptonMessageBox)
            {

            }
            else if (useWin32MessageBox)
            {
                MessageBox.Show(exceptionMessage, caption, buttons, icon, defaultButton, options);
            }
            else if (useConsole)
            {
                Console.WriteLine($"[ { DateTime.Now.ToString() } ]: { exceptionMessage }");
            }
        }

        /// <summary>
        /// Captures the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="currentWindow">The current window.</param>
        /// <param name="title">The title.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodSignature">The method signature.</param>
        /// <param name="defaultTypeface">The default typeface.</param>
        public static void CaptureException(Exception exception, KryptonForm currentWindow, Control control = null, string title = @"Exception Caught", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, string className = "", string methodSignature = "", Font defaultTypeface = null)
        {
            defaultTypeface = new Font(currentWindow.Font.FontFamily, currentWindow.Font.Size, currentWindow.Font.Style, currentWindow.Font.Unit);

            if (className != "")
            {
                ExtendedKryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else if (methodSignature != "")
            {
                ExtendedKryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in method: '{ methodSignature }'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else if (className != "" && methodSignature != "")
            {
                ExtendedKryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.\n\nError in method: '{ methodSignature }'.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
            else
            {
                ExtendedKryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.", title, buttons, icon, messageboxTypeface: defaultTypeface);
            }
        }

        /// <summary>
        /// Captures a stacktrace of the exception.
        /// </summary>
        /// <param name="exc">The incoming exception.</param>
        /// <param name="fileName">The file to write the exception stacktrace to.</param>
        public static void PrintStackTrace(Exception exc, string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                }

                StreamWriter writer = new StreamWriter(fileName);

                writer.Write(exc.ToString());

                writer.Close();

                writer.Dispose();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// Captures a stacktrace of the exception.
        /// </summary>
        /// <param name="exc">The incoming exception.</param>
        /// <param name="fileName">The file to write the exception stacktrace to.</param>
        public static void PrintExceptionStackTrace(Exception exc, string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                }

                StreamWriter writer = new StreamWriter(fileName);

                writer.Write(exc.StackTrace);

                writer.Close();

                writer.Dispose();
            }
            catch (Exception e)
            {

                throw;
            }
        }
        #endregion
    }
}