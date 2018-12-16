using ComponentFactory.Krypton.Toolkit;

namespace PaletteComposer.UI
{
    public partial class MainWindow : KryptonForm
    {
        public MainWindow()
        {
            InitializeComponent();

            SyncupBackColour();

            //KryptonManager.GlobalAllowFormChromeChanged += new EventHandler((s, e), SyncupBackColour());

            AllowStatusStripMerge = false;
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            skinsToolStripMenuItem.DropDownItems.Clear();

            //foreach (PaletteItem item in collection)
            //{

            //}
        }

        private void SyncupBackColour()
        {
            BackColor = KryptonManager.CurrentGlobalPalette.GetBackColor1(PaletteBackStyle.PanelClient, PaletteState.Normal);
        }
    }
}
