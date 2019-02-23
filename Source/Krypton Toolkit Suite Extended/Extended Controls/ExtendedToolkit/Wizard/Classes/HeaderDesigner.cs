using System.Collections;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Wizard.Classes
{
    public class HeaderDesigner : ParentControlDesigner
    {
        protected override bool DrawGrid { get { return false; } }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("BackgroundImage"))
            {
                properties.Remove("BackgroundImage");
            }

            if (properties.Contains("DrawGrid"))
            {
                properties.Remove("DrawGrid");
            }
        }
    }
}