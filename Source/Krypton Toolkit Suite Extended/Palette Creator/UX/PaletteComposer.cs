using ComponentFactory.Krypton.Toolkit;
using PaletteCreator.Classes;
using System;
using System.Windows.Forms;

namespace PaletteCreator.UX
{
    public partial class PaletteColourComposer : KryptonForm
    {
        #region Variables
        private SettingsManager _settingsManager = new SettingsManager();

        private PaletteExporter _paletteExporter = new PaletteExporter();
        #endregion

        public PaletteColourComposer()
        {
            InitializeComponent();
        }

        private void PaletteComposer_Load(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateBaseColour_Click(object sender, EventArgs e)
        {
            ColourMixer colourMixer = new ColourMixer();

            colourMixer.Show();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = _settingsManager.GetBaseColour();

            pbxDarkestColour.BackColor = _settingsManager.GetBaseColour();

            pbxMediumColour.BackColor = _settingsManager.GetBaseColour();

            pbxLightColour.BackColor = _settingsManager.GetBaseColour();

            pbxLightestColour.BackColor = _settingsManager.GetBaseColour();
        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = KryptonMessageBox.Show("Do you wish to export these current colour values?", "Export Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _settingsManager.SetDarkestColour(pbxDarkestColour.BackColor);

                _settingsManager.SetMediumColour(pbxMediumColour.BackColor);

                _settingsManager.SetLightColour(pbxLightColour.BackColor);

                _settingsManager.SetLightestColour(pbxLightestColour.BackColor);
            }

            _paletteExporter.ExportPalette(_settingsManager.GetBaseColour(), _settingsManager.GetDarkestColour(), _settingsManager.GetMediumColour(), _settingsManager.GetLightColour(), _settingsManager.GetLightestColour(), pbxNormalTextColour.BackColor, pbxDisabledTextColour.BackColor);
        }
    }
}
