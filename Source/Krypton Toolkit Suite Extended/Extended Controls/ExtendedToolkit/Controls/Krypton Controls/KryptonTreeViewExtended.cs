using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.ExtendedToolkit.Controls.Krypton_Controls
{
    public partial class KryptonTreeViewExtended : Component
    {
        public KryptonTreeViewExtended()
        {
            InitializeComponent();
        }

        public KryptonTreeViewExtended(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
