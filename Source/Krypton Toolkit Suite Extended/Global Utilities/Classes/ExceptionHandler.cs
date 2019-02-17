using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GlobalUtilities.Classes
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
        /// Captures the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="title">The title.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodSignature">The method signature.</param>
        public static void CaptureException(Exception exception, string title = @"Exception Caught", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error, string className = "", string methodSignature = "")
        {
            if (className != "")
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.", title, buttons, icon);
            }
            else if (methodSignature != "")
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in method: '{ methodSignature }'.", title, buttons, icon);
            }
            else if (className != "" && methodSignature != "")
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.\n\nError in class: '{ className }.cs'.\n\nError in method: '{ methodSignature }'.", title, buttons, icon);
            }
            else
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exception.Message }.", title, buttons, icon);
            }
        }
        #endregion
    }
}