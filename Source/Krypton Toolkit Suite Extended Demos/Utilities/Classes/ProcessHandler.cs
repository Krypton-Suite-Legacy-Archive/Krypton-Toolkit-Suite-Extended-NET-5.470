using Common;
using KryptonToolkitSuiteExtendedCore;
using System;
using System.Diagnostics;
using System.IO;

namespace Utilities.Classes
{
    public class ProcessHandler
    {
        public ProcessHandler()
        {

        }

        public static void RunProcess(string processName)
        {
            try
            {
                if (!File.Exists(processName))
                {
                    FailLaunch(processName);
                }
                else
                {
                    Process.Start(processName);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.CaptureException(ex);
            }
        }

        private static void FailLaunch(string value) => KryptonMessageBoxExtended.Show($"'{ value }' failed to launch.\nPlease check if this file exists before proceeding.");
    }
}