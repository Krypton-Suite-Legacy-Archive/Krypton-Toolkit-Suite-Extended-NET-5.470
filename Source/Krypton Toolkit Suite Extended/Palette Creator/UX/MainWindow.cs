using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteCreator.UX
{
    public partial class MainWindow : Form
    {
        #region Variables
        private bool _dirty, _loaded;

        private string _fileName;

        private KryptonPalette _paletteTheme;

        private TMSChromeForm _tmsChrome;

        private RibbonChromeForm _ribbonChrome;
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
    }
}