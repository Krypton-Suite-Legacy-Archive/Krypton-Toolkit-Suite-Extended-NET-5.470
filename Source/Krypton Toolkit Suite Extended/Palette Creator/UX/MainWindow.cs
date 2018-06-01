using ComponentFactory.Krypton.Toolkit;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PaletteCreator.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private bool _dirty, _loaded;

        private string _fileName;

        private KryptonPalette _paletteTheme;

        private TMSChromeForm _tmsChrome;

        private RibbonChromeForm _ribbonChrome;

        Assembly _assembly = Assembly.GetExecutingAssembly();

        Version _version = Assembly.GetExecutingAssembly().GetName().Version;

        MostRecentlyUsedFileManager _mostRecentlyUsedFileManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Text = $"Palette Composer - Developer Edition - Version: { _version.ToString() } - Build: { _version.Build.ToString() }";

            WindowState = FormWindowState.Maximized;

            _mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(openRecentPaletteToolStripMenuItem, "Palette Creator", MyOwnRecentFileGotClicked_Handler, MyOwnRecentFilesGotCleared_Handler);
        }

        private void MyOwnRecentFileGotClicked_Handler(object sender, EventArgs e)
        {
            string paletteFileName = (sender as ToolStripItem).Text;

            if (!File.Exists(paletteFileName))
            {
                if (KryptonMessageBox.Show($"{ paletteFileName } doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _mostRecentlyUsedFileManager.RemoveRecentFile(paletteFileName);
                }
                else
                {
                    return;
                }
            }

            OpenPaletteFile(paletteFileName);
        }

        private void MyOwnRecentFilesGotCleared_Handler(object sender, EventArgs e)
        {

        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                openPaletteToolStripMenuItem.PerformClick();
            }
        }
        #endregion

        #region Methods
        private void OpenPaletteFile(string paletteFilePath)
        {

        }
        #endregion
    }
}