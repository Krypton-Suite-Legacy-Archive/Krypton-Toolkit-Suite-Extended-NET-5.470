using ComponentFactory.Krypton.Toolkit;

namespace PaletteCreator.UX
{
    public partial class RibbonChromeForm : KryptonForm
    {
        public RibbonChromeForm()
        {
            InitializeComponent();
        }

        #region Public
        public KryptonPalette OverridePalette
        {
            set
            {
                Palette = value;

                kryptonPanel1.Palette = value;

                kryptonRibbon1.Palette = value;
            }
        }
        #endregion
    }
}
