using ColourComposer.Classes;
using ColourComposer.Enumerations;
using ColourComposer.Structures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColourComposer.UX
{
    internal partial class ColourAdjustForm : BaseForm
    {
        #region Variables
        private CustomisableColourTable _initialColourTable, _colourTable;
        #endregion

        public ColourAdjustForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void UpdateColours()
        {
            var deltaHue = hueBar.Value;

            var deltaSat = 2.0 / (saturationBar.Maximum - saturationBar.Minimum) * saturationBar.Value;

            var deltaLight = 2.0 / (lightnessBar.Maximum - lightnessBar.Minimum) * lightnessBar.Value;

            var enumValues = Enum.GetValues(typeof(ColourTableGroup));

            foreach (ColourTableGroup colourTableGroup in enumValues)
            {
                if (_initialColourTable[colourTableGroup] == Color.Empty)
                {
                    continue;
                }

                HSLColour hslColour = HSLColour.FromColour(_initialColourTable[colourTableGroup]);

                _colourTable[colourTableGroup] = new HSLColour(hslColour.Alpha, hslColour.Hue + deltaHue, hslColour.Saturation + deltaSat, hslColour.Luminosity + deltaLight).ToColour();
            }

            MainForm.Renderer.RefreshToolStrips();
        }

        private void ResetBarValues()
        {
            hueBar.Value = 0;

            saturationBar.Value = 0;

            lightnessBar.Value = 0;
        }
        #endregion

        #region Event Handlers
        private void OnHueBarValueChanged(object sender, EventArgs e)
        {
            UpdateColours();
        }

        private void OnResetButtonClick(object sender, EventArgs e)
        {
            ResetBarValues();

            UpdateColours();
        }

        private void OnHueBarScroll(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar)sender;

            Point cursorPos = Cursor.Position;

            cursorPos.Offset(Cursor.Size.Width / 2, Cursor.Size.Height / 2);

            toolTip.Show(bar.Value.ToString(), bar, bar.PointToClient(cursorPos), 1000);
        }

        private void OnShown(object sender, EventArgs e)
        {
            _colourTable = MainForm.Renderer.ColourTable;

            _initialColourTable = (CustomisableColourTable)_colourTable.Clone();

            ResetBarValues();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                _colourTable.InitFrom(_initialColourTable, false);
            }
        }
        #endregion
    }
}
