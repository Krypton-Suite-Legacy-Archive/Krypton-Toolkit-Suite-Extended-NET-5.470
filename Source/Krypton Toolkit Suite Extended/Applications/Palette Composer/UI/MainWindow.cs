#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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
