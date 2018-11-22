using ComponentFactory.Krypton.Toolkit;
using System;
using Tooling.Classes.Other;

namespace Tooling.UX
{
    public partial class CustomColoursOld : KryptonForm
    {
        public CustomColoursOld()
        {
            InitializeComponent();
        }

        private void CustomColours_Load(object sender, EventArgs e)
        {
            ColourUtilities.PropagateStandardColours(kcmbNormalTextColour);

            ColourUtilities.PropagateSystemColours(kcmbNormalTextSystemColours);
        }
    }
}
