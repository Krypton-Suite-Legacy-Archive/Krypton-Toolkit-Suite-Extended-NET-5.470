using KryptonSparkle.UX;
using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// Diagnostic for net Sparkle
    /// </summary>
    internal class KryptonSparkleDiagnostic
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly bool _isDiagnosticWindowShown;
        private readonly KryptonSparkleMainWindows _diagnosticWindow;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="isDiagnosticWindowShown"><c>true</c> if a diagnostic window should be shown</param>
        public KryptonSparkleDiagnostic(bool isDiagnosticWindowShown)
        {
            _isDiagnosticWindowShown = isDiagnosticWindowShown;
            if (_isDiagnosticWindowShown)
            {
                _diagnosticWindow = new KryptonSparkleMainWindows();
            }
        }

        /// <summary>
        /// Reports a message
        /// </summary>
        /// <param name="message">the message</param>
        public void Report(string message)
        {
            if (_isDiagnosticWindowShown && _diagnosticWindow != null)
            {
                _diagnosticWindow.Report(message);
            }
            logger.Info(message);
        }

        /// <summary>
        /// Shows the diagnostic form if needed
        /// </summary>
        /// <param name="isShown"><c>true</c> if we want to show the diagnostic window</param>
        public void ShowDiagnosticWindowIfNeeded(bool isShown)
        {
            if (!_isDiagnosticWindowShown || _diagnosticWindow == null)
            {
                return;
            }
            if (_diagnosticWindow.InvokeRequired)
            {
                _diagnosticWindow.Invoke(new Action(() => ShowDiagnosticWindowIfNeeded(isShown)));
            }
            else
            {
                // check the diagnotic value
                if (isShown || _isDiagnosticWindowShown)
                {
                    Point newLocation = new Point
                    {
                        X = Screen.PrimaryScreen.Bounds.Width - _diagnosticWindow.Width,
                        Y = 0
                    };

                    _diagnosticWindow.Location = newLocation;
                    _diagnosticWindow.Show();
                }
            }
        }
    }
}