using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonPaletteChooserComboBox : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        #region Variables
        private KryptonManager _manager = new KryptonManager();
        #endregion

        public delegate void ChangePaletteEventHandler(object sender, EventArgs e);

        public event ChangePaletteEventHandler PaletteChanged;

        #region Constructor
        public KryptonPaletteChooserComboBox()
        {
            foreach (PaletteMode mode in Enum.GetValues(typeof(PaletteMode)))
            {
                Items.Add(mode.ToString());
            }

            Text = string.Empty;

            DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
    }
}