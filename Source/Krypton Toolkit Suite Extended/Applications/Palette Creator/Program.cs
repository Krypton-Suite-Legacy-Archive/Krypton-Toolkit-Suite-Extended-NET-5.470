using PaletteCreator.UX;
using System;
using System.Windows.Forms;

namespace PaletteCreator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaletteColourComposer());
        }
    }
}
