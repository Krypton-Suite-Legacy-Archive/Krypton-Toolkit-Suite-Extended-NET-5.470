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

namespace Playground
{
    public partial class Scrollbars : KryptonForm
    {
        public Scrollbars()
        {
            InitializeComponent();
        }

        private void Scrollbars_Load(object sender, EventArgs e)
        {
            foreach (PaletteMode item in Enum.GetValues(typeof(PaletteMode)))
            {
                kcmbThemeSelector.Items.Add(item.ToString());
            }
        }
    }
}
