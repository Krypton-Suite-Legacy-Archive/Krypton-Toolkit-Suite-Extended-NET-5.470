using System.Collections;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Wizard.Classes
{
    public class InfoPageDesigner : ParentControlDesigner
    {
        protected override bool DrawGrid { get { return false; } }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("BackgroundImage") == true)
            {
                properties.Remove("BackgroundImage");
            }
        }
    }
}