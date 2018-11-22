using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooling.UX
{
    public partial class ColourPickerDialog : KryptonForm
    {
        #region Constants

        private static readonly object _eventPreviewColorChanged = new object();

        #endregion

        #region Fields

        private Brush _textureBrush;

        #endregion

        #region Properties

        public Color Colour
        {
            get { return Colour; }
            set {
                //colorEditorManager.Color = value; 
                Colour = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }

        #endregion

        public ColourPickerDialog()
        {
            InitializeComponent();
        }
    }
}
